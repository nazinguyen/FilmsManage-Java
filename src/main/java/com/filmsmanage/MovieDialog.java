package com.filmsmanage;

import javax.swing.*;
import javax.swing.filechooser.FileNameExtensionFilter;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.File;
import java.sql.*;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.List;
import com.toedter.calendar.JDateChooser;

public class MovieDialog extends JDialog {
    private JTextField idField;
    private JTextField titleField;
    private JTextArea descriptionArea;
    private JTextArea contentArea;
    private JTextField durationField;
    private JDateChooser startDateChooser;
    private JDateChooser endDateChooser;
    private JTextField directorField;
    private JLabel imageLabel;
    private String imagePath;
    private List<JCheckBox> genreCheckBoxes;
    private boolean confirmed = false;
    private Movie movie;
    private DatabaseUtil dbUtil;
    private String selectedImagePath;
    private SimpleDateFormat dateFormat = new SimpleDateFormat("yyyy-MM-dd");

    public MovieDialog(JFrame parent, String title, Movie movie) {
        super(parent, title, true);
        this.movie = movie;
        this.dbUtil = new DatabaseUtil();
        initializeComponents();
        if (movie != null) {
            populateFields();
        }
        pack();
        setLocationRelativeTo(parent);
    }

    private void initializeComponents() {
        setLayout(new BorderLayout());
        
        // Main panel with GridBagLayout
        JPanel mainPanel = new JPanel(new GridBagLayout());
        GridBagConstraints gbc = new GridBagConstraints();
        gbc.insets = new Insets(5, 5, 5, 5);
        gbc.fill = GridBagConstraints.HORIZONTAL;

        // Add fields
        gbc.gridx = 0; gbc.gridy = 0;
        mainPanel.add(new JLabel("Mã phim:"), gbc);
        gbc.gridx = 1;
        idField = new JTextField(20);
        idField.setEditable(false);
        mainPanel.add(idField, gbc);

        gbc.gridx = 0; gbc.gridy = 1;
        mainPanel.add(new JLabel("Tên phim:"), gbc);
        gbc.gridx = 1;
        titleField = new JTextField(20);
        mainPanel.add(titleField, gbc);

        gbc.gridx = 0; gbc.gridy = 2;
        mainPanel.add(new JLabel("Mô tả:"), gbc);
        gbc.gridx = 1;
        descriptionArea = new JTextArea(3, 20);
        descriptionArea.setLineWrap(true);
        descriptionArea.setWrapStyleWord(true);
        JScrollPane descScroll = new JScrollPane(descriptionArea);
        mainPanel.add(descScroll, gbc);

        gbc.gridx = 0; gbc.gridy = 3;
        mainPanel.add(new JLabel("Nội dung:"), gbc);
        gbc.gridx = 1;
        contentArea = new JTextArea(5, 20);
        contentArea.setLineWrap(true);
        contentArea.setWrapStyleWord(true);
        JScrollPane contentScroll = new JScrollPane(contentArea);
        mainPanel.add(contentScroll, gbc);

        gbc.gridx = 0; gbc.gridy = 4;
        mainPanel.add(new JLabel("Thời lượng (phút):"), gbc);
        gbc.gridx = 1;
        durationField = new JTextField(20);
        mainPanel.add(durationField, gbc);

        gbc.gridx = 0; gbc.gridy = 5;
        mainPanel.add(new JLabel("Ngày khởi chiếu:"), gbc);
        gbc.gridx = 1;
        startDateChooser = new JDateChooser();
        startDateChooser.setDateFormatString("yyyy-MM-dd");
        startDateChooser.setPreferredSize(new Dimension(120, 30));
        startDateChooser.setFont(new Font("Arial", Font.PLAIN, 14));
        startDateChooser.setBackground(Color.WHITE);
        mainPanel.add(startDateChooser, gbc);

        gbc.gridx = 0; gbc.gridy = 6;
        mainPanel.add(new JLabel("Ngày kết thúc:"), gbc);
        gbc.gridx = 1;
        endDateChooser = new JDateChooser();
        endDateChooser.setDateFormatString("yyyy-MM-dd");
        endDateChooser.setPreferredSize(new Dimension(120, 30));
        endDateChooser.setFont(new Font("Arial", Font.PLAIN, 14));
        endDateChooser.setBackground(Color.WHITE);
        mainPanel.add(endDateChooser, gbc);

        gbc.gridx = 0; gbc.gridy = 7;
        mainPanel.add(new JLabel("Đạo diễn:"), gbc);
        gbc.gridx = 1;
        directorField = new JTextField(20);
        mainPanel.add(directorField, gbc);

        // Image panel
        JPanel imagePanel = new JPanel(new BorderLayout());
        imageLabel = new JLabel("No image selected");
        imageLabel.setPreferredSize(new Dimension(200, 200));
        imageLabel.setBorder(BorderFactory.createEtchedBorder());
        imagePanel.add(imageLabel, BorderLayout.CENTER);
        
        JButton selectImageButton = new JButton("Chọn ảnh");
        selectImageButton.addActionListener(e -> selectImage());
        imagePanel.add(selectImageButton, BorderLayout.SOUTH);

        gbc.gridx = 0; gbc.gridy = 8;
        gbc.gridwidth = 2;
        mainPanel.add(imagePanel, gbc);

        // Genre checkboxes
        JPanel genrePanel = new JPanel(new GridLayout(0, 2));
        genreCheckBoxes = new ArrayList<>();
        
        // Load genres from database
        try (Connection conn = dbUtil.getConnection();
             Statement stmt = conn.createStatement();
             ResultSet rs = stmt.executeQuery("SELECT name FROM genres ORDER BY name")) {
            
            while (rs.next()) {
                JCheckBox checkBox = new JCheckBox(rs.getString("name"));
                genreCheckBoxes.add(checkBox);
                genrePanel.add(checkBox);
            }
        } catch (SQLException e) {
            e.printStackTrace();
            JOptionPane.showMessageDialog(this, "Lỗi khi tải thể loại: " + e.getMessage());
        }

        gbc.gridx = 0; gbc.gridy = 9;
        gbc.gridwidth = 2;
        mainPanel.add(genrePanel, gbc);

        // Buttons
        JPanel buttonPanel = new JPanel();
        JButton saveButton = new JButton("Lưu");
        JButton cancelButton = new JButton("Hủy");

        saveButton.addActionListener(e -> {
            if (validateInput()) {
                saveMovieData();
                if (confirmed) {
                    dispose();
                }
            }
        });

        cancelButton.addActionListener(e -> dispose());

        buttonPanel.add(saveButton);
        buttonPanel.add(cancelButton);

        gbc.gridx = 0; gbc.gridy = 10;
        gbc.gridwidth = 2;
        mainPanel.add(buttonPanel, gbc);

        add(mainPanel, BorderLayout.CENTER);
    }

    private void populateFields() {
        titleField.setText(movie.getTitle());
        contentArea.setText(movie.getContent());
        durationField.setText(String.valueOf(movie.getDuration()));
        
        try {
            if (movie.getStartDate() != null && !movie.getStartDate().isEmpty()) {
                startDateChooser.setDate(dateFormat.parse(movie.getStartDate()));
            }
            if (movie.getEndDate() != null && !movie.getEndDate().isEmpty()) {
                endDateChooser.setDate(dateFormat.parse(movie.getEndDate()));
            }
        } catch (ParseException e) {
            e.printStackTrace();
        }
        
        directorField.setText(movie.getDirector());
        descriptionArea.setText(movie.getDescription());
        
        if (movie.getImagePath() != null && !movie.getImagePath().isEmpty()) {
            try {
                ImageIcon icon = new ImageIcon(movie.getImagePath());
                Image img = icon.getImage().getScaledInstance(200, 200, Image.SCALE_SMOOTH);
                imageLabel.setIcon(new ImageIcon(img));
                imageLabel.setText("");
            } catch (Exception e) {
                imageLabel.setText("Error loading image");
            }
        }

        if (movie.getGenres() != null && !movie.getGenres().isEmpty()) {
            String[] genres = movie.getGenres().split(",");
            for (JCheckBox checkBox : genreCheckBoxes) {
                for (String genre : genres) {
                    if (checkBox.getText().trim().equals(genre.trim())) {
                        checkBox.setSelected(true);
                        break;
                    }
                }
            }
        }
    }

    private void selectImage() {
        JFileChooser fileChooser = new JFileChooser();
        fileChooser.setFileFilter(new FileNameExtensionFilter("Image files", "jpg", "jpeg", "png", "gif"));
        
        // Set initial directory to the resources/images folder
        String initialDir = "src/main/resources/images";
        File dir = new File(initialDir);
        if (dir.exists()) {
            fileChooser.setCurrentDirectory(dir);
        }
        
        if (fileChooser.showOpenDialog(this) == JFileChooser.APPROVE_OPTION) {
            File selectedFile = fileChooser.getSelectedFile();
            selectedImagePath = selectedFile.getAbsolutePath();
            
            // Copy the image to the resources/images directory if it's not already there
            try {
                File destDir = new File("src/main/resources/images");
                if (!destDir.exists()) {
                    destDir.mkdirs();
                }
                
                File destFile = new File(destDir, selectedFile.getName());
                if (!destFile.exists()) {
                    java.nio.file.Files.copy(
                        selectedFile.toPath(),
                        destFile.toPath(),
                        java.nio.file.StandardCopyOption.REPLACE_EXISTING
                    );
                }
                
                // Update the image path to be relative to the resources directory
                selectedImagePath = "images/" + selectedFile.getName();
                
                // Display the image
                ImageIcon icon = new ImageIcon(destFile.getAbsolutePath());
                Image img = icon.getImage().getScaledInstance(200, 200, Image.SCALE_SMOOTH);
                imageLabel.setIcon(new ImageIcon(img));
                imageLabel.setText("");
            } catch (Exception e) {
                e.printStackTrace();
                JOptionPane.showMessageDialog(this, "Lỗi khi xử lý ảnh: " + e.getMessage());
            }
        }
    }

    private boolean validateInput() {
        if (titleField.getText().trim().isEmpty()) {
            JOptionPane.showMessageDialog(this, "Vui lòng nhập tên phim");
            return false;
        }
        if (durationField.getText().trim().isEmpty()) {
            JOptionPane.showMessageDialog(this, "Vui lòng nhập thời lượng");
            return false;
        }
        try {
            Integer.parseInt(durationField.getText());
        } catch (NumberFormatException e) {
            JOptionPane.showMessageDialog(this, "Thời lượng phải là số");
            return false;
        }
        if (startDateChooser.getDate() == null) {
            JOptionPane.showMessageDialog(this, "Vui lòng chọn ngày khởi chiếu");
            return false;
        }
        if (endDateChooser.getDate() == null) {
            JOptionPane.showMessageDialog(this, "Vui lòng chọn ngày kết thúc");
            return false;
        }
        if (endDateChooser.getDate().before(startDateChooser.getDate())) {
            JOptionPane.showMessageDialog(this, "Ngày kết thúc phải sau ngày khởi chiếu");
            return false;
        }
        return true;
    }

    private void saveMovieData() {
        String startDate = startDateChooser.getDate() != null ? dateFormat.format(startDateChooser.getDate()) : "";
        String endDate = endDateChooser.getDate() != null ? dateFormat.format(endDateChooser.getDate()) : "";
        
        if (movie == null) {
            // Create a new movie with default values
            movie = new Movie(
                0, // id will be set by the database
                titleField.getText(),
                contentArea.getText(),
                Integer.parseInt(durationField.getText()),
                startDate,
                endDate,
                directorField.getText(),
                descriptionArea.getText(),
                selectedImagePath,
                "" // genres will be set below
            );
        } else {
            // Update existing movie
            movie.setTitle(titleField.getText());
            movie.setContent(contentArea.getText());
            movie.setDuration(Integer.parseInt(durationField.getText()));
            movie.setStartDate(startDate);
            movie.setEndDate(endDate);
            movie.setDirector(directorField.getText());
            movie.setDescription(descriptionArea.getText());
            movie.setImagePath(selectedImagePath);
        }
        
        // Get selected genres
        StringBuilder genres = new StringBuilder();
        for (JCheckBox checkBox : genreCheckBoxes) {
            if (checkBox.isSelected()) {
                if (genres.length() > 0) {
                    genres.append(",");
                }
                genres.append(checkBox.getText());
            }
        }
        movie.setGenres(genres.toString());
        
        confirmed = true;
    }

    public Movie getMovie() {
        if (movie == null) {
            movie = new Movie(0, "", "", 0, "", "", "", "", "", "");
        }
        movie.setTitle(titleField.getText());
        movie.setContent(contentArea.getText());
        movie.setDuration(Integer.parseInt(durationField.getText()));
        movie.setStartDate(startDateChooser.getDate() != null ? dateFormat.format(startDateChooser.getDate()) : "");
        movie.setEndDate(endDateChooser.getDate() != null ? dateFormat.format(endDateChooser.getDate()) : "");
        movie.setDirector(directorField.getText());
        movie.setDescription(descriptionArea.getText());
        movie.setImagePath(imageLabel.getIcon() != null ? selectedImagePath : "");
        
        // Get selected genres
        StringBuilder genres = new StringBuilder();
        for (JCheckBox checkBox : genreCheckBoxes) {
            if (checkBox.isSelected()) {
                if (genres.length() > 0) {
                    genres.append(",");
                }
                genres.append(checkBox.getText());
            }
        }
        movie.setGenres(genres.toString());
        
        return movie;
    }

    public boolean isConfirmed() {
        return confirmed;
    }
} 
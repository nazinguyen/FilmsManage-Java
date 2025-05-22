package com.filmsmanage;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.File;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

public class FoodDialog extends JDialog {
    private JTextField nameField;
    private JTextArea descriptionArea;
    private JTextField priceField;
    private JComboBox<String> categoryComboBox;
    private JLabel imageLabel;
    private String imagePath;
    private boolean confirmed = false;
    private Food food;

    public FoodDialog(JFrame parent, String title, Food food) {
        super(parent, title, true);
        this.food = food;
        
        setLayout(new BorderLayout());
        setSize(500, 600);
        setLocationRelativeTo(parent);

        // Create form panel
        JPanel formPanel = new JPanel(new GridBagLayout());
        formPanel.setBorder(BorderFactory.createEmptyBorder(10, 10, 10, 10));
        GridBagConstraints gbc = new GridBagConstraints();
        gbc.fill = GridBagConstraints.HORIZONTAL;
        gbc.insets = new Insets(5, 5, 5, 5);

        // Image selection
        gbc.gridx = 0;
        gbc.gridy = 0;
        formPanel.add(new JLabel("Hình ảnh:"), gbc);
        
        gbc.gridx = 1;
        gbc.gridwidth = 2;
        imageLabel = new JLabel();
        imageLabel.setPreferredSize(new Dimension(200, 200));
        imageLabel.setBorder(BorderFactory.createEtchedBorder());
        JPanel imagePanel = new JPanel(new BorderLayout());
        imagePanel.add(imageLabel, BorderLayout.CENTER);
        JButton selectImageButton = new JButton("Chọn ảnh");
        selectImageButton.addActionListener(e -> selectImage());
        imagePanel.add(selectImageButton, BorderLayout.SOUTH);
        formPanel.add(imagePanel, gbc);

        // Name field
        gbc.gridx = 0;
        gbc.gridy = 1;
        gbc.gridwidth = 1;
        formPanel.add(new JLabel("Tên:"), gbc);
        
        gbc.gridx = 1;
        gbc.gridwidth = 2;
        nameField = new JTextField(20);
        formPanel.add(nameField, gbc);

        // Description field
        gbc.gridx = 0;
        gbc.gridy = 2;
        gbc.gridwidth = 1;
        formPanel.add(new JLabel("Mô tả:"), gbc);
        
        gbc.gridx = 1;
        gbc.gridwidth = 2;
        descriptionArea = new JTextArea(4, 20);
        descriptionArea.setLineWrap(true);
        descriptionArea.setWrapStyleWord(true);
        JScrollPane descScrollPane = new JScrollPane(descriptionArea);
        formPanel.add(descScrollPane, gbc);

        // Price field
        gbc.gridx = 0;
        gbc.gridy = 3;
        gbc.gridwidth = 1;
        formPanel.add(new JLabel("Giá:"), gbc);
        
        gbc.gridx = 1;
        gbc.gridwidth = 2;
        priceField = new JTextField(20);
        formPanel.add(priceField, gbc);

        // Category combo box
        gbc.gridx = 0;
        gbc.gridy = 4;
        gbc.gridwidth = 1;
        formPanel.add(new JLabel("Danh mục:"), gbc);
        
        gbc.gridx = 1;
        gbc.gridwidth = 2;
        categoryComboBox = new JComboBox<>();
        loadCategories();
        formPanel.add(categoryComboBox, gbc);

        // Buttons
        JPanel buttonPanel = new JPanel(new FlowLayout(FlowLayout.RIGHT));
        JButton saveButton = new JButton("Lưu");
        JButton cancelButton = new JButton("Hủy");

        saveButton.addActionListener(e -> {
            if (validateInput()) {
                saveFood();
                confirmed = true;
                dispose();
            }
        });

        cancelButton.addActionListener(e -> dispose());

        buttonPanel.add(saveButton);
        buttonPanel.add(cancelButton);

        add(formPanel, BorderLayout.CENTER);
        add(buttonPanel, BorderLayout.SOUTH);

        // If editing, populate fields
        if (food != null) {
            nameField.setText(food.getName());
            descriptionArea.setText(food.getDescription());
            priceField.setText(String.valueOf(food.getPrice()));
            categoryComboBox.setSelectedItem(food.getCategory());
            if (food.getImagePath() != null && !food.getImagePath().isEmpty()) {
                imagePath = food.getImagePath();
                updateImageLabel();
            }
        }
    }

    private void selectImage() {
        JFileChooser fileChooser = new JFileChooser();
        fileChooser.setFileFilter(new javax.swing.filechooser.FileFilter() {
            public boolean accept(File f) {
                return f.isDirectory() || f.getName().toLowerCase().endsWith(".jpg")
                    || f.getName().toLowerCase().endsWith(".jpeg")
                    || f.getName().toLowerCase().endsWith(".png");
            }
            public String getDescription() {
                return "Image files (*.jpg, *.jpeg, *.png)";
            }
        });

        int result = fileChooser.showOpenDialog(this);
        if (result == JFileChooser.APPROVE_OPTION) {
            imagePath = fileChooser.getSelectedFile().getAbsolutePath();
            updateImageLabel();
        }
    }

    private void updateImageLabel() {
        if (imagePath != null && !imagePath.isEmpty()) {
            ImageIcon icon = new ImageIcon(imagePath);
            Image image = icon.getImage().getScaledInstance(200, 200, Image.SCALE_SMOOTH);
            imageLabel.setIcon(new ImageIcon(image));
        }
    }

    private void loadCategories() {
        try (Connection conn = DatabaseUtil.getConnection();
             PreparedStatement pstmt = conn.prepareStatement("SELECT DISTINCT category FROM foods");
             ResultSet rs = pstmt.executeQuery()) {
            
            while (rs.next()) {
                categoryComboBox.addItem(rs.getString("category"));
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }
        categoryComboBox.setEditable(true);
    }

    private boolean validateInput() {
        if (nameField.getText().trim().isEmpty()) {
            JOptionPane.showMessageDialog(this, "Vui lòng nhập tên thức ăn");
            return false;
        }
        if (descriptionArea.getText().trim().isEmpty()) {
            JOptionPane.showMessageDialog(this, "Vui lòng nhập mô tả");
            return false;
        }
        try {
            double price = Double.parseDouble(priceField.getText().trim());
            if (price <= 0) {
                JOptionPane.showMessageDialog(this, "Giá phải lớn hơn 0");
                return false;
            }
        } catch (NumberFormatException e) {
            JOptionPane.showMessageDialog(this, "Giá không hợp lệ");
            return false;
        }
        if (categoryComboBox.getSelectedItem() == null || 
            categoryComboBox.getSelectedItem().toString().trim().isEmpty()) {
            JOptionPane.showMessageDialog(this, "Vui lòng chọn hoặc nhập danh mục");
            return false;
        }
        return true;
    }

    private void saveFood() {
        try (Connection conn = DatabaseUtil.getConnection()) {
            String sql;
            PreparedStatement pstmt;

            if (food == null) {
                // Insert new food
                sql = "INSERT INTO foods (name, description, price, category, image_path) VALUES (?, ?, ?, ?, ?)";
                pstmt = conn.prepareStatement(sql);
            } else {
                // Update existing food
                sql = "UPDATE foods SET name = ?, description = ?, price = ?, category = ?, image_path = ? WHERE id = ?";
                pstmt = conn.prepareStatement(sql);
                pstmt.setInt(6, food.getId());
            }

            pstmt.setString(1, nameField.getText().trim());
            pstmt.setString(2, descriptionArea.getText().trim());
            pstmt.setDouble(3, Double.parseDouble(priceField.getText().trim()));
            pstmt.setString(4, categoryComboBox.getSelectedItem().toString().trim());
            pstmt.setString(5, imagePath);

            pstmt.executeUpdate();
        } catch (SQLException e) {
            e.printStackTrace();
            JOptionPane.showMessageDialog(this, "Lỗi khi lưu thức ăn: " + e.getMessage());
        }
    }

    public boolean isConfirmed() {
        return confirmed;
    }
} 
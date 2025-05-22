package com.filmsmanage;

import javax.swing.*;
import javax.swing.table.DefaultTableModel;
import java.awt.*;
import java.sql.*;
import java.util.Vector;
import java.io.File;
import java.io.PrintWriter;
import java.io.FileWriter;
import java.io.IOException;
import java.time.LocalDate;
import java.util.ArrayList;
import java.util.List;
import java.text.SimpleDateFormat;
import java.text.ParseException;
import java.util.Calendar;
import java.util.Date;
import com.toedter.calendar.JDateChooser;
import java.util.Properties;
import javax.swing.table.DefaultTableCellRenderer;

public class MovieManagerApp extends JFrame {
    private JTable movieTable;
    private DefaultTableModel tableModel;
    private JButton addButton, editButton, deleteButton;
    private DatabaseUtil dbUtil;
    private JPanel mainContentPanel;
    private CardLayout cardLayout;
    private DefaultTableModel foodTableModel;
    private String currentUserRole;
    private Integer currentUserId;
    private String currentUsername;

    public MovieManagerApp(String role) {
        this.currentUserRole = role;
        dbUtil = new DatabaseUtil();
        createRevenueTables();
        createScreensTable();
        createGenresTable();
        createTheatersTable();
        createStaffTable();
        initializeUI();
    }

    private void createRevenueTables() {
        try (Connection conn = dbUtil.getConnection();
             Statement stmt = conn.createStatement()) {
            
            // Create orders table
            stmt.execute("CREATE TABLE IF NOT EXISTS orders (" +
                        "id INTEGER PRIMARY KEY AUTOINCREMENT," +
                        "movie_id INTEGER NOT NULL," +
                        "show_date DATE NOT NULL," +
                        "created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP," +
                        "FOREIGN KEY (movie_id) REFERENCES movies(id))");

            // Create tickets table
            stmt.execute("CREATE TABLE IF NOT EXISTS tickets (" +
                        "id INTEGER PRIMARY KEY AUTOINCREMENT," +
                        "order_id INTEGER NOT NULL," +
                        "schedule_id VARCHAR(20) NOT NULL," +
                        "seat_id VARCHAR(20) NOT NULL," +
                        "status VARCHAR(20) NOT NULL," +
                        "price DECIMAL(10,2) NOT NULL," +
                        "created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP," +
                        "FOREIGN KEY (order_id) REFERENCES orders(id)," +
                        "FOREIGN KEY (schedule_id) REFERENCES schedules(id))");

        } catch (SQLException e) {
            JOptionPane.showMessageDialog(this,
                "Lỗi khi khởi tạo bảng doanh thu: " + e.getMessage(),
                "Lỗi",
                JOptionPane.ERROR_MESSAGE);
        }
    }

    private void createScreensTable() {
        try (Connection conn = dbUtil.getConnection();
             Statement stmt = conn.createStatement()) {
            
            // Create screens table
            stmt.execute("CREATE TABLE IF NOT EXISTS screens (" +
                        "id VARCHAR(20) PRIMARY KEY," +
                        "name VARCHAR(100) NOT NULL)");

        } catch (SQLException e) {
            JOptionPane.showMessageDialog(this,
                "Lỗi khi khởi tạo bảng màn hình: " + e.getMessage(),
                "Lỗi",
                JOptionPane.ERROR_MESSAGE);
        }
    }

    private void createGenresTable() {
        try (Connection conn = dbUtil.getConnection();
             Statement stmt = conn.createStatement()) {
            
            // Create genres table
            stmt.execute("CREATE TABLE IF NOT EXISTS genres (" +
                        "id VARCHAR(20) PRIMARY KEY," +
                        "name VARCHAR(100) NOT NULL)");

        } catch (SQLException e) {
            JOptionPane.showMessageDialog(this,
                "Lỗi khi khởi tạo bảng thể loại: " + e.getMessage(),
                "Lỗi",
                JOptionPane.ERROR_MESSAGE);
        }
    }

    private void createTheatersTable() {
        try (Connection conn = dbUtil.getConnection();
             Statement stmt = conn.createStatement()) {
            
            // Create theaters table
            stmt.execute("CREATE TABLE IF NOT EXISTS theaters (" +
                        "id VARCHAR(20) PRIMARY KEY," +
                        "name VARCHAR(100) NOT NULL," +
                        "screen_id VARCHAR(20) NOT NULL," +
                        "total_seats INTEGER NOT NULL," +
                        "rows INTEGER NOT NULL," +
                        "seats_per_row INTEGER NOT NULL," +
                        "FOREIGN KEY (screen_id) REFERENCES screens(id))");

        } catch (SQLException e) {
            JOptionPane.showMessageDialog(this,
                "Lỗi khi khởi tạo bảng phòng chiếu: " + e.getMessage(),
                "Lỗi",
                JOptionPane.ERROR_MESSAGE);
        }
    }

    private void createStaffTable() {
        try (Connection conn = dbUtil.getConnection();
             Statement stmt = conn.createStatement()) {
            
            // Create staff table
            stmt.execute("CREATE TABLE IF NOT EXISTS staff (" +
                        "id INTEGER PRIMARY KEY AUTOINCREMENT," +
                        "name TEXT NOT NULL," +
                        "username TEXT NOT NULL UNIQUE," +
                        "password TEXT NOT NULL," +
                        "role TEXT NOT NULL)");

            // Insert default admin user if not exists
            stmt.execute("INSERT OR IGNORE INTO staff (name, username, password, role) " +
                        "VALUES ('Admin', 'admin', 'admin123', 'ADMIN')");

        } catch (SQLException e) {
            JOptionPane.showMessageDialog(this,
                "Lỗi khi khởi tạo bảng nhân viên: " + e.getMessage(),
                "Lỗi",
                JOptionPane.ERROR_MESSAGE);
        }
    }

    private void initializeUI() {
        setTitle("Hệ Thống Quản Lý Rạp Chiếu Phim");
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setSize(1200, 800);
        setLocationRelativeTo(null);

        // Create main layout
        setLayout(new BorderLayout());

        // Create top menu bar
        JPanel topMenuBar = createTopMenuBar();
        add(topMenuBar, BorderLayout.NORTH);

        // Create main content area with CardLayout
        cardLayout = new CardLayout();
        mainContentPanel = new JPanel(cardLayout);
        add(mainContentPanel, BorderLayout.CENTER);

        // Add different panels based on user role
        if ("ADMIN".equals(currentUserRole)) {
            mainContentPanel.add(createRevenuePanel(), "REVENUE");
            mainContentPanel.add(createDataPanel(), "DATA");
            mainContentPanel.add(createStaffPanel(), "STAFF");
            mainContentPanel.add(createCustomersPanel(), "CUSTOMERS");
            cardLayout.show(mainContentPanel, "REVENUE");
        } else if ("STAFF".equals(currentUserRole)) {
            mainContentPanel.add(createTicketsPanel(), "TICKETS");
            mainContentPanel.add(createSchedulesPanel(), "SCHEDULES");
            mainContentPanel.add(createFoodPanel(), "FOOD");
            cardLayout.show(mainContentPanel, "TICKETS");
        }
    }

    private JPanel createRevenueSummaryPanel() {
        JPanel panel = new JPanel(new FlowLayout(FlowLayout.LEFT, 20, 10));
        panel.setBackground(new Color(33, 37, 41));
        panel.setBorder(BorderFactory.createEmptyBorder(10, 20, 10, 20));

        // Create labels for revenue metrics
        JLabel todayRevenueLabel = new JLabel("Doanh thu hôm nay: 0 VNĐ");
        JLabel totalRevenueLabel = new JLabel("Tổng doanh thu: 0 VNĐ");
        JLabel ticketsSoldLabel = new JLabel("Số vé đã bán: 0");
        JLabel activeMoviesLabel = new JLabel("Phim đang chiếu: 0");

        // Style the labels
        Font labelFont = new Font("Arial", Font.BOLD, 14);
        Color labelColor = new Color(255, 255, 255);
        for (JLabel label : new JLabel[]{todayRevenueLabel, totalRevenueLabel, ticketsSoldLabel, activeMoviesLabel}) {
            label.setFont(labelFont);
            label.setForeground(labelColor);
        }

        // Add labels to panel
        panel.add(todayRevenueLabel);
        panel.add(totalRevenueLabel);
        panel.add(ticketsSoldLabel);
        panel.add(activeMoviesLabel);

        // Create timer to update revenue information every minute
        Timer timer = new Timer(60000, e -> updateRevenueSummary(todayRevenueLabel, totalRevenueLabel, ticketsSoldLabel, activeMoviesLabel));
        timer.start();

        // Initial update
        updateRevenueSummary(todayRevenueLabel, totalRevenueLabel, ticketsSoldLabel, activeMoviesLabel);

        return panel;
    }

    private void updateRevenueSummary(JLabel todayRevenueLabel, JLabel totalRevenueLabel, 
                                    JLabel ticketsSoldLabel, JLabel activeMoviesLabel) {
        try (Connection conn = dbUtil.getConnection()) {
            // Get today's revenue and tickets sold (dựa vào tickets.created_at)
            String today = new java.text.SimpleDateFormat("yyyy-MM-dd").format(new java.util.Date());
            double todayRevenue = 0;
            int ticketsSold = 0;
            try (PreparedStatement pstmt = conn.prepareStatement(
                "SELECT COUNT(*) as ticket_count, SUM(price) as total_revenue " +
                "FROM tickets WHERE DATE(created_at) = ?")) {
                pstmt.setString(1, today);
                ResultSet rs = pstmt.executeQuery();
                if (rs.next()) {
                    ticketsSold = rs.getInt("ticket_count");
                    todayRevenue = rs.getDouble("total_revenue");
                }
            }

            // Get total revenue
            double totalRevenue = 0;
            try (Statement stmt = conn.createStatement();
                 ResultSet rs = stmt.executeQuery(
                    "SELECT SUM(price) as total_revenue FROM tickets")) {
                if (rs.next()) {
                    totalRevenue = rs.getDouble("total_revenue");
                }
            }

            // Get number of active movies (dựa vào ngày hiện tại nằm trong khoảng start_date và end_date)
            int activeMovies = 0;
            String todayStr = new java.text.SimpleDateFormat("yyyy-MM-dd").format(new java.util.Date());
            try (PreparedStatement stmt = conn.prepareStatement(
                "SELECT COUNT(*) as active_count FROM movies WHERE start_date <= ? AND end_date >= ?")) {
                stmt.setString(1, todayStr);
                stmt.setString(2, todayStr);
                ResultSet rs = stmt.executeQuery();
                if (rs.next()) {
                    activeMovies = rs.getInt("active_count");
                }
            }

            // Update labels
            todayRevenueLabel.setText(String.format("Doanh thu hôm nay: %,.0f VNĐ", todayRevenue));
            totalRevenueLabel.setText(String.format("Tổng doanh thu: %,.0f VNĐ", totalRevenue));
            ticketsSoldLabel.setText(String.format("Số vé đã bán: %d", ticketsSold));
            activeMoviesLabel.setText(String.format("Phim đang chiếu: %d", activeMovies));

        } catch (SQLException e) {
            e.printStackTrace();
            JOptionPane.showMessageDialog(this, "Lỗi khi cập nhật thông tin doanh thu: " + e.getMessage());
        }
    }

    private JPanel createTopMenuBar() {
        JPanel menuBar = new JPanel(new FlowLayout(FlowLayout.LEFT));
        menuBar.setBackground(new Color(33, 37, 41));
        menuBar.setBorder(BorderFactory.createEmptyBorder(10, 10, 10, 10));

        // Add menu buttons based on user role
        if ("ADMIN".equals(currentUserRole)) {
            addTopMenuButton(menuBar, "Doanh thu", "REVENUE", "src/main/resources/images/doanhThu.png");
            addTopMenuButton(menuBar, "Dữ liệu", "DATA", "src/main/resources/images/data.png");
            addTopMenuButton(menuBar, "Nhân viên", "STAFF", "src/main/resources/images/staff.png");
            addTopMenuButton(menuBar, "Khách hàng", "CUSTOMERS", "src/main/resources/images/customer.png");
        } else if ("STAFF".equals(currentUserRole)) {
            addTopMenuButton(menuBar, "Bán vé", "TICKETS", null);
            addTopMenuButton(menuBar, "Lịch chiếu", "SCHEDULES", null);
            addTopMenuButton(menuBar, "Thức ăn", "FOOD", null);
        }

        // Add logout button
        menuBar.add(Box.createHorizontalGlue());
        JButton logoutButton = new JButton("Đăng xuất");
        try {
            ImageIcon logoutIcon = new ImageIcon("src/main/resources/images/logout.png");
            Image img = logoutIcon.getImage().getScaledInstance(20, 20, Image.SCALE_SMOOTH);
            logoutButton.setIcon(new ImageIcon(img));
        } catch (Exception e) {
            e.printStackTrace();
        }
        styleTopMenuButton(logoutButton);
        logoutButton.addActionListener(e -> handleLogout());
        menuBar.add(logoutButton);

        return menuBar;
    }

    private void addTopMenuButton(JPanel menuBar, String text, String cardName, String iconPath) {
        JButton button = new JButton(text);
        if (iconPath != null) {
            try {
                ImageIcon icon = new ImageIcon(iconPath);
                Image img = icon.getImage().getScaledInstance(20, 20, Image.SCALE_SMOOTH);
                button.setIcon(new ImageIcon(img));
            } catch (Exception e) {
                e.printStackTrace();
            }
        }
        styleTopMenuButton(button);
        button.addActionListener(e -> cardLayout.show(mainContentPanel, cardName));
        button.setBorder(BorderFactory.createCompoundBorder(
            BorderFactory.createLineBorder(new Color(255, 193, 7), 2),
            BorderFactory.createEmptyBorder(5, 10, 5, 10)
        ));
        menuBar.add(button);
    }

    private void styleTopMenuButton(JButton button) {
        // Set text color to black for logout button, white for others
        if (button.getText().equals("Đăng xuất")) {
            button.setForeground(Color.BLACK);
        } else {
            button.setForeground(Color.WHITE);
        }
        button.setBackground(new Color(52, 58, 64));
        button.setFocusPainted(false);
        button.setBorderPainted(true);
        button.setFont(new Font("Arial", Font.PLAIN, 14));
        button.setPreferredSize(new Dimension(150, 40));
        button.setCursor(new Cursor(Cursor.HAND_CURSOR));
        button.setIconTextGap(10);
        
        // Add hover effect
        button.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseEntered(java.awt.event.MouseEvent evt) {
                button.setBackground(new Color(73, 80, 87));
            }

            public void mouseExited(java.awt.event.MouseEvent evt) {
                button.setBackground(new Color(52, 58, 64));
            }
        });
    }

    private JPanel createDashboardPanel() {
        JPanel panel = new JPanel(new GridLayout(2, 2, 10, 10));
        panel.setBorder(BorderFactory.createEmptyBorder(20, 20, 20, 20));

        // Add dashboard cards
        panel.add(createDashboardCard("Doanh Thu Hôm Nay", "0 VNĐ", new Color(40, 167, 69)));
        panel.add(createDashboardCard("Số Vé Đã Bán", "0", new Color(23, 162, 184)));
        panel.add(createDashboardCard("Số Phim Đang Chiếu", "0", new Color(255, 193, 7)));
        panel.add(createDashboardCard("Tổng Số Khách Hàng", "0", new Color(220, 53, 69)));

        return panel;
    }

    private JPanel createDashboardCard(String title, String value, Color color) {
        JPanel card = new JPanel(new BorderLayout());
        card.setBackground(color);
        card.setBorder(BorderFactory.createEmptyBorder(20, 20, 20, 20));

        JLabel titleLabel = new JLabel(title);
        titleLabel.setForeground(Color.WHITE);
        titleLabel.setFont(new Font("Arial", Font.BOLD, 16));

        JLabel valueLabel = new JLabel(value);
        valueLabel.setForeground(Color.WHITE);
        valueLabel.setFont(new Font("Arial", Font.BOLD, 24));

        card.add(titleLabel, BorderLayout.NORTH);
        card.add(valueLabel, BorderLayout.CENTER);

        return card;
    }

    private JPanel createMoviesPanel() {
        JPanel panel = new JPanel(new BorderLayout());
        panel.setBorder(BorderFactory.createEmptyBorder(20, 20, 20, 20));

        // Create top panel with search and CRUD buttons
        JPanel topPanel = new JPanel(new GridBagLayout());
        GridBagConstraints gbc = new GridBagConstraints();
        gbc.insets = new Insets(5, 5, 5, 5);
        gbc.fill = GridBagConstraints.HORIZONTAL;

        // Search panel
        JPanel searchPanel = new JPanel(new GridBagLayout());
        searchPanel.setBorder(BorderFactory.createTitledBorder("Tìm kiếm"));
        GridBagConstraints searchGbc = new GridBagConstraints();
        searchGbc.insets = new Insets(5, 5, 5, 5);
        searchGbc.fill = GridBagConstraints.HORIZONTAL;

        // Search field
        JTextField searchField = new JTextField(20);
        searchField.setPreferredSize(new Dimension(200, 30));
        searchGbc.gridx = 0;
        searchGbc.gridy = 0;
        searchPanel.add(new JLabel("Tìm kiếm:"), searchGbc);
        searchGbc.gridx = 1;
        searchPanel.add(searchField, searchGbc);

        // Search button
        JButton searchButton = new JButton("Tìm");
        styleSearchButton(searchButton);
        searchButton.setPreferredSize(new Dimension(100, 36));
        searchButton.setBackground(new Color(33, 150, 243));
        searchButton.setForeground(Color.WHITE);
        searchButton.setFocusPainted(false);
        searchButton.setBorderPainted(false);
        searchButton.setFont(new Font("Arial", Font.BOLD, 14));
        searchGbc.gridx = 2;
        searchPanel.add(searchButton, searchGbc);

        // CRUD buttons panel
        JPanel crudPanel = new JPanel(new FlowLayout(FlowLayout.RIGHT, 10, 5));
        crudPanel.setBorder(BorderFactory.createTitledBorder("Thao tác"));

        addButton = createActionButton("Thêm phim", "icon-add.png");
        editButton = createActionButton("Sửa phim", "Setting.png");
        deleteButton = createActionButton("Xóa phim", "remove.png");

        crudPanel.add(addButton);
        crudPanel.add(editButton);
        crudPanel.add(deleteButton);

        // Add search panel and CRUD panel to top panel side by side
        gbc.gridx = 0;
        gbc.gridy = 0;
        gbc.weightx = 0.7; // Give more space to search panel
        topPanel.add(searchPanel, gbc);

        gbc.gridx = 1;
        gbc.weightx = 0.3; // Less space for CRUD panel
        topPanel.add(crudPanel, gbc);

        // Create table
        String[] columnNames = {"ID", "Tên phim", "Nội dung", "Thời lượng", "Ngày bắt đầu", "Ngày kết thúc", 
                              "Đạo diễn", "Mô tả", "Thể loại"};
        tableModel = new DefaultTableModel(columnNames, 0) {
            @Override
            public boolean isCellEditable(int row, int column) {
                return false;
            }
        };
        movieTable = new JTable(tableModel);
        movieTable.setSelectionMode(ListSelectionModel.SINGLE_SELECTION);
        movieTable.setAutoResizeMode(JTable.AUTO_RESIZE_ALL_COLUMNS);
        movieTable.getTableHeader().setReorderingAllowed(false);
        
        // Set up scroll pane with preferred size
        JScrollPane scrollPane = new JScrollPane(movieTable);
        scrollPane.setPreferredSize(new Dimension(800, 400));

        // Add components to main panel
        panel.add(topPanel, BorderLayout.NORTH);
        panel.add(scrollPane, BorderLayout.CENTER);

        // Add action listeners
        searchButton.addActionListener(e -> {
            String searchText = searchField.getText().trim();
            loadMovies(searchText);
        });

        addButton.addActionListener(e -> showMovieDialog(null));
        editButton.addActionListener(e -> {
            int selectedRow = movieTable.getSelectedRow();
            System.out.println("[DEBUG] Edit button clicked. Selected row: " + selectedRow);
            if (selectedRow >= 0) {
                Object idObj = movieTable.getValueAt(selectedRow, 0);
                System.out.println("[DEBUG] Selected movie ID: " + idObj + " (" + (idObj != null ? idObj.getClass() : "null") + ")");
                showMovieDialog(String.valueOf(idObj));
            } else {
                JOptionPane.showMessageDialog(this, "Vui lòng chọn phim cần sửa.");
            }
        });

        deleteButton.addActionListener(e -> {
            int selectedRow = movieTable.getSelectedRow();
            if (selectedRow >= 0) {
                int movieId = (int) movieTable.getValueAt(selectedRow, 0);
                deleteMovie(movieId);
            } else {
                JOptionPane.showMessageDialog(this, "Vui lòng chọn phim cần xóa.");
            }
        });

        // Load initial data
        loadMovies("");

        return panel;
    }

    private void showMovieDialog(String movieId) {
        System.out.println("[DEBUG] showMovieDialog called with movieId: " + movieId);
        Movie movie = null;
        if (movieId != null) {
            try (Connection conn = dbUtil.getConnection();
                 PreparedStatement pstmt = conn.prepareStatement(
                     "SELECT m.*, GROUP_CONCAT(g.name) as genres " +
                     "FROM movies m " +
                     "LEFT JOIN movie_genres mg ON m.id = mg.movie_id " +
                     "LEFT JOIN genres g ON mg.genre_id = g.id " +
                     "WHERE m.id = ? " +
                     "GROUP BY m.id")) {
                
                pstmt.setInt(1, Integer.parseInt(movieId));
                try (ResultSet rs = pstmt.executeQuery()) {
                    if (rs.next()) {
                        movie = new Movie(
                            rs.getInt("id"),
                            rs.getString("title"),
                            rs.getString("content"),
                            rs.getInt("duration"),
                            rs.getString("start_date"),
                            rs.getString("end_date"),
                            rs.getString("director"),
                            rs.getString("description"),
                            rs.getString("image_path"),
                            rs.getString("genres")
                        );
                    }
                }
            } catch (SQLException e) {
                e.printStackTrace();
                JOptionPane.showMessageDialog(this, "Lỗi khi tải thông tin phim: " + e.getMessage());
                return;
            } catch (NumberFormatException e) {
                e.printStackTrace();
                JOptionPane.showMessageDialog(this, "Lỗi: ID phim không hợp lệ");
                return;
            }
        }
        
        try {
            MovieDialog dialog = new MovieDialog(this, movieId == null ? "Thêm phim mới" : "Sửa phim", movie);
            dialog.setVisible(true);
            
            if (dialog.isConfirmed()) {
                Movie updatedMovie = dialog.getMovie();
                if (movieId == null) {
                    // Thêm phim mới
                    insertMovie(updatedMovie);
                } else {
                    // Cập nhật phim hiện có
                    updateMovie(updatedMovie);
                }
                loadMovies(""); // Cập nhật lại danh sách phim
            }
        } catch (Exception ex) {
            ex.printStackTrace();
            JOptionPane.showMessageDialog(this, "Lỗi khi hiển thị form phim: " + ex.getMessage());
        }
    }

    private void deleteMovie(int movieId) {
        int confirm = JOptionPane.showConfirmDialog(this,
            "Bạn có chắc chắn muốn xóa phim này?",
            "Xác nhận xóa",
            JOptionPane.YES_NO_OPTION);
        
        if (confirm == JOptionPane.YES_OPTION) {
            try (Connection conn = dbUtil.getConnection()) {
                // First delete related records from movie_genres table
                try (PreparedStatement pstmt = conn.prepareStatement(
                    "DELETE FROM movie_genres WHERE movie_id = ?")) {
                    pstmt.setInt(1, movieId);
                    pstmt.executeUpdate();
                }

                // Then delete the movie
                try (PreparedStatement pstmt = conn.prepareStatement(
                    "DELETE FROM movies WHERE id = ?")) {
                    pstmt.setInt(1, movieId);
                    pstmt.executeUpdate();
                }

                loadMovies("");
                JOptionPane.showMessageDialog(this, "Xóa phim thành công");
            } catch (SQLException ex) {
                JOptionPane.showMessageDialog(this, "Lỗi khi xóa phim: " + ex.getMessage());
            }
        }
    }

    private void loadMovies(String searchText) {
        tableModel.setRowCount(0);
        String sql = "SELECT m.*, GROUP_CONCAT(DISTINCT g.name) as genres FROM movies m " +
                 "LEFT JOIN movie_genres mg ON m.id = mg.movie_id " +
                 "LEFT JOIN genres g ON mg.genre_id = g.id WHERE 1=1";
        boolean hasSearch = searchText != null && !searchText.trim().isEmpty();
        boolean isNumber = hasSearch && searchText.matches("\\d+");
        if (hasSearch) {
            if (isNumber) {
                sql += " AND (m.id = ? OR m.title LIKE ?)";
            } else {
                sql += " AND m.title LIKE ?";
            }
        }
        sql += " GROUP BY m.id ORDER BY m.title";
        try (Connection conn = dbUtil.getConnection();
             PreparedStatement pstmt = conn.prepareStatement(sql)) {
            if (hasSearch) {
                if (isNumber) {
                    pstmt.setInt(1, Integer.parseInt(searchText));
                    pstmt.setString(2, "%" + searchText + "%");
                } else {
            pstmt.setString(1, "%" + searchText + "%");
                }
            }
            ResultSet rs = pstmt.executeQuery();
            while (rs.next()) {
                String startDate = rs.getString("start_date");
                String endDate = rs.getString("end_date");
                try {
                    java.util.Date d = new java.text.SimpleDateFormat("yyyy-MM-dd").parse(startDate);
                    startDate = new java.text.SimpleDateFormat("dd/MM/yyyy").format(d);
                } catch (Exception e) {}
                try {
                    java.util.Date d = new java.text.SimpleDateFormat("yyyy-MM-dd").parse(endDate);
                    endDate = new java.text.SimpleDateFormat("dd/MM/yyyy").format(d);
                } catch (Exception e) {}
                tableModel.addRow(new Object[]{
                    rs.getInt("id"),
                    rs.getString("title"),
                    rs.getString("content"),
                    rs.getInt("duration"),
                    startDate,
                    endDate,
                    rs.getString("director"),
                    rs.getString("description"),
                    rs.getString("genres")
                });
            }
        } catch (SQLException e) {
            JOptionPane.showMessageDialog(this, "Lỗi khi tải danh sách phim: " + e.getMessage());
        }
    }

    private void showAddMovieDialog() {
        JDialog dialog = new JDialog(this, "Thêm phim mới", true);
        dialog.setLayout(new BorderLayout());
        
        JPanel formPanel = new JPanel(new GridBagLayout());
        GridBagConstraints gbc = new GridBagConstraints();
        gbc.insets = new Insets(5, 5, 5, 5);
        gbc.fill = GridBagConstraints.HORIZONTAL;
        
        // Add form fields
        gbc.gridx = 0; gbc.gridy = 0;
        formPanel.add(new JLabel("Tên phim:"), gbc);
        gbc.gridx = 1;
        JTextField titleField = new JTextField(20);
        formPanel.add(titleField, gbc);
        
        gbc.gridx = 0; gbc.gridy = 1;
        formPanel.add(new JLabel("Nội dung:"), gbc);
        gbc.gridx = 1;
        JTextArea contentArea = new JTextArea(3, 20);
        formPanel.add(new JScrollPane(contentArea), gbc);
        
        gbc.gridx = 0; gbc.gridy = 2;
        formPanel.add(new JLabel("Thời lượng (phút):"), gbc);
        gbc.gridx = 1;
        JTextField durationField = new JTextField(20);
        formPanel.add(durationField, gbc);
        
        gbc.gridx = 0; gbc.gridy = 3;
        formPanel.add(new JLabel("Ngày bắt đầu:"), gbc);
        gbc.gridx = 1;
        JDateChooser startDatePicker = createDatePicker();
        formPanel.add(startDatePicker, gbc);
        
        gbc.gridx = 0; gbc.gridy = 4;
        formPanel.add(new JLabel("Ngày kết thúc:"), gbc);
        gbc.gridx = 1;
        JDateChooser endDatePicker = createDatePicker();
        formPanel.add(endDatePicker, gbc);
        
        gbc.gridx = 0; gbc.gridy = 5;
        formPanel.add(new JLabel("Đạo diễn:"), gbc);
        gbc.gridx = 1;
        JTextField directorField = new JTextField(20);
        formPanel.add(directorField, gbc);
        
        gbc.gridx = 0; gbc.gridy = 6;
        formPanel.add(new JLabel("Mô tả:"), gbc);
        gbc.gridx = 1;
        JTextArea descriptionArea = new JTextArea(3, 20);
        formPanel.add(new JScrollPane(descriptionArea), gbc);
        
        gbc.gridx = 0; gbc.gridy = 7;
        formPanel.add(new JLabel("Thể loại:"), gbc);
        gbc.gridx = 1;
        JTextField genresField = new JTextField(20);
        formPanel.add(genresField, gbc);
        
        dialog.add(formPanel, BorderLayout.CENTER);
        
        JPanel buttonPanel = new JPanel();
        JButton saveButton = new JButton("Lưu");
        JButton cancelButton = new JButton("Hủy");
        
        saveButton.addActionListener(e -> {
            try {
                String title = titleField.getText();
                String content = contentArea.getText();
                int duration = Integer.parseInt(durationField.getText());
                String startDate = getDateFromPicker(startDatePicker);
                String endDate = getDateFromPicker(endDatePicker);
                String director = directorField.getText();
                String description = descriptionArea.getText();
                String[] genres = genresField.getText().split(",");
                // Bắt buộc nhập thể loại
                List<String> genreList = new ArrayList<>();
                for (String g : genres) {
                    if (!g.trim().isEmpty()) genreList.add(g.trim());
                }
                if (genreList.isEmpty()) {
                    JOptionPane.showMessageDialog(dialog, "Vui lòng nhập ít nhất 1 thể loại, cách nhau bằng dấu phẩy.");
                    return;
                }
                // Insert movie
                String sql = "INSERT INTO movies (title, content, duration, start_date, end_date, director, description) " +
                            "VALUES (?, ?, ?, ?, ?, ?, ?)";
                try (Connection conn = dbUtil.getConnection();
                     PreparedStatement pstmt = conn.prepareStatement(sql, Statement.RETURN_GENERATED_KEYS)) {
                    pstmt.setString(1, title);
                    pstmt.setString(2, content);
                    pstmt.setInt(3, duration);
                    pstmt.setString(4, startDate);
                    pstmt.setString(5, endDate);
                    pstmt.setString(6, director);
                    pstmt.setString(7, description);
                    pstmt.executeUpdate();
                    int movieId;
                    try (ResultSet generatedKeys = pstmt.getGeneratedKeys()) {
                        if (generatedKeys.next()) {
                            movieId = generatedKeys.getInt(1);
                            String insertMovieGenre = "INSERT INTO movie_genres (movie_id, genre_id) VALUES (?, ?)";
                            for (String genreName : genreList) {
                                int genreId;
                                try (PreparedStatement genreStmt = conn.prepareStatement(
                                    "SELECT id FROM genres WHERE name = ?")) {
                                    genreStmt.setString(1, genreName);
                                    try (ResultSet genreRs = genreStmt.executeQuery()) {
                                        if (genreRs.next()) {
                                            genreId = genreRs.getInt("id");
                                        } else {
                                            try (PreparedStatement insertGenreStmt = conn.prepareStatement(
                                                "INSERT INTO genres (name) VALUES (?)", Statement.RETURN_GENERATED_KEYS)) {
                                                insertGenreStmt.setString(1, genreName);
                                                insertGenreStmt.executeUpdate();
                                                try (ResultSet genreKeys = insertGenreStmt.getGeneratedKeys()) {
                                                    if (genreKeys.next()) {
                                                        genreId = genreKeys.getInt(1);
                                                    } else {
                                                        throw new SQLException("Không lấy được ID thể loại mới.");
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                try (PreparedStatement movieGenreStmt = conn.prepareStatement(insertMovieGenre)) {
                                    movieGenreStmt.setInt(1, movieId);
                                    movieGenreStmt.setInt(2, genreId);
                                    movieGenreStmt.executeUpdate();
                                }
                            }
                        }
                    }
                }
                loadMovies("");
                dialog.dispose();
            } catch (NumberFormatException ex) {
                JOptionPane.showMessageDialog(dialog, "Thời lượng phải là số nguyên.");
            } catch (SQLException ex) {
                ex.printStackTrace();
                JOptionPane.showMessageDialog(dialog, "Lỗi khi thêm phim: " + ex.getMessage());
            }
        });
        
        cancelButton.addActionListener(e -> dialog.dispose());
        
        buttonPanel.add(saveButton);
        buttonPanel.add(cancelButton);
        dialog.add(buttonPanel, BorderLayout.SOUTH);
        
        dialog.pack();
        dialog.setLocationRelativeTo(this);
        dialog.setVisible(true);
    }

    private void showEditMovieDialog(int selectedRow) {
        if (selectedRow == -1) {
            JOptionPane.showMessageDialog(this, "Vui lòng chọn phim để sửa");
            return;
        }

        int movieId = (int) movieTable.getValueAt(selectedRow, 0);
        try (Connection conn = dbUtil.getConnection();
             PreparedStatement pstmt = conn.prepareStatement(
                 "SELECT m.*, GROUP_CONCAT(g.name) as genres " +
                 "FROM movies m " +
                 "LEFT JOIN movie_genres mg ON m.id = mg.movie_id " +
                 "LEFT JOIN genres g ON mg.genre_id = g.id " +
                 "WHERE m.id = ? " +
                 "GROUP BY m.id")) {
            
            pstmt.setInt(1, movieId);
            ResultSet rs = pstmt.executeQuery();
            
            if (rs.next()) {
                Movie movie = new Movie(
                    rs.getInt("id"),
                    rs.getString("title"),
                    rs.getString("content"),
                    rs.getInt("duration"),
                    rs.getString("start_date"),
                    rs.getString("end_date"),
                    rs.getString("director"),
                    rs.getString("description"),
                    rs.getString("image_path"),
                    rs.getString("genres")
                );
                
                MovieDialog dialog = new MovieDialog(this, "Sửa phim", movie);
                dialog.setVisible(true);
                
                if (dialog.isConfirmed()) {
                    Movie updatedMovie = dialog.getMovie();
                    updateMovie(updatedMovie);
                    loadMovies("");
                }
            }
        } catch (SQLException e) {
            JOptionPane.showMessageDialog(this, "Lỗi khi tải thông tin phim: " + e.getMessage());
        }
    }

    private void updateMovie(Movie movie) {
        try (Connection conn = dbUtil.getConnection()) {
            conn.setAutoCommit(false);
            try {
                // Update movie details
                try (PreparedStatement pstmt = conn.prepareStatement(
                    "UPDATE movies SET title = ?, content = ?, duration = ?, " +
                    "start_date = ?, end_date = ?, director = ?, description = ?, " +
                    "image_path = ? WHERE id = ?")) {
                    
                    pstmt.setString(1, movie.getTitle());
                    pstmt.setString(2, movie.getContent());
                    pstmt.setInt(3, movie.getDuration());
                    pstmt.setString(4, movie.getStartDate());
                    pstmt.setString(5, movie.getEndDate());
                    pstmt.setString(6, movie.getDirector());
                    pstmt.setString(7, movie.getDescription());
                    pstmt.setString(8, movie.getImagePath());
                    pstmt.setInt(9, movie.getId());
                    pstmt.executeUpdate();
                }

                // Update genres
                try (PreparedStatement deleteStmt = conn.prepareStatement(
                    "DELETE FROM movie_genres WHERE movie_id = ?")) {
                    deleteStmt.setInt(1, movie.getId());
                    deleteStmt.executeUpdate();
                }

                if (movie.getGenres() != null && !movie.getGenres().isEmpty()) {
                    String[] genreNames = movie.getGenres().split(",");
                    for (String genreName : genreNames) {
                        genreName = genreName.trim();
                        int genreId = -1;
                        // Tìm id thể loại
                        try (PreparedStatement genreStmt = conn.prepareStatement("SELECT id FROM genres WHERE name = ?")) {
                            genreStmt.setString(1, genreName);
                            try (ResultSet rs = genreStmt.executeQuery()) {
                                if (rs.next()) {
                                    genreId = rs.getInt("id");
                                } else {
                                    // Nếu chưa có thì thêm mới
                                    try (PreparedStatement insertGenreStmt = conn.prepareStatement(
                                        "INSERT INTO genres (name) VALUES (?)", Statement.RETURN_GENERATED_KEYS)) {
                                        insertGenreStmt.setString(1, genreName);
                                        insertGenreStmt.executeUpdate();
                                        try (ResultSet genreKeys = insertGenreStmt.getGeneratedKeys()) {
                                            if (genreKeys.next()) {
                                                genreId = genreKeys.getInt(1);
                                            } else {
                                                throw new SQLException("Không lấy được ID thể loại mới.");
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        // Thêm vào bảng movie_genres
                    try (PreparedStatement insertStmt = conn.prepareStatement(
                        "INSERT INTO movie_genres (movie_id, genre_id) VALUES (?, ?)")) {
                            insertStmt.setInt(1, movie.getId());
                            insertStmt.setInt(2, genreId);
                            insertStmt.executeUpdate();
                        }
                    }
                }

                conn.commit();
                JOptionPane.showMessageDialog(this, "Cập nhật phim thành công!");
            } catch (SQLException e) {
                conn.rollback();
                throw e;
            }
        } catch (SQLException e) {
            JOptionPane.showMessageDialog(this, "Lỗi khi cập nhật phim: " + e.getMessage());
        }
    }

    private JPanel createScreensPanel() {
        JPanel panel = new JPanel(new BorderLayout(10, 10));
        panel.setBorder(BorderFactory.createEmptyBorder(20, 20, 20, 20));

        // Create form panel
        JPanel formPanel = new JPanel(new GridBagLayout());
        GridBagConstraints gbc = new GridBagConstraints();
        gbc.insets = new Insets(5, 5, 5, 5);
        gbc.fill = GridBagConstraints.HORIZONTAL;

        // Search field and button
        gbc.gridx = 0; gbc.gridy = 0;
        formPanel.add(new JLabel("Tìm kiếm:"), gbc);
        gbc.gridx = 1;
        JTextField searchField = new JTextField(16);
        formPanel.add(searchField, gbc);
        gbc.gridx = 2;
        JButton searchButton = new JButton("Tìm kiếm");
        styleSearchButton(searchButton);
        searchButton.setBackground(new Color(33, 150, 243));
        searchButton.setForeground(Color.WHITE);
        searchButton.setFont(new Font("Arial", Font.BOLD, 14));
        searchButton.setOpaque(true);
        searchButton.setContentAreaFilled(true);
        searchButton.setBorderPainted(false);
        searchButton.setPreferredSize(new Dimension(100, 36));
        formPanel.add(searchButton, gbc);

        // Screen ID field
        gbc.gridx = 0; gbc.gridy = 1;
        formPanel.add(new JLabel("Mã màn hình:"), gbc);
        gbc.gridx = 1;
        JTextField screenIdField = new JTextField(20);
        formPanel.add(screenIdField, gbc);

        // Screen Name field
        gbc.gridx = 0; gbc.gridy = 2;
        formPanel.add(new JLabel("Tên màn hình:"), gbc);
        gbc.gridx = 1;
        JTextField screenNameField = new JTextField(20);
        formPanel.add(screenNameField, gbc);

        // Create button panel
        JPanel buttonPanel = new JPanel(new FlowLayout(FlowLayout.LEFT));
        JButton addButton = createActionButton("Thêm", "icon-add.png");
        JButton editButton = createActionButton("Sửa", "Setting.png");
        JButton deleteButton = createActionButton("Xóa", "remove.png");
        JButton exportButton = createActionButton("Xuất File", "export.png");

        buttonPanel.add(addButton);
        buttonPanel.add(editButton);
        buttonPanel.add(deleteButton);
        buttonPanel.add(exportButton);

        // Create table
        String[] columnNames = {"Mã màn hình", "Tên màn hình"};
        DefaultTableModel screenTableModel = new DefaultTableModel(columnNames, 0) {
            @Override
            public boolean isCellEditable(int row, int column) {
                return false;
            }
        };
        JTable screenTable = new JTable(screenTableModel);
        JScrollPane scrollPane = new JScrollPane(screenTable);

        // Add action listeners
        addButton.addActionListener(e -> {
            String screenId = screenIdField.getText().trim();
            String screenName = screenNameField.getText().trim();

            if (screenId.isEmpty() || screenName.isEmpty()) {
                JOptionPane.showMessageDialog(panel, "Vui lòng nhập đầy đủ thông tin");
                return;
            }

            try (Connection conn = dbUtil.getConnection();
                 PreparedStatement pstmt = conn.prepareStatement(
                     "INSERT INTO screens (id, name) VALUES (?, ?)")) {
                
                pstmt.setString(1, screenId);
                pstmt.setString(2, screenName);
                pstmt.executeUpdate();

                screenIdField.setText("");
                screenNameField.setText("");
                loadScreens(screenTableModel, "");
                // Refresh all screen combo boxes in the app
                refreshAllScreenComboBoxes();
                JOptionPane.showMessageDialog(panel, "Thêm màn hình thành công");
            } catch (SQLException ex) {
                JOptionPane.showMessageDialog(panel, "Lỗi khi thêm màn hình: " + ex.getMessage());
            }
        });

        editButton.addActionListener(e -> {
            int selectedRow = screenTable.getSelectedRow();
            if (selectedRow >= 0) {
                String oldScreenId = (String) screenTableModel.getValueAt(selectedRow, 0);
                String newScreenId = screenIdField.getText().trim();
                String newScreenName = screenNameField.getText().trim();

                if (newScreenId.isEmpty() || newScreenName.isEmpty()) {
                    JOptionPane.showMessageDialog(panel, "Vui lòng nhập đầy đủ thông tin");
                    return;
                }

                try (Connection conn = dbUtil.getConnection();
                     PreparedStatement pstmt = conn.prepareStatement(
                         "UPDATE screens SET id = ?, name = ? WHERE id = ?")) {
                    
                    pstmt.setString(1, newScreenId);
                    pstmt.setString(2, newScreenName);
                    pstmt.setString(3, oldScreenId);
                    pstmt.executeUpdate();

                    screenIdField.setText("");
                    screenNameField.setText("");
                    loadScreens(screenTableModel, "");
                    JOptionPane.showMessageDialog(panel, "Cập nhật màn hình thành công");
                } catch (SQLException ex) {
                    JOptionPane.showMessageDialog(panel, "Lỗi khi cập nhật màn hình: " + ex.getMessage());
                }
            } else {
                JOptionPane.showMessageDialog(panel, "Vui lòng chọn màn hình cần sửa");
            }
        });

        deleteButton.addActionListener(e -> {
            int selectedRow = screenTable.getSelectedRow();
            if (selectedRow >= 0) {
                String screenId = (String) screenTableModel.getValueAt(selectedRow, 0);
                int confirm = JOptionPane.showConfirmDialog(panel,
                    "Bạn có chắc chắn muốn xóa màn hình này?",
                    "Xác nhận xóa",
                    JOptionPane.YES_NO_OPTION);
                
                if (confirm == JOptionPane.YES_OPTION) {
                    try (Connection conn = dbUtil.getConnection();
                         PreparedStatement pstmt = conn.prepareStatement(
                             "DELETE FROM screens WHERE id = ?")) {
                        
                        pstmt.setString(1, screenId);
                        pstmt.executeUpdate();

                        screenIdField.setText("");
                        screenNameField.setText("");
                        loadScreens(screenTableModel, "");
                        JOptionPane.showMessageDialog(panel, "Xóa màn hình thành công");
                    } catch (SQLException ex) {
                        JOptionPane.showMessageDialog(panel, "Lỗi khi xóa màn hình: " + ex.getMessage());
                    }
                }
            } else {
                JOptionPane.showMessageDialog(panel, "Vui lòng chọn màn hình cần xóa");
            }
        });

        exportButton.addActionListener(e -> {
            JFileChooser fileChooser = new JFileChooser();
            fileChooser.setDialogTitle("Chọn nơi lưu file");
            fileChooser.setFileSelectionMode(JFileChooser.FILES_ONLY);
            
            if (fileChooser.showSaveDialog(panel) == JFileChooser.APPROVE_OPTION) {
                File file = fileChooser.getSelectedFile();
                if (!file.getName().toLowerCase().endsWith(".csv")) {
                    file = new File(file.getAbsolutePath() + ".csv");
                }
                
                try (PrintWriter writer = new PrintWriter(new FileWriter(file))) {
                    // Write header
                    writer.println("Mã màn hình,Tên màn hình");
                    
                    // Write data
                    for (int i = 0; i < screenTableModel.getRowCount(); i++) {
                        String screenId = (String) screenTableModel.getValueAt(i, 0);
                        String screenName = (String) screenTableModel.getValueAt(i, 1);
                        writer.println(screenId + "," + screenName);
                    }
                    
                    JOptionPane.showMessageDialog(panel, "Xuất file thành công");
                } catch (IOException ex) {
                    JOptionPane.showMessageDialog(panel, "Lỗi khi xuất file: " + ex.getMessage());
                }
            }
        });

        // Add table selection listener
        screenTable.getSelectionModel().addListSelectionListener(e -> {
            if (!e.getValueIsAdjusting()) {
                int selectedRow = screenTable.getSelectedRow();
                if (selectedRow >= 0) {
                    screenIdField.setText((String) screenTableModel.getValueAt(selectedRow, 0));
                    screenNameField.setText((String) screenTableModel.getValueAt(selectedRow, 1));
                }
            }
        });

        // Search action
        searchButton.addActionListener(e -> {
            String searchText = searchField.getText().trim();
            loadScreens(screenTableModel, searchText);
        });

        // Add panels to main panel
        panel.add(formPanel, BorderLayout.NORTH);
        panel.add(buttonPanel, BorderLayout.CENTER);
        panel.add(scrollPane, BorderLayout.SOUTH);

        // Load initial data
        loadScreens(screenTableModel, "");

        return panel;
    }

    // Overload loadScreens to support search
    private void loadScreens(DefaultTableModel model, String searchText) {
        model.setRowCount(0);
        try (Connection conn = dbUtil.getConnection();
             PreparedStatement stmt = conn.prepareStatement(
                 "SELECT * FROM screens WHERE id LIKE ? OR name LIKE ?")) {
            stmt.setString(1, "%" + searchText + "%");
            stmt.setString(2, "%" + searchText + "%");
            ResultSet rs = stmt.executeQuery();
            while (rs.next()) {
                Vector<Object> row = new Vector<>();
                row.add(rs.getString("id"));
                row.add(rs.getString("name"));
                model.addRow(row);
            }
        } catch (SQLException e) {
            JOptionPane.showMessageDialog(this, "Lỗi khi tải dữ liệu màn hình: " + e.getMessage());
        }
    }

    private JPanel createTheatersPanel() {
        JPanel panel = new JPanel(new BorderLayout(10, 10));
        panel.setBorder(BorderFactory.createEmptyBorder(20, 20, 20, 20));

        // Create top panel with search and CRUD buttons
        JPanel topPanel = new JPanel(new GridBagLayout());
        GridBagConstraints gbc = new GridBagConstraints();
        gbc.insets = new Insets(5, 5, 5, 5);
        gbc.fill = GridBagConstraints.HORIZONTAL;

        // Search panel
        JPanel searchPanel = new JPanel(new GridBagLayout());
        searchPanel.setBorder(BorderFactory.createTitledBorder("Tìm kiếm"));
        GridBagConstraints searchGbc = new GridBagConstraints();
        searchGbc.insets = new Insets(5, 5, 5, 5);
        searchGbc.fill = GridBagConstraints.HORIZONTAL;

        // Search field
        JTextField searchField = new JTextField(20);
        searchField.setPreferredSize(new Dimension(200, 30));
        searchGbc.gridx = 0;
        searchGbc.gridy = 0;
        searchPanel.add(new JLabel("Tìm kiếm:"), searchGbc);
        searchGbc.gridx = 1;
        searchPanel.add(searchField, searchGbc);

        // Search button
        JButton searchButton = new JButton("Tìm");
        styleSearchButton(searchButton);
        searchButton.setPreferredSize(new Dimension(80, 30));
        searchButton.setBackground(Color.BLACK);
        searchButton.setForeground(Color.WHITE);
        searchButton.setFocusPainted(false);
        searchGbc.gridx = 2;
        searchPanel.add(searchButton, searchGbc);

        // CRUD buttons panel
        JPanel crudPanel = new JPanel(new FlowLayout(FlowLayout.RIGHT, 10, 5));
        crudPanel.setBorder(BorderFactory.createTitledBorder("Thao tác"));

        JButton addButton = createActionButton("Thêm", "icon-add.png");
        JButton editButton = createActionButton("Sửa", "Setting.png");
        JButton deleteButton = createActionButton("Xóa", "remove.png");
        JButton exportButton = createActionButton("Xuất File", "export.png");

        crudPanel.add(addButton);
        crudPanel.add(editButton);
        crudPanel.add(deleteButton);
        crudPanel.add(exportButton);

        // Add search panel and CRUD panel to top panel side by side
        gbc.gridx = 0;
        gbc.gridy = 0;
        gbc.weightx = 0.7; // Give more space to search panel
        topPanel.add(searchPanel, gbc);

        gbc.gridx = 1;
        gbc.weightx = 0.3; // Less space for CRUD panel
        topPanel.add(crudPanel, gbc);

        // Create table
        String[] columnNames = {"Mã phòng", "Tên phòng chiếu", "Tên màn hình", "Số chỗ ngồi", "Số hàng ghế", "Số ghế mỗi hàng"};
        DefaultTableModel theaterTableModel = new DefaultTableModel(columnNames, 0) {
            @Override
            public boolean isCellEditable(int row, int column) {
                return false;
            }
        };
        JTable theaterTable = new JTable(theaterTableModel);
        JScrollPane scrollPane = new JScrollPane(theaterTable);

        // Add panels to main panel
        panel.add(topPanel, BorderLayout.NORTH);
        panel.add(scrollPane, BorderLayout.CENTER);

        // Load initial data
        loadTheaters(theaterTableModel, "");

        // Add action listeners
        searchButton.addActionListener(e -> {
            String searchText = searchField.getText().trim();
            loadTheaters(theaterTableModel, searchText);
        });

        addButton.addActionListener(e -> showTheaterDialog(null, theaterTableModel));

        editButton.addActionListener(e -> {
            int selectedRow = theaterTable.getSelectedRow();
            if (selectedRow >= 0) {
                String theaterId = (String) theaterTable.getValueAt(selectedRow, 0);
                showTheaterDialog(theaterId, theaterTableModel);
            } else {
                JOptionPane.showMessageDialog(this, "Vui lòng chọn phòng chiếu cần sửa.");
            }
        });

        deleteButton.addActionListener(e -> {
            int selectedRow = theaterTable.getSelectedRow();
            if (selectedRow >= 0) {
                String theaterId = (String) theaterTable.getValueAt(selectedRow, 0);
                deleteTheater(theaterId, theaterTableModel);
            } else {
                JOptionPane.showMessageDialog(this, "Vui lòng chọn phòng chiếu cần xóa.");
            }
        });

        exportButton.addActionListener(e -> {
            JFileChooser fileChooser = new JFileChooser();
            fileChooser.setDialogTitle("Chọn nơi lưu file");
            fileChooser.setFileSelectionMode(JFileChooser.FILES_ONLY);
            
            if (fileChooser.showSaveDialog(panel) == JFileChooser.APPROVE_OPTION) {
                File file = fileChooser.getSelectedFile();
                if (!file.getName().toLowerCase().endsWith(".csv")) {
                    file = new File(file.getAbsolutePath() + ".csv");
                }
                
                try (PrintWriter writer = new PrintWriter(new FileWriter(file))) {
                    // Write header
                    writer.println("Mã phòng,Tên phòng chiếu,Tên màn hình,Số chỗ ngồi,Số hàng ghế,Số ghế mỗi hàng");
                    
                    // Write data
                    for (int i = 0; i < theaterTableModel.getRowCount(); i++) {
                        StringBuilder line = new StringBuilder();
                        for (int j = 0; j < theaterTableModel.getColumnCount(); j++) {
                            if (j > 0) line.append(",");
                            line.append(theaterTableModel.getValueAt(i, j));
                        }
                        writer.println(line.toString());
                    }
                    
                    JOptionPane.showMessageDialog(panel, "Xuất file thành công");
                } catch (IOException ex) {
                    JOptionPane.showMessageDialog(panel, "Lỗi khi xuất file: " + ex.getMessage());
                }
            }
        });

        return panel;
    }

    private void loadTheaters(DefaultTableModel model, String searchText) {
        model.setRowCount(0);
        try (Connection conn = dbUtil.getConnection();
             PreparedStatement stmt = conn.prepareStatement(
                 "SELECT t.*, s.name as screen_name FROM theaters t " +
                 "JOIN screens s ON t.screen_id = s.id " +
                 "WHERE t.name LIKE ? OR s.name LIKE ?")) {
            
            stmt.setString(1, "%" + searchText + "%");
            stmt.setString(2, "%" + searchText + "%");
            
            try (ResultSet rs = stmt.executeQuery()) {
                while (rs.next()) {
                    Object[] row = {
                        rs.getString("id"),
                        rs.getString("name"),
                        rs.getString("screen_name"),
                        rs.getInt("total_seats"),
                        rs.getInt("rows"),
                        rs.getInt("seats_per_row")
                    };
                    model.addRow(row);
                }
            }
        } catch (SQLException e) {
            JOptionPane.showMessageDialog(this, "Lỗi khi tải dữ liệu phòng chiếu: " + e.getMessage());
        }
    }

    private void loadScreensToComboBox(JComboBox<String> comboBox) {
        comboBox.removeAllItems();
        try (Connection conn = dbUtil.getConnection();
             Statement stmt = conn.createStatement();
             ResultSet rs = stmt.executeQuery("SELECT id, name FROM screens")) {
            
            while (rs.next()) {
                comboBox.addItem(rs.getString("id") + " - " + rs.getString("name"));
            }
        } catch (SQLException e) {
            JOptionPane.showMessageDialog(this, "Lỗi khi tải danh sách màn hình: " + e.getMessage());
        }
    }

    private void clearTheaterFields(JTextField idField, JTextField nameField, JComboBox<String> screenComboBox,
                                  JTextField totalSeatsField, JTextField rowsField, JTextField seatsPerRowField) {
        idField.setText("");
        nameField.setText("");
        screenComboBox.setSelectedIndex(0);
        totalSeatsField.setText("");
        rowsField.setText("");
        seatsPerRowField.setText("");
    }

    private JPanel createGenresPanel() {
        JPanel panel = new JPanel(new BorderLayout(10, 10));
        panel.setBorder(BorderFactory.createEmptyBorder(20, 20, 20, 20));

        // Top: Form + Search
        JPanel topPanel = new JPanel(new BorderLayout(10, 0));
        JPanel formPanel = new JPanel(new GridBagLayout());
        GridBagConstraints gbc = new GridBagConstraints();
        gbc.insets = new Insets(5, 5, 5, 5);
        gbc.fill = GridBagConstraints.HORIZONTAL;
        gbc.gridx = 0; gbc.gridy = 0;
        formPanel.add(new JLabel("Mã thể loại:"), gbc);
        gbc.gridx = 1;
        JTextField genreIdField = new JTextField(12);
        formPanel.add(genreIdField, gbc);
        gbc.gridx = 0; gbc.gridy = 1;
        formPanel.add(new JLabel("Tên thể loại:"), gbc);
        gbc.gridx = 1;
        JTextField genreNameField = new JTextField(18);
        formPanel.add(genreNameField, gbc);
        topPanel.add(formPanel, BorderLayout.WEST);

        // Search panel
        JPanel searchPanel = new JPanel(new FlowLayout(FlowLayout.RIGHT, 10, 0));
        JTextField searchField = new JTextField(16);
        JButton searchButton = new JButton("Tìm kiếm");
        searchButton.setBackground(new Color(33, 150, 243));
        searchButton.setForeground(Color.WHITE);
        searchButton.setFont(new Font("Arial", Font.BOLD, 14));
        searchButton.setOpaque(true);
        searchButton.setContentAreaFilled(true);
        searchButton.setBorderPainted(false);
        searchButton.setPreferredSize(new Dimension(100, 36));
        searchPanel.add(searchField);
        searchPanel.add(searchButton);
        topPanel.add(searchPanel, BorderLayout.EAST);
        panel.add(topPanel, BorderLayout.NORTH);

        // Middle: Action buttons
        JPanel buttonPanel = new JPanel(new FlowLayout(FlowLayout.LEFT, 10, 0));
        JButton addButton = createActionButton("Thêm", "icon-add.png");
        JButton editButton = createActionButton("Sửa", "Setting.png");
        JButton deleteButton = createActionButton("Xóa", "remove.png");
        buttonPanel.add(addButton);
        buttonPanel.add(editButton);
        buttonPanel.add(deleteButton);
        panel.add(buttonPanel, BorderLayout.CENTER);

        // Table
        String[] columnNames = {"Mã thể loại", "Tên thể loại"};
        DefaultTableModel genreTableModel = new DefaultTableModel(columnNames, 0) {
            @Override
            public boolean isCellEditable(int row, int column) {
                return false;
            }
        };
        JTable genreTable = new JTable(genreTableModel);
        genreTable.setSelectionMode(ListSelectionModel.SINGLE_SELECTION);
        genreTable.setAutoResizeMode(JTable.AUTO_RESIZE_ALL_COLUMNS);
        genreTable.getTableHeader().setReorderingAllowed(false);
        JScrollPane scrollPane = new JScrollPane(genreTable);
        scrollPane.setPreferredSize(new Dimension(0, 300));
        panel.add(scrollPane, BorderLayout.SOUTH);

        // Action listeners
        addButton.addActionListener(e -> {
            try (Connection conn = dbUtil.getConnection();
                 PreparedStatement pstmt = conn.prepareStatement(
                    "INSERT INTO genres (id, name) VALUES (?, ?)")) {
                pstmt.setString(1, genreIdField.getText().trim());
                pstmt.setString(2, genreNameField.getText().trim());
                pstmt.executeUpdate();
                loadGenres(genreTableModel, "");
                genreIdField.setText("");
                genreNameField.setText("");
            } catch (SQLException ex) {
                JOptionPane.showMessageDialog(this,
                    "Lỗi khi thêm thể loại: " + ex.getMessage(),
                    "Lỗi",
                    JOptionPane.ERROR_MESSAGE);
            }
        });
        editButton.addActionListener(e -> {
            int selectedRow = genreTable.getSelectedRow();
            if (selectedRow == -1) {
                JOptionPane.showMessageDialog(this,
                    "Vui lòng chọn thể loại cần sửa",
                    "Thông báo",
                    JOptionPane.WARNING_MESSAGE);
                return;
            }
            try (Connection conn = dbUtil.getConnection();
                 PreparedStatement pstmt = conn.prepareStatement(
                    "UPDATE genres SET name = ? WHERE id = ?")) {
                pstmt.setString(1, genreNameField.getText().trim());
                pstmt.setString(2, genreIdField.getText().trim());
                pstmt.executeUpdate();
                loadGenres(genreTableModel, "");
            } catch (SQLException ex) {
                JOptionPane.showMessageDialog(this,
                    "Lỗi khi sửa thể loại: " + ex.getMessage(),
                    "Lỗi",
                    JOptionPane.ERROR_MESSAGE);
            }
        });
        deleteButton.addActionListener(e -> {
            int selectedRow = genreTable.getSelectedRow();
            if (selectedRow == -1) {
                JOptionPane.showMessageDialog(this,
                    "Vui lòng chọn thể loại cần xóa",
                    "Thông báo",
                    JOptionPane.WARNING_MESSAGE);
                return;
            }
            int confirm = JOptionPane.showConfirmDialog(this,
                "Bạn có chắc chắn muốn xóa thể loại này?",
                "Xác nhận xóa",
                JOptionPane.YES_NO_OPTION);
            if (confirm == JOptionPane.YES_OPTION) {
                try (Connection conn = dbUtil.getConnection();
                     PreparedStatement pstmt = conn.prepareStatement(
                        "DELETE FROM genres WHERE id = ?")) {
                    pstmt.setString(1, (String) genreTable.getValueAt(selectedRow, 0));
                    pstmt.executeUpdate();
                    loadGenres(genreTableModel, "");
                    genreIdField.setText("");
                    genreNameField.setText("");
                } catch (SQLException ex) {
                    JOptionPane.showMessageDialog(this,
                        "Lỗi khi xóa thể loại: " + ex.getMessage(),
                        "Lỗi",
                        JOptionPane.ERROR_MESSAGE);
                }
            }
        });
        searchButton.addActionListener(e -> {
            String searchText = searchField.getText().trim();
            loadGenres(genreTableModel, searchText);
        });
        genreTable.getSelectionModel().addListSelectionListener(e -> {
            if (!e.getValueIsAdjusting()) {
                int selectedRow = genreTable.getSelectedRow();
                if (selectedRow >= 0) {
                    genreIdField.setText((String) genreTableModel.getValueAt(selectedRow, 0));
                    genreNameField.setText((String) genreTableModel.getValueAt(selectedRow, 1));
                }
            }
        });
        // Load initial data
        loadGenres(genreTableModel, "");
        return panel;
    }

    // Overload loadGenres to support search
    private void loadGenres(DefaultTableModel model, String searchText) {
        model.setRowCount(0);
        try (Connection conn = dbUtil.getConnection();
             PreparedStatement stmt = conn.prepareStatement(
                 "SELECT * FROM genres WHERE id LIKE ? OR name LIKE ?")) {
            stmt.setString(1, "%" + searchText + "%");
            stmt.setString(2, "%" + searchText + "%");
            ResultSet rs = stmt.executeQuery();
            while (rs.next()) {
                Vector<Object> row = new Vector<>();
                row.add(rs.getString("id"));
                row.add(rs.getString("name"));
                model.addRow(row);
            }
        } catch (SQLException e) {
            JOptionPane.showMessageDialog(this, "Lỗi khi tải dữ liệu thể loại: " + e.getMessage());
        }
    }

    private JPanel createFormatsPanel() {
        JPanel panel = new JPanel(new BorderLayout());
        panel.setBorder(BorderFactory.createEmptyBorder(20, 20, 20, 20));

        // Create table
        String[] columnNames = {"Mã định dạng", "Tên dạng phim", "Mã màn hình", "Tên màn hình"};
        DefaultTableModel tableModel = new DefaultTableModel(columnNames, 0) {
            @Override
            public boolean isCellEditable(int row, int column) {
                return false;
            }
        };
        JTable formatTable = new JTable(tableModel);
        formatTable.setSelectionMode(ListSelectionModel.SINGLE_SELECTION);
        formatTable.setAutoResizeMode(JTable.AUTO_RESIZE_ALL_COLUMNS);
        formatTable.getTableHeader().setReorderingAllowed(false);

        // Create button panel
        JPanel buttonPanel = new JPanel(new FlowLayout(FlowLayout.LEFT));
        JButton addButton = createActionButton("Thêm", "icon-add.png");
        JButton editButton = createActionButton("Sửa", "Setting.png");
        JButton deleteButton = createActionButton("Xóa", "remove.png");
        JButton exportButton = createActionButton("Xuất Excel", "export.png");

        buttonPanel.add(addButton);
        buttonPanel.add(editButton);
        buttonPanel.add(deleteButton);
        buttonPanel.add(exportButton);

        // Add action listeners
        addButton.addActionListener(e -> showAddFormatDialog(tableModel));
        editButton.addActionListener(e -> showEditFormatDialog(formatTable, tableModel));
        deleteButton.addActionListener(e -> deleteFormat(formatTable, tableModel));
        exportButton.addActionListener(e -> exportFormatsToExcel(formatTable));

        // Add components to panel
        panel.add(new JScrollPane(formatTable), BorderLayout.CENTER);
        panel.add(buttonPanel, BorderLayout.NORTH);

        // Load initial data
        loadFormats(tableModel);

        return panel;
    }

    private void loadFormats(DefaultTableModel model) {
        model.setRowCount(0);
        try (Connection conn = dbUtil.getConnection();
             Statement stmt = conn.createStatement();
             ResultSet rs = stmt.executeQuery(
                "SELECT f.id, f.name, f.screen_id, s.name as screen_name " +
                "FROM formats f " +
                "LEFT JOIN screens s ON f.screen_id = s.id")) {
            
            while (rs.next()) {
                Vector<Object> row = new Vector<>();
                row.add(rs.getString("id"));
                row.add(rs.getString("name"));
                row.add(rs.getString("screen_id"));
                row.add(rs.getString("screen_name"));
                model.addRow(row);
            }
        } catch (SQLException e) {
            JOptionPane.showMessageDialog(this,
                "Lỗi khi tải dữ liệu định dạng: " + e.getMessage(),
                "Lỗi",
                JOptionPane.ERROR_MESSAGE);
        }
    }

    private void showAddFormatDialog(DefaultTableModel model) {
        JDialog dialog = new JDialog(this, "Thêm định dạng mới", true);
        dialog.setLayout(new BorderLayout());
        dialog.setSize(400, 200);
        dialog.setLocationRelativeTo(this);

        JPanel inputPanel = new JPanel(new GridLayout(3, 2, 5, 5));
        inputPanel.setBorder(BorderFactory.createEmptyBorder(10, 10, 10, 10));

        JTextField idField = new JTextField();
        JTextField nameField = new JTextField();
        JComboBox<String> screenComboBox = new JComboBox<>();
        loadScreensToComboBox(screenComboBox);

        inputPanel.add(new JLabel("Mã định dạng:"));
        inputPanel.add(idField);
        inputPanel.add(new JLabel("Tên định dạng:"));
        inputPanel.add(nameField);
        inputPanel.add(new JLabel("Màn hình:"));
        inputPanel.add(screenComboBox);

        JPanel buttonPanel = new JPanel(new FlowLayout(FlowLayout.RIGHT));
        JButton saveButton = new JButton("Lưu");
        JButton cancelButton = new JButton("Hủy");

        saveButton.addActionListener(e -> {
            try (Connection conn = dbUtil.getConnection();
                 PreparedStatement pstmt = conn.prepareStatement(
                    "INSERT INTO formats (id, name, screen_id) VALUES (?, ?, ?)")) {
                
                pstmt.setString(1, idField.getText().trim());
                pstmt.setString(2, nameField.getText().trim());
                pstmt.setString(3, ((String)screenComboBox.getSelectedItem()).split(" - ")[0]); // Extract screen ID
                pstmt.executeUpdate();

                loadFormats(model);
                dialog.dispose();
            } catch (SQLException ex) {
                JOptionPane.showMessageDialog(dialog,
                    "Lỗi khi thêm định dạng: " + ex.getMessage(),
                    "Lỗi",
                    JOptionPane.ERROR_MESSAGE);
            }
        });

        cancelButton.addActionListener(e -> dialog.dispose());

        buttonPanel.add(saveButton);
        buttonPanel.add(cancelButton);

        dialog.add(inputPanel, BorderLayout.CENTER);
        dialog.add(buttonPanel, BorderLayout.SOUTH);
        dialog.setVisible(true);
    }

    private void showEditFormatDialog(JTable table, DefaultTableModel model) {
        if (table.getSelectedRow() == -1) {
            JOptionPane.showMessageDialog(this,
                "Vui lòng chọn định dạng cần sửa",
                "Thông báo",
                JOptionPane.WARNING_MESSAGE);
            return;
        }

        String id = (String) table.getValueAt(table.getSelectedRow(), 0);
        String name = (String) table.getValueAt(table.getSelectedRow(), 1);
        String screenId = (String) table.getValueAt(table.getSelectedRow(), 2);

        JDialog dialog = new JDialog(this, "Sửa định dạng", true);
        dialog.setLayout(new BorderLayout());
        dialog.setSize(400, 200);
        dialog.setLocationRelativeTo(this);

        JPanel inputPanel = new JPanel(new GridLayout(3, 2, 5, 5));
        inputPanel.setBorder(BorderFactory.createEmptyBorder(10, 10, 10, 10));

        JTextField idField = new JTextField(id);
        idField.setEditable(false);
        JTextField nameField = new JTextField(name);
        JComboBox<String> screenComboBox = new JComboBox<>();
        loadScreensToComboBox(screenComboBox);
        screenComboBox.setSelectedItem(screenId);

        inputPanel.add(new JLabel("Mã định dạng:"));
        inputPanel.add(idField);
        inputPanel.add(new JLabel("Tên định dạng:"));
        inputPanel.add(nameField);
        inputPanel.add(new JLabel("Màn hình:"));
        inputPanel.add(screenComboBox);

        JPanel buttonPanel = new JPanel(new FlowLayout(FlowLayout.RIGHT));
        JButton saveButton = new JButton("Lưu");
        JButton cancelButton = new JButton("Hủy");

        saveButton.addActionListener(e -> {
            try (Connection conn = dbUtil.getConnection();
                 PreparedStatement pstmt = conn.prepareStatement(
                    "UPDATE formats SET name = ?, screen_id = ? WHERE id = ?")) {
                
                pstmt.setString(1, nameField.getText().trim());
                pstmt.setString(2, screenComboBox.getSelectedItem().toString());
                pstmt.setString(3, id);
                pstmt.executeUpdate();

                loadFormats(model);
                dialog.dispose();
            } catch (SQLException ex) {
                JOptionPane.showMessageDialog(dialog,
                    "Lỗi khi cập nhật định dạng: " + ex.getMessage(),
                    "Lỗi",
                    JOptionPane.ERROR_MESSAGE);
            }
        });

        cancelButton.addActionListener(e -> dialog.dispose());

        buttonPanel.add(saveButton);
        buttonPanel.add(cancelButton);

        dialog.add(inputPanel, BorderLayout.CENTER);
        dialog.add(buttonPanel, BorderLayout.SOUTH);
        dialog.setVisible(true);
    }

    private void deleteFormat(JTable table, DefaultTableModel model) {
        if (table.getSelectedRow() == -1) {
            JOptionPane.showMessageDialog(this,
                "Vui lòng chọn định dạng cần xóa",
                "Thông báo",
                JOptionPane.WARNING_MESSAGE);
            return;
        }

        int result = JOptionPane.showConfirmDialog(this,
            "Bạn có chắc chắn muốn xóa định dạng này?",
            "Xác nhận xóa",
            JOptionPane.YES_NO_OPTION);

        if (result == JOptionPane.YES_OPTION) {
            String id = (String) table.getValueAt(table.getSelectedRow(), 0);
            try (Connection conn = dbUtil.getConnection();
                 PreparedStatement pstmt = conn.prepareStatement(
                    "DELETE FROM formats WHERE id = ?")) {
                
                pstmt.setString(1, id);
                pstmt.executeUpdate();

                loadFormats(model);
            } catch (SQLException e) {
                JOptionPane.showMessageDialog(this,
                    "Lỗi khi xóa định dạng: " + e.getMessage(),
                    "Lỗi",
                    JOptionPane.ERROR_MESSAGE);
            }
        }
    }

    private void exportFormatsToExcel(JTable table) {
        JFileChooser fileChooser = new JFileChooser();
        fileChooser.setDialogTitle("Lưu file Excel");
        fileChooser.setFileFilter(new javax.swing.filechooser.FileFilter() {
            public boolean accept(File f) {
                return f.getName().toLowerCase().endsWith(".xlsx") || f.isDirectory();
            }
            public String getDescription() {
                return "Excel Files (*.xlsx)";
            }
        });

        if (fileChooser.showSaveDialog(this) == JFileChooser.APPROVE_OPTION) {
            File file = fileChooser.getSelectedFile();
            if (!file.getName().toLowerCase().endsWith(".xlsx")) {
                file = new File(file.getAbsolutePath() + ".xlsx");
            }

            try (PrintWriter writer = new PrintWriter(new FileWriter(file))) {
                // Write header
                for (int i = 0; i < table.getColumnCount(); i++) {
                    writer.print(table.getColumnName(i));
                    if (i < table.getColumnCount() - 1) writer.print(",");
                }
                writer.println();

                // Write data
                for (int i = 0; i < table.getRowCount(); i++) {
                    for (int j = 0; j < table.getColumnCount(); j++) {
                        writer.print(table.getValueAt(i, j));
                        if (j < table.getColumnCount() - 1) writer.print(",");
                    }
                    writer.println();
                }

                JOptionPane.showMessageDialog(this,
                    "Xuất dữ liệu thành công!",
                    "Thông báo",
                    JOptionPane.INFORMATION_MESSAGE);
            } catch (IOException e) {
                JOptionPane.showMessageDialog(this,
                    "Lỗi khi xuất file Excel: " + e.getMessage(),
                    "Lỗi",
                    JOptionPane.ERROR_MESSAGE);
            }
        }
    }

    private JPanel createSchedulesPanel() {
        JPanel panel = new JPanel(new BorderLayout(10, 10));
        panel.setBackground(Color.WHITE);
        panel.setBorder(BorderFactory.createEmptyBorder(20, 20, 20, 20));

        // Create table model
        String[] columns = {"Mã lịch chiếu", "Phòng chiếu", "Phim", "Ngày chiếu", "Giờ bắt đầu", "Giờ kết thúc", "Giá vé", "Trạng thái"};
        DefaultTableModel model = new DefaultTableModel(columns, 0) {
            @Override
            public boolean isCellEditable(int row, int column) {
                return false;
            }
        };

        // Create table
        JTable table = new JTable(model);
        table.setSelectionMode(ListSelectionModel.SINGLE_SELECTION);
        table.getTableHeader().setReorderingAllowed(false);
        table.setRowHeight(30);
        table.getTableHeader().setFont(new Font("Arial", Font.BOLD, 14));
        table.setFont(new Font("Arial", Font.PLAIN, 14));

        // Add scroll pane
        JScrollPane scrollPane = new JScrollPane(table);
        panel.add(scrollPane, BorderLayout.CENTER);

        // Create button panel
        JPanel buttonPanel = new JPanel(new FlowLayout(FlowLayout.RIGHT));
        JButton addButton = new JButton("Thêm mới");
        JButton editButton = new JButton("Sửa");
        JButton deleteButton = new JButton("Xóa");

        // Style buttons
        addButton.setBackground(new Color(0, 123, 255));
        addButton.setForeground(Color.WHITE);
        addButton.setFont(new Font("Arial", Font.BOLD, 14));
        addButton.setFocusPainted(false);
        addButton.setBorderPainted(true);
        addButton.setBorder(BorderFactory.createLineBorder(new Color(0, 123, 255), 2, true));
        addButton.setOpaque(true);
        addButton.setContentAreaFilled(true);
        addButton.setPreferredSize(new Dimension(120, 40));

        editButton.setBackground(new Color(255, 193, 7));
        editButton.setForeground(Color.WHITE);
        editButton.setFont(new Font("Arial", Font.BOLD, 14));
        editButton.setFocusPainted(false);
        editButton.setBorderPainted(true);
        editButton.setBorder(BorderFactory.createLineBorder(new Color(255, 193, 7), 2, true));
        editButton.setOpaque(true);
        editButton.setContentAreaFilled(true);
        editButton.setPreferredSize(new Dimension(120, 40));

        deleteButton.setBackground(new Color(220, 53, 69));
        deleteButton.setForeground(Color.WHITE);
        deleteButton.setFont(new Font("Arial", Font.BOLD, 14));
        deleteButton.setFocusPainted(false);
        deleteButton.setBorderPainted(true);
        deleteButton.setBorder(BorderFactory.createLineBorder(new Color(220, 53, 69), 2, true));
        deleteButton.setOpaque(true);
        deleteButton.setContentAreaFilled(true);
        deleteButton.setPreferredSize(new Dimension(120, 40));

        buttonPanel.add(addButton);
        buttonPanel.add(editButton);
        buttonPanel.add(deleteButton);
        panel.add(buttonPanel, BorderLayout.SOUTH);

        // Add action listeners
        addButton.addActionListener(e -> showScheduleDialog(null, model));

        editButton.addActionListener(e -> {
            int selectedRow = table.getSelectedRow();
            if (selectedRow >= 0) {
                String scheduleId = (String) table.getValueAt(selectedRow, 0);
                showScheduleDialog(scheduleId, model);
            } else {
                JOptionPane.showMessageDialog(this, "Vui lòng chọn lịch chiếu cần sửa!");
            }
        });

        deleteButton.addActionListener(e -> {
            int selectedRow = table.getSelectedRow();
            if (selectedRow >= 0) {
                String scheduleId = (String) table.getValueAt(selectedRow, 0);
                int confirm = JOptionPane.showConfirmDialog(this,
                    "Bạn có chắc chắn muốn xóa lịch chiếu này?",
                    "Xác nhận xóa",
                    JOptionPane.YES_NO_OPTION);
                if (confirm == JOptionPane.YES_OPTION) {
                    deleteSchedule(scheduleId, model);
                }
            } else {
                JOptionPane.showMessageDialog(this, "Vui lòng chọn lịch chiếu cần xóa!");
            }
        });

        // Load initial data
        loadSchedules(model);

        return panel;
    }

    private void loadTicketsWithSeatType(DefaultTableModel model, String scheduleId) {
        model.setRowCount(0);
        try (Connection conn = dbUtil.getConnection();
             PreparedStatement pstmt = conn.prepareStatement(
                 "SELECT t.id, t.seat_id, " +
                 "CASE WHEN CAST(SUBSTR(t.seat_id, -1) AS INTEGER) > 5 THEN 'VIP' ELSE 'Thường' END as seat_type, " +
                 "CASE WHEN t.order_id IS NULL THEN 'Chưa bán' ELSE 'Đã bán' END as status, " +
                 "t.price " +
                 "FROM tickets t " +
                 "WHERE t.schedule_id = ? " +
                 "ORDER BY t.seat_id")) {
            pstmt.setString(1, scheduleId);
            ResultSet rs = pstmt.executeQuery();
            while (rs.next()) {
                Vector<Object> row = new Vector<>();
                row.add(rs.getString("id"));
                row.add(rs.getString("seat_id"));
                row.add(rs.getString("seat_type"));
                row.add(rs.getString("status"));
                row.add(String.format("%,.0f VNĐ", rs.getDouble("price")));
                model.addRow(row);
            }
        } catch (SQLException e) {
            JOptionPane.showMessageDialog(null, "Lỗi khi tải thông tin vé: " + e.getMessage());
        }
    }

    private JPanel createFoodPanel() {
        JPanel panel = new JPanel(new BorderLayout());
        panel.setBackground(new Color(240, 240, 240));

        // Create table model (bỏ cột hình ảnh)
        String[] columnNames = {"ID", "Tên", "Mô tả", "Giá", "Danh mục"};
        foodTableModel = new DefaultTableModel(columnNames, 0) {
            @Override
            public boolean isCellEditable(int row, int column) {
                return false;
            }
        };
        JTable foodTable = new JTable(foodTableModel);
        foodTable.setSelectionMode(ListSelectionModel.SINGLE_SELECTION);

        JScrollPane scrollPane = new JScrollPane(foodTable);
        scrollPane.setBorder(BorderFactory.createEmptyBorder(10, 10, 10, 10));

        // Create buttons panel
        JPanel buttonPanel = new JPanel(new FlowLayout(FlowLayout.LEFT));
        buttonPanel.setBackground(new Color(240, 240, 240));
        
        JButton addButton = createActionButton("Thêm mới", "icon-add.png");
        JButton editButton = createActionButton("Sửa", "Setting.png");
        JButton deleteButton = createActionButton("Xóa", "remove.png");

        buttonPanel.add(addButton);
        buttonPanel.add(editButton);
        buttonPanel.add(deleteButton);

        // Add action listeners
        addButton.addActionListener(e -> {
            FoodDialog dialog = new FoodDialog(this, "Thêm thức ăn mới", null);
            dialog.setVisible(true);
            if (dialog.isConfirmed()) {
                loadFoods(); // Refresh the table
            }
        });

        editButton.addActionListener(e -> {
            int selectedRow = foodTable.getSelectedRow();
            if (selectedRow >= 0) {
                int foodId = Integer.parseInt(foodTableModel.getValueAt(selectedRow, 0).toString());
                Food food = new Food(
                    foodId,
                    (String) foodTableModel.getValueAt(selectedRow, 1),
                    (String) foodTableModel.getValueAt(selectedRow, 2),
                    (double) foodTableModel.getValueAt(selectedRow, 3),
                    (String) foodTableModel.getValueAt(selectedRow, 4),
                    null // Không cần imagePath
                );
                FoodDialog dialog = new FoodDialog(this, "Sửa thức ăn", food);
                dialog.setVisible(true);
                if (dialog.isConfirmed()) {
                    loadFoods(); // Refresh the table
                }
            } else {
                JOptionPane.showMessageDialog(this, "Vui lòng chọn thức ăn cần sửa.");
            }
        });

        deleteButton.addActionListener(e -> {
            int selectedRow = foodTable.getSelectedRow();
            if (selectedRow >= 0) {
                int foodId = Integer.parseInt(foodTableModel.getValueAt(selectedRow, 0).toString());
                int confirm = JOptionPane.showConfirmDialog(this,
                    "Bạn có chắc chắn muốn xóa thức ăn này?",
                    "Xác nhận xóa",
                    JOptionPane.YES_NO_OPTION);
                
                if (confirm == JOptionPane.YES_OPTION) {
                    deleteFood(foodId);
                }
            } else {
                JOptionPane.showMessageDialog(this, "Vui lòng chọn thức ăn cần xóa.");
            }
        });

        panel.add(scrollPane, BorderLayout.CENTER);
        panel.add(buttonPanel, BorderLayout.SOUTH);

        // Load initial data
        loadFoods();

        return panel;
    }

    private void loadFoods() {
        foodTableModel.setRowCount(0);
        try (Connection conn = dbUtil.getConnection();
             Statement stmt = conn.createStatement();
             ResultSet rs = stmt.executeQuery("SELECT * FROM foods")) {
            while (rs.next()) {
                foodTableModel.addRow(new Object[]{
                    rs.getInt("id"),
                    rs.getString("name"),
                    rs.getString("description"),
                    rs.getDouble("price"),
                    rs.getString("category")
                });
            }
        } catch (SQLException e) {
            JOptionPane.showMessageDialog(this, "Lỗi khi tải danh sách đồ ăn: " + e.getMessage());
        }
    }

    private void deleteFood(int id) {
        try (Connection conn = dbUtil.getConnection();
             PreparedStatement pstmt = conn.prepareStatement("DELETE FROM foods WHERE id = ?")) {
            pstmt.setInt(1, id);
            pstmt.executeUpdate();
        } catch (SQLException e) {
            e.printStackTrace();
            JOptionPane.showMessageDialog(this, "Lỗi khi xóa thức ăn: " + e.getMessage());
        }
    }

    private JPanel createRevenuePanel() {
        JPanel panel = new JPanel(new BorderLayout(10, 10));
        panel.setBorder(BorderFactory.createEmptyBorder(20, 20, 20, 20));

        // Create filter panel
        JPanel filterPanel = new JPanel(new FlowLayout(FlowLayout.LEFT));
        
        // Movie selection
        JLabel movieLabel = new JLabel("Chọn phim:");
        JComboBox<String> movieComboBox = new JComboBox<>();
        movieComboBox.addItem("Tất cả phim");
        loadMoviesToComboBox(movieComboBox);
        
        // Date selection
        JLabel fromDateLabel = new JLabel("Từ ngày:");
        JDateChooser fromDatePicker = createDatePicker();
        
        JLabel toDateLabel = new JLabel("Đến ngày:");
        JDateChooser toDatePicker = createDatePicker();
        
        // Buttons
        JButton statisticsButton = new JButton("Thống kê");
        JButton reportButton = new JButton("Báo cáo");
        
        // Add components to filter panel
        filterPanel.add(movieLabel);
        filterPanel.add(movieComboBox);
        filterPanel.add(fromDateLabel);
        filterPanel.add(fromDatePicker);
        filterPanel.add(toDateLabel);
        filterPanel.add(toDatePicker);
        filterPanel.add(statisticsButton);
        filterPanel.add(reportButton);

        // Create table
        String[] columnNames = {"Mã hoá đơn", "Tên Phim", "Ngày khởi chiếu", "Số vé bán", "Tổng doanh thu"};
        DefaultTableModel revenueTableModel = new DefaultTableModel(columnNames, 0) {
            @Override
            public boolean isCellEditable(int row, int column) {
                return false;
            }
        };
        JTable revenueTable = new JTable(revenueTableModel);
        JScrollPane scrollPane = new JScrollPane(revenueTable);

        // Create total panel
        JPanel totalPanel = new JPanel(new FlowLayout(FlowLayout.RIGHT));
        JLabel totalLabel = new JLabel("Tổng doanh thu: ");
        JLabel totalAmountLabel = new JLabel("0 VNĐ");
        totalAmountLabel.setFont(new Font("Arial", Font.BOLD, 16));
        totalPanel.add(totalLabel);
        totalPanel.add(totalAmountLabel);

        // Add action listeners
        statisticsButton.addActionListener(e -> {
            String selectedMovie = (String) movieComboBox.getSelectedItem();
            String fromDate = getDateFromPicker(fromDatePicker);
            String toDate = getDateFromPicker(toDatePicker);
            
            updateRevenueTable(revenueTableModel, totalAmountLabel, selectedMovie, fromDate, toDate);
        });

        reportButton.addActionListener(e -> {
            String selectedMovie = (String) movieComboBox.getSelectedItem();
            String fromDate = getDateFromPicker(fromDatePicker);
            String toDate = getDateFromPicker(toDatePicker);
            
            exportRevenueReport(selectedMovie, fromDate, toDate);
        });

        // Add panels to main panel
        panel.add(filterPanel, BorderLayout.NORTH);
        panel.add(scrollPane, BorderLayout.CENTER);
        panel.add(totalPanel, BorderLayout.SOUTH);

        return panel;
    }

    private boolean isValidDateFormat(String date) {
        try {
            SimpleDateFormat sdf = new SimpleDateFormat("dd/MM/yyyy");
            sdf.setLenient(false);
            sdf.parse(date);
            return true;
        } catch (ParseException e) {
            return false;
        }
    }

    private void exportRevenueReport(String movie, String fromDate, String toDate) {
        JFileChooser fileChooser = new JFileChooser();
        fileChooser.setDialogTitle("Chọn nơi lưu báo cáo");
        fileChooser.setFileSelectionMode(JFileChooser.FILES_ONLY);
        
        if (fileChooser.showSaveDialog(this) == JFileChooser.APPROVE_OPTION) {
            File file = fileChooser.getSelectedFile();
            if (!file.getName().toLowerCase().endsWith(".csv")) {
                file = new File(file.getAbsolutePath() + ".csv");
            }
            
            try (PrintWriter writer = new PrintWriter(new FileWriter(file))) {
                // Write header
                writer.println("Báo cáo doanh thu");
                writer.println("Thời gian: " + fromDate + " đến " + toDate);
                writer.println("Phim: " + movie);
                writer.println();
                writer.println("Mã suất chiếu,Tên Phim,Ngày chiếu,Số vé bán,Tổng doanh thu");
                
                // Get data
                try (Connection conn = dbUtil.getConnection()) {
                    StringBuilder sql = new StringBuilder(
                        "SELECT s.id as schedule_id, m.title, s.show_date, " +
                        "COUNT(t.id) as ticket_count, SUM(t.price) as total_revenue " +
                        "FROM schedules s " +
                        "JOIN movies m ON s.movie_id = m.id " +
                        "LEFT JOIN tickets t ON t.schedule_id = s.id " +
                        "WHERE 1=1");
                    
                    List<Object> params = new ArrayList<>();
                    
                    if (!"Tất cả phim".equals(movie)) {
                        sql.append(" AND m.id = ?");
                        params.add(Integer.parseInt(movie.split(" - ")[0]));
                    }
                    if (!fromDate.isEmpty()) {
                        sql.append(" AND s.show_date >= ?");
                        params.add(fromDate);
                    }
                    if (!toDate.isEmpty()) {
                        sql.append(" AND s.show_date <= ?");
                        params.add(toDate);
                    }
                    
                    sql.append(" GROUP BY s.id, m.title, s.show_date ORDER BY s.show_date DESC");
                    
                    PreparedStatement pstmt = conn.prepareStatement(sql.toString());
                    for (int i = 0; i < params.size(); i++) {
                        pstmt.setObject(i + 1, params.get(i));
                    }
                    
                    ResultSet rs = pstmt.executeQuery();
                    double totalRevenue = 0;
                    
                    while (rs.next()) {
                        writer.printf("%s,%s,%s,%d,%.0f VNĐ%n",
                            rs.getString("schedule_id"),
                            rs.getString("title"),
                            rs.getString("show_date"),
                            rs.getInt("ticket_count"),
                            rs.getDouble("total_revenue"));
                        totalRevenue += rs.getDouble("total_revenue");
                    }
                    
                    writer.println();
                    writer.printf("Tổng doanh thu: %.0f VNĐ%n", totalRevenue);
                }
                
                JOptionPane.showMessageDialog(this, "Xuất báo cáo thành công!");
            } catch (IOException | SQLException ex) {
                ex.printStackTrace();
                JOptionPane.showMessageDialog(this, "Lỗi khi xuất báo cáo: " + ex.getMessage());
            }
        }
    }

    private void loadMoviesToComboBox(JComboBox<String> comboBox) {
        comboBox.removeAllItems();
        try (Connection conn = dbUtil.getConnection();
             Statement stmt = conn.createStatement();
             ResultSet rs = stmt.executeQuery("SELECT id, title FROM movies")) {
            while (rs.next()) {
                comboBox.addItem(rs.getInt("id") + " - " + rs.getString("title"));
            }
        } catch (SQLException e) {
            JOptionPane.showMessageDialog(this, "Lỗi khi tải danh sách phim: " + e.getMessage());
        }
    }

    private void updateRevenueTable(DefaultTableModel model, JLabel totalLabel, String movie, String fromDate, String toDate) {
        model.setRowCount(0);
        double totalRevenue = 0;

        try (Connection conn = dbUtil.getConnection()) {
            StringBuilder sql = new StringBuilder(
                "SELECT s.id as schedule_id, m.title, s.show_date, " +
                "COUNT(t.id) as ticket_count, SUM(t.price) as total_revenue " +
                "FROM schedules s " +
                "JOIN movies m ON s.movie_id = m.id " +
                "LEFT JOIN tickets t ON t.schedule_id = s.id " +
                "WHERE 1=1");

            List<Object> params = new ArrayList<>();

            if (!"Tất cả phim".equals(movie)) {
                sql.append(" AND m.id = ?");
                params.add(Integer.parseInt(movie.split(" - ")[0]));
            }
            if (!fromDate.isEmpty()) {
                sql.append(" AND DATE(s.show_date) >= DATE(?)");
                params.add(convertDateFormat(fromDate));
            }
            if (!toDate.isEmpty()) {
                sql.append(" AND DATE(s.show_date) <= DATE(?)");
                params.add(convertDateFormat(toDate));
            }
            sql.append(" GROUP BY s.id, m.title, s.show_date ORDER BY s.show_date DESC");

            PreparedStatement pstmt = conn.prepareStatement(sql.toString());
            
            // Set parameters
            for (int i = 0; i < params.size(); i++) {
                pstmt.setObject(i + 1, params.get(i));
            }

            ResultSet rs = pstmt.executeQuery();
            while (rs.next()) {
                Vector<Object> row = new Vector<>();
                row.add(rs.getString("schedule_id"));
                row.add(rs.getString("title"));
                // Format date to dd/MM/yyyy
                String showDate = rs.getString("show_date");
                try {
                    java.util.Date d = new java.text.SimpleDateFormat("yyyy-MM-dd").parse(showDate);
                    showDate = new java.text.SimpleDateFormat("dd/MM/yyyy").format(d);
                } catch (Exception e) {}
                row.add(showDate);
                row.add(rs.getInt("ticket_count"));
                double revenue = rs.getDouble("total_revenue");
                row.add(String.format("%,.0f VNĐ", revenue));
                model.addRow(row);
                totalRevenue += revenue;
            }

            totalLabel.setText(String.format("%,.0f VNĐ", totalRevenue));
        } catch (SQLException e) {
            e.printStackTrace();
            JOptionPane.showMessageDialog(null, "Lỗi khi cập nhật bảng doanh thu: " + e.getMessage());
        }
    }

    private String convertDateFormat(String date) {
        try {
            SimpleDateFormat inputFormat = new SimpleDateFormat("dd/MM/yyyy");
            SimpleDateFormat outputFormat = new SimpleDateFormat("yyyy-MM-dd");
            return outputFormat.format(inputFormat.parse(date));
        } catch (ParseException e) {
            return date;
        }
    }

    private JPanel createDataPanel() {
        JPanel dataPanel = new JPanel(new BorderLayout());
        
        // Create menu panel for data sub-items
        JPanel menuPanel = new JPanel();
        menuPanel.setLayout(new BoxLayout(menuPanel, BoxLayout.Y_AXIS));
        menuPanel.setBackground(new Color(33, 37, 41));
        menuPanel.setPreferredSize(new Dimension(200, getHeight()));
        menuPanel.setBorder(BorderFactory.createEmptyBorder(10, 10, 10, 10));

        // Add sub-menu buttons
        addSubMenuButton(menuPanel, "Loại màn hình", "SCREENS");
        addSubMenuButton(menuPanel, "Phòng chiếu", "THEATERS");
        addSubMenuButton(menuPanel, "Thể loại", "GENRES");
        addSubMenuButton(menuPanel, "Phim", "MOVIES");
        addSubMenuButton(menuPanel, "Định dạng", "FORMATS");
        addSubMenuButton(menuPanel, "Lịch chiếu", "SCHEDULES");
        addSubMenuButton(menuPanel, "Thức ăn", "FOOD");

        // Create content panel for data sub-items
        JPanel dataContentPanel = new JPanel(new CardLayout());
        dataContentPanel.setBorder(BorderFactory.createEmptyBorder(10, 10, 10, 10));

        // Add sub-panels to content panel
        dataContentPanel.add(createScreensPanel(), "SCREENS");
        dataContentPanel.add(createTheatersPanel(), "THEATERS");
        dataContentPanel.add(createGenresPanel(), "GENRES");
        dataContentPanel.add(createMoviesPanel(), "MOVIES");
        dataContentPanel.add(createFormatsPanel(), "FORMATS");
        dataContentPanel.add(createSchedulesPanel(), "SCHEDULES");
        dataContentPanel.add(createFoodPanel(), "FOOD");

        // Add panels to data panel
        dataPanel.add(menuPanel, BorderLayout.WEST);
        dataPanel.add(dataContentPanel, BorderLayout.CENTER);

        return dataPanel;
    }

    private void addSubMenuButton(JPanel panel, String text, String cardName) {
        JButton button = new JButton(text);
        
        // Add icon based on the button text
        String iconPath = null;
        switch (text) {
            case "Loại màn hình":
                iconPath = "src/main/resources/images/manHinh.png";
                break;
            case "Phòng chiếu":
                iconPath = "src/main/resources/images/phongChieu.png";
                break;
            case "Thể loại":
                iconPath = "src/main/resources/images/theloai.jpeg";
                break;
            case "Phim":
                iconPath = "src/main/resources/images/phim.png";
                break;
            case "Định dạng":
                iconPath = "src/main/resources/images/dinhDang.png";
                break;
            case "Lịch chiếu":
                iconPath = "src/main/resources/images/lichChieu.png";
                break;
            case "Thức ăn":
                iconPath = "src/main/resources/images/ve.png"; // Using ve.png as placeholder
                break;
        }

        if (iconPath != null) {
            try {
                ImageIcon icon = new ImageIcon(iconPath);
                Image img = icon.getImage().getScaledInstance(20, 20, Image.SCALE_SMOOTH);
                button.setIcon(new ImageIcon(img));
            } catch (Exception e) {
                e.printStackTrace();
            }
        }

        // Style the button
        button.setForeground(Color.WHITE);
        button.setBackground(new Color(52, 58, 64));
        button.setFocusPainted(false);
        button.setBorderPainted(true);
        button.setFont(new Font("Arial", Font.PLAIN, 14));
        button.setPreferredSize(new Dimension(220, 40)); // Increased width to 220
        button.setMinimumSize(new Dimension(220, 40));   // Set minimum size
        button.setMaximumSize(new Dimension(220, 40));   // Set maximum size
        button.setHorizontalAlignment(SwingConstants.LEFT); // Align text to left
        button.setHorizontalTextPosition(SwingConstants.RIGHT); // Place text to the right of icon
        button.setIconTextGap(15); // Increased gap between icon and text
        
        // Add consistent border to all buttons
        button.setBorder(BorderFactory.createCompoundBorder(
            BorderFactory.createLineBorder(new Color(255, 193, 7), 2),
            BorderFactory.createEmptyBorder(5, 15, 5, 15) // Increased left padding to 15
        ));

        // Add hover effect
        button.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseEntered(java.awt.event.MouseEvent evt) {
                button.setBackground(new Color(73, 80, 87));
            }

            public void mouseExited(java.awt.event.MouseEvent evt) {
                button.setBackground(new Color(52, 58, 64));
            }
        });

        button.addActionListener(e -> {
            JPanel dataPanel = (JPanel) mainContentPanel.getComponent(1);
            JPanel contentPanel = (JPanel) dataPanel.getComponent(1);
            CardLayout cl = (CardLayout) contentPanel.getLayout();
            cl.show(contentPanel, cardName);
        });

        panel.add(button);
        panel.add(Box.createVerticalStrut(10));
    }

    private JPanel createStaffPanel() {
        JPanel panel = new JPanel(new BorderLayout(10, 10));
        panel.setBorder(BorderFactory.createEmptyBorder(20, 20, 20, 20));

        // Create top panel with search and CRUD buttons
        JPanel topPanel = new JPanel(new GridBagLayout());
        GridBagConstraints gbc = new GridBagConstraints();
        gbc.insets = new Insets(5, 5, 5, 5);
        gbc.fill = GridBagConstraints.HORIZONTAL;

        // Search panel
        JPanel searchPanel = new JPanel(new GridBagLayout());
        searchPanel.setBorder(BorderFactory.createTitledBorder("Tìm kiếm"));
        GridBagConstraints searchGbc = new GridBagConstraints();
        searchGbc.insets = new Insets(5, 5, 5, 5);
        searchGbc.fill = GridBagConstraints.HORIZONTAL;

        // Search field
        JTextField searchField = new JTextField(20);
        searchField.setPreferredSize(new Dimension(200, 30));
        searchGbc.gridx = 0;
        searchGbc.gridy = 0;
        searchPanel.add(new JLabel("Tìm kiếm:"), searchGbc);
        searchGbc.gridx = 1;
        searchPanel.add(searchField, searchGbc);

        // Search button
        JButton searchButton = new JButton("Tìm");
        styleSearchButton(searchButton);
        searchButton.setPreferredSize(new Dimension(80, 30));
        searchButton.setBackground(Color.BLACK);
        searchButton.setForeground(Color.WHITE);
        searchButton.setFocusPainted(false);
        searchGbc.gridx = 2;
        searchPanel.add(searchButton, searchGbc);

        // CRUD buttons panel
        JPanel crudPanel = new JPanel(new FlowLayout(FlowLayout.RIGHT, 10, 5));
        crudPanel.setBorder(BorderFactory.createTitledBorder("Thao tác"));

        JButton addButton = createActionButton("Thêm", "icon-add.png");
        JButton editButton = createActionButton("Sửa", "Setting.png");
        JButton deleteButton = createActionButton("Xóa", "remove.png");
        JButton resetPasswordButton = createActionButton("Cấp lại mật khẩu", "Setting.png");

        crudPanel.add(addButton);
        crudPanel.add(editButton);
        crudPanel.add(deleteButton);
        crudPanel.add(resetPasswordButton);

        // Add search panel and CRUD panel to top panel side by side
        gbc.gridx = 0;
        gbc.gridy = 0;
        gbc.weightx = 0.7; // Give more space to search panel
        topPanel.add(searchPanel, gbc);

        gbc.gridx = 1;
        gbc.weightx = 0.3; // Less space for CRUD panel
        topPanel.add(crudPanel, gbc);

        // Create table
        String[] columnNames = {"ID", "Tên nhân viên", "Tên đăng nhập", "Quyền"};
        DefaultTableModel staffTableModel = new DefaultTableModel(columnNames, 0) {
            @Override
            public boolean isCellEditable(int row, int column) {
                return false;
            }
        };
        JTable staffTable = new JTable(staffTableModel);
        JScrollPane scrollPane = new JScrollPane(staffTable);

        // Add search functionality
        searchButton.addActionListener(e -> {
            String searchText = searchField.getText().trim();
            loadStaffWithSearch(staffTableModel, searchText);
        });

        searchField.addActionListener(e -> {
            String searchText = searchField.getText().trim();
            loadStaffWithSearch(staffTableModel, searchText);
        });

        // Add action listeners for CRUD buttons
        addButton.addActionListener(e -> {
            StaffDialog dialog = new StaffDialog(this, "Thêm nhân viên mới", null);
            dialog.setVisible(true);
            if (dialog.isConfirmed()) {
                Staff staff = dialog.getStaff();
                try (Connection conn = DatabaseUtil.getConnection();
                     PreparedStatement pstmt = conn.prepareStatement(
                         "INSERT INTO staff (name, username, password, role) VALUES (?, ?, ?, ?)")) {
                    
                    pstmt.setString(1, staff.getName());
                    pstmt.setString(2, staff.getUsername());
                    pstmt.setString(3, staff.getPassword());
                    pstmt.setString(4, staff.getRole());
                    pstmt.executeUpdate();

                    loadStaffWithSearch(staffTableModel, searchField.getText().trim());
                    JOptionPane.showMessageDialog(this, "Thêm nhân viên thành công");
                } catch (SQLException ex) {
                    JOptionPane.showMessageDialog(this, "Lỗi khi thêm nhân viên: " + ex.getMessage());
                }
            }
        });

        editButton.addActionListener(e -> {
            int selectedRow = staffTable.getSelectedRow();
            if (selectedRow >= 0) {
                Staff staff = new Staff(
                    (int) staffTable.getValueAt(selectedRow, 0),
                    (String) staffTable.getValueAt(selectedRow, 1),
                    (String) staffTable.getValueAt(selectedRow, 2),
                    "", // Password will be updated only if changed
                    (String) staffTable.getValueAt(selectedRow, 3)
                );

                StaffDialog dialog = new StaffDialog(this, "Sửa thông tin nhân viên", staff);
                dialog.setVisible(true);
                if (dialog.isConfirmed()) {
                    Staff updatedStaff = dialog.getStaff();
                    try (Connection conn = DatabaseUtil.getConnection();
                         PreparedStatement pstmt = conn.prepareStatement(
                             "UPDATE staff SET name = ?, username = ?, password = ?, role = ? WHERE id = ?")) {
                        
                        pstmt.setString(1, updatedStaff.getName());
                        pstmt.setString(2, updatedStaff.getUsername());
                        pstmt.setString(3, updatedStaff.getPassword());
                        pstmt.setString(4, updatedStaff.getRole());
                        pstmt.setInt(5, updatedStaff.getId());
                        pstmt.executeUpdate();

                        loadStaffWithSearch(staffTableModel, searchField.getText().trim());
                        JOptionPane.showMessageDialog(this, "Cập nhật thông tin nhân viên thành công");
                    } catch (SQLException ex) {
                        JOptionPane.showMessageDialog(this, "Lỗi khi cập nhật thông tin nhân viên: " + ex.getMessage());
                    }
                }
            } else {
                JOptionPane.showMessageDialog(this, "Vui lòng chọn nhân viên cần sửa");
            }
        });

        deleteButton.addActionListener(e -> {
            int selectedRow = staffTable.getSelectedRow();
            if (selectedRow >= 0) {
                int id = (int) staffTable.getValueAt(selectedRow, 0);
                int confirm = JOptionPane.showConfirmDialog(this,
                    "Bạn có chắc chắn muốn xóa nhân viên này?",
                    "Xác nhận xóa",
                    JOptionPane.YES_NO_OPTION);
                
                if (confirm == JOptionPane.YES_OPTION) {
                    try (Connection conn = DatabaseUtil.getConnection();
                         PreparedStatement pstmt = conn.prepareStatement(
                             "DELETE FROM staff WHERE id = ?")) {
                        
                        pstmt.setInt(1, id);
                        pstmt.executeUpdate();

                        loadStaffWithSearch(staffTableModel, searchField.getText().trim());
                        JOptionPane.showMessageDialog(this, "Xóa nhân viên thành công");
                    } catch (SQLException ex) {
                        JOptionPane.showMessageDialog(this, "Lỗi khi xóa nhân viên: " + ex.getMessage());
                    }
                }
            } else {
                JOptionPane.showMessageDialog(this, "Vui lòng chọn nhân viên cần xóa");
            }
        });

        resetPasswordButton.addActionListener(e -> {
            int selectedRow = staffTable.getSelectedRow();
            if (selectedRow >= 0) {
                int id = (int) staffTable.getValueAt(selectedRow, 0);
                String defaultPassword = "123456"; // Default password
                
                try (Connection conn = DatabaseUtil.getConnection();
                     PreparedStatement pstmt = conn.prepareStatement(
                         "UPDATE staff SET password = ? WHERE id = ?")) {
                    
                    pstmt.setString(1, defaultPassword);
                    pstmt.setInt(2, id);
                    pstmt.executeUpdate();

                    JOptionPane.showMessageDialog(this, 
                        "Đã cấp lại mật khẩu mặc định: " + defaultPassword);
                } catch (SQLException ex) {
                    JOptionPane.showMessageDialog(this, 
                        "Lỗi khi cấp lại mật khẩu: " + ex.getMessage());
                }
            } else {
                JOptionPane.showMessageDialog(this, 
                    "Vui lòng chọn nhân viên cần cấp lại mật khẩu");
            }
        });

        // Add components to panel
        panel.add(topPanel, BorderLayout.NORTH);
        panel.add(scrollPane, BorderLayout.CENTER);

        // Load initial data
        loadStaffWithSearch(staffTableModel, "");

        return panel;
    }

    private void loadStaffWithSearch(DefaultTableModel model, String searchText) {
        model.setRowCount(0);
        String sql = "SELECT * FROM staff WHERE 1=1";
        boolean hasSearch = searchText != null && !searchText.trim().isEmpty();
        boolean isNumber = hasSearch && searchText.matches("\\d+");
        if (hasSearch) {
            if (isNumber) {
                sql += " AND (id = ? OR name LIKE ? OR username LIKE ? OR role LIKE ?)";
            } else {
                sql += " AND (name LIKE ? OR username LIKE ? OR role LIKE ?)";
            }
        }
        sql += " ORDER BY id";
        try (Connection conn = DatabaseUtil.getConnection();
             PreparedStatement stmt = conn.prepareStatement(sql)) {
            if (hasSearch) {
                if (isNumber) {
                    stmt.setInt(1, Integer.parseInt(searchText));
                    String like = "%" + searchText + "%";
                    stmt.setString(2, like);
                    stmt.setString(3, like);
                    stmt.setString(4, like);
                } else {
                    String like = "%" + searchText + "%";
                    stmt.setString(1, like);
                    stmt.setString(2, like);
                    stmt.setString(3, like);
                }
            }
            try (ResultSet rs = stmt.executeQuery()) {
                while (rs.next()) {
                    Vector<Object> row = new Vector<>();
                    row.add(rs.getInt("id"));
                    row.add(rs.getString("name"));
                    row.add(rs.getString("username"));
                    row.add(rs.getString("role"));
                    model.addRow(row);
                }
            }
        } catch (SQLException e) {
            JOptionPane.showMessageDialog(this, 
                "Lỗi khi tải dữ liệu nhân viên: " + e.getMessage());
        }
    }

    private JPanel createCustomersPanel() {
        JPanel panel = new JPanel(new BorderLayout(10, 10));
        panel.setBorder(BorderFactory.createEmptyBorder(20, 20, 20, 20));

        // Create top panel with search and CRUD buttons
        JPanel topPanel = new JPanel(new GridBagLayout());
        GridBagConstraints gbc = new GridBagConstraints();
        gbc.insets = new Insets(5, 5, 5, 5);
        gbc.fill = GridBagConstraints.HORIZONTAL;

        // Search panel
        JPanel searchPanel = new JPanel(new GridBagLayout());
        searchPanel.setBorder(BorderFactory.createTitledBorder("Tìm kiếm"));
        GridBagConstraints searchGbc = new GridBagConstraints();
        searchGbc.insets = new Insets(5, 5, 5, 5);
        searchGbc.fill = GridBagConstraints.HORIZONTAL;

        // Search field
        JTextField searchField = new JTextField(20);
        searchField.setPreferredSize(new Dimension(200, 30));
        searchGbc.gridx = 0;
        searchGbc.gridy = 0;
        searchPanel.add(new JLabel("Tìm kiếm:"), searchGbc);
        searchGbc.gridx = 1;
        searchPanel.add(searchField, searchGbc);

        // Search button
        JButton searchButton = new JButton("Tìm");
        styleSearchButton(searchButton);
        searchButton.setPreferredSize(new Dimension(80, 30));
        searchButton.setBackground(Color.BLACK);
        searchButton.setForeground(Color.WHITE);
        searchButton.setFocusPainted(false);
        searchGbc.gridx = 2;
        searchPanel.add(searchButton, searchGbc);

        // CRUD buttons panel
        JPanel crudPanel = new JPanel(new FlowLayout(FlowLayout.RIGHT, 10, 5));
        crudPanel.setBorder(BorderFactory.createTitledBorder("Thao tác"));

        JButton addButton = createActionButton("Thêm", "icon-add.png");
        JButton editButton = createActionButton("Sửa", "Setting.png");
        JButton deleteButton = createActionButton("Xóa", "remove.png");
        JButton viewButton = createActionButton("Xem", "view.png");
        JButton exportButton = createActionButton("Xuất File", "export.png");

        crudPanel.add(addButton);
        crudPanel.add(editButton);
        crudPanel.add(deleteButton);
        crudPanel.add(viewButton);
        crudPanel.add(exportButton);

        // Add search panel and CRUD panel to top panel side by side
        gbc.gridx = 0;
        gbc.gridy = 0;
        gbc.weightx = 0.7; // Give more space to search panel
        topPanel.add(searchPanel, gbc);

        gbc.gridx = 1;
        gbc.weightx = 0.3; // Less space for CRUD panel
        topPanel.add(crudPanel, gbc);

        // Create table
        String[] columnNames = {"Mã KH", "Họ tên", "Ngày sinh", "Địa chỉ", "SĐT", "CCCD", "Điểm tích lũy"};
        DefaultTableModel customerTableModel = new DefaultTableModel(columnNames, 0) {
            @Override
            public boolean isCellEditable(int row, int column) {
                return false;
            }
        };
        JTable customerTable = new JTable(customerTableModel);
        JScrollPane scrollPane = new JScrollPane(customerTable);

        // Add panels to main panel
        panel.add(topPanel, BorderLayout.NORTH);
        panel.add(scrollPane, BorderLayout.CENTER);

        // Add action listeners
        searchButton.addActionListener(e -> {
            String searchText = searchField.getText().trim();
            loadCustomers(customerTableModel, searchText);
        });

        addButton.addActionListener(e -> showCustomerDialog(null, customerTableModel));

        editButton.addActionListener(e -> {
            int selectedRow = customerTable.getSelectedRow();
            if (selectedRow >= 0) {
                String customerId = (String) customerTable.getValueAt(selectedRow, 0);
                showCustomerDialog(customerId, customerTableModel);
            } else {
                JOptionPane.showMessageDialog(this, "Vui lòng chọn khách hàng cần sửa.");
            }
        });

        deleteButton.addActionListener(e -> {
            int selectedRow = customerTable.getSelectedRow();
            if (selectedRow >= 0) {
                String customerId = (String) customerTable.getValueAt(selectedRow, 0);
                deleteCustomer(customerId, customerTableModel);
            } else {
                JOptionPane.showMessageDialog(this, "Vui lòng chọn khách hàng cần xóa.");
            }
        });

        viewButton.addActionListener(e -> {
            int selectedRow = customerTable.getSelectedRow();
            if (selectedRow >= 0) {
                String customerId = (String) customerTable.getValueAt(selectedRow, 0);
                viewCustomerDetails(customerId);
            } else {
                JOptionPane.showMessageDialog(this, "Vui lòng chọn khách hàng cần xem.");
            }
        });

        exportButton.addActionListener(e -> {
            JFileChooser fileChooser = new JFileChooser();
            fileChooser.setDialogTitle("Chọn nơi lưu file");
            fileChooser.setFileSelectionMode(JFileChooser.FILES_ONLY);
            
            if (fileChooser.showSaveDialog(panel) == JFileChooser.APPROVE_OPTION) {
                File file = fileChooser.getSelectedFile();
                if (!file.getName().toLowerCase().endsWith(".csv")) {
                    file = new File(file.getAbsolutePath() + ".csv");
                }
                
                try (PrintWriter writer = new PrintWriter(new FileWriter(file))) {
                    // Write header
                    writer.println("Mã KH,Họ tên,Ngày sinh,Địa chỉ,SĐT,CCCD,Điểm tích lũy");
                    
                    // Write data
                    for (int i = 0; i < customerTableModel.getRowCount(); i++) {
                        StringBuilder line = new StringBuilder();
                        for (int j = 0; j < customerTableModel.getColumnCount(); j++) {
                            if (j > 0) line.append(",");
                            line.append(customerTableModel.getValueAt(i, j));
                        }
                        writer.println(line.toString());
                    }
                    
                    JOptionPane.showMessageDialog(panel, "Xuất file thành công");
                } catch (IOException ex) {
                    JOptionPane.showMessageDialog(panel, "Lỗi khi xuất file: " + ex.getMessage());
                }
            }
        });

        // Load initial data
        loadCustomers(customerTableModel, "");

        return panel;
    }

    private void loadCustomers(DefaultTableModel model, String searchQuery) {
        model.setRowCount(0);
        String sql = "SELECT * FROM customers WHERE customer_id NOT LIKE 'GUEST%'";
        boolean hasSearch = searchQuery != null && !searchQuery.trim().isEmpty();
        if (hasSearch) {
            sql += " AND (customer_id LIKE ? OR full_name LIKE ? OR address LIKE ? OR phone_number LIKE ? OR id_card LIKE ?)";
        }
        sql += " ORDER BY customer_id";
        try (Connection conn = dbUtil.getConnection();
             PreparedStatement pstmt = conn.prepareStatement(sql)) {
            if (hasSearch) {
                String like = "%" + searchQuery.trim() + "%";
                pstmt.setString(1, like);
                pstmt.setString(2, like);
                pstmt.setString(3, like);
                pstmt.setString(4, like);
                pstmt.setString(5, like);
            }
            ResultSet rs = pstmt.executeQuery();
            while (rs.next()) {
                String dob = rs.getString("date_of_birth");
                try {
                    java.util.Date d = new java.text.SimpleDateFormat("yyyy-MM-dd").parse(dob);
                    dob = new java.text.SimpleDateFormat("dd/MM/yyyy").format(d);
                } catch (Exception e) {}
                Vector<Object> row = new Vector<>();
                row.add(rs.getString("customer_id"));
                row.add(rs.getString("full_name"));
                row.add(dob);
                row.add(rs.getString("address"));
                row.add(rs.getString("phone_number"));
                row.add(rs.getString("id_card"));
                row.add(rs.getInt("loyalty_points"));
                model.addRow(row);
            }
        } catch (SQLException e) {
            JOptionPane.showMessageDialog(this, "Lỗi khi tải danh sách khách hàng: " + e.getMessage());
        }
    }

    private void deleteCustomer(String customerId, DefaultTableModel model) {
        try (Connection conn = DatabaseUtil.getConnection();
             PreparedStatement pstmt = conn.prepareStatement("DELETE FROM customers WHERE customer_id = ?")) {
            pstmt.setString(1, customerId);
            pstmt.executeUpdate();
            model.removeRow(model.getRowCount() - 1);
        } catch (SQLException e) {
            e.printStackTrace();
            JOptionPane.showMessageDialog(this, "Lỗi khi xóa khách hàng: " + e.getMessage());
        }
    }

    private void viewCustomerDetails(String customerId) {
        try (Connection conn = DatabaseUtil.getConnection();
             PreparedStatement pstmt = conn.prepareStatement("SELECT * FROM customers WHERE customer_id = ?")) {
            pstmt.setString(1, customerId);
            ResultSet rs = pstmt.executeQuery();
            if (rs.next()) {
                String fullName = rs.getString("full_name");
                String dateOfBirth = rs.getString("date_of_birth");
                // Đổi định dạng ngày sinh nếu cần
                try {
                    java.util.Date d = new java.text.SimpleDateFormat("yyyy-MM-dd").parse(dateOfBirth);
                    dateOfBirth = new java.text.SimpleDateFormat("dd/MM/yyyy").format(d);
                } catch (Exception e) {}
                String address = rs.getString("address");
                String phoneNumber = rs.getString("phone_number");
                String idCard = rs.getString("id_card");
                int loyaltyPoints = rs.getInt("loyalty_points");
                JOptionPane.showMessageDialog(this,
                    "Mã khách hàng: " + customerId + "\n" +
                    "Họ tên: " + fullName + "\n" +
                    "Ngày sinh: " + dateOfBirth + "\n" +
                    "Địa chỉ: " + address + "\n" +
                    "Số điện thoại: " + phoneNumber + "\n" +
                    "CCCD: " + idCard + "\n" +
                    "Điểm tích lũy: " + loyaltyPoints,
                    "Chi tiết khách hàng",
                    JOptionPane.INFORMATION_MESSAGE);
            }
        } catch (SQLException e) {
            e.printStackTrace();
            JOptionPane.showMessageDialog(this, "Lỗi khi lấy thông tin khách hàng: " + e.getMessage());
        }
    }

    private void handleLogout() {
        int choice = JOptionPane.showConfirmDialog(
            this,
            "Bạn có chắc chắn muốn đăng xuất?",
            "Xác nhận đăng xuất",
            JOptionPane.YES_NO_OPTION,
            JOptionPane.QUESTION_MESSAGE
        );
        
        if (choice == JOptionPane.YES_OPTION) {
            showLoginDialog();
        }
    }

    private void showLoginDialog() {
        // Dispose current window
        dispose();
        
        // Create and show new login dialog
        SwingUtilities.invokeLater(() -> {
            LoginDialog loginDialog = new LoginDialog(null);
            loginDialog.setVisible(true);
            
            if (loginDialog.isAuthenticated()) {
                String role = loginDialog.getCurrentUserRole();
                if ("ADMIN".equals(role)) {
                    MovieManagerApp app = new MovieManagerApp(role);
                    app.setVisible(true);
                } else if ("STAFF".equals(role)) {
                    StaffControlPanel staffPanel = new StaffControlPanel();
                    staffPanel.setVisible(true);
                }
            } else {
                System.exit(0);
            }
        });
    }

    public static void main(String[] args) {
        SwingUtilities.invokeLater(() -> {
            LoginDialog loginDialog = new LoginDialog(null);
            loginDialog.setVisible(true);
            
            if (loginDialog.isAuthenticated()) {
                String role = loginDialog.getCurrentUserRole();
                if ("ADMIN".equals(role)) {
                    MovieManagerApp app = new MovieManagerApp(role);
                    app.setVisible(true);
                } else if ("STAFF".equals(role)) {
                    StaffControlPanel staffPanel = new StaffControlPanel();
                    staffPanel.setVisible(true);
                }
            } else {
                System.exit(0);
            }
        });
    }

    // Add this helper method to refresh all screen combo boxes
    private void refreshAllScreenComboBoxes() {
        // If you have references to all screen combo boxes, call loadScreensToComboBox on each
        // For now, reload the theater panel if possible
        // This is a placeholder for a more robust solution
        // You may need to refactor to keep references to the combo boxes
    }

    private void styleButton(JButton button) {
        Color bg = button.getBackground();
        // Nếu nền tối thì chữ trắng, nền sáng thì chữ đen
        int brightness = (bg.getRed()*299 + bg.getGreen()*587 + bg.getBlue()*114) / 1000;
        if (brightness < 128) {
            button.setForeground(Color.WHITE);
        } else {
            button.setForeground(Color.BLACK);
        }
        button.setFocusPainted(false);
        button.setBorderPainted(false);
        button.setFont(new Font("Arial", Font.BOLD, 14));
    }

    // Add this helper method for creating action buttons
    private JButton createActionButton(String text, String iconPath) {
        JButton button = new JButton(text);
        try {
            ImageIcon icon = new ImageIcon("src/main/resources/images/" + iconPath);
            Image img = icon.getImage().getScaledInstance(20, 20, Image.SCALE_SMOOTH);
            button.setIcon(new ImageIcon(img));
        } catch (Exception e) {
            e.printStackTrace();
        }
        styleButton(button);
        button.setIconTextGap(10);
        return button;
    }

    private String buildSearchQuery(String customerId, String name, String dob, String address, 
                                  String phone, String idCard, String points) {
        StringBuilder query = new StringBuilder();
        List<String> conditions = new ArrayList<>();

        if (!customerId.isEmpty()) {
            conditions.add("customer_id LIKE '%" + customerId + "%'");
        }
        if (!name.isEmpty()) {
            conditions.add("full_name LIKE '%" + name + "%'");
        }
        if (!dob.isEmpty()) {
            conditions.add("date_of_birth LIKE '%" + dob + "%'");
        }
        if (!address.isEmpty()) {
            conditions.add("address LIKE '%" + address + "%'");
        }
        if (!phone.isEmpty()) {
            conditions.add("phone_number LIKE '%" + phone + "%'");
        }
        if (!idCard.isEmpty()) {
            conditions.add("id_card LIKE '%" + idCard + "%'");
        }
        if (!points.isEmpty()) {
            conditions.add("loyalty_points = " + points);
        }

        if (!conditions.isEmpty()) {
            query.append(String.join(" AND ", conditions));
        }

        return query.toString();
    }

    private void showCustomerDialog(String customerId, DefaultTableModel model) {
        JDialog dialog = new JDialog(this, "Thông tin khách hàng", true);
        dialog.setLayout(new BorderLayout(10, 10));
        dialog.setSize(400, 500);
        dialog.setLocationRelativeTo(this);

        JPanel formPanel = new JPanel(new GridBagLayout());
        formPanel.setBorder(BorderFactory.createEmptyBorder(10, 10, 10, 10));
        GridBagConstraints gbc = new GridBagConstraints();
        gbc.fill = GridBagConstraints.HORIZONTAL;
        gbc.insets = new Insets(5, 5, 5, 5);

        // Create form fields
        JTextField idField = new JTextField(20);
        JTextField nameField = new JTextField(20);
        JTextField dobField = new JTextField(20);
        JTextField addressField = new JTextField(20);
        JTextField phoneField = new JTextField(20);
        JTextField idCardField = new JTextField(20);
        JTextField pointsField = new JTextField(20);

        // If editing existing customer, load their data
        if (customerId != null) {
            try (Connection conn = DatabaseUtil.getConnection();
                 PreparedStatement pstmt = conn.prepareStatement("SELECT * FROM customers WHERE customer_id = ?")) {
                pstmt.setString(1, customerId);
                ResultSet rs = pstmt.executeQuery();
                if (rs.next()) {
                    idField.setText(rs.getString("customer_id"));
                    nameField.setText(rs.getString("full_name"));
                    dobField.setText(rs.getString("date_of_birth"));
                    addressField.setText(rs.getString("address"));
                    phoneField.setText(rs.getString("phone_number"));
                    idCardField.setText(rs.getString("id_card"));
                    pointsField.setText(String.valueOf(rs.getInt("loyalty_points")));
                }
            } catch (SQLException e) {
                e.printStackTrace();
                JOptionPane.showMessageDialog(dialog, "Lỗi khi tải thông tin khách hàng: " + e.getMessage());
                return;
            }
        } else {
            // For new customer, generate ID
            idField.setText("C" + System.currentTimeMillis());
            idField.setEditable(false);
            pointsField.setText("0");
        }

        // Add form fields
        gbc.gridx = 0; gbc.gridy = 0;
        formPanel.add(new JLabel("Mã khách hàng:"), gbc);
        gbc.gridx = 1;
        formPanel.add(idField, gbc);

        gbc.gridx = 0; gbc.gridy = 1;
        formPanel.add(new JLabel("Họ tên:"), gbc);
        gbc.gridx = 1;
        formPanel.add(nameField, gbc);

        gbc.gridx = 0; gbc.gridy = 2;
        formPanel.add(new JLabel("Ngày sinh:"), gbc);
        gbc.gridx = 1;
        formPanel.add(dobField, gbc);

        gbc.gridx = 0; gbc.gridy = 3;
        formPanel.add(new JLabel("Địa chỉ:"), gbc);
        gbc.gridx = 1;
        formPanel.add(addressField, gbc);

        gbc.gridx = 0; gbc.gridy = 4;
        formPanel.add(new JLabel("Số điện thoại:"), gbc);
        gbc.gridx = 1;
        formPanel.add(phoneField, gbc);

        gbc.gridx = 0; gbc.gridy = 5;
        formPanel.add(new JLabel("CCCD:"), gbc);
        gbc.gridx = 1;
        formPanel.add(idCardField, gbc);

        gbc.gridx = 0; gbc.gridy = 6;
        formPanel.add(new JLabel("Điểm tích lũy:"), gbc);
        gbc.gridx = 1;
        formPanel.add(pointsField, gbc);

        // Add buttons
        JPanel buttonPanel = new JPanel(new FlowLayout(FlowLayout.RIGHT));
        JButton saveButton = new JButton("Lưu");
        JButton cancelButton = new JButton("Hủy");

        saveButton.addActionListener(e -> {
            try {
                String id = idField.getText().trim();
                String name = nameField.getText().trim();
                String dob = dobField.getText().trim();
                String address = addressField.getText().trim();
                String phone = phoneField.getText().trim();
                String idCard = idCardField.getText().trim();
                int points = Integer.parseInt(pointsField.getText().trim());

                if (name.isEmpty() || dob.isEmpty() || address.isEmpty() || phone.isEmpty() || idCard.isEmpty()) {
                    JOptionPane.showMessageDialog(dialog, "Vui lòng điền đầy đủ thông tin!");
                    return;
                }

                try (Connection conn = DatabaseUtil.getConnection()) {
                    if (customerId == null) {
                        // Insert new customer
                        try (PreparedStatement pstmt = conn.prepareStatement(
                                "INSERT INTO customers (customer_id, full_name, date_of_birth, address, phone_number, id_card, loyalty_points) VALUES (?, ?, ?, ?, ?, ?, ?)")) {
                            pstmt.setString(1, id);
                            pstmt.setString(2, name);
                            pstmt.setString(3, dob);
                            pstmt.setString(4, address);
                            pstmt.setString(5, phone);
                            pstmt.setString(6, idCard);
                            pstmt.setInt(7, points);
                            pstmt.executeUpdate();
                        }
                    } else {
                        // Update existing customer
                        try (PreparedStatement pstmt = conn.prepareStatement(
                                "UPDATE customers SET full_name = ?, date_of_birth = ?, address = ?, phone_number = ?, id_card = ?, loyalty_points = ? WHERE customer_id = ?")) {
                            pstmt.setString(1, name);
                            pstmt.setString(2, dob);
                            pstmt.setString(3, address);
                            pstmt.setString(4, phone);
                            pstmt.setString(5, idCard);
                            pstmt.setInt(6, points);
                            pstmt.setString(7, id);
                            pstmt.executeUpdate();
                        }
                    }
                    loadCustomers(model, "");
                    dialog.dispose();
                }
            } catch (SQLException ex) {
                ex.printStackTrace();
                JOptionPane.showMessageDialog(dialog, "Lỗi khi lưu thông tin khách hàng: " + ex.getMessage());
            } catch (NumberFormatException ex) {
                JOptionPane.showMessageDialog(dialog, "Điểm tích lũy phải là số!");
            }
        });

        cancelButton.addActionListener(e -> dialog.dispose());

        buttonPanel.add(saveButton);
        buttonPanel.add(cancelButton);

        dialog.add(formPanel, BorderLayout.CENTER);
        dialog.add(buttonPanel, BorderLayout.SOUTH);
        dialog.setVisible(true);
    }

    // Remove the old DatePicker class and add these utility methods
    private JDateChooser createDatePicker() {
        JDateChooser dateChooser = new JDateChooser();
        dateChooser.setDateFormatString("dd/MM/yyyy");
        dateChooser.setPreferredSize(new Dimension(120, 30));
        dateChooser.setFont(new Font("Arial", Font.PLAIN, 14));
        dateChooser.setBackground(Color.WHITE);
        return dateChooser;
    }

    private String getDateFromPicker(JDateChooser picker) {
        if (picker.getDate() == null) return "";
        return new SimpleDateFormat("dd/MM/yyyy").format(picker.getDate());
    }

    private void setDateToPicker(JDateChooser picker, String dateStr) {
        try {
            if (dateStr != null && !dateStr.isEmpty()) {
                // Parse SQL date format (yyyy-MM-dd)
                SimpleDateFormat sqlFormat = new SimpleDateFormat("yyyy-MM-dd");
                Date date = sqlFormat.parse(dateStr);
                picker.setDate(date);
            }
        } catch (ParseException e) {
            e.printStackTrace();
        }
    }

    private void showTheaterDialog(String theaterId, DefaultTableModel model) {
        JDialog dialog = new JDialog(this, theaterId == null ? "Thêm phòng chiếu" : "Sửa phòng chiếu", true);
        dialog.setSize(400, 300);
        dialog.setLocationRelativeTo(this);

        JPanel panel = new JPanel(new GridBagLayout());
        GridBagConstraints gbc = new GridBagConstraints();
        gbc.insets = new Insets(5, 5, 5, 5);
        gbc.fill = GridBagConstraints.HORIZONTAL;

        // Add form fields
        JTextField nameField = new JTextField(20);
        JComboBox<String> screenCombo = new JComboBox<>();
        JTextField seatsField = new JTextField(20);
        JTextField rowsField = new JTextField(20);
        JTextField seatsPerRowField = new JTextField(20);

        // Load screen data
        loadScreensToComboBox(screenCombo);

        // Add components to panel
        gbc.gridx = 0; gbc.gridy = 0;
        panel.add(new JLabel("Tên phòng:"), gbc);
        gbc.gridx = 1;
        panel.add(nameField, gbc);

        gbc.gridx = 0; gbc.gridy = 1;
        panel.add(new JLabel("Màn hình:"), gbc);
        gbc.gridx = 1;
        panel.add(screenCombo, gbc);

        gbc.gridx = 0; gbc.gridy = 2;
        panel.add(new JLabel("Số chỗ ngồi:"), gbc);
        gbc.gridx = 1;
        panel.add(seatsField, gbc);

        gbc.gridx = 0; gbc.gridy = 3;
        panel.add(new JLabel("Số hàng ghế:"), gbc);
        gbc.gridx = 1;
        panel.add(rowsField, gbc);

        gbc.gridx = 0; gbc.gridy = 4;
        panel.add(new JLabel("Số ghế mỗi hàng:"), gbc);
        gbc.gridx = 1;
        panel.add(seatsPerRowField, gbc);

        // Add buttons
        JPanel buttonPanel = new JPanel(new FlowLayout(FlowLayout.RIGHT));
        JButton saveButton = new JButton("Lưu");
        JButton cancelButton = new JButton("Hủy");
        buttonPanel.add(saveButton);
        buttonPanel.add(cancelButton);

        gbc.gridx = 0; gbc.gridy = 5;
        gbc.gridwidth = 2;
        panel.add(buttonPanel, gbc);

        // Load existing data if editing
        if (theaterId != null) {
            try (Connection conn = dbUtil.getConnection();
                 PreparedStatement stmt = conn.prepareStatement("SELECT * FROM theaters WHERE id = ?")) {
                stmt.setString(1, theaterId);
                try (ResultSet rs = stmt.executeQuery()) {
                    if (rs.next()) {
                        nameField.setText(rs.getString("name"));
                        screenCombo.setSelectedItem(rs.getString("screen_id"));
                        seatsField.setText(String.valueOf(rs.getInt("total_seats")));
                        rowsField.setText(String.valueOf(rs.getInt("rows")));
                        seatsPerRowField.setText(String.valueOf(rs.getInt("seats_per_row")));
                    }
                }
            } catch (SQLException e) {
                JOptionPane.showMessageDialog(this, "Lỗi khi tải dữ liệu phòng chiếu: " + e.getMessage());
            }
        }

        // Add action listeners
        saveButton.addActionListener(e -> {
            try {
                String name = nameField.getText().trim();
                String screenId = screenCombo.getSelectedItem().toString().split(" - ")[0];
                int seats = Integer.parseInt(seatsField.getText().trim());
                int rows = Integer.parseInt(rowsField.getText().trim());
                int seatsPerRow = Integer.parseInt(seatsPerRowField.getText().trim());

                if (theaterId == null) {
                    // Add new theater
                    try (Connection conn = dbUtil.getConnection()) {
                        // Generate new theater ID in format T00x
                        String newTheaterId;
                        try (PreparedStatement stmt = conn.prepareStatement(
                            "SELECT MAX(CAST(SUBSTR(id, 2) AS INTEGER)) AS max_num FROM theaters WHERE id LIKE 'T%'")) {
                            ResultSet rs = stmt.executeQuery();
                            int maxNum = 0;
                            if (rs.next()) {
                                maxNum = rs.getInt("max_num");
                            }
                            newTheaterId = String.format("T%03d", maxNum + 1);
                        }

                        // Insert new theater
                        try (PreparedStatement stmt = conn.prepareStatement(
                            "INSERT INTO theaters (id, name, screen_id, total_seats, rows, seats_per_row) VALUES (?, ?, ?, ?, ?, ?)")) {
                            stmt.setString(1, newTheaterId);
                            stmt.setString(2, name);
                            stmt.setString(3, screenId);
                            stmt.setInt(4, seats);
                            stmt.setInt(5, rows);
                            stmt.setInt(6, seatsPerRow);
                        stmt.executeUpdate();
                        JOptionPane.showMessageDialog(this, "Thêm phòng chiếu thành công");
                        }

                        // Delete any records with null IDs
                        try (Statement stmt = conn.createStatement()) {
                            stmt.execute("DELETE FROM theaters WHERE id IS NULL");
                        }
                    }
                } else {
                    // Update existing theater
                    try (Connection conn = dbUtil.getConnection();
                         PreparedStatement stmt = conn.prepareStatement(
                             "UPDATE theaters SET name = ?, screen_id = ?, total_seats = ?, rows = ?, seats_per_row = ? WHERE id = ?")) {
                        stmt.setString(1, name);
                        stmt.setString(2, screenId);
                        stmt.setInt(3, seats);
                        stmt.setInt(4, rows);
                        stmt.setInt(5, seatsPerRow);
                        stmt.setString(6, theaterId);
                        stmt.executeUpdate();
                        JOptionPane.showMessageDialog(this, "Cập nhật phòng chiếu thành công");
                    }
                }
                dialog.dispose();
                loadTheaters(model, "");
            } catch (NumberFormatException ex) {
                JOptionPane.showMessageDialog(this, "Vui lòng nhập số hợp lệ cho số chỗ ngồi, số hàng ghế và số ghế mỗi hàng");
            } catch (SQLException ex) {
                JOptionPane.showMessageDialog(this, "Lỗi khi lưu phòng chiếu: " + ex.getMessage());
            }
        });

        cancelButton.addActionListener(e -> dialog.dispose());

        dialog.add(panel);
        dialog.setVisible(true);
    }

    private void showScheduleDialog(String scheduleId, DefaultTableModel model) {
        JDialog dialog = new JDialog(this, scheduleId == null ? "Thêm lịch chiếu mới" : "Chỉnh sửa lịch chiếu", true);
        dialog.setSize(600, 500);
        dialog.setLocationRelativeTo(this);
        dialog.setLayout(new BorderLayout(10, 10));

        JPanel mainPanel = new JPanel(new BorderLayout(10, 10));
        mainPanel.setBorder(BorderFactory.createEmptyBorder(20, 20, 20, 20));

        JPanel formPanel = new JPanel(new GridBagLayout());
        formPanel.setBackground(Color.WHITE);
        GridBagConstraints gbc = new GridBagConstraints();
        gbc.fill = GridBagConstraints.HORIZONTAL;
        gbc.insets = new Insets(5, 5, 5, 5);

        // Theater selection
        gbc.gridx = 0; gbc.gridy = 0;
        formPanel.add(new JLabel("Phòng chiếu:"), gbc);
        JComboBox<String> theaterComboBox = new JComboBox<>();
        gbc.gridx = 1;
        formPanel.add(theaterComboBox, gbc);

        // Movie selection
        gbc.gridx = 0; gbc.gridy = 1;
        formPanel.add(new JLabel("Phim:"), gbc);
        JComboBox<String> movieComboBox = new JComboBox<>();
        gbc.gridx = 1;
        formPanel.add(movieComboBox, gbc);

        // Show date
        gbc.gridx = 0; gbc.gridy = 2;
        formPanel.add(new JLabel("Ngày chiếu:"), gbc);
        JDateChooser dateChooser = new JDateChooser();
        dateChooser.setDateFormatString("dd/MM/yyyy");
        gbc.gridx = 1;
        formPanel.add(dateChooser, gbc);

        // Start time
        gbc.gridx = 0; gbc.gridy = 3;
        formPanel.add(new JLabel("Giờ bắt đầu:"), gbc);
        JTextField startTimeField = new JTextField();
        gbc.gridx = 1;
        formPanel.add(startTimeField, gbc);

        // End time
        gbc.gridx = 0; gbc.gridy = 4;
        formPanel.add(new JLabel("Giờ kết thúc:"), gbc);
        JTextField endTimeField = new JTextField();
        gbc.gridx = 1;
        formPanel.add(endTimeField, gbc);

        // Ticket price
        gbc.gridx = 0; gbc.gridy = 5;
        formPanel.add(new JLabel("Giá vé:"), gbc);
        JTextField priceField = new JTextField();
        gbc.gridx = 1;
        formPanel.add(priceField, gbc);

        mainPanel.add(formPanel, BorderLayout.CENTER);

        // Load data
        try {
            loadTheatersToComboBox(theaterComboBox);
            loadMoviesToComboBox(movieComboBox);

        if (scheduleId != null) {
                try (Connection conn = DatabaseUtil.getConnection();
                     PreparedStatement pstmt = conn.prepareStatement(
                        "SELECT * FROM schedules WHERE id = ?")) {
                    pstmt.setString(1, scheduleId);
                    ResultSet rs = pstmt.executeQuery();
                    if (rs.next()) {
                        theaterComboBox.setSelectedItem(rs.getString("theater_id"));
                        movieComboBox.setSelectedItem(rs.getString("movie_id"));
                        setDateToPicker(dateChooser, rs.getString("show_date"));
                        startTimeField.setText(rs.getString("start_time"));
                        endTimeField.setText(rs.getString("end_time"));
                        priceField.setText(String.valueOf(rs.getDouble("original_price")));
                    }
                    }
                }
            } catch (SQLException e) {
            e.printStackTrace();
            JOptionPane.showMessageDialog(dialog, "Lỗi khi tải dữ liệu: " + e.getMessage());
        }

        // Buttons
        JPanel buttonPanel = new JPanel(new FlowLayout(FlowLayout.RIGHT));
        JButton saveButton = new JButton("Lưu");
        JButton cancelButton = new JButton("Hủy");

        // Style buttons
        saveButton.setBackground(new Color(0, 123, 255));
        saveButton.setForeground(Color.WHITE);
        saveButton.setFont(new Font("Arial", Font.BOLD, 14));
        saveButton.setFocusPainted(false);
        saveButton.setBorderPainted(true);
        saveButton.setBorder(BorderFactory.createLineBorder(new Color(0, 123, 255), 2, true));
        saveButton.setOpaque(true);
        saveButton.setContentAreaFilled(true);
        saveButton.setPreferredSize(new Dimension(120, 40));

        cancelButton.setBackground(new Color(220, 53, 69));
        cancelButton.setForeground(Color.WHITE);
        cancelButton.setFont(new Font("Arial", Font.BOLD, 14));
        cancelButton.setFocusPainted(false);
        cancelButton.setBorderPainted(true);
        cancelButton.setBorder(BorderFactory.createLineBorder(new Color(220, 53, 69), 2, true));
        cancelButton.setOpaque(true);
        cancelButton.setContentAreaFilled(true);
        cancelButton.setPreferredSize(new Dimension(120, 40));

        buttonPanel.add(cancelButton);
        buttonPanel.add(saveButton);
        mainPanel.add(buttonPanel, BorderLayout.SOUTH);

        // Add action listeners
        saveButton.addActionListener(e -> {
            try {
                // Validate inputs
                if (theaterComboBox.getSelectedItem() == null) {
                    JOptionPane.showMessageDialog(dialog, "Vui lòng chọn phòng chiếu!");
                    return;
                }
                if (movieComboBox.getSelectedItem() == null) {
                    JOptionPane.showMessageDialog(dialog, "Vui lòng chọn phim!");
                    return;
                }
                if (dateChooser.getDate() == null) {
                    JOptionPane.showMessageDialog(dialog, "Vui lòng chọn ngày chiếu!");
                    return;
                }
                if (!isValidTimeFormat(startTimeField.getText())) {
                    JOptionPane.showMessageDialog(dialog, "Giờ bắt đầu không hợp lệ! Định dạng: HH:mm");
                    return;
                }
                if (!isValidTimeFormat(endTimeField.getText())) {
                    JOptionPane.showMessageDialog(dialog, "Giờ kết thúc không hợp lệ! Định dạng: HH:mm");
                    return;
                }
                if (!isValidTimeRange(startTimeField.getText(), endTimeField.getText())) {
                    JOptionPane.showMessageDialog(dialog, "Giờ kết thúc phải sau giờ bắt đầu!");
                    return;
                }
                if (!isValidPrice(priceField.getText())) {
                    JOptionPane.showMessageDialog(dialog, "Giá vé không hợp lệ! Vui lòng nhập số nguyên dương.");
                    return;
                }

                // Check for schedule conflicts
                String selectedTheaterId = theaterComboBox.getSelectedItem().toString().split(" - ")[0];
                String showDate = new SimpleDateFormat("yyyy-MM-dd").format(dateChooser.getDate());
                String startTime = startTimeField.getText();
                String endTime = endTimeField.getText();

                try (Connection conn = DatabaseUtil.getConnection();
                     PreparedStatement pstmt = conn.prepareStatement(
                        "SELECT COUNT(*) FROM schedules " +
                        "WHERE theater_id = ? AND show_date = ? " +
                        "AND ((start_time <= ? AND end_time > ?) " +
                        "OR (start_time < ? AND end_time >= ?) " +
                        "OR (start_time >= ? AND end_time <= ?)) " +
                        (scheduleId != null ? "AND id != ?" : ""))) {
                    pstmt.setString(1, selectedTheaterId);
                    pstmt.setString(2, showDate);
                    pstmt.setString(3, endTime);
                    pstmt.setString(4, startTime);
                    pstmt.setString(5, endTime);
                    pstmt.setString(6, startTime);
                    pstmt.setString(7, startTime);
                    pstmt.setString(8, endTime);
                    if (scheduleId != null) {
                        pstmt.setString(9, scheduleId);
                    }
                    ResultSet rs = pstmt.executeQuery();
                    if (rs.next() && rs.getInt(1) > 0) {
                        JOptionPane.showMessageDialog(dialog, "Lịch chiếu này trùng với lịch chiếu khác trong cùng phòng!");
                        return;
                    }
                }

                // Save schedule
                if (scheduleId == null) {
                    // Generate new schedule ID in format SCH00x
                    String newScheduleId;
                    try (Connection conn = DatabaseUtil.getConnection();
                         PreparedStatement pstmt = conn.prepareStatement(
                            "SELECT MAX(CAST(SUBSTR(id, 4) AS INTEGER)) AS max_num FROM schedules WHERE id LIKE 'SCH%'")) {
                        ResultSet rs = pstmt.executeQuery();
                        int maxNum = 0;
                        if (rs.next()) {
                            maxNum = rs.getInt("max_num");
                        }
                        newScheduleId = String.format("SCH%03d", maxNum + 1);
                    }
                    
                    // Get movie ID and theater ID
                    String movieId = movieComboBox.getSelectedItem().toString().split(" - ")[0];
                    
                    // Insert new schedule
                    try (Connection conn = DatabaseUtil.getConnection();
                         PreparedStatement pstmt = conn.prepareStatement(
                            "INSERT INTO schedules (id, movie_id, theater_id, show_date, start_time, end_time, original_price) " +
                            "VALUES (?, ?, ?, ?, ?, ?, ?)")) {
                        pstmt.setString(1, newScheduleId);
                        pstmt.setString(2, movieId);
                        pstmt.setString(3, selectedTheaterId);
                        pstmt.setString(4, showDate);
                        pstmt.setString(5, startTime);
                        pstmt.setString(6, endTime);
                        pstmt.setDouble(7, Double.parseDouble(priceField.getText()));
                        pstmt.executeUpdate();
                        JOptionPane.showMessageDialog(dialog, "Thêm lịch chiếu thành công!");
                    }
                } else {
                    // Get movie ID and theater ID
                    String movieId = movieComboBox.getSelectedItem().toString().split(" - ")[0];
                    
                    // Update existing schedule
                    try (Connection conn = DatabaseUtil.getConnection();
                         PreparedStatement pstmt = conn.prepareStatement(
                            "UPDATE schedules SET movie_id = ?, theater_id = ?, show_date = ?, " +
                            "start_time = ?, end_time = ?, original_price = ? WHERE id = ?")) {
                        pstmt.setString(1, movieId);
                        pstmt.setString(2, selectedTheaterId);
                        pstmt.setString(3, showDate);
                        pstmt.setString(4, startTime);
                        pstmt.setString(5, endTime);
                        pstmt.setDouble(6, Double.parseDouble(priceField.getText()));
                        pstmt.setString(7, scheduleId);
                        pstmt.executeUpdate();
                        JOptionPane.showMessageDialog(dialog, "Cập nhật lịch chiếu thành công!");
                    }
                }

                dialog.dispose();
                model.setRowCount(0); // Clear the table
                loadSchedules(model); // Reload the data
            } catch (SQLException ex) {
                ex.printStackTrace();
                JOptionPane.showMessageDialog(dialog, "Lỗi khi lưu lịch chiếu: " + ex.getMessage());
            }
        });

        cancelButton.addActionListener(e -> dialog.dispose());

        dialog.add(mainPanel);
        dialog.setVisible(true);
    }

    private boolean isValidTimeFormat(String time) {
        if (time == null || time.length() != 5) return false;
        try {
            int hours = Integer.parseInt(time.substring(0, 2));
            int minutes = Integer.parseInt(time.substring(3, 5));
            return hours >= 0 && hours <= 23 && minutes >= 0 && minutes <= 59;
        } catch (NumberFormatException e) {
            return false;
        }
    }

    private boolean isValidTimeRange(String startTime, String endTime) {
        return startTime.compareTo(endTime) < 0;
    }

    private boolean isValidPrice(String price) {
        try {
            double value = Double.parseDouble(price);
            return value > 0 && value == Math.floor(value);
        } catch (NumberFormatException e) {
            return false;
        }
    }

    private void deleteTheater(String theaterId, DefaultTableModel model) {
        int confirm = JOptionPane.showConfirmDialog(this,
            "Bạn có chắc chắn muốn xóa phòng chiếu này?",
            "Xác nhận xóa",
            JOptionPane.YES_NO_OPTION);
        
        if (confirm == JOptionPane.YES_OPTION) {
            try (Connection conn = dbUtil.getConnection();
                 PreparedStatement stmt = conn.prepareStatement("DELETE FROM theaters WHERE id = ?")) {
                stmt.setString(1, theaterId);
                stmt.executeUpdate();
                loadTheaters(model, "");
                JOptionPane.showMessageDialog(this, "Xóa phòng chiếu thành công");
            } catch (SQLException e) {
                JOptionPane.showMessageDialog(this, "Lỗi khi xóa phòng chiếu: " + e.getMessage());
            }
        }
    }

    private void deleteSchedule(String scheduleId, DefaultTableModel model) {
        int confirm = JOptionPane.showConfirmDialog(this,
            "Bạn có chắc chắn muốn xóa lịch chiếu này?",
            "Xác nhận xóa",
            JOptionPane.YES_NO_OPTION);
        
        if (confirm == JOptionPane.YES_OPTION) {
            try (Connection conn = dbUtil.getConnection();
                 PreparedStatement stmt = conn.prepareStatement("DELETE FROM schedules WHERE id = ?")) {
                stmt.setString(1, scheduleId);
                stmt.executeUpdate();
                JOptionPane.showMessageDialog(this, "Xóa lịch chiếu thành công");
                // Reload the table data
                model.setRowCount(0);
                loadSchedules(model);
            } catch (SQLException e) {
                JOptionPane.showMessageDialog(this, "Lỗi khi xóa lịch chiếu: " + e.getMessage());
            }
        }
    }

    private String formatDate(String sqlDate) {
        if (sqlDate == null || sqlDate.isEmpty()) {
            return "";
        }
        try {
            java.sql.Date date = java.sql.Date.valueOf(sqlDate);
            SimpleDateFormat sdf = new SimpleDateFormat("dd/MM/yyyy");
            return sdf.format(date);
        } catch (Exception e) {
            return sqlDate;
        }
    }

    private String formatTime(String sqlTime) {
        if (sqlTime == null || sqlTime.isEmpty()) {
            return "";
        }
        try {
            java.sql.Timestamp timestamp = java.sql.Timestamp.valueOf(sqlTime);
            SimpleDateFormat sdf = new SimpleDateFormat("dd/MM/yyyy HH:mm");
            return sdf.format(timestamp);
        } catch (Exception e) {
            return sqlTime;
        }
    }

    private java.sql.Date parseSqlDate(String ddMMyyyy) {
        try {
            java.util.Date utilDate = new java.text.SimpleDateFormat("dd/MM/yyyy").parse(ddMMyyyy);
            return new java.sql.Date(utilDate.getTime());
        } catch (Exception e) {
            return null;
        }
    }

    // Thêm hàm loadTheatersToComboBox cho JComboBox<String>
    private void loadTheatersToComboBox(JComboBox<String> comboBox) {
        comboBox.removeAllItems();
        try (Connection conn = dbUtil.getConnection();
             Statement stmt = conn.createStatement();
             ResultSet rs = stmt.executeQuery("SELECT id, name FROM theaters")) {
            while (rs.next()) {
                comboBox.addItem(rs.getString("id") + " - " + rs.getString("name"));
            }
        } catch (SQLException e) {
            JOptionPane.showMessageDialog(this, "Lỗi khi tải danh sách phòng chiếu: " + e.getMessage());
        }
    }

    private JPanel createTicketsPanel() {
        JPanel panel = new JPanel(new BorderLayout(10, 10));
        panel.setBorder(BorderFactory.createEmptyBorder(20, 20, 20, 20));

        // Movies panel with grid layout
        JPanel moviesPanel = new JPanel(new GridLayout(0, 4, 10, 10));
        moviesPanel.setBackground(Color.WHITE);
        JScrollPane scrollPane = new JScrollPane(moviesPanel);
        scrollPane.setBorder(BorderFactory.createEmptyBorder());
        panel.add(scrollPane, BorderLayout.CENTER);

        // Load movies as cards
        try (Connection conn = dbUtil.getConnection();
             PreparedStatement pstmt = conn.prepareStatement(
                 "SELECT m.*, GROUP_CONCAT(DISTINCT g.name) as genres, " +
                 "(SELECT s.show_date || ' ' || s.start_time FROM schedules s " +
                 "WHERE s.movie_id = m.id AND s.show_date >= date('now') " +
                 "ORDER BY s.show_date, s.start_time LIMIT 1) as next_showtime " +
                 "FROM movies m " +
                 "LEFT JOIN movie_genres mg ON m.id = mg.movie_id " +
                 "LEFT JOIN genres g ON mg.genre_id = g.id " +
                 "GROUP BY m.id " +
                 "ORDER BY m.title")) {
            ResultSet rs = pstmt.executeQuery();
            while (rs.next()) {
                String title = rs.getString("title");
                String genres = rs.getString("genres");
                int duration = rs.getInt("duration");
                String imagePath = rs.getString("image_path");
                int movieId = rs.getInt("id");
                String showTime = rs.getString("next_showtime");
                moviesPanel.add(createMovieCard(title, genres, duration, showTime, imagePath, movieId));
            }
        } catch (SQLException e) {
            JOptionPane.showMessageDialog(this, "Lỗi khi tải danh sách phim: " + e.getMessage());
        }

        return panel;
    }

    // Added createMovieCard method from StaffControlPanel
    private JPanel createMovieCard(String title, String genres, int duration, String showTime, String imagePath, int movieId) {
        JPanel cardPanel = new JPanel();
        cardPanel.setLayout(new BoxLayout(cardPanel, BoxLayout.Y_AXIS));
        cardPanel.setPreferredSize(new Dimension(220, 480));
        cardPanel.setMaximumSize(new Dimension(220, 480));
        cardPanel.setBorder(BorderFactory.createCompoundBorder(
            BorderFactory.createLineBorder(new Color(200, 200, 200), 1),
            BorderFactory.createEmptyBorder(10, 10, 10, 10)));
        cardPanel.setBackground(Color.WHITE);

        JLabel posterLabel;
        if (imagePath != null && !imagePath.isEmpty()) {
            try {
                String fullPath = imagePath.startsWith("/") ? imagePath : "src/main/resources/" + imagePath;
                File imageFile = new File(fullPath);
                if (imageFile.exists()) {
                    ImageIcon icon = new ImageIcon(fullPath);
                    Image img = icon.getImage().getScaledInstance(180, 240, Image.SCALE_SMOOTH);
                    posterLabel = new JLabel(new ImageIcon(img));
                } else {
                    posterLabel = new JLabel("Không có ảnh");
                    posterLabel.setPreferredSize(new Dimension(180, 240));
                    posterLabel.setOpaque(true);
                    posterLabel.setBackground(new Color(230, 230, 230));
                    posterLabel.setHorizontalAlignment(SwingConstants.CENTER);
                    posterLabel.setFont(new Font("Arial", Font.PLAIN, 14));
                }
            } catch (Exception e) {
                posterLabel = new JLabel("Lỗi tải ảnh");
                posterLabel.setPreferredSize(new Dimension(180, 240));
                posterLabel.setOpaque(true);
                posterLabel.setBackground(new Color(230, 230, 230));
                posterLabel.setHorizontalAlignment(SwingConstants.CENTER);
                posterLabel.setFont(new Font("Arial", Font.PLAIN, 14));
            }
        } else {
            posterLabel = new JLabel("Không có ảnh");
            posterLabel.setPreferredSize(new Dimension(180, 240));
            posterLabel.setOpaque(true);
            posterLabel.setBackground(new Color(230, 230, 230));
            posterLabel.setHorizontalAlignment(SwingConstants.CENTER);
            posterLabel.setFont(new Font("Arial", Font.PLAIN, 14));
        }
        posterLabel.setBorder(BorderFactory.createLineBorder(new Color(200, 200, 200), 1));
        posterLabel.setAlignmentX(Component.CENTER_ALIGNMENT);
        cardPanel.add(posterLabel);
        cardPanel.add(Box.createRigidArea(new Dimension(0, 10)));

        JLabel titleLabel = new JLabel("<html><div style='text-align: center;'><b>" + title + "</b></div></html>");
        titleLabel.setFont(new Font("Arial", Font.BOLD, 16));
        titleLabel.setAlignmentX(Component.CENTER_ALIGNMENT);
        cardPanel.add(titleLabel);
        cardPanel.add(Box.createRigidArea(new Dimension(0, 5)));

        JLabel genreLabel = new JLabel("<html><div style='text-align: center;'>Thể loại: " + (genres != null ? genres : "") + "</div></html>");
        genreLabel.setFont(new Font("Arial", Font.PLAIN, 13));
        genreLabel.setAlignmentX(Component.CENTER_ALIGNMENT);
        cardPanel.add(genreLabel);
        cardPanel.add(Box.createRigidArea(new Dimension(0, 5)));

        JLabel durationLabel = new JLabel("<html><div style='text-align: center;'>Thời lượng: " + duration + " phút</div></html>");
        durationLabel.setFont(new Font("Arial", Font.PLAIN, 13));
        durationLabel.setAlignmentX(Component.CENTER_ALIGNMENT);
        cardPanel.add(durationLabel);
        cardPanel.add(Box.createRigidArea(new Dimension(0, 5)));

        String showTimeDisplay = showTime;
        if (showTime != null && showTime.matches("\\d{4}-\\d{2}-\\d{2} \\d{2}:\\d{2}")) {
            try {
                java.util.Date d = new java.text.SimpleDateFormat("yyyy-MM-dd HH:mm").parse(showTime);
                showTimeDisplay = new java.text.SimpleDateFormat("dd/MM/yyyy HH:mm").format(d);
            } catch (Exception e) {
                showTimeDisplay = showTime;
            }
        }
        JLabel showTimeLabel = new JLabel("<html><div style='text-align: center;'>Suất chiếu: " + (showTimeDisplay != null ? showTimeDisplay : "--:--") + "</div></html>");
        showTimeLabel.setFont(new Font("Arial", Font.PLAIN, 13));
        showTimeLabel.setAlignmentX(Component.CENTER_ALIGNMENT);
        cardPanel.add(showTimeLabel);
        cardPanel.add(Box.createRigidArea(new Dimension(0, 10)));

        JButton buyTicketButton = new JButton("Mua vé");
        buyTicketButton.setAlignmentX(Component.CENTER_ALIGNMENT);
        buyTicketButton.setPreferredSize(new Dimension(180, 44));
        buyTicketButton.setMaximumSize(new Dimension(180, 44));
        buyTicketButton.setBackground(new Color(33, 150, 243));
        buyTicketButton.setForeground(Color.WHITE);
        buyTicketButton.setFont(new Font("Arial", Font.BOLD, 20));
        buyTicketButton.setFocusPainted(false);
        buyTicketButton.setBorderPainted(false);
        buyTicketButton.setCursor(new Cursor(Cursor.HAND_CURSOR));
        buyTicketButton.setBorder(BorderFactory.createLineBorder(new Color(33, 150, 243), 2, true));
        buyTicketButton.setOpaque(true);
        buyTicketButton.setContentAreaFilled(true);
        buyTicketButton.addActionListener(e -> showSeatSelectionDialog(title, movieId));
        cardPanel.add(buyTicketButton);
        cardPanel.add(Box.createVerticalGlue());

        return cardPanel;
    }

    // Added showSeatSelectionDialog method stub to satisfy the reference in createMovieCard
    private void showSeatSelectionDialog(String movieTitle, int movieId) {
        // TODO: Implement seat selection dialog logic
        JOptionPane.showMessageDialog(this, "Chức năng chọn ghế chưa được triển khai.");
    }

    private void styleSearchButton(JButton button) {
        button.setBackground(new Color(33, 150, 243));
        button.setForeground(Color.WHITE);
        button.setFont(new Font("Arial", Font.BOLD, 14));
        button.setOpaque(true);
        button.setContentAreaFilled(true);
        button.setBorderPainted(false);
        button.setPreferredSize(new Dimension(100, 36));
    }

    // Thêm hàm insertMovie
    private void insertMovie(Movie movie) {
        try (Connection conn = dbUtil.getConnection()) {
            conn.setAutoCommit(false);
            int movieId = -1;
            
            // Insert movie
            String sql = "INSERT INTO movies (title, content, duration, start_date, end_date, director, description, image_path) " +
                        "VALUES (?, ?, ?, ?, ?, ?, ?, ?)";
            
            try (PreparedStatement pstmt = conn.prepareStatement(sql, Statement.RETURN_GENERATED_KEYS)) {
                pstmt.setString(1, movie.getTitle());
                pstmt.setString(2, movie.getContent());
                pstmt.setInt(3, movie.getDuration());
                pstmt.setString(4, movie.getStartDate());
                pstmt.setString(5, movie.getEndDate());
                pstmt.setString(6, movie.getDirector());
                pstmt.setString(7, movie.getDescription());
                pstmt.setString(8, movie.getImagePath());
                
                int affectedRows = pstmt.executeUpdate();
                if (affectedRows == 0) {
                    throw new SQLException("Không thể thêm phim, không có dòng nào bị ảnh hưởng.");
                }

                try (ResultSet generatedKeys = pstmt.getGeneratedKeys()) {
                    if (generatedKeys.next()) {
                        movieId = generatedKeys.getInt(1);
                    } else {
                        throw new SQLException("Không lấy được ID phim mới.");
                    }
                }
            }

            // Insert genres
            if (movie.getGenres() != null && !movie.getGenres().isEmpty()) {
                String[] genres = movie.getGenres().split(",");
                for (String genreName : genres) {
                    genreName = genreName.trim();
                    if (!genreName.isEmpty()) {
                        int genreId = -1;
                        
                        // Check if genre exists
                        try (PreparedStatement genreStmt = conn.prepareStatement("SELECT id FROM genres WHERE name = ?")) {
                            genreStmt.setString(1, genreName);
                            try (ResultSet rs = genreStmt.executeQuery()) {
                                if (rs.next()) {
                                    genreId = rs.getInt("id");
                                } else {
                                    // Insert new genre
                                    try (PreparedStatement insertGenreStmt = conn.prepareStatement(
                                        "INSERT INTO genres (name) VALUES (?)", Statement.RETURN_GENERATED_KEYS)) {
                                        insertGenreStmt.setString(1, genreName);
                                        insertGenreStmt.executeUpdate();
                                        try (ResultSet genreKeys = insertGenreStmt.getGeneratedKeys()) {
                                            if (genreKeys.next()) {
                                                genreId = genreKeys.getInt(1);
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        // Insert movie-genre relationship
                        if (genreId != -1) {
                            try (PreparedStatement movieGenreStmt = conn.prepareStatement(
                                "INSERT INTO movie_genres (movie_id, genre_id) VALUES (?, ?)")) {
                                movieGenreStmt.setInt(1, movieId);
                                movieGenreStmt.setInt(2, genreId);
                                movieGenreStmt.executeUpdate();
                            }
                        }
                    }
                }
            }

            conn.commit();
            JOptionPane.showMessageDialog(this, "Thêm phim thành công!");
            loadMovies(""); // Refresh the movie list
        } catch (SQLException e) {
            e.printStackTrace();
            JOptionPane.showMessageDialog(this, "Lỗi khi thêm phim: " + e.getMessage());
        }
    }

    private void loadSchedules(DefaultTableModel model) {
        model.setRowCount(0);
        try (Connection conn = DatabaseUtil.getConnection();
             PreparedStatement pstmt = conn.prepareStatement(
                "SELECT s.*, m.title as movie_title, t.name as theater_name " +
                "FROM schedules s " +
                "JOIN movies m ON s.movie_id = m.id " +
                "JOIN theaters t ON s.theater_id = t.id " +
                "ORDER BY s.show_date, s.start_time")) {
            ResultSet rs = pstmt.executeQuery();
            while (rs.next()) {
                Vector<Object> row = new Vector<>();
                row.add(rs.getString("id"));
                row.add(rs.getString("theater_name"));
                row.add(rs.getString("movie_title"));
                
                // Format date
                String showDate = rs.getString("show_date");
                try {
                    java.util.Date d = new java.text.SimpleDateFormat("yyyy-MM-dd").parse(showDate);
                    showDate = new java.text.SimpleDateFormat("dd/MM/yyyy").format(d);
                } catch (Exception e) {
                    e.printStackTrace();
                }
                row.add(showDate);
                
                // Format time
                String startTime = rs.getString("start_time");
                String endTime = rs.getString("end_time");
                if (startTime != null && startTime.length() >= 5) {
                    startTime = startTime.substring(0, 5);
                }
                if (endTime != null && endTime.length() >= 5) {
                    endTime = endTime.substring(0, 5);
                }
                row.add(startTime);
                row.add(endTime);
                row.add(String.format("%,.0f VNĐ", rs.getDouble("original_price")));
                
                // Check if tickets exist for this schedule
                boolean hasTickets = false;
                try (PreparedStatement ticketStmt = conn.prepareStatement(
                    "SELECT COUNT(*) FROM tickets WHERE schedule_id = ?")) {
                    ticketStmt.setString(1, rs.getString("id"));
                    ResultSet ticketRs = ticketStmt.executeQuery();
                    if (ticketRs.next()) {
                        hasTickets = ticketRs.getInt(1) > 0;
                    }
                }
                row.add(hasTickets ? "Đã bán vé" : "Chưa bán vé");
                model.addRow(row);
            }
        } catch (SQLException e) {
            e.printStackTrace();
            JOptionPane.showMessageDialog(this, "Lỗi khi tải lịch chiếu: " + e.getMessage());
        }
    }

}

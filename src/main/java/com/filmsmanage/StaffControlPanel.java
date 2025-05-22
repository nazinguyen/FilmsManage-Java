package com.filmsmanage;

import javax.swing.*;
import javax.swing.table.DefaultTableModel;
import java.awt.*;
import java.sql.*;
import java.util.Vector;
import java.util.List;
import java.util.ArrayList;
import java.util.Set;
import java.util.HashSet;
import java.util.Map;
import java.util.HashMap;
import java.io.File;
import java.time.format.DateTimeFormatter;
import javax.swing.event.DocumentEvent;
import javax.swing.event.DocumentListener;
import java.util.Collections;

public class StaffControlPanel extends JFrame {
    private JPanel mainContentPanel;
    private CardLayout cardLayout;

    // Constants for UI
    private static final Color SELECTED_SEAT_COLOR = new Color(255, 215, 0); // Yellow
    private static final Color SOLD_SEAT_COLOR = new Color(220, 53, 69);     // Red
    private static final Color BLUE_SEAT_COLOR = new Color(0, 123, 255);     // Blue
    private static final Color WHITE_SEAT_COLOR = Color.WHITE;               // White
    private static final int SEAT_ROWS = 12;
    private static final int SEAT_COLS = 10;
    private static final double VIP_SEAT_PRICE = 150000;
    private static final double STANDARD_SEAT_PRICE = 100000;

    /**
     * Khởi tạo cửa sổ chính cho giao diện nhân viên quản lý rạp chiếu phim.
     *
     * Ví dụ sử dụng:
     * <pre>
     *     StaffControlPanel panel = new StaffControlPanel();
     *     panel.setVisible(true);
     * </pre>
     *
     * Lưu ý thường gặp:
     * - Đảm bảo gọi setVisible(true) để hiển thị cửa sổ.
     */
    public StaffControlPanel() {
        initializeUI();
    }

    private void initializeUI() {
        setTitle("Hệ Thống Quản Lý Rạp Chiếu Phim - Nhân Viên");
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setSize(1200, 800);
        setLocationRelativeTo(null);
        setLayout(new BorderLayout());

        // Create and add sidebar
        JPanel sidebar = createSidebar();
        add(sidebar, BorderLayout.WEST);

        // Create main content area
        cardLayout = new CardLayout();
        mainContentPanel = new JPanel(cardLayout);
        mainContentPanel.add(createTicketsPanel(), "TICKETS"); // Add bán vé panel
        mainContentPanel.add(createSchedulesPanel(), "SCHEDULES");
        mainContentPanel.add(createFoodPanel(), "FOOD");
        mainContentPanel.add(createCustomersPanel(), "CUSTOMERS");
        add(mainContentPanel, BorderLayout.CENTER);

        // Show tickets panel by default
        cardLayout.show(mainContentPanel, "TICKETS");
    }

    private JPanel createSidebar() {
        JPanel sidebar = new JPanel();
        sidebar.setLayout(new BoxLayout(sidebar, BoxLayout.Y_AXIS));
        sidebar.setBackground(new Color(15, 18, 54));
        sidebar.setPreferredSize(new Dimension(180, getHeight()));
        sidebar.setBorder(BorderFactory.createEmptyBorder(20, 10, 20, 10));

        // Add sidebar buttons
        addMenuButton(sidebar, "Bán vé", "TICKETS"); // Add bán vé button
        addMenuButton(sidebar, "Đồ ăn", "FOOD");
        addMenuButton(sidebar, "Khách hàng", "CUSTOMERS");

        sidebar.add(Box.createVerticalGlue());
        JButton logoutButton = new JButton("Đăng xuất");
        styleSidebarButton(logoutButton);
        logoutButton.setForeground(Color.WHITE);
        logoutButton.addActionListener(e -> handleLogout());
        sidebar.add(logoutButton);

        return sidebar;
    }

    private void styleSidebarButton(JButton button) {
        button.setAlignmentX(Component.CENTER_ALIGNMENT);
        button.setMaximumSize(new Dimension(Integer.MAX_VALUE, 45));
        button.setBackground(new Color(33, 150, 243)); // Blue
        button.setForeground(Color.WHITE);
        button.setFocusPainted(false);
        button.setBorderPainted(false);
        button.setFont(new Font("Arial", Font.BOLD, 16));
        button.setCursor(new Cursor(Cursor.HAND_CURSOR));
        button.setBorder(BorderFactory.createEmptyBorder(10, 20, 10, 20));
    }

    private void addMenuButton(JPanel sidebar, String text, String cardName) {
        JButton button = new JButton(text);
        styleSidebarButton(button);
        button.addActionListener(e -> cardLayout.show(mainContentPanel, cardName));
        sidebar.add(button);
        sidebar.add(Box.createRigidArea(new Dimension(0, 10)));
    }

    private void styleButton(JButton button) {
        button.setAlignmentX(Component.LEFT_ALIGNMENT);
        button.setMaximumSize(new Dimension(Integer.MAX_VALUE, button.getPreferredSize().height));
        button.setBackground(new Color(33, 37, 41));
        button.setForeground(Color.BLACK);
        button.setFocusPainted(false);
        button.setBorderPainted(false);
        button.setFont(new Font("Arial", Font.PLAIN, 14));
        
        button.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseEntered(java.awt.event.MouseEvent evt) {
                button.setBackground(new Color(52, 58, 64));
            }

            public void mouseExited(java.awt.event.MouseEvent evt) {
                button.setBackground(new Color(33, 37, 41));
            }
        });
    }

    // Ticket Sales Section
    private JPanel createTicketsPanel() {
        JPanel panel = new JPanel(new BorderLayout(10, 10));
        panel.setBorder(BorderFactory.createCompoundBorder(
            BorderFactory.createTitledBorder("Bán vé"),
            BorderFactory.createEmptyBorder(20, 20, 20, 20)));

        // Search panel
        JPanel searchPanel = createSearchPanel();
        searchPanel.setBorder(BorderFactory.createTitledBorder("Tìm kiếm"));
        panel.add(searchPanel, BorderLayout.NORTH);

        // Movies panel with improved styling
        JPanel moviesPanel = new JPanel();
        moviesPanel.setLayout(new BoxLayout(moviesPanel, BoxLayout.X_AXIS));
        moviesPanel.setBackground(Color.WHITE);
        moviesPanel.setBorder(BorderFactory.createEmptyBorder(10, 10, 10, 10));
        
        JScrollPane moviesScrollPane = new JScrollPane(moviesPanel,
            JScrollPane.VERTICAL_SCROLLBAR_NEVER,
            JScrollPane.HORIZONTAL_SCROLLBAR_AS_NEEDED);
        moviesScrollPane.setBorder(BorderFactory.createTitledBorder("Danh sách phim"));
        panel.add(moviesScrollPane, BorderLayout.CENTER);

        // Load initial data
        loadMoviesAsCards(moviesPanel, "", "");

        return panel;
    }

    private JPanel createSearchPanel() {
        JPanel searchPanel = new JPanel(new FlowLayout(FlowLayout.LEFT));
        searchPanel.setBackground(Color.WHITE);
        
        JTextField searchField = new JTextField(20);
        JComboBox<String> genreComboBox = new JComboBox<>(new String[]{"Tất cả thể loại"});
        JButton searchButton = new JButton("Tìm kiếm");

        // Style the search components
        searchField.setPreferredSize(new Dimension(200, 30));
        genreComboBox.setPreferredSize(new Dimension(150, 30));
        searchButton.setPreferredSize(new Dimension(130, 38));
        searchButton.setBackground(new Color(33, 150, 243));
        searchButton.setForeground(Color.WHITE);
        searchButton.setFont(new Font("Arial", Font.BOLD, 14));
        searchButton.setOpaque(true);
        searchButton.setContentAreaFilled(true);
        searchButton.setBorderPainted(false);

        // Style labels
        JLabel searchLabel = new JLabel("Tìm kiếm tên phim:");
        searchLabel.setForeground(Color.BLACK);
        JLabel genreLabel = new JLabel("Thể loại:");
        genreLabel.setForeground(Color.BLACK);

        searchPanel.add(searchLabel);
        searchPanel.add(searchField);
        searchPanel.add(genreLabel);
        searchPanel.add(genreComboBox);
        searchPanel.add(searchButton);

        // Load genres
        try {
            loadGenres(genreComboBox);
        } catch (SQLException e) {
            JOptionPane.showMessageDialog(this, 
                "Lỗi khi tải danh sách thể loại: " + e.getMessage());
        }

        // Add search functionality
        searchButton.addActionListener(e -> {
            String searchText = searchField.getText().trim();
            String selectedGenre = (String) genreComboBox.getSelectedItem();
            if (selectedGenre.equals("Tất cả thể loại")) {
                selectedGenre = "";
            }
            // Get the movies panel from the main content panel
            JPanel mainPanel = (JPanel) searchPanel.getParent();
            JScrollPane scrollPane = (JScrollPane) mainPanel.getComponent(1);
            JPanel moviesPanel = (JPanel) scrollPane.getViewport().getView();
            loadMoviesAsCards(moviesPanel, searchText, selectedGenre);
        });

        return searchPanel;
    }

    // Seat Selection Dialog
    private void showSeatSelectionDialog(String movieTitle, int movieId, String scheduleId) {
        int rows = 12, seatsPerRow = 10;
        double seatPrice = 100000.0; // Default price
        try (Connection conn = DatabaseUtil.getConnection();
             PreparedStatement pstmt = conn.prepareStatement(
                "SELECT t.rows, t.seats_per_row, s.original_price FROM schedules s JOIN theaters t ON s.theater_id = t.id WHERE s.id = ?")) {
            pstmt.setString(1, scheduleId);
                    ResultSet rs = pstmt.executeQuery();
            if (rs.next()) {
                rows = rs.getInt("rows");
                seatsPerRow = rs.getInt("seats_per_row");
                seatPrice = rs.getDouble("original_price");
                }
        } catch (SQLException e) { 
            JOptionPane.showMessageDialog(this, "Lỗi lấy cấu hình ghế: " + e.getMessage()); 
        }
        JDialog dialog = new JDialog(this, "Chọn ghế cho: " + movieTitle, true);
        dialog.setSize(1100, 700);
        dialog.setLocationRelativeTo(this);
        dialog.setLayout(new BorderLayout());
        SeatSelectionData seatData = new SeatSelectionData();
        seatData.scheduleId = scheduleId;
        seatData.seatPrice = seatPrice; // Store the actual price
        JPanel seatGrid = createSeatGrid(seatData, scheduleId, rows, seatsPerRow);

        // Create info panel
        JPanel infoPanel = createModernSeatInfoPanel(movieTitle, movieId, seatData);

        // Create button panel
        JPanel buttonPanel = createSeatButtonPanel(dialog, movieTitle, movieId, seatData, infoPanel);

        // Add components to dialog
        JPanel centerPanel = new JPanel();
        centerPanel.setLayout(new BoxLayout(centerPanel, BoxLayout.Y_AXIS));
        JPanel screenPanel = createScreenPanel();
        screenPanel.setMaximumSize(new Dimension(600, 80));
        screenPanel.setPreferredSize(new Dimension(600, 80));
        screenPanel.setAlignmentX(Component.CENTER_ALIGNMENT);
        centerPanel.add(Box.createVerticalStrut(10));
        centerPanel.add(screenPanel);
        centerPanel.add(Box.createRigidArea(new Dimension(0, 10)));
        // dialog.add(createScreenPanel(), BorderLayout.NORTH); // (đã xóa màn hình ở trên)
        dialog.add(seatGrid, BorderLayout.CENTER); // (lưới ghế ở giữa)
        dialog.add(infoPanel, BorderLayout.EAST); // (lưới bên phải)
        dialog.add(buttonPanel, BorderLayout.SOUTH); // (các nút ở dưới)

        dialog.setVisible(true);
    }

    private String getLatestScheduleId(int movieId) {
        try (Connection conn = DatabaseUtil.getConnection();
             PreparedStatement pstmt = conn.prepareStatement(
                "SELECT s.id FROM schedules s " +
                "JOIN movies m ON s.movie_id = m.id " +
                "WHERE s.movie_id = ? AND s.show_date >= date('now') " +
                "ORDER BY s.show_date, s.start_time LIMIT 1")) {
            pstmt.setInt(1, movieId);
            ResultSet rs = pstmt.executeQuery();
            if (rs.next()) {
                return rs.getString("id");
            }
        } catch (SQLException e) {
            JOptionPane.showMessageDialog(this, "Lỗi khi lấy lịch chiếu: " + e.getMessage());
        }
        return null;
    }

    private JPanel createScreenPanel() {
        JPanel screenPanel = new JPanel() {
            @Override
            protected void paintComponent(Graphics g) {
                super.paintComponent(g);
                Graphics2D g2d = (Graphics2D) g;
                g2d.setRenderingHint(RenderingHints.KEY_ANTIALIASING, RenderingHints.VALUE_ANTIALIAS_ON);
                int width = 600; // chỉ chiếm phần ghế
                int x = (getWidth() - width) / 2;
                g2d.setColor(new Color(200, 200, 200));
                g2d.fillRoundRect(x, 20, width, 40, 20, 20);
                g2d.setColor(Color.BLACK);
                g2d.drawRoundRect(x, 20, width, 40, 20, 20);
                g2d.setFont(new Font("Arial", Font.BOLD, 16));
                FontMetrics fm = g2d.getFontMetrics();
                String screenText = "Màn hình";
                int textWidth = fm.stringWidth(screenText);
                g2d.drawString(screenText, (getWidth() - textWidth) / 2, 45);
            }
        };
        screenPanel.setPreferredSize(new Dimension(600, 80));
        return screenPanel;
    }

    private JPanel createSeatGrid(SeatSelectionData seatData, String scheduleId, int rows, int seatsPerRow) {
        Set<String> soldSeats = loadSoldSeats(scheduleId);
        JPanel wrapper = new JPanel();
        wrapper.setLayout(new BoxLayout(wrapper, BoxLayout.Y_AXIS));
        wrapper.setBackground(Color.WHITE);
        JPanel screenPanel = createScreenPanel();
        screenPanel.setMaximumSize(new Dimension(600, 80));
        screenPanel.setPreferredSize(new Dimension(600, 80));
        screenPanel.setAlignmentX(Component.CENTER_ALIGNMENT);
        wrapper.add(Box.createVerticalStrut(10));
        wrapper.add(screenPanel);
        wrapper.add(Box.createRigidArea(new Dimension(0, 20)));
        JPanel colLabelPanel = new JPanel(new GridLayout(1, seatsPerRow + 1, 4, 0));
        colLabelPanel.setBackground(Color.WHITE);
        colLabelPanel.add(new JLabel(""));
        for (int col = 0; col < seatsPerRow; col++) {
            JLabel colLabel = new JLabel(String.format("%02d", col + 1), SwingConstants.CENTER);
            colLabel.setFont(new Font("Arial", Font.BOLD, 13));
            colLabel.setPreferredSize(new Dimension(48, 20));
            colLabelPanel.add(colLabel);
        }
        JPanel seatPanel = new JPanel(new GridLayout(rows, seatsPerRow + 1, 4, 4));
        seatPanel.setBackground(Color.WHITE);
        for (int row = 0; row < rows; row++) {
            char rowChar = (char) ('A' + row);
            JLabel rowLabel = new JLabel(String.valueOf(rowChar), SwingConstants.CENTER);
            rowLabel.setFont(new Font("Arial", Font.BOLD, 13));
            seatPanel.add(rowLabel);
            for (int col = 0; col < seatsPerRow; col++) {
                String seatId = rowChar + String.format("%02d", col + 1);
                JButton seatButton = createSeatButton(seatId, row, soldSeats, seatData);
                seatButton.setToolTipText("Ghế " + seatId);
                seatPanel.add(seatButton);
            }
        }
        colLabelPanel.setAlignmentX(Component.CENTER_ALIGNMENT);
        seatPanel.setAlignmentX(Component.CENTER_ALIGNMENT);
        wrapper.add(colLabelPanel);
        wrapper.add(Box.createRigidArea(new Dimension(0, 8)));
        wrapper.add(seatPanel);
        wrapper.add(Box.createRigidArea(new Dimension(0, 10)));
        JPanel legendPanel = createModernSeatLegend();
        legendPanel.setAlignmentX(Component.CENTER_ALIGNMENT);
        wrapper.add(legendPanel);
        return wrapper;
    }

    private JButton createSeatButton(String seatId, int row, Set<String> soldSeats, SeatSelectionData seatData) {
        JButton seatButton = new JButton(seatId);
        seatButton.setPreferredSize(new Dimension(48, 38));
        seatButton.setFont(new Font(Font.MONOSPACED, Font.BOLD, 15));
        seatButton.setOpaque(true);
        seatButton.setContentAreaFilled(true);
        seatButton.setBorder(BorderFactory.createLineBorder(Color.GRAY, 2, true));
        seatButton.setFocusPainted(false);
        seatButton.setForeground(Color.BLACK);
        seatButton.setMargin(new Insets(0, 0, 0, 0));

        // Set initial color based on seat type
        String rowLetter = seatId.substring(0, 1);
        if (rowLetter.compareTo("C") >= 0) {
            seatButton.setBackground(WHITE_SEAT_COLOR); // VIP seats
            seatButton.setToolTipText("Ghế VIP (+20%)");
        } else {
            seatButton.setBackground(BLUE_SEAT_COLOR); // Standard seats
            seatButton.setToolTipText("Ghế thường");
        }

        // If seat is sold, mark it as unavailable
        if (soldSeats.contains(seatId)) {
            seatButton.setBackground(SOLD_SEAT_COLOR);
            seatButton.setEnabled(false);
            seatButton.setToolTipText("Ghế đã được bán");
            }

            seatButton.addActionListener(e -> handleSeatSelection(seatButton, seatId, seatData));
        return seatButton;
    }

    private void handleSeatSelection(JButton seatButton, String seatId, SeatSelectionData seatData) {
        // Check if seat is sold
        if (seatButton.getBackground().equals(SOLD_SEAT_COLOR)) {
            JOptionPane.showMessageDialog(this, "Ghế này đã được bán!");
            return;
        }

        if (seatButton.getBackground().equals(SELECTED_SEAT_COLOR)) {
            // Deselect seat and restore original color
            String rowLetter = seatId.substring(0, 1);
            if (rowLetter.compareTo("C") >= 0) {
                seatButton.setBackground(WHITE_SEAT_COLOR); // VIP seats
            } else {
                seatButton.setBackground(BLUE_SEAT_COLOR); // Standard seats
            }
            seatData.selectedSeats.remove(seatId);
        } else {
            // Select seat
            seatButton.setBackground(SELECTED_SEAT_COLOR);
            seatData.selectedSeats.add(seatId);
        }
        
        // Calculate total price with VIP seats (20% increase for rows C and above)
        double totalPrice = 0;
        for (String seat : seatData.selectedSeats) {
            String row = seat.substring(0, 1);
            double seatPrice = seatData.seatPrice;
            // If row is C or above, add 20% to the price
            if (row.compareTo("C") >= 0) {
                seatPrice *= 1.2;
            }
            totalPrice += seatPrice;
        }
        seatData.totalPrice = totalPrice;
    }

    private JPanel createSeatLegend() {
        JPanel legendPanel = new JPanel(new FlowLayout(FlowLayout.CENTER, 20, 5));
        legendPanel.add(createLegendItem("Đang chọn", SELECTED_SEAT_COLOR));
        legendPanel.add(createLegendItem("Đã mua", SOLD_SEAT_COLOR));
        legendPanel.add(createLegendItem("Ghế A1-D10", BLUE_SEAT_COLOR));
        legendPanel.add(createLegendItem("Ghế còn lại", WHITE_SEAT_COLOR));
        return legendPanel;
    }

    private JPanel createLegendItem(String text, Color color) {
        JPanel panel = new JPanel(new FlowLayout(FlowLayout.LEFT, 5, 0));
        JLabel colorLabel = new JLabel();
        colorLabel.setPreferredSize(new Dimension(20, 20));
        colorLabel.setOpaque(true);
        colorLabel.setBackground(color);
        colorLabel.setBorder(BorderFactory.createLineBorder(Color.BLACK));
        panel.add(colorLabel);
        panel.add(new JLabel(text));
        return panel;
    }

    private JPanel createSeatButtonPanel(JDialog dialog, String movieTitle, int movieId, SeatSelectionData seatData, JPanel infoPanel) {
        JPanel buttonPanel = new JPanel(new FlowLayout(FlowLayout.RIGHT));
        buttonPanel.setBackground(Color.WHITE);
        JButton continueButton = new JButton("Tiếp tục");
        JButton backButton = new JButton("Quay lại");

        // Style buttons
        continueButton.setBackground(new Color(0, 123, 255));
        continueButton.setForeground(Color.WHITE);
        continueButton.setFont(new Font("Arial", Font.BOLD, 18));
        continueButton.setFocusPainted(false);
        continueButton.setBorderPainted(true);
        continueButton.setBorder(BorderFactory.createLineBorder(new Color(0, 123, 255), 3, true));
        continueButton.setOpaque(true);
        continueButton.setContentAreaFilled(true);
        continueButton.setCursor(new Cursor(Cursor.HAND_CURSOR));
        continueButton.setPreferredSize(new Dimension(160, 45));
        continueButton.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseEntered(java.awt.event.MouseEvent evt) {
                continueButton.setBackground(new Color(0, 86, 179));
            }
            public void mouseExited(java.awt.event.MouseEvent evt) {
                continueButton.setBackground(new Color(0, 123, 255));
            }
        });

        backButton.setBackground(new Color(220, 53, 69));
        backButton.setForeground(Color.WHITE);
        backButton.setFont(new Font("Arial", Font.BOLD, 18));
        backButton.setFocusPainted(false);
        backButton.setBorderPainted(true);
        backButton.setBorder(BorderFactory.createLineBorder(new Color(220, 53, 69), 3, true));
        backButton.setOpaque(true);
        backButton.setContentAreaFilled(true);
        backButton.setCursor(new Cursor(Cursor.HAND_CURSOR));
        backButton.setPreferredSize(new Dimension(160, 45));
        backButton.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseEntered(java.awt.event.MouseEvent evt) {
                backButton.setBackground(new Color(200, 35, 51));
            }
            public void mouseExited(java.awt.event.MouseEvent evt) {
                backButton.setBackground(new Color(220, 53, 69));
            }
        });

        continueButton.addActionListener(e -> {
            if (seatData.selectedSeats.isEmpty()) {
                JOptionPane.showMessageDialog(dialog, "Vui lòng chọn ít nhất một ghế",
                    "Thông báo", JOptionPane.WARNING_MESSAGE);
                return;
            }

            // Group seats by row
            Map<String, List<Integer>> seatsByRow = new HashMap<>();
            for (String seat : seatData.selectedSeats) {
                String row = seat.substring(0, 1);
                int seatNumber = Integer.parseInt(seat.substring(seat.length() - 2));
                seatsByRow.computeIfAbsent(row, k -> new ArrayList<>()).add(seatNumber);
            }

            // Check each row
            for (Map.Entry<String, List<Integer>> entry : seatsByRow.entrySet()) {
                List<Integer> seats = entry.getValue();
                Collections.sort(seats);

                // Check for single seat gaps between selected seats
                for (int i = 0; i < seats.size() - 1; i++) {
                    if (seats.get(i + 1) - seats.get(i) == 2) {
                        JOptionPane.showMessageDialog(dialog, 
                            "Không được để 1 ghế trống giữa các ghế đã chọn!",
                            "Thông báo", JOptionPane.WARNING_MESSAGE);
                        return;
                    }
                }

                // Check left edge (seat 1)
                if (seats.contains(2) && !seats.contains(1)) {
                    JOptionPane.showMessageDialog(dialog, 
                        "Không được bỏ trống 1 ghế ở bên trái!",
                        "Thông báo", JOptionPane.WARNING_MESSAGE);
                    return;
                }

                // Check right edge (seat 10)
                if (seats.contains(9) && !seats.contains(10)) {
                    JOptionPane.showMessageDialog(dialog, 
                        "Không được bỏ trống 1 ghế ở bên phải!",
                        "Thông báo", JOptionPane.WARNING_MESSAGE);
                    return;
                }
            }

            dialog.dispose();
            showFoodSelectionDialog(movieTitle, movieId, seatData.selectedSeats, seatData.totalPrice, seatData.scheduleId);
        });

        backButton.addActionListener(e -> {
            dialog.dispose();
            showScheduleSelectionDialog(movieTitle, movieId);
        });

        buttonPanel.add(backButton);
        buttonPanel.add(continueButton);
        return buttonPanel;
    }

    private Set<String> loadSoldSeats(String scheduleId) {
        Set<String> soldSeats = new HashSet<>();
        try (Connection conn = DatabaseUtil.getConnection();
             PreparedStatement pstmt = conn.prepareStatement(
                "SELECT seat_id FROM tickets WHERE schedule_id = ? AND status = 'sold'")) {
            pstmt.setString(1, scheduleId);
            ResultSet rs = pstmt.executeQuery();
            while (rs.next()) {
                soldSeats.add(rs.getString("seat_id"));
            }
        } catch (SQLException e) {
            JOptionPane.showMessageDialog(this, "Lỗi khi tải trạng thái ghế: " + e.getMessage());
        }
        return soldSeats;
    }

    // Helper class for seat selection data
    private static class SeatSelectionData {
        List<String> selectedSeats = new ArrayList<>();
        double totalPrice = 0.0;
        String scheduleId;
        double seatPrice = 100000.0; // Default price
    }

    // Food Selection Dialog
    private void showFoodSelectionDialog(String movieTitle, int movieId, 
                                       List<String> selectedSeats, 
                                       double seatPrice, 
                                       String scheduleId) {
        JDialog dialog = new JDialog(this, "Chọn đồ ăn", true);
        dialog.setSize(1000, 700);
        dialog.setLocationRelativeTo(this);
        dialog.setLayout(new BorderLayout());

        // Create food selection data
        FoodSelectionData foodData = new FoodSelectionData();

        // Chỉ còn 1 danh mục 'Tất cả'
        String category = "Tất cả";
        JPanel mainPanel = new JPanel(new CardLayout());
        JPanel categoryPanel = new JPanel(new FlowLayout(FlowLayout.LEFT, 10, 10));
        categoryPanel.setBackground(Color.WHITE);
        JLabel allLabel = new JLabel("Tất cả");
        allLabel.setFont(new Font("Arial", Font.BOLD, 16));
        allLabel.setForeground(Color.BLACK);
        categoryPanel.add(allLabel);

        // Panel chứa tất cả đồ ăn
        JPanel foodPanel = new JPanel(new GridLayout(0, 3, 10, 10));
        foodPanel.setBackground(Color.WHITE);
        foodPanel.setBorder(BorderFactory.createEmptyBorder(10, 10, 10, 10));
        loadFoodItemsModern(foodPanel, foodData, category);
        mainPanel.add(foodPanel, category);

        // Create cart panel
        JPanel cartPanel = createModernCartPanel(foodData);
        // Create button panel
        JPanel buttonPanel = new JPanel(new FlowLayout(FlowLayout.RIGHT));
        JButton continueButton = new JButton("Tiếp tục");
        JButton cancelButton = new JButton("Hủy");
        // Style buttons
        continueButton.setBackground(new Color(0, 123, 255));
        continueButton.setForeground(Color.WHITE);
        continueButton.setFont(new Font("Arial", Font.BOLD, 18));
        continueButton.setFocusPainted(false);
        continueButton.setBorderPainted(true);
        continueButton.setBorder(BorderFactory.createLineBorder(new Color(0, 123, 255), 3, true));
        continueButton.setOpaque(true);
        continueButton.setContentAreaFilled(true);
        continueButton.setCursor(new Cursor(Cursor.HAND_CURSOR));
        continueButton.setPreferredSize(new Dimension(160, 45));
        continueButton.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseEntered(java.awt.event.MouseEvent evt) {
                continueButton.setBackground(new Color(0, 86, 179));
            }
            public void mouseExited(java.awt.event.MouseEvent evt) {
                continueButton.setBackground(new Color(0, 123, 255));
            }
        });
        cancelButton.setBackground(new Color(220, 53, 69));
        cancelButton.setForeground(Color.WHITE);
        cancelButton.setFont(new Font("Arial", Font.BOLD, 18));
        cancelButton.setFocusPainted(false);
        cancelButton.setBorderPainted(true);
        cancelButton.setBorder(BorderFactory.createLineBorder(new Color(220, 53, 69), 3, true));
        cancelButton.setOpaque(true);
        cancelButton.setContentAreaFilled(true);
        cancelButton.setCursor(new Cursor(Cursor.HAND_CURSOR));
        cancelButton.setPreferredSize(new Dimension(160, 45));
        cancelButton.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseEntered(java.awt.event.MouseEvent evt) {
                cancelButton.setBackground(new Color(200, 35, 51));
            }
            public void mouseExited(java.awt.event.MouseEvent evt) {
                cancelButton.setBackground(new Color(220, 53, 69));
            }
        });
        continueButton.addActionListener(e -> {
            dialog.dispose();
            // Gọi đúng hàm showPaymentDialog tối ưu nhất
            showPaymentDialog(movieTitle, movieId, selectedSeats, seatPrice, foodData.selectedFoods, foodData.totalPrice, scheduleId);
        });
        cancelButton.addActionListener(e -> dialog.dispose());
        buttonPanel.add(cancelButton);
        buttonPanel.add(continueButton);

        // Add components to dialog
        dialog.add(categoryPanel, BorderLayout.NORTH);
        dialog.add(mainPanel, BorderLayout.CENTER);
        dialog.add(cartPanel, BorderLayout.EAST);
        dialog.add(buttonPanel, BorderLayout.SOUTH);
        dialog.setVisible(true);
    }

    // Sửa lại loadFoodItemsModern: luôn show tất cả món ăn
    private void loadFoodItemsModern(JPanel foodPanel, FoodSelectionData foodData, String category) {
        foodPanel.removeAll();
        try (Connection conn = DatabaseUtil.getConnection();
             PreparedStatement pstmt = conn.prepareStatement("SELECT * FROM foods ORDER BY name")) {
            ResultSet rs = pstmt.executeQuery();
            while (rs.next()) {
                String name = rs.getString("name");
                String description = rs.getString("description");
                double price = rs.getDouble("price");
                String imagePath = rs.getString("image_path");
                JPanel foodCard = createModernFoodCard(name, description, price, imagePath, foodData);
                foodPanel.add(foodCard);
            }
        } catch (SQLException e) {
            JOptionPane.showMessageDialog(this, "Lỗi khi tải danh sách đồ ăn: " + e.getMessage());
        }
        foodPanel.revalidate();
        foodPanel.repaint();
    }

    // Card món ăn: hình, tên, giá, nút +
    private JPanel createModernFoodCard(String name, String description, double price, String imagePath, FoodSelectionData foodData) {
        JPanel card = new JPanel();
        card.setLayout(new BoxLayout(card, BoxLayout.Y_AXIS));
        card.setBackground(Color.WHITE);
        card.setBorder(BorderFactory.createCompoundBorder(
            BorderFactory.createLineBorder(new Color(200, 200, 200), 1),
            BorderFactory.createEmptyBorder(10, 10, 10, 10)));
        card.setPreferredSize(new Dimension(200, 260));
        card.setMaximumSize(new Dimension(200, 260));

        // Image panel
        JLabel imageLabel;
        if (imagePath != null && !imagePath.isEmpty()) {
            try {
                String fullPath = imagePath.startsWith("/") ? imagePath : "src/main/resources/" + imagePath;
                File imageFile = new File(fullPath);
                if (imageFile.exists()) {
                    ImageIcon icon = new ImageIcon(fullPath);
                    Image img = icon.getImage().getScaledInstance(120, 90, Image.SCALE_SMOOTH);
                    imageLabel = new JLabel(new ImageIcon(img));
                } else {
                    imageLabel = new JLabel();
                    imageLabel.setPreferredSize(new Dimension(120, 90));
                    imageLabel.setOpaque(true);
                    imageLabel.setBackground(new Color(230, 230, 230));
                }
            } catch (Exception e) {
                imageLabel = new JLabel();
                imageLabel.setPreferredSize(new Dimension(120, 90));
                imageLabel.setOpaque(true);
                imageLabel.setBackground(new Color(230, 230, 230));
            }
        } else {
            imageLabel = new JLabel();
            imageLabel.setPreferredSize(new Dimension(120, 90));
            imageLabel.setOpaque(true);
            imageLabel.setBackground(new Color(230, 230, 230));
        }
        imageLabel.setAlignmentX(Component.CENTER_ALIGNMENT);
        card.add(imageLabel);
        card.add(Box.createRigidArea(new Dimension(0, 5)));

        // Name label
        JLabel nameLabel = new JLabel(name);
        nameLabel.setFont(new Font("Arial", Font.BOLD, 15));
        nameLabel.setAlignmentX(Component.CENTER_ALIGNMENT);
        card.add(nameLabel);
        card.add(Box.createRigidArea(new Dimension(0, 2)));

        // Price label
        JLabel priceLabel = new JLabel(String.format("%,.0f VNĐ", price));
        priceLabel.setFont(new Font("Arial", Font.BOLD, 14));
        priceLabel.setForeground(new Color(33, 150, 243));
        priceLabel.setAlignmentX(Component.CENTER_ALIGNMENT);
        card.add(priceLabel);
        card.add(Box.createRigidArea(new Dimension(0, 5)));

        // Add to cart button with improved styling
        JButton addButton = new JButton("+");
        addButton.setAlignmentX(Component.CENTER_ALIGNMENT);
        addButton.setPreferredSize(new Dimension(48, 38));
        addButton.setMaximumSize(new Dimension(48, 38));
        addButton.setBackground(new Color(46, 204, 113)); // Bright green color
        addButton.setForeground(Color.WHITE);
        addButton.setFocusPainted(false);
        addButton.setBorder(BorderFactory.createLineBorder(new Color(39, 174, 96), 2, true));
        addButton.setFont(new Font("Arial", Font.BOLD, 24));
        addButton.setToolTipText("Chọn " + name);
        addButton.setCursor(new Cursor(Cursor.HAND_CURSOR));
        addButton.setOpaque(true);
        addButton.setContentAreaFilled(true);
        addButton.addActionListener(e -> handleFoodSelection(name, price, foodData));
        card.add(addButton);
        return card;
    }

    // Modern cart panel with bold title and thick border
    private JPanel createModernCartPanel(FoodSelectionData foodData) {
        JPanel cartPanel = new JPanel(new BorderLayout());
        cartPanel.setBorder(BorderFactory.createCompoundBorder(
            BorderFactory.createLineBorder(new Color(100, 100, 100), 3),
            BorderFactory.createEmptyBorder(10, 10, 10, 10)));
        cartPanel.setBackground(Color.WHITE);
        JLabel title = new JLabel("Giỏ hàng");
        title.setFont(new Font("Arial", Font.BOLD, 24));
        title.setHorizontalAlignment(SwingConstants.CENTER);
        cartPanel.add(title, BorderLayout.NORTH);
        // Cart table
        DefaultTableModel cartModel = new DefaultTableModel(
            new String[]{"Tên", "Số lượng", "Giá", "Tổng"}, 0);
        JTable cartTable = new JTable(cartModel);
        cartTable.setRowHeight(32);
        cartTable.getTableHeader().setFont(new Font("Arial", Font.BOLD, 16));
        JScrollPane cartScrollPane = new JScrollPane(cartTable);
        cartPanel.add(cartScrollPane, BorderLayout.CENTER);
        // Store references
        foodData.cartModel = cartModel;
        return cartPanel;
    }

    // Modern action buttons (large, rounded, colored)
    private JPanel createFoodButtonPanel(JDialog dialog, String movieTitle, int movieId, 
                                       List<String> selectedSeats, double seatPrice,
                                       FoodSelectionData foodData, String scheduleId) {
        JPanel buttonPanel = new JPanel(new FlowLayout(FlowLayout.RIGHT));
        JButton continueButton = new JButton("Tiếp tục");
        JButton cancelButton = new JButton("Hủy");

        // Style buttons
        continueButton.setBackground(new Color(33, 150, 243)); // Blue
        continueButton.setForeground(Color.BLACK);
        continueButton.setFont(new Font("Arial", Font.BOLD, 14));
        continueButton.setFocusPainted(false);
        continueButton.setBorderPainted(false);

        cancelButton.setBackground(new Color(108, 117, 125)); // Gray
        cancelButton.setForeground(Color.BLACK);
        cancelButton.setFont(new Font("Arial", Font.BOLD, 14));
        cancelButton.setFocusPainted(false);
        cancelButton.setBorderPainted(false);

        continueButton.addActionListener(e -> {
            dialog.dispose();
            showPaymentDialog(movieTitle, movieId, selectedSeats, seatPrice, 
                            foodData.selectedFoods, foodData.totalPrice, scheduleId);
        });

        cancelButton.addActionListener(e -> dialog.dispose());

        buttonPanel.add(cancelButton);
        buttonPanel.add(continueButton);
        return buttonPanel;
    }

    // Helper class for food selection data
    private static class FoodSelectionData {
        List<FoodItem> selectedFoods = new ArrayList<>();
        double totalPrice = 0.0;
        DefaultTableModel cartModel;
        JLabel totalLabel;
    }

    private static class FoodItem {
        private String name;
        private double price;
        private int quantity;

        public FoodItem(String name, double price) {
            this.name = name;
            this.price = price;
            this.quantity = 1;
        }

        public String getName() { return name; }
        public double getPrice() { return price; }
        public int getQuantity() { return quantity; }
        public void setQuantity(int quantity) { this.quantity = quantity; }
    }

    // Payment Dialog
    private void showPaymentDialog(String movieTitle, int movieId,
                                 List<String> selectedSeats,
                                 double seatPrice,
                                 List<FoodItem> selectedFoods,
                                 double foodPrice,
                                 String scheduleId) {
        JDialog dialog = new JDialog(this, "Thanh toán", true);
        dialog.setSize(1000, 700);
        dialog.setLocationRelativeTo(this);
        dialog.setLayout(new BorderLayout(10, 10));

        JPanel mainPanel = new JPanel(new GridBagLayout());
        mainPanel.setBorder(BorderFactory.createEmptyBorder(20, 20, 20, 20));
        GridBagConstraints gbc = new GridBagConstraints();
        gbc.insets = new Insets(10, 10, 10, 10);
        gbc.fill = GridBagConstraints.BOTH;

        // Panel thông tin khách hàng và vé
        JPanel infoPanel = new JPanel(new GridLayout(2, 1, 0, 10));
        infoPanel.setBorder(BorderFactory.createTitledBorder("Thông tin đặt vé"));
        infoPanel.setBackground(new Color(245, 250, 255));

        // Thông tin khách hàng
        JPanel customerPanel = new JPanel(new GridLayout(3, 2, 5, 5));
        customerPanel.setBackground(new Color(245, 250, 255));
        JLabel nameLabel = new JLabel("Họ tên:");
        JTextField nameField = new JTextField(20);
        JLabel phoneLabel = new JLabel("Điện thoại:");
        JTextField phoneField = new JTextField(15);
        JCheckBox guestCheckBox = new JCheckBox("Khách vãng lai");
        nameLabel.setFont(new Font("Arial", Font.BOLD, 14));
        phoneLabel.setFont(new Font("Arial", Font.BOLD, 14));
        customerPanel.add(nameLabel);
        customerPanel.add(nameField);
        customerPanel.add(phoneLabel);
        customerPanel.add(phoneField);
        customerPanel.add(new JLabel(""));
        customerPanel.add(guestCheckBox);

        // Thông tin vé
        JPanel ticketPanel = new JPanel(new GridLayout(3, 1, 5, 5));
        ticketPanel.setBackground(new Color(245, 250, 255));
        JLabel movieLabel = new JLabel("Phim: " + movieTitle);
        JLabel seatLabel = new JLabel("Ghế: " + String.join(", ", selectedSeats));
        JLabel priceLabel = new JLabel("Giá vé: " + String.format("%,.0f VNĐ", seatPrice));
        movieLabel.setFont(new Font("Arial", Font.BOLD, 14));
        seatLabel.setFont(new Font("Arial", Font.PLAIN, 14));
        priceLabel.setFont(new Font("Arial", Font.PLAIN, 14));
        ticketPanel.add(movieLabel);
        ticketPanel.add(seatLabel);
        ticketPanel.add(priceLabel);

        infoPanel.add(customerPanel);
        infoPanel.add(ticketPanel);

        // Panel đồ ăn
        JPanel foodPanel = new JPanel(new BorderLayout());
        foodPanel.setBorder(BorderFactory.createTitledBorder("Đồ ăn"));
        foodPanel.setBackground(new Color(255, 255, 245));

        JPanel foodListPanel = new JPanel();
        foodListPanel.setLayout(new BoxLayout(foodListPanel, BoxLayout.Y_AXIS));
        foodListPanel.setBackground(new Color(255, 255, 245));

        if (selectedFoods != null && !selectedFoods.isEmpty()) {
            for (FoodItem food : selectedFoods) {
                JPanel foodItemPanel = new JPanel(new BorderLayout());
                foodItemPanel.setBackground(new Color(255, 255, 245));
                JLabel foodLbl = new JLabel(food.getName() + " x" + food.getQuantity());
                JLabel priceLbl = new JLabel(String.format("%,.0f VNĐ", food.getPrice() * food.getQuantity()));
                foodLbl.setFont(new Font("Arial", Font.PLAIN, 14));
                priceLbl.setFont(new Font("Arial", Font.PLAIN, 14));
                foodItemPanel.add(foodLbl, BorderLayout.WEST);
                foodItemPanel.add(priceLbl, BorderLayout.EAST);
                foodListPanel.add(foodItemPanel);
            }
        } else {
            JLabel noFood = new JLabel("Không có");
            noFood.setFont(new Font("Arial", Font.ITALIC, 14));
            foodListPanel.add(noFood);
        }

        JScrollPane foodScrollPane = new JScrollPane(foodListPanel);
        foodPanel.add(foodScrollPane, BorderLayout.CENTER);

        // Panel thanh toán
        JPanel paymentPanel = new JPanel(new BorderLayout());
        paymentPanel.setBorder(BorderFactory.createTitledBorder("Thanh toán"));
        paymentPanel.setBackground(new Color(255, 245, 245));

        // Panel điểm tích lũy
        JPanel pointsPanel = new JPanel(new FlowLayout(FlowLayout.LEFT));
        pointsPanel.setBackground(new Color(255, 245, 245));
        JCheckBox usePointsCheckBox = new JCheckBox("Sử dụng điểm tích lũy (5 điểm = 1 vé)");
        usePointsCheckBox.setEnabled(false);
        JLabel pointsInfoLabel = new JLabel("Điểm tích lũy: 0");

        // Thêm listener cho việc nhập thông tin khách hàng
        nameField.getDocument().addDocumentListener(new DocumentListener() {
            public void changedUpdate(DocumentEvent e) { checkCustomer(); }
            public void removeUpdate(DocumentEvent e) { checkCustomer(); }
            public void insertUpdate(DocumentEvent e) { checkCustomer(); }
            
            private void checkCustomer() {
                String name = nameField.getText().trim();
                String phone = phoneField.getText().trim();
                if (!name.isEmpty() && !phone.isEmpty()) {
                    try (Connection conn = DatabaseUtil.getConnection();
                         PreparedStatement pstmt = conn.prepareStatement(
                             "SELECT customer_id, loyalty_points FROM customers WHERE full_name = ? AND phone_number = ?")) {
                        pstmt.setString(1, name);
                        pstmt.setString(2, phone);
                        ResultSet rs = pstmt.executeQuery();
                        if (rs.next()) {
                            int points = rs.getInt("loyalty_points");
                            pointsInfoLabel.setText("Điểm tích lũy: " + points);
                            usePointsCheckBox.setEnabled(points >= 5);
                        } else {
                            pointsInfoLabel.setText("Điểm tích lũy: 0");
        usePointsCheckBox.setEnabled(false);
                        }
                    } catch (SQLException ex) {
                        ex.printStackTrace();
                    }
                }
            }
        });

        phoneField.getDocument().addDocumentListener(new DocumentListener() {
            public void changedUpdate(DocumentEvent e) { checkCustomer(); }
            public void removeUpdate(DocumentEvent e) { checkCustomer(); }
            public void insertUpdate(DocumentEvent e) { checkCustomer(); }
            
            private void checkCustomer() {
                String name = nameField.getText().trim();
                String phone = phoneField.getText().trim();
                if (!name.isEmpty() && !phone.isEmpty()) {
                    try (Connection conn = DatabaseUtil.getConnection();
                         PreparedStatement pstmt = conn.prepareStatement(
                             "SELECT customer_id, loyalty_points FROM customers WHERE full_name = ? AND phone_number = ?")) {
                        pstmt.setString(1, name);
                        pstmt.setString(2, phone);
                        ResultSet rs = pstmt.executeQuery();
                        if (rs.next()) {
                            int points = rs.getInt("loyalty_points");
                            pointsInfoLabel.setText("Điểm tích lũy: " + points);
                            usePointsCheckBox.setEnabled(points >= 5);
                        } else {
                            pointsInfoLabel.setText("Điểm tích lũy: 0");
                            usePointsCheckBox.setEnabled(false);
                        }
                    } catch (SQLException ex) {
                        ex.printStackTrace();
                    }
                }
            }
        });

        pointsPanel.add(usePointsCheckBox);
        pointsPanel.add(pointsInfoLabel);

        // Panel tổng tiền
        JPanel totalPanel = new JPanel(new FlowLayout(FlowLayout.RIGHT));
        totalPanel.setBackground(new Color(255, 245, 245));
        double totalPrice = seatPrice + foodPrice;
        JLabel totalLabel = new JLabel(String.format("Tổng cộng: %,d VNĐ", (int)totalPrice));
        totalLabel.setFont(new Font("Arial", Font.BOLD, 16));
        totalPanel.add(totalLabel);

        paymentPanel.add(pointsPanel, BorderLayout.NORTH);
        paymentPanel.add(totalPanel, BorderLayout.CENTER);

        // Thêm các panel vào mainPanel
        gbc.gridx = 0;
        gbc.gridy = 0;
        mainPanel.add(infoPanel, gbc);

        gbc.gridx = 1;
        mainPanel.add(foodPanel, gbc);

        gbc.gridx = 0;
        gbc.gridy = 1;
        gbc.gridwidth = 2;
        gbc.weighty = 0.3;
        mainPanel.add(paymentPanel, gbc);

        // Panel nút
        JPanel buttonPanel = new JPanel(new FlowLayout(FlowLayout.CENTER, 40, 20));
        JButton payButton = new JButton("Thanh toán");
        JButton backButton = new JButton("Quay lại");
        payButton.setFont(new Font("Arial", Font.BOLD, 22));
        payButton.setBackground(new Color(33, 150, 243));
        payButton.setForeground(Color.WHITE);
        payButton.setFocusPainted(false);
        payButton.setBorder(BorderFactory.createLineBorder(new Color(0, 80, 180), 3, true));
        payButton.setPreferredSize(new Dimension(220, 60));
        backButton.setFont(new Font("Arial", Font.BOLD, 22));
        backButton.setBackground(new Color(220, 53, 69));
        backButton.setForeground(Color.WHITE);
        backButton.setFocusPainted(false);
        backButton.setBorder(BorderFactory.createLineBorder(new Color(180, 0, 0), 3, true));
        backButton.setPreferredSize(new Dimension(220, 60));
        buttonPanel.setOpaque(false);
        buttonPanel.add(backButton);
        buttonPanel.add(payButton);

        // Thêm mainPanel và buttonPanel vào dialog
        dialog.add(mainPanel, BorderLayout.CENTER);
        dialog.add(buttonPanel, BorderLayout.SOUTH);

        // Xử lý sự kiện
        backButton.addActionListener(e -> {
            dialog.dispose();
            SwingUtilities.invokeLater(() -> {
                showFoodSelectionDialog(movieTitle, movieId, selectedSeats, seatPrice, scheduleId);
            });
        });

        payButton.addActionListener(e -> {
            if (nameField.getText().trim().isEmpty()) {
                JOptionPane.showMessageDialog(dialog, "Vui lòng nhập họ tên khách hàng.");
                return;
            }
            if (phoneField.getText().trim().isEmpty()) {
                JOptionPane.showMessageDialog(dialog, "Vui lòng nhập số điện thoại.");
                return;
            }

            try (Connection conn = DatabaseUtil.getConnection()) {
                conn.setAutoCommit(false);
                String customerId;
                
                // Kiểm tra xem khách hàng đã tồn tại chưa
                    try (PreparedStatement checkStmt = conn.prepareStatement(
                    "SELECT customer_id FROM customers WHERE phone_number = ?")) {
                        checkStmt.setString(1, phoneField.getText().trim());
                        ResultSet rs = checkStmt.executeQuery();
                        if (rs.next()) {
                            customerId = rs.getString("customer_id");
                            } else {
                        // Tạo khách hàng mới
                        customerId = "CUS" + System.currentTimeMillis();
                        try (PreparedStatement insertStmt = conn.prepareStatement(
                            "INSERT INTO customers (customer_id, full_name, phone_number) VALUES (?, ?, ?)")) {
                            insertStmt.setString(1, customerId);
                            insertStmt.setString(2, nameField.getText().trim());
                            insertStmt.setString(3, phoneField.getText().trim());
                            insertStmt.executeUpdate();
                        }
                    }
                }

                // Tạo đơn hàng mới
                int orderId;
                try (PreparedStatement orderStmt = conn.prepareStatement(
                    "INSERT INTO orders (customer_id, movie_id, showtime_id, seat_number, total_amount) VALUES (?, ?, ?, ?, ?)",
                    Statement.RETURN_GENERATED_KEYS)) {
                    orderStmt.setString(1, customerId);
                    orderStmt.setInt(2, movieId);
                    orderStmt.setString(3, scheduleId);
                    orderStmt.setString(4, String.join(",", selectedSeats));
                    orderStmt.setDouble(5, seatPrice);
                    orderStmt.executeUpdate();
                    try (ResultSet rs = orderStmt.getGeneratedKeys()) {
                        if (rs.next()) {
                    orderId = rs.getInt(1);
                        } else {
                            throw new SQLException("Không lấy được ID đơn hàng mới.");
                }
                    }
                }

                // Thêm vé
                try (PreparedStatement ticketStmt = conn.prepareStatement(
                    "INSERT INTO tickets (order_id, schedule_id, seat_id, status, price) VALUES (?, ?, ?, 'sold', ?)")) {
                    for (String seat : selectedSeats) {
                        ticketStmt.setInt(1, orderId);
                        ticketStmt.setString(2, scheduleId);
                        ticketStmt.setString(3, seat);
                        ticketStmt.setDouble(4, usePointsCheckBox.isSelected() ? 0 : seatPrice / selectedSeats.size());
                        ticketStmt.addBatch();
                    }
                    ticketStmt.executeBatch();
                }

                // Cập nhật điểm tích lũy
                if (usePointsCheckBox.isSelected()) {
                    // Trừ 5 điểm khi sử dụng điểm
                    try (PreparedStatement updatePointsStmt = conn.prepareStatement(
                        "UPDATE customers SET loyalty_points = loyalty_points - 5 WHERE customer_id = ?")) {
                        updatePointsStmt.setString(1, customerId);
                        updatePointsStmt.executeUpdate();
                    }
                } else {
                    // Tích 1 điểm khi không sử dụng điểm
                    try (PreparedStatement updatePointsStmt = conn.prepareStatement(
                        "UPDATE customers SET loyalty_points = loyalty_points + 1 WHERE customer_id = ?")) {
                        updatePointsStmt.setString(1, customerId);
                        updatePointsStmt.executeUpdate();
                    }
                }

                conn.commit();
                JOptionPane.showMessageDialog(dialog, 
                    "Thanh toán thành công!\n" +
                    (usePointsCheckBox.isSelected() ? "Đã sử dụng điểm tích lũy." : "") +
                    "\nCảm ơn quý khách đã sử dụng dịch vụ của chúng tôi.");
                dialog.dispose();
            } catch (SQLException ex) {
                ex.printStackTrace();
                JOptionPane.showMessageDialog(dialog, "Lỗi khi thanh toán: " + ex.getMessage());
            }
        });

        dialog.setVisible(true);
    }

    private JPanel createMovieInfoPanel(String movieTitle, List<String> selectedSeats, double seatPrice) {
        JPanel panel = new JPanel(new BorderLayout());
        panel.setBorder(BorderFactory.createTitledBorder("Phim"));
        
        DefaultTableModel model = new DefaultTableModel(
            new String[]{"Thông tin", "Chi tiết"}, 0);
        JTable table = new JTable(model);
        table.getColumnModel().getColumn(0).setPreferredWidth(150);
        table.getColumnModel().getColumn(1).setPreferredWidth(300);
        
        model.addRow(new Object[]{"Tên phim", movieTitle});
        model.addRow(new Object[]{"Ghế", String.join(", ", selectedSeats)});
        model.addRow(new Object[]{"Giá vé", String.format("%,.0f VNĐ", seatPrice)});
        
        panel.add(new JScrollPane(table), BorderLayout.CENTER);
        return panel;
    }

    private JPanel createFoodInfoPanel(List<FoodItem> selectedFoods) {
        JPanel panel = new JPanel(new BorderLayout());
        panel.setBorder(BorderFactory.createTitledBorder("Đồ ăn"));
        
        DefaultTableModel model = new DefaultTableModel(
            new String[]{"Tên", "Số lượng", "Đơn giá", "Thành tiền"}, 0);
        JTable table = new JTable(model);
        
        for (FoodItem food : selectedFoods) {
            model.addRow(new Object[]{
                food.getName(),
                food.getQuantity(),
                String.format("%,.0f VNĐ", food.getPrice()),
                String.format("%,.0f VNĐ", food.getPrice() * food.getQuantity())
            });
        }
        
        panel.add(new JScrollPane(table), BorderLayout.CENTER);
        return panel;
    }

    private JPanel createTotalPricePanel(double seatPrice, double foodPrice) {
        JPanel panel = new JPanel(new FlowLayout(FlowLayout.RIGHT));
        double totalPrice = seatPrice + foodPrice;
        JLabel totalLabel = new JLabel(String.format("Tổng cộng: %,d VNĐ", (int)totalPrice));
        totalLabel.setFont(new Font("Arial", Font.BOLD, 16));
        panel.add(totalLabel);
        return panel;
    }

    private JPanel createCustomersPanel() {
        JPanel panel = new JPanel(new BorderLayout());
        panel.setBorder(BorderFactory.createEmptyBorder(20, 20, 20, 20));

        // Create table WITHOUT 'Điểm' column
        String[] columnNames = {"Mã khách hàng", "Họ tên", "Ngày sinh", "Địa chỉ", "Số điện thoại", "CMND"};
        DefaultTableModel model = new DefaultTableModel(columnNames, 0) {
            @Override
            public boolean isCellEditable(int row, int column) {
                return false;
            }
        };
        JTable table = new JTable(model);
        table.setSelectionMode(ListSelectionModel.SINGLE_SELECTION);
        table.setAutoResizeMode(JTable.AUTO_RESIZE_ALL_COLUMNS);
        table.getTableHeader().setReorderingAllowed(false);

        // Create scroll pane
        JScrollPane scrollPane = new JScrollPane(table);

        // CRUD buttons panel
        JPanel crudPanel = new JPanel(new FlowLayout(FlowLayout.RIGHT, 10, 5));
        crudPanel.setBorder(BorderFactory.createTitledBorder("Thao tác"));
        JButton viewButton = new JButton("Xem");
        JButton addButton = new JButton("Thêm");
        JButton editButton = new JButton("Sửa");
        JButton deleteButton = new JButton("Xóa");
        crudPanel.add(viewButton);
        crudPanel.add(addButton);
        crudPanel.add(editButton);
        crudPanel.add(deleteButton);
        panel.add(crudPanel, BorderLayout.NORTH);
        panel.add(scrollPane, BorderLayout.CENTER);

        // Load initial data (without loyalty_points)
        loadCustomers(model, "");

        // Action listeners
        viewButton.addActionListener(e -> {
            int selectedRow = table.getSelectedRow();
            if (selectedRow >= 0) {
                String customerId = (String) table.getValueAt(selectedRow, 0);
                viewCustomerDetails(customerId);
            } else {
                JOptionPane.showMessageDialog(this, "Vui lòng chọn khách hàng cần xem.");
            }
        });
        addButton.addActionListener(e -> showCustomerDialog(null, model));
        editButton.addActionListener(e -> {
            int selectedRow = table.getSelectedRow();
            if (selectedRow >= 0) {
                String customerId = (String) table.getValueAt(selectedRow, 0);
                showCustomerDialog(customerId, model);
            } else {
                JOptionPane.showMessageDialog(this, "Vui lòng chọn khách hàng cần sửa.");
            }
        });
        deleteButton.addActionListener(e -> {
            int selectedRow = table.getSelectedRow();
            if (selectedRow >= 0) {
                String customerId = (String) table.getValueAt(selectedRow, 0);
                deleteCustomer(customerId, model);
            } else {
                JOptionPane.showMessageDialog(this, "Vui lòng chọn khách hàng cần xóa.");
            }
        });

        return panel;
    }

    private String buildSearchQuery(String customerId, String name, String dob, 
                                  String address, String phone, String idCard, String points) {
        StringBuilder query = new StringBuilder();
        if (!customerId.isEmpty()) query.append("customer_id LIKE '%").append(customerId).append("%' AND ");
        if (!name.isEmpty()) query.append("full_name LIKE '%").append(name).append("%' AND ");
        if (!dob.isEmpty()) query.append("date_of_birth LIKE '%").append(dob).append("%' AND ");
        if (!address.isEmpty()) query.append("address LIKE '%").append(address).append("%' AND ");
        if (!phone.isEmpty()) query.append("phone_number LIKE '%").append(phone).append("%' AND ");
        if (!idCard.isEmpty()) query.append("id_card LIKE '%").append(idCard).append("%' AND ");
        if (!points.isEmpty()) query.append("loyalty_points = ").append(points).append(" AND ");
        
        String result = query.toString();
        return result.isEmpty() ? "" : result.substring(0, result.length() - 5);
    }

    private void loadCustomers(DefaultTableModel model, String searchQuery) {
        model.setRowCount(0);
        try (Connection conn = DatabaseUtil.getConnection();
             PreparedStatement pstmt = conn.prepareStatement(
                 "SELECT * FROM customers WHERE customer_id NOT LIKE 'GUEST%' " +
                 (searchQuery.isEmpty() ? "" : "AND " + searchQuery) +
                 " ORDER BY customer_id")) {
            ResultSet rs = pstmt.executeQuery();
            while (rs.next()) {
                Vector<Object> row = new Vector<>();
                row.add(rs.getString("customer_id"));
                row.add(rs.getString("full_name"));
                // Định dạng ngày sinh
                String dob = rs.getString("date_of_birth");
                try {
                    java.util.Date d = new java.text.SimpleDateFormat("yyyy-MM-dd").parse(dob);
                    dob = new java.text.SimpleDateFormat("dd/MM/yyyy").format(d);
                } catch (Exception e) {}
                row.add(dob);
                row.add(rs.getString("address"));
                row.add(rs.getString("phone_number"));
                row.add(rs.getString("id_card"));
                // Không add loyalty_points vào bảng staff
                model.addRow(row);
            }
        } catch (SQLException e) {
            JOptionPane.showMessageDialog(this, "Lỗi khi tải danh sách khách hàng: " + e.getMessage());
        }
    }

    private void showCustomerDialog(String customerId, DefaultTableModel model) {
        JDialog dialog = new JDialog(this, customerId == null ? "Thêm khách hàng" : "Sửa khách hàng", true);
        dialog.setSize(400, 500);
        dialog.setLocationRelativeTo(this);
        dialog.setLayout(new BorderLayout(10, 10));

        JPanel panel = new JPanel(new GridBagLayout());
        panel.setBorder(BorderFactory.createEmptyBorder(20, 20, 20, 20));
        GridBagConstraints gbc = new GridBagConstraints();
        gbc.fill = GridBagConstraints.HORIZONTAL;
        gbc.insets = new Insets(5, 5, 5, 5);

        // Add fields
        JTextField nameField = new JTextField(20);
        JTextField dobField = new JTextField(20);
        JTextField addressField = new JTextField(20);
        JTextField phoneField = new JTextField(20);
        JTextField idCardField = new JTextField(20);
        JTextField pointsField = new JTextField(20);

        // Add labels and fields
        gbc.gridx = 0;
        gbc.gridy = 0;
        panel.add(new JLabel("Họ tên:"), gbc);
        gbc.gridx = 1;
        panel.add(nameField, gbc);

        gbc.gridx = 0;
        gbc.gridy = 1;
        panel.add(new JLabel("Ngày sinh (YYYY-MM-DD):"), gbc);
        gbc.gridx = 1;
        panel.add(dobField, gbc);

        gbc.gridx = 0;
        gbc.gridy = 2;
        panel.add(new JLabel("Địa chỉ:"), gbc);
        gbc.gridx = 1;
        panel.add(addressField, gbc);

        gbc.gridx = 0;
        gbc.gridy = 3;
        panel.add(new JLabel("Số điện thoại:"), gbc);
        gbc.gridx = 1;
        panel.add(phoneField, gbc);

        gbc.gridx = 0;
        gbc.gridy = 4;
        panel.add(new JLabel("CCCD:"), gbc);
        gbc.gridx = 1;
        panel.add(idCardField, gbc);

        gbc.gridx = 0;
        gbc.gridy = 5;
        panel.add(new JLabel("Điểm tích lũy:"), gbc);
        gbc.gridx = 1;
        panel.add(pointsField, gbc);

        // Load customer data if editing
        if (customerId != null) {
            try (Connection conn = DatabaseUtil.getConnection();
                 PreparedStatement pstmt = conn.prepareStatement(
                     "SELECT * FROM customers WHERE customer_id = ?")) {
                pstmt.setString(1, customerId);
                ResultSet rs = pstmt.executeQuery();
                if (rs.next()) {
                    nameField.setText(rs.getString("full_name"));
                    dobField.setText(rs.getString("date_of_birth"));
                    addressField.setText(rs.getString("address"));
                    phoneField.setText(rs.getString("phone_number"));
                    idCardField.setText(rs.getString("id_card"));
                    pointsField.setText(String.valueOf(rs.getInt("loyalty_points")));
                }
            } catch (SQLException e) {
                JOptionPane.showMessageDialog(dialog, "Lỗi khi tải thông tin khách hàng: " + e.getMessage());
                dialog.dispose();
                return;
            }
        }

        // Add buttons
        JPanel buttonPanel = new JPanel(new FlowLayout(FlowLayout.RIGHT));
        JButton saveButton = new JButton("Lưu");
        JButton cancelButton = new JButton("Hủy");

        saveButton.addActionListener(e -> {
            // Validate fields
            if (nameField.getText().trim().isEmpty() ||
                dobField.getText().trim().isEmpty() ||
                addressField.getText().trim().isEmpty() ||
                phoneField.getText().trim().isEmpty() ||
                idCardField.getText().trim().isEmpty() ||
                pointsField.getText().trim().isEmpty()) {
                JOptionPane.showMessageDialog(dialog, "Vui lòng điền đầy đủ thông tin.");
                return;
            }

            try {
                int points = Integer.parseInt(pointsField.getText().trim());
                if (points < 0) {
                    JOptionPane.showMessageDialog(dialog, "Điểm tích lũy không được âm.");
                    return;
                }

                if (customerId == null) {
                    // Add new customer
                    try (Connection conn = DatabaseUtil.getConnection();
                         PreparedStatement pstmt = conn.prepareStatement(
                             "INSERT INTO customers (customer_id, full_name, date_of_birth, address, phone_number, id_card, loyalty_points) " +
                             "VALUES (?, ?, ?, ?, ?, ?, ?)")) {
                        
                        String newCustomerId = "C" + String.format("%03d", (int)(Math.random() * 1000));
                        pstmt.setString(1, newCustomerId);
                        pstmt.setString(2, nameField.getText().trim());
                        pstmt.setString(3, dobField.getText().trim());
                        pstmt.setString(4, addressField.getText().trim());
                        pstmt.setString(5, phoneField.getText().trim());
                        pstmt.setString(6, idCardField.getText().trim());
                        pstmt.setInt(7, points);
                        pstmt.executeUpdate();
                    }
                } else {
                    // Update existing customer
                    try (Connection conn = DatabaseUtil.getConnection();
                         PreparedStatement pstmt = conn.prepareStatement(
                             "UPDATE customers SET full_name = ?, date_of_birth = ?, address = ?, " +
                             "phone_number = ?, id_card = ?, loyalty_points = ? WHERE customer_id = ?")) {
                        
                        pstmt.setString(1, nameField.getText().trim());
                        pstmt.setString(2, dobField.getText().trim());
                        pstmt.setString(3, addressField.getText().trim());
                        pstmt.setString(4, phoneField.getText().trim());
                        pstmt.setString(5, idCardField.getText().trim());
                        pstmt.setInt(6, points);
                        pstmt.setString(7, customerId);
                        pstmt.executeUpdate();
                    }
                }

                loadCustomers(model, "");
                dialog.dispose();
                JOptionPane.showMessageDialog(dialog, 
                    customerId == null ? "Thêm khách hàng thành công!" : "Cập nhật khách hàng thành công!");

            } catch (NumberFormatException ex) {
                JOptionPane.showMessageDialog(dialog, "Điểm tích lũy phải là số.");
            } catch (SQLException ex) {
                JOptionPane.showMessageDialog(dialog, "Lỗi khi lưu thông tin khách hàng: " + ex.getMessage());
            }
        });

        cancelButton.addActionListener(e -> dialog.dispose());

        buttonPanel.add(cancelButton);
        buttonPanel.add(saveButton);

        dialog.add(panel, BorderLayout.CENTER);
        dialog.add(buttonPanel, BorderLayout.SOUTH);
        dialog.setVisible(true);
    }

    private void deleteCustomer(String customerId, DefaultTableModel model) {
        int confirm = JOptionPane.showConfirmDialog(this,
            "Bạn có chắc chắn muốn xóa khách hàng này?",
            "Xác nhận xóa",
            JOptionPane.YES_NO_OPTION);
            
        if (confirm == JOptionPane.YES_OPTION) {
            try (Connection conn = DatabaseUtil.getConnection();
                 PreparedStatement pstmt = conn.prepareStatement(
                     "DELETE FROM customers WHERE customer_id = ?")) {
                pstmt.setString(1, customerId);
                pstmt.executeUpdate();
                loadCustomers(model, "");
                JOptionPane.showMessageDialog(this, "Xóa khách hàng thành công!");
            } catch (SQLException e) {
                JOptionPane.showMessageDialog(this, "Lỗi khi xóa khách hàng: " + e.getMessage());
            }
        }
    }

    private void viewCustomerDetails(String customerId) {
        try (Connection conn = DatabaseUtil.getConnection();
             PreparedStatement pstmt = conn.prepareStatement(
                 "SELECT * FROM customers WHERE customer_id = ?")) {
            pstmt.setString(1, customerId);
            ResultSet rs = pstmt.executeQuery();
            if (rs.next()) {
                StringBuilder details = new StringBuilder();
                details.append("Mã khách hàng: ").append(rs.getString("customer_id")).append("\n");
                details.append("Họ tên: ").append(rs.getString("full_name")).append("\n");
                // Định dạng ngày sinh
                String dob = rs.getString("date_of_birth");
                try {
                    java.util.Date d = new java.text.SimpleDateFormat("yyyy-MM-dd").parse(dob);
                    dob = new java.text.SimpleDateFormat("dd/MM/yyyy").format(d);
                } catch (Exception e) {}
                details.append("Ngày sinh: ").append(dob).append("\n");
                details.append("Địa chỉ: ").append(rs.getString("address")).append("\n");
                details.append("Số điện thoại: ").append(rs.getString("phone_number")).append("\n");
                details.append("CCCD: ").append(rs.getString("id_card")).append("\n");
                details.append("Điểm tích lũy: ").append(rs.getInt("loyalty_points"));
                JOptionPane.showMessageDialog(this, details.toString(), 
                    "Chi tiết khách hàng", JOptionPane.INFORMATION_MESSAGE);
            }
        } catch (SQLException e) {
            JOptionPane.showMessageDialog(this, "Lỗi khi xem thông tin khách hàng: " + e.getMessage());
        }
    }

    private void handleLogout() {
        int confirm = JOptionPane.showConfirmDialog(this,
            "Bạn có chắc chắn muốn đăng xuất?",
            "Xác nhận đăng xuất",
            JOptionPane.YES_NO_OPTION);
            
        if (confirm == JOptionPane.YES_OPTION) {
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
    }

    private JPanel createSchedulesPanel() {
        JPanel panel = new JPanel(new BorderLayout(10, 10));
        panel.setBorder(BorderFactory.createEmptyBorder(20, 20, 20, 20));

        // Create top panel with search and CRUD buttons
        JPanel topPanel = new JPanel(new GridBagLayout());
        GridBagConstraints gbc = new GridBagConstraints();
        gbc.insets = new Insets(5, 5, 5, 5);
        gbc.fill = GridBagConstraints.HORIZONTAL;

        // Create table
        String[] columns = {"Mã lịch chiếu", "Phim", "Rạp", "Giá vé", "Ngày chiếu", "Giờ bắt đầu", "Giờ kết thúc"};
        DefaultTableModel model = new DefaultTableModel(columns, 0) {
            @Override
            public boolean isCellEditable(int row, int column) {
                return false;
            }
        };
        JTable table = new JTable(model);
        JScrollPane scrollPane = new JScrollPane(table);

        // Bảng vé đã bán
        String[] ticketColumns = {"Mã vé", "Mã ghế", "Loại ghế", "Trạng thái", "Giá vé"};
        DefaultTableModel ticketModel = new DefaultTableModel(ticketColumns, 0) {
            @Override
            public boolean isCellEditable(int row, int column) {
                return false;
            }
        };
        JTable ticketTable = new JTable(ticketModel);
        JScrollPane ticketScrollPane = new JScrollPane(ticketTable);

        // Khi chọn lịch chiếu, load vé tương ứng
        table.getSelectionModel().addListSelectionListener(e -> {
            if (!e.getValueIsAdjusting()) {
                int selectedRow = table.getSelectedRow();
                if (selectedRow >= 0) {
                    String scheduleId = (String) model.getValueAt(selectedRow, 0);
                    loadTicketsForSchedule(ticketModel, scheduleId);
                } else {
                    ticketModel.setRowCount(0);
                }
            }
        });

        JSplitPane splitPane = new JSplitPane(JSplitPane.VERTICAL_SPLIT, scrollPane, ticketScrollPane);
        splitPane.setDividerLocation(200);
        panel.add(splitPane, BorderLayout.CENTER);

        // CRUD buttons panel
        JPanel crudPanel = new JPanel(new FlowLayout(FlowLayout.RIGHT, 10, 5));
        crudPanel.setBorder(BorderFactory.createTitledBorder("Thao tác"));

        JButton viewButton = new JButton("Xem");
        JButton addButton = new JButton("Thêm");
        JButton editButton = new JButton("Sửa");
        JButton deleteButton = new JButton("Xóa");

        // Style the buttons
        viewButton.setPreferredSize(new Dimension(100, 30));
        addButton.setPreferredSize(new Dimension(100, 30));
        editButton.setPreferredSize(new Dimension(100, 30));
        deleteButton.setPreferredSize(new Dimension(100, 30));

        viewButton.setBackground(new Color(0, 123, 255));
        viewButton.setForeground(Color.WHITE);
        viewButton.setFocusPainted(false);

        // Add buttons to CRUD panel
        crudPanel.add(viewButton);
        crudPanel.add(addButton);
        crudPanel.add(editButton);
        crudPanel.add(deleteButton);

        // Add CRUD panel to top panel
        gbc.gridx = 0;
        gbc.gridy = 0;
        gbc.weightx = 1.0;
        topPanel.add(crudPanel, gbc);

        // Add components to panel
        panel.add(topPanel, BorderLayout.NORTH);
        panel.add(scrollPane, BorderLayout.CENTER);

        // Add action listeners
        viewButton.addActionListener(e -> {
            int selectedRow = table.getSelectedRow();
            if (selectedRow >= 0) {
                String scheduleId = (String) table.getValueAt(selectedRow, 0);
                // Add view schedule functionality
            } else {
                JOptionPane.showMessageDialog(this, "Vui lòng chọn lịch chiếu cần xem.");
            }
        });

        addButton.addActionListener(e -> {
            // Add new schedule functionality
        });

        editButton.addActionListener(e -> {
            int selectedRow = table.getSelectedRow();
            if (selectedRow >= 0) {
                String scheduleId = (String) table.getValueAt(selectedRow, 0);
                // Add edit schedule functionality
            } else {
                JOptionPane.showMessageDialog(this, "Vui lòng chọn lịch chiếu cần sửa.");
            }
        });

        deleteButton.addActionListener(e -> {
            int selectedRow = table.getSelectedRow();
            if (selectedRow >= 0) {
                String scheduleId = (String) table.getValueAt(selectedRow, 0);
                // Add delete schedule functionality
            } else {
                JOptionPane.showMessageDialog(this, "Vui lòng chọn lịch chiếu cần xóa.");
            }
        });

        // Load initial data
        loadSchedules(model);

        return panel;
    }

    private void loadTicketsForSchedule(DefaultTableModel ticketModel, String scheduleId) {
        ticketModel.setRowCount(0);
        try (Connection conn = DatabaseUtil.getConnection();
             PreparedStatement pstmt = conn.prepareStatement(
                "SELECT id, seat_id, status, price FROM tickets WHERE schedule_id = ?")) {
            pstmt.setString(1, scheduleId);
            ResultSet rs = pstmt.executeQuery();
            while (rs.next()) {
                String seatId = rs.getString("seat_id");
                // For demo: seat type based on seatId
                String[] parts = seatId.split("-");
                String seatType = (parts.length == 3 && (Integer.parseInt(parts[1]) + Integer.parseInt(parts[2])) % 2 == 0) ? "Standard" : "VIP";
                Vector<Object> row = new Vector<>();
                row.add(rs.getString("id"));
                row.add(seatId);
                row.add(seatType);
                row.add(rs.getString("status"));
                row.add(rs.getDouble("price"));
                ticketModel.addRow(row);
            }
        } catch (SQLException e) {
            JOptionPane.showMessageDialog(null, "Lỗi khi tải dữ liệu vé: " + e.getMessage());
        }
    }

    private JPanel createFoodPanel() {
        JPanel foodPanel = new JPanel(new BorderLayout(10, 10));
        foodPanel.setBorder(BorderFactory.createEmptyBorder(20, 20, 20, 20));

        // Create table model with image column
        DefaultTableModel model = new DefaultTableModel(
            new Object[]{"ID", "Tên", "Mô tả", "Giá", "Danh mục", "Ảnh"}, 0) {
            @Override
            public boolean isCellEditable(int row, int column) {
                return false;
            }
        };

        JTable foodTable = new JTable(model);
        // Set custom renderer for image column
        foodTable.getColumnModel().getColumn(5).setCellRenderer(new javax.swing.table.DefaultTableCellRenderer() {
            @Override
            public java.awt.Component getTableCellRendererComponent(JTable table, Object value, boolean isSelected, boolean hasFocus, int row, int column) {
                JLabel label = new JLabel();
                if (value != null && !value.toString().isEmpty()) {
                    try {
                        String imagePath = value.toString();
                        String fullPath = imagePath.startsWith("/") ? imagePath : "src/main/resources/" + imagePath;
                        java.io.File imageFile = new java.io.File(fullPath);
                        if (imageFile.exists()) {
                            javax.swing.ImageIcon icon = new javax.swing.ImageIcon(fullPath);
                            java.awt.Image img = icon.getImage().getScaledInstance(80, 80, java.awt.Image.SCALE_SMOOTH);
                            label.setIcon(new javax.swing.ImageIcon(img));
                        } else {
                            label.setText("Không có ảnh");
                        }
                    } catch (Exception e) {
                        label.setText("Lỗi ảnh");
                    }
                } else {
                    label.setText("Không có ảnh");
                }
                label.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
                return label;
            }
        });
        JScrollPane scrollPane = new JScrollPane(foodTable);
        foodPanel.add(scrollPane, BorderLayout.CENTER);

        // Create button panel
        JPanel buttonPanel = new JPanel(new FlowLayout(FlowLayout.RIGHT));
        JButton addButton = new JButton("Thêm");
        JButton editButton = new JButton("Sửa");
        JButton deleteButton = new JButton("Xóa");
        JButton sellButton = new JButton("Bán");

        addButton.addActionListener(e -> showFoodDialog(null, model));
        editButton.addActionListener(e -> {
            int selectedRow = foodTable.getSelectedRow();
            if (selectedRow >= 0) {
                String foodId = (String) model.getValueAt(selectedRow, 0);
                showFoodDialog(foodId, model);
            } else {
                JOptionPane.showMessageDialog(this, "Vui lòng chọn một món ăn để sửa.");
            }
        });
        deleteButton.addActionListener(e -> {
            int selectedRow = foodTable.getSelectedRow();
            if (selectedRow >= 0) {
                String foodId = (String) model.getValueAt(selectedRow, 0);
                deleteFood(foodId, model);
            } else {
                JOptionPane.showMessageDialog(this, "Vui lòng chọn một món ăn để xóa.");
            }
        });
        sellButton.addActionListener(e -> {
            int selectedRow = foodTable.getSelectedRow();
            if (selectedRow >= 0) {
                String foodName = (String) model.getValueAt(selectedRow, 1);
                String foodId = (String) model.getValueAt(selectedRow, 0);
                String price = model.getValueAt(selectedRow, 3).toString();
                String quantityStr = JOptionPane.showInputDialog(this, "Nhập số lượng bán cho '" + foodName + "':", "1");
                if (quantityStr != null && !quantityStr.trim().isEmpty()) {
                    try {
                        int quantity = Integer.parseInt(quantityStr.trim());
                        if (quantity > 0) {
                            JOptionPane.showMessageDialog(this, "Đã bán " + quantity + " x '" + foodName + "' với giá " + price + " mỗi cái.");
                        } else {
                            JOptionPane.showMessageDialog(this, "Số lượng phải lớn hơn 0.");
                        }
                    } catch (NumberFormatException ex) {
                        JOptionPane.showMessageDialog(this, "Số lượng không hợp lệ.");
                    }
                }
            } else {
                JOptionPane.showMessageDialog(this, "Vui lòng chọn một món ăn để bán.");
            }
        });

        buttonPanel.add(addButton);
        buttonPanel.add(editButton);
        buttonPanel.add(deleteButton);
        buttonPanel.add(sellButton);
        foodPanel.add(buttonPanel, BorderLayout.SOUTH);

        // Load food items (update loadFoods to include image path)
        loadFoodsWithImage(model, "", "");

        return foodPanel;
    }

    // New method to load foods with image path
    private void loadFoodsWithImage(DefaultTableModel model, String name, String category) {
        model.setRowCount(0);
        StringBuilder query = new StringBuilder("SELECT * FROM foods WHERE 1=1");
        if (name != null && !name.isEmpty()) {
            query.append(" AND name LIKE ?");
        }
        if (category != null && !category.isEmpty()) {
            query.append(" AND category = ?");
        }
        try (Connection conn = DatabaseUtil.getConnection();
             PreparedStatement pstmt = conn.prepareStatement(query.toString())) {
            int idx = 1;
            if (name != null && !name.isEmpty()) {
                pstmt.setString(idx++, "%" + name + "%");
            }
            if (category != null && !category.isEmpty()) {
                pstmt.setString(idx++, category);
            }
            ResultSet rs = pstmt.executeQuery();
            while (rs.next()) {
                model.addRow(new Object[]{
                    rs.getString("id"),
                    rs.getString("name"),
                    rs.getString("description"),
                    rs.getDouble("price"),
                    rs.getString("category"),
                    rs.getString("image_path")
                });
            }
        } catch (SQLException e) {
            JOptionPane.showMessageDialog(null, "Lỗi khi tải danh sách đồ ăn: " + e.getMessage());
        }
    }

    private void showFoodDialog(String foodId, DefaultTableModel model) {
        JDialog dialog = new JDialog(this, foodId == null ? "Thêm món ăn" : "Sửa món ăn", true);
        dialog.setSize(400, 300);
        dialog.setLocationRelativeTo(this);
        dialog.setLayout(new BorderLayout(10, 10));

        JPanel formPanel = new JPanel(new GridBagLayout());
        formPanel.setBorder(BorderFactory.createEmptyBorder(10, 10, 10, 10));
        GridBagConstraints gbc = new GridBagConstraints();
        gbc.fill = GridBagConstraints.HORIZONTAL;
        gbc.insets = new Insets(5, 5, 5, 5);

        JTextField nameField = new JTextField(20);
        JTextField descriptionField = new JTextField(20);
        JTextField priceField = new JTextField(20);
        JComboBox<String> categoryComboBox = new JComboBox<>(new String[]{"Đồ ăn", "Đồ uống", "Bắp rang"});

        if (foodId != null) {
            try (Connection conn = DatabaseUtil.getConnection();
                 PreparedStatement pstmt = conn.prepareStatement("SELECT * FROM foods WHERE id = ?")) {
                pstmt.setString(1, foodId);
                ResultSet rs = pstmt.executeQuery();
                if (rs.next()) {
                    nameField.setText(rs.getString("name"));
                    descriptionField.setText(rs.getString("description"));
                    priceField.setText(String.valueOf(rs.getDouble("price")));
                    categoryComboBox.setSelectedItem(rs.getString("category"));
                }
            } catch (SQLException e) {
                e.printStackTrace();
                JOptionPane.showMessageDialog(dialog, "Lỗi khi tải thông tin món ăn: " + e.getMessage());
                return;
            }
        }

        gbc.gridx = 0; gbc.gridy = 0;
        formPanel.add(new JLabel("Tên:"), gbc);
        gbc.gridx = 1;
        formPanel.add(nameField, gbc);

        gbc.gridx = 0; gbc.gridy = 1;
        formPanel.add(new JLabel("Mô tả:"), gbc);
        gbc.gridx = 1;
        formPanel.add(descriptionField, gbc);

        gbc.gridx = 0; gbc.gridy = 2;
        formPanel.add(new JLabel("Giá:"), gbc);
        gbc.gridx = 1;
        formPanel.add(priceField, gbc);

        gbc.gridx = 0; gbc.gridy = 3;
        formPanel.add(new JLabel("Danh mục:"), gbc);
        gbc.gridx = 1;
        formPanel.add(categoryComboBox, gbc);

        JPanel buttonPanel = new JPanel(new FlowLayout(FlowLayout.RIGHT));
        JButton saveButton = new JButton("Lưu");
        JButton cancelButton = new JButton("Hủy");

        saveButton.addActionListener(e -> {
            try {
                String name = nameField.getText().trim();
                String description = descriptionField.getText().trim();
                double price = Double.parseDouble(priceField.getText().trim());
                String category = (String) categoryComboBox.getSelectedItem();

                if (name.isEmpty() || description.isEmpty()) {
                    JOptionPane.showMessageDialog(dialog, "Vui lòng điền đầy đủ thông tin!");
                    return;
                }

                try (Connection conn = DatabaseUtil.getConnection()) {
                    if (foodId == null) {
                        // Insert new food
                        try (PreparedStatement pstmt = conn.prepareStatement(
                                "INSERT INTO foods (name, description, price, category) VALUES (?, ?, ?, ?)")) {
                            pstmt.setString(1, name);
                            pstmt.setString(2, description);
                            pstmt.setDouble(3, price);
                            pstmt.setString(4, category);
                            pstmt.executeUpdate();
                        }
            } else {
                        // Update existing food
                        try (PreparedStatement pstmt = conn.prepareStatement(
                                "UPDATE foods SET name = ?, description = ?, price = ?, category = ? WHERE id = ?")) {
                            pstmt.setString(1, name);
                            pstmt.setString(2, description);
                            pstmt.setDouble(3, price);
                            pstmt.setString(4, category);
                            pstmt.setString(5, foodId);
                            pstmt.executeUpdate();
                        }
                    }
                } catch (SQLException ex) {
                    ex.printStackTrace();
                    JOptionPane.showMessageDialog(dialog, "Lỗi khi lưu món ăn: " + ex.getMessage());
                    return;
                }

                dialog.dispose();
        loadFoods(model, "", "");
            } catch (NumberFormatException ex) {
                JOptionPane.showMessageDialog(dialog, "Giá không hợp lệ!");
            }
        });

        cancelButton.addActionListener(e -> dialog.dispose());

        dialog.setVisible(true);
    }

    private void deleteFood(String foodId, DefaultTableModel model) {
        int confirm = JOptionPane.showConfirmDialog(this, "Bạn có chắc chắn muốn xóa món ăn này?", "Xác nhận xóa", JOptionPane.YES_NO_OPTION);
        if (confirm == JOptionPane.YES_OPTION) {
            try (Connection conn = DatabaseUtil.getConnection();
                 PreparedStatement pstmt = conn.prepareStatement("DELETE FROM foods WHERE id = ?")) {
                pstmt.setString(1, foodId);
                pstmt.executeUpdate();
                loadFoods(model, "", "");
            } catch (SQLException e) {
                e.printStackTrace();
                JOptionPane.showMessageDialog(this, "Lỗi khi xóa món ăn: " + e.getMessage());
            }
        }
    }

    private void loadFoods(DefaultTableModel model, String name, String category) {
        model.setRowCount(0);
        try (Connection conn = DatabaseUtil.getConnection();
             PreparedStatement pstmt = conn.prepareStatement(
                "SELECT * FROM foods WHERE name LIKE ? AND category LIKE ?")) {
            pstmt.setString(1, "%" + name + "%");
            pstmt.setString(2, "%" + category + "%");
            ResultSet rs = pstmt.executeQuery();
            while (rs.next()) {
                String imagePath = rs.getString("image_path");
                JLabel imageLabel = new JLabel();
                if (imagePath != null && !imagePath.isEmpty()) {
                    try {
                        String fullPath = imagePath.startsWith("/") ? imagePath : "src/main/resources/" + imagePath;
                        File imageFile = new File(fullPath);
                        if (imageFile.exists()) {
                            ImageIcon icon = new ImageIcon(fullPath);
                            Image img = icon.getImage().getScaledInstance(60, 60, Image.SCALE_SMOOTH);
                            imageLabel.setIcon(new ImageIcon(img));
                        } else {
                            imageLabel.setText("Không có ảnh");
                        }
                    } catch (Exception e) {
                        imageLabel.setText("Lỗi ảnh");
                    }
                } else {
                    imageLabel.setText("Không có ảnh");
                }
                model.addRow(new Object[]{
                    rs.getString("id"),
                    rs.getString("name"),
                    rs.getString("description"),
                    rs.getDouble("price"),
                    rs.getString("category"),
                    imageLabel
                });
            }
        } catch (SQLException e) {
            e.printStackTrace();
            JOptionPane.showMessageDialog(this, "Lỗi khi tải danh sách món ăn: " + e.getMessage());
        }
    }

    private void loadGenres(JComboBox<String> genreComboBox) throws SQLException {
        try (Connection conn = DatabaseUtil.getConnection();
             Statement stmt = conn.createStatement();
             ResultSet rs = stmt.executeQuery("SELECT name FROM genres ORDER BY name")) {
            
            while (rs.next()) {
                genreComboBox.addItem(rs.getString("name"));
            }
        }
    }

    private void loadMoviesAsCards(JPanel moviesPanel, String searchText, String genre) {
        moviesPanel.removeAll();
        try (Connection conn = DatabaseUtil.getConnection();
             PreparedStatement pstmt = conn.prepareStatement(
                 "SELECT m.*, GROUP_CONCAT(DISTINCT g.name) as genres, " +
                 "(SELECT s.show_date || ' ' || s.start_time FROM schedules s WHERE s.movie_id = m.id AND s.show_date >= date('now') ORDER BY s.show_date, s.start_time LIMIT 1) as next_showtime " +
                 "FROM movies m " +
                 "LEFT JOIN movie_genres mg ON m.id = mg.movie_id " +
                 "LEFT JOIN genres g ON mg.genre_id = g.id " +
                 "WHERE m.title LIKE ? " +
                 (genre.isEmpty() ? "" : "AND g.name = ? ") +
                 "GROUP BY m.id " +
                 "ORDER BY m.title")) {
            pstmt.setString(1, "%" + searchText + "%");
            if (!genre.isEmpty()) {
                pstmt.setString(2, genre);
            }
            ResultSet rs = pstmt.executeQuery();
            while (rs.next()) {
                String showTime = rs.getString("next_showtime");
                JPanel card = createMovieCard(
                    rs.getString("title"),
                    rs.getString("genres"),
                    rs.getInt("duration"),
                    showTime != null ? showTime : "--:--",
                    rs.getString("image_path"),
                    rs.getInt("id")
                );
                moviesPanel.add(card);
                moviesPanel.add(Box.createRigidArea(new Dimension(20, 0)));
            }
        } catch (SQLException e) {
            JOptionPane.showMessageDialog(this, "Lỗi khi tải danh sách phim: " + e.getMessage());
        }
        moviesPanel.revalidate();
        moviesPanel.repaint();
    }

    // Formatting Improvement all: Improved method formatting, variable naming, and layout for clarity and maintainability.
    private JPanel createMovieCard(String title, String genres, int duration, String showTime, String imagePath, int movieId) {
        // Formatting Improvement all: Use descriptive variable names and consistent indentation.
        JPanel cardPanel = new JPanel();
        cardPanel.setLayout(new BoxLayout(cardPanel, BoxLayout.Y_AXIS));
        cardPanel.setPreferredSize(new Dimension(220, 480)); // Formatting Improvement all: Increased height for button visibility.
        cardPanel.setMaximumSize(new Dimension(220, 480));
        cardPanel.setBorder(BorderFactory.createCompoundBorder(
            BorderFactory.createLineBorder(new Color(200, 200, 200), 1),
            BorderFactory.createEmptyBorder(10, 10, 10, 10)));
        cardPanel.setBackground(Color.WHITE);

        // Formatting Improvement all: Poster image loading and fallback handling.
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

        // Formatting Improvement all: Use clear label names and consistent font styling.
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

        // Định dạng lại showTime: dd/MM/yyyy HH:mm
        String showTimeDisplay = showTime;
        if (showTime != null && showTime.matches("\\d{4}-\\d{2}-\\d{2} \\d{2}:\\d{2}(:\\d{2}(\\.\\d+)?)?")) {
            try {
                java.util.Date d = new java.text.SimpleDateFormat("yyyy-MM-dd HH:mm:ss").parse(showTime);
                showTimeDisplay = new java.text.SimpleDateFormat("dd/MM/yyyy HH:mm").format(d);
            } catch (Exception e) {
                try {
                    java.util.Date d = new java.text.SimpleDateFormat("yyyy-MM-dd HH:mm").parse(showTime);
                    showTimeDisplay = new java.text.SimpleDateFormat("dd/MM/yyyy HH:mm").format(d);
                } catch (Exception ex) {
                    showTimeDisplay = showTime;
                }
            }
        }
        JLabel showTimeLabel = new JLabel("<html><div style='text-align: center;'>Suất chiếu: " + (showTimeDisplay != null ? showTimeDisplay : "--:--") + "</div></html>");
        showTimeLabel.setFont(new Font("Arial", Font.PLAIN, 13));
        showTimeLabel.setAlignmentX(Component.CENTER_ALIGNMENT);
        cardPanel.add(showTimeLabel);
        cardPanel.add(Box.createRigidArea(new Dimension(0, 10)));

        // Formatting Improvement all: Add the buy button with clear naming and styling, and ensure it's always visible.
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
        // Change the action listener to show schedule selection first
        buyTicketButton.addActionListener(e -> showScheduleSelectionDialog(title, movieId));
        cardPanel.add(buyTicketButton);
        cardPanel.add(Box.createVerticalGlue()); // Formatting Improvement all: Glue after button ensures button is always visible at the bottom.

        return cardPanel;
    }

    private void loadSchedules(DefaultTableModel model) {
        model.setRowCount(0);
        try (Connection conn = DatabaseUtil.getConnection();
             Statement stmt = conn.createStatement();
             ResultSet rs = stmt.executeQuery(
                 "SELECT s.*, m.title, t.name as theater_name " +
                 "FROM schedules s " +
                 "JOIN movies m ON s.movie_id = m.id " +
                 "JOIN theaters t ON s.theater_id = t.id " +
                 "WHERE s.show_date >= date('now') " +
                 "ORDER BY s.show_date, s.start_time")) {
            while (rs.next()) {
                Vector<Object> row = new Vector<>();
                row.add(rs.getString("id"));
                row.add(rs.getString("title"));
                row.add(rs.getString("theater_name"));
                // Định dạng ngày
                String rawDate = rs.getString("show_date");
                String showDate = rawDate;
                try {
                    java.util.Date d = new java.text.SimpleDateFormat("yyyy-MM-dd").parse(rawDate);
                    showDate = new java.text.SimpleDateFormat("dd/MM/yyyy").format(d);
                } catch (Exception e) {}
                row.add(rs.getDouble("original_price"));
                row.add(showDate);
                row.add(rs.getString("start_time"));
                row.add(rs.getString("end_time"));
                model.addRow(row);
            }
        } catch (SQLException e) {
            JOptionPane.showMessageDialog(this, 
                "Lỗi khi tải dữ liệu lịch chiếu: " + e.getMessage());
        }
    }

    private JPanel createModernSeatLegend() {
        JPanel legendPanel = new JPanel(new FlowLayout(FlowLayout.LEFT, 20, 5));
        legendPanel.setBackground(Color.WHITE);
        legendPanel.add(createLegendItem("Đang chọn", SELECTED_SEAT_COLOR));
        legendPanel.add(createLegendItem("Đã mua", SOLD_SEAT_COLOR));
        legendPanel.add(createLegendItem("Ghế thường (màu xanh)", BLUE_SEAT_COLOR));
        legendPanel.add(createLegendItem("Ghế VIP (màu trắng)", WHITE_SEAT_COLOR));
        return legendPanel;
    }

    private JPanel createModernSeatInfoPanel(String movieTitle, int movieId, SeatSelectionData seatData) {
        JPanel infoPanel = new JPanel();
        infoPanel.setLayout(new BoxLayout(infoPanel, BoxLayout.Y_AXIS));
        infoPanel.setBorder(BorderFactory.createEmptyBorder(20, 20, 20, 20));
        infoPanel.setBackground(Color.WHITE);

        // Add movie title
        JLabel titleLabel = new JLabel(movieTitle);
        titleLabel.setFont(new Font("Arial", Font.BOLD, 24));
        titleLabel.setAlignmentX(Component.CENTER_ALIGNMENT);
        infoPanel.add(titleLabel);
        infoPanel.add(Box.createVerticalStrut(20));

        // Add seat selection info
        JPanel detailsPanel = new JPanel();
        detailsPanel.setLayout(new GridLayout(0, 2, 10, 10));
        detailsPanel.setOpaque(false);

        // Add price information
        detailsPanel.add(new JLabel("Giá vé cơ bản:"));
        detailsPanel.add(new JLabel(String.format("%,.0f VNĐ", seatData.seatPrice)));
        detailsPanel.add(new JLabel("Giá vé VIP:"));
        detailsPanel.add(new JLabel(String.format("%,.0f VNĐ", seatData.seatPrice * 1.2)));

        // Add selected seats info
        detailsPanel.add(new JLabel("Ghế đã chọn:"));
        JLabel seatsLabel = new JLabel(seatData.selectedSeats.isEmpty() ? "Chưa chọn" : String.join(", ", seatData.selectedSeats));
        detailsPanel.add(seatsLabel);

        // Add total price
        detailsPanel.add(new JLabel("Tổng tiền:"));
        JLabel totalLabel = new JLabel(String.format("%,.0f VNĐ", seatData.totalPrice));
        totalLabel.setFont(new Font("Arial", Font.BOLD, 16));
        detailsPanel.add(totalLabel);

        infoPanel.add(detailsPanel);
        return infoPanel;
    }

    private JPanel createModernButtonPanel(JDialog dialog, String movieTitle, int movieId, SeatSelectionData seatData, JPanel infoPanel) {
        JPanel buttonPanel = new JPanel(new FlowLayout(FlowLayout.CENTER, 30, 10));
        buttonPanel.setBackground(Color.WHITE);
        JButton continueButton = new JButton("Tiếp tục");
        JButton backButton = new JButton("Quay lại");
        continueButton.setBackground(new Color(0, 123, 255));
        continueButton.setForeground(Color.WHITE);
        continueButton.setFont(new Font("Arial", Font.BOLD, 18));
        continueButton.setFocusPainted(false);
        continueButton.setBorderPainted(true);
        continueButton.setBorder(BorderFactory.createLineBorder(new Color(0, 123, 255), 3, true));
        continueButton.setOpaque(true);
        continueButton.setContentAreaFilled(true);
        continueButton.setCursor(new Cursor(Cursor.HAND_CURSOR));
        continueButton.setPreferredSize(new Dimension(160, 45));
        continueButton.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseEntered(java.awt.event.MouseEvent evt) {
                continueButton.setBackground(new Color(0, 86, 179));
            }
            public void mouseExited(java.awt.event.MouseEvent evt) {
                continueButton.setBackground(new Color(0, 123, 255));
            }
        });
        backButton.setBackground(new Color(220, 53, 69));
        backButton.setForeground(Color.WHITE);
        backButton.setFont(new Font("Arial", Font.BOLD, 18));
        backButton.setFocusPainted(false);
        backButton.setBorderPainted(true);
        backButton.setBorder(BorderFactory.createLineBorder(new Color(220, 53, 69), 3, true));
        backButton.setOpaque(true);
        backButton.setContentAreaFilled(true);
        backButton.setCursor(new Cursor(Cursor.HAND_CURSOR));
        backButton.setPreferredSize(new Dimension(160, 45));
        backButton.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseEntered(java.awt.event.MouseEvent evt) {
                backButton.setBackground(new Color(200, 35, 51));
            }
            public void mouseExited(java.awt.event.MouseEvent evt) {
                backButton.setBackground(new Color(220, 53, 69));
            }
        });
        buttonPanel.add(continueButton);
        buttonPanel.add(backButton);
        return buttonPanel;
    }

    // Add back handleFoodSelection for food add button
    private void handleFoodSelection(String name, double price, FoodSelectionData foodData) {
        boolean found = false;
        for (FoodItem food : foodData.selectedFoods) {
            if (food.getName().equals(name)) {
                food.setQuantity(food.getQuantity() + 1);
                found = true;
                break;
            }
        }
        if (!found) {
            FoodItem food = new FoodItem(name, price);
            foodData.selectedFoods.add(food);
        }
        foodData.totalPrice += price;
        // Update cart table
        foodData.cartModel.setRowCount(0);
        for (FoodItem food : foodData.selectedFoods) {
            foodData.cartModel.addRow(new Object[]{
                food.getName(),
                food.getQuantity(),
                String.format("%,.0f đ", food.getPrice()),
                String.format("%,.0f đ", food.getPrice() * food.getQuantity())
            });
        }
    }

    private void showPaymentDialog(Customer customer, Movie movie, List<Food> selectedFoods) {
        JDialog dialog = new JDialog(this, "Thanh toán", true);
        dialog.setLayout(new BorderLayout());
        dialog.setSize(800, 600);
        dialog.setLocationRelativeTo(this);

        // Main content panel with 3 columns
        JPanel mainPanel = new JPanel(new GridLayout(1, 3, 20, 0));
        mainPanel.setBorder(BorderFactory.createEmptyBorder(20, 20, 20, 20));

        // Left column - Customer Info
        JPanel customerPanel = createSectionPanel("Thông tin khách hàng");
        customerPanel.setLayout(new BoxLayout(customerPanel, BoxLayout.Y_AXIS));
        customerPanel.add(Box.createVerticalStrut(10));
        
        // Customer info fields
        addInfoField(customerPanel, "Mã khách hàng:", customer.getCustomerId());
        addInfoField(customerPanel, "Họ tên:", customer.getFullName());
        addInfoField(customerPanel, "Ngày sinh:", customer.getDateOfBirth().format(DateTimeFormatter.ofPattern("dd/MM/yyyy")));
        addInfoField(customerPanel, "Địa chỉ:", customer.getAddress());
        addInfoField(customerPanel, "Số điện thoại:", customer.getPhoneNumber());
        addInfoField(customerPanel, "CCCD:", customer.getIdCard());
        addInfoField(customerPanel, "Điểm tích lũy:", String.valueOf(customer.getLoyaltyPoints()));

        // Center column - Movie Info
        JPanel moviePanel = createSectionPanel("Phim");
        moviePanel.setLayout(new BoxLayout(moviePanel, BoxLayout.Y_AXIS));
        moviePanel.add(Box.createVerticalStrut(10));
        
        // Movie info fields
        addInfoField(moviePanel, "Mã phim:", String.valueOf(movie.getId()));
        addInfoField(moviePanel, "Tên phim:", movie.getTitle());
        addInfoField(moviePanel, "Thể loại:", movie.getGenres());
        addInfoField(moviePanel, "Thời lượng:", movie.getDuration() + " phút");
        addInfoField(moviePanel, "Ngày chiếu:", movie.getStartDate());
        addInfoField(moviePanel, "Đạo diễn:", movie.getDirector());

        // Right column - Food Info
        JPanel foodPanel = createSectionPanel("Đồ ăn");
        foodPanel.setLayout(new BoxLayout(foodPanel, BoxLayout.Y_AXIS));
        foodPanel.add(Box.createVerticalStrut(10));

        // Food items
        double totalFoodPrice = 0;
        for (Food food : selectedFoods) {
            JPanel foodItemPanel = new JPanel(new BorderLayout());
            foodItemPanel.setBorder(BorderFactory.createEmptyBorder(5, 0, 5, 0));
            
            JLabel nameLabel = new JLabel(food.getName());
            nameLabel.setFont(new Font("Arial", Font.PLAIN, 14));
            
            JLabel priceLabel = new JLabel(String.format("%,d VNĐ", food.getPrice()));
            priceLabel.setFont(new Font("Arial", Font.PLAIN, 14));
            
            foodItemPanel.add(nameLabel, BorderLayout.WEST);
            foodItemPanel.add(priceLabel, BorderLayout.EAST);
            foodPanel.add(foodItemPanel);
            
            totalFoodPrice += food.getPrice();
        }

        // Total price
        JPanel totalPanel = new JPanel(new BorderLayout());
        totalPanel.setBorder(BorderFactory.createEmptyBorder(20, 0, 0, 0));
        JLabel totalLabel = new JLabel("Tổng tiền đồ ăn: " + String.format("%,d VNĐ", (int)totalFoodPrice));
        totalLabel.setFont(new Font("Arial", Font.BOLD, 14));
        totalPanel.add(totalLabel, BorderLayout.EAST);
        foodPanel.add(totalPanel);

        // Add panels to main panel
        mainPanel.add(customerPanel);
        mainPanel.add(moviePanel);
        mainPanel.add(foodPanel);

        // Button panel
        JPanel buttonPanel = new JPanel(new FlowLayout(FlowLayout.CENTER, 20, 20));
        buttonPanel.setBorder(BorderFactory.createEmptyBorder(0, 0, 20, 0));

        JButton payButton = new JButton("Thanh toán");
        payButton.setPreferredSize(new Dimension(150, 40));
        payButton.setBackground(new Color(0, 123, 255));
        payButton.setForeground(Color.WHITE);
        payButton.setFocusPainted(false);
        payButton.setBorderPainted(false);

        JButton backButton = new JButton("Quay lại");
        backButton.setPreferredSize(new Dimension(150, 40));
        backButton.setBackground(new Color(220, 53, 69));
        backButton.setForeground(Color.WHITE);
        backButton.setFocusPainted(false);
        backButton.setBorderPainted(false);

        buttonPanel.add(payButton);
        buttonPanel.add(backButton);

        // Add panels to dialog
        dialog.add(mainPanel, BorderLayout.CENTER);
        dialog.add(buttonPanel, BorderLayout.SOUTH);

        // Add action listeners
        payButton.addActionListener(e -> {
            // TODO: Implement payment logic
            dialog.dispose();
        });

        backButton.addActionListener(e -> dialog.dispose());

        dialog.setVisible(true);
    }

    private JPanel createSectionPanel(String title) {
        JPanel panel = new JPanel();
        panel.setBorder(BorderFactory.createCompoundBorder(
            BorderFactory.createTitledBorder(
                BorderFactory.createLineBorder(Color.GRAY),
                title,
                javax.swing.border.TitledBorder.LEFT,
                javax.swing.border.TitledBorder.TOP,
                new Font("Arial", Font.BOLD, 16)
            ),
            BorderFactory.createEmptyBorder(10, 10, 10, 10)
        ));
        return panel;
    }

    private void addInfoField(JPanel panel, String label, String value) {
        JPanel fieldPanel = new JPanel(new BorderLayout());
        fieldPanel.setBorder(BorderFactory.createEmptyBorder(5, 0, 5, 0));
        
        JLabel labelComponent = new JLabel(label);
        labelComponent.setFont(new Font("Arial", Font.BOLD, 14));
        
        JLabel valueComponent = new JLabel(value);
        valueComponent.setFont(new Font("Arial", Font.PLAIN, 14));
        
        fieldPanel.add(labelComponent, BorderLayout.WEST);
        fieldPanel.add(valueComponent, BorderLayout.EAST);
        panel.add(fieldPanel);
    }

    /**
     * Hàm main để khởi động ứng dụng giao diện nhân viên quản lý rạp chiếu phim.
     *
     * Ví dụ sử dụng:
     * <pre>
     *     // Chạy từ dòng lệnh hoặc IDE
     *     java com.filmsmanage.StaffControlPanel
     * </pre>
     *
     * Lưu ý thường gặp:
     * - Đảm bảo đã cấu hình đầy đủ các thư viện phụ thuộc và cơ sở dữ liệu trước khi chạy.
     */
    public static void main(String[] args) {
        SwingUtilities.invokeLater(() -> {
            StaffControlPanel frame = new StaffControlPanel();
            frame.setVisible(true);
        });
    }

    private JButton createActionButton(String text, String iconPath) {
        JButton button = new JButton(text);
        try {
            ImageIcon icon = new ImageIcon("src/main/resources/images/" + iconPath);
            Image img = icon.getImage().getScaledInstance(20, 20, Image.SCALE_SMOOTH);
            button.setIcon(new ImageIcon(img));
        } catch (Exception e) {
            e.printStackTrace();
        }
        button.setBackground(Color.WHITE);
        button.setForeground(Color.BLACK);
        button.setFocusPainted(false);
        button.setBorderPainted(true);
        button.setBorder(BorderFactory.createLineBorder(Color.BLACK));
        button.setFont(new Font("Arial", Font.BOLD, 14));
        button.setIconTextGap(10);
        return button;
    }

    // Add new method for schedule selection dialog
    private void showScheduleSelectionDialog(String movieTitle, int movieId) {
        JDialog dialog = new JDialog(this, "Chọn lịch chiếu - " + movieTitle, true);
        dialog.setSize(800, 600);
        dialog.setLocationRelativeTo(this);
        dialog.setLayout(new BorderLayout(10, 10));

        // Create main panel
        JPanel mainPanel = new JPanel(new BorderLayout(10, 10));
        mainPanel.setBorder(BorderFactory.createEmptyBorder(20, 20, 20, 20));

        // Create table model for schedules
        String[] columns = {"Mã lịch chiếu", "Phòng chiếu", "Ngày chiếu", "Giờ bắt đầu", "Giờ kết thúc", "Giá vé"};
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
        mainPanel.add(scrollPane, BorderLayout.CENTER);

        // Create button panel
        JPanel buttonPanel = new JPanel(new FlowLayout(FlowLayout.RIGHT));
        JButton selectButton = new JButton("Chọn");
        JButton cancelButton = new JButton("Hủy");
        buttonPanel.setBackground(Color.WHITE);

        // Style buttons
        selectButton.setBackground(new Color(0, 123, 255));
        selectButton.setForeground(Color.WHITE);
        selectButton.setFont(new Font("Arial", Font.BOLD, 22));
        selectButton.setFocusPainted(false);
        selectButton.setBorderPainted(true);
        selectButton.setBorder(BorderFactory.createLineBorder(new Color(0, 123, 255), 3, true));
        selectButton.setOpaque(true);
        selectButton.setContentAreaFilled(true);
        selectButton.setPreferredSize(new Dimension(200, 54));

        cancelButton.setBackground(new Color(220, 53, 69));
        cancelButton.setForeground(Color.WHITE);
        cancelButton.setFont(new Font("Arial", Font.BOLD, 22));
        cancelButton.setFocusPainted(false);
        cancelButton.setBorderPainted(true);
        cancelButton.setBorder(BorderFactory.createLineBorder(new Color(220, 53, 69), 3, true));
        cancelButton.setOpaque(true);
        cancelButton.setContentAreaFilled(true);
        cancelButton.setPreferredSize(new Dimension(200, 54));

        // Load schedules
        try (Connection conn = DatabaseUtil.getConnection();
             PreparedStatement pstmt = conn.prepareStatement(
                "SELECT s.*, t.name as theater_name " +
                "FROM schedules s " +
                "JOIN theaters t ON s.theater_id = t.id " +
                "WHERE s.movie_id = ? AND s.show_date >= date('now') " +
                "ORDER BY s.show_date, s.start_time")) {
            pstmt.setInt(1, movieId);
            ResultSet rs = pstmt.executeQuery();
            while (rs.next()) {
                Vector<Object> row = new Vector<>();
                row.add(rs.getString("id"));
                row.add(rs.getString("theater_name"));
                
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
                model.addRow(row);
            }
        } catch (SQLException e) {
            JOptionPane.showMessageDialog(dialog, "Lỗi khi tải lịch chiếu: " + e.getMessage());
        }

        // Add action listeners
        selectButton.addActionListener(e -> {
            int selectedRow = table.getSelectedRow();
            if (selectedRow >= 0) {
                String scheduleId = (String) table.getValueAt(selectedRow, 0);
                dialog.dispose();
                showSeatSelectionDialog(movieTitle, movieId, scheduleId);
            } else {
                JOptionPane.showMessageDialog(dialog, "Vui lòng chọn một lịch chiếu!");
            }
        });

        cancelButton.addActionListener(e -> dialog.dispose());

        buttonPanel.add(cancelButton);
        buttonPanel.add(selectButton);
        mainPanel.add(buttonPanel, BorderLayout.SOUTH);
        dialog.add(mainPanel);
        dialog.setVisible(true);
    }

    // Add method to create new schedule
    private void createNewSchedule(String movieTitle, int movieId) {
        try (Connection conn = DatabaseUtil.getConnection()) {
            // Get the first available theater that has a screen
            String theaterId;
            try (PreparedStatement pstmt = conn.prepareStatement(
                "SELECT t.id FROM theaters t " +
                "JOIN screens s ON t.screen_id = s.id " +
                "WHERE t.id NOT IN (SELECT theater_id FROM schedules WHERE show_date = date('now')) " +
                "LIMIT 1")) {
                ResultSet rs = pstmt.executeQuery();
                if (!rs.next()) {
                    // If no theater is available today, get any theater
                    try (PreparedStatement pstmt2 = conn.prepareStatement(
                        "SELECT t.id FROM theaters t " +
                        "JOIN screens s ON t.screen_id = s.id " +
                        "LIMIT 1")) {
                        ResultSet rs2 = pstmt2.executeQuery();
                        if (!rs2.next()) {
                            JOptionPane.showMessageDialog(this, "Không tìm thấy phòng chiếu phù hợp. Vui lòng liên hệ quản trị viên để thêm phòng chiếu.");
                            return;
                        }
                        theaterId = rs2.getString("id");
                    }
                } else {
                    theaterId = rs.getString("id");
                }
            }

            // Sinh mã lịch chiếu mới dạng SCH00x
            String scheduleId;
            try (PreparedStatement pstmt = conn.prepareStatement(
                "SELECT MAX(CAST(SUBSTR(id, 4) AS INTEGER)) AS max_num FROM schedules WHERE id LIKE 'SCH%'")) {
                ResultSet rs = pstmt.executeQuery();
                int maxNum = 0;
                if (rs.next()) {
                    maxNum = rs.getInt("max_num");
                }
                scheduleId = String.format("SCH%03d", maxNum + 1);
            }

            // Create a new schedule
            try (PreparedStatement pstmt = conn.prepareStatement(
                "INSERT INTO schedules (id, movie_id, theater_id, original_price, show_date, start_time, end_time) " +
                "VALUES (?, ?, ?, ?, date('now'), ?, ?)",
                Statement.RETURN_GENERATED_KEYS)) {
                pstmt.setString(1, scheduleId);
                pstmt.setInt(2, movieId);
                pstmt.setString(3, theaterId);
                pstmt.setDouble(4, 100000.0); // Default price
                // Set default show time (current time + 1 hour)
                java.time.LocalTime now = java.time.LocalTime.now().plusHours(1);
                pstmt.setString(5, now.toString());
                pstmt.setString(6, now.plusHours(2).toString()); // 2 hours duration
                pstmt.executeUpdate();
                // Show seat selection dialog with the new schedule
                showSeatSelectionDialog(movieTitle, movieId, scheduleId);
            }
        } catch (SQLException e) {
            JOptionPane.showMessageDialog(this, "Lỗi khi tạo lịch chiếu: " + e.getMessage());
        }
    }
} 
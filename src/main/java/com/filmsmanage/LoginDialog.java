package com.filmsmanage;

import javax.swing.*;
import java.awt.*;
import java.sql.*;

public class LoginDialog extends JDialog {
    private JTextField usernameField;
    private JPasswordField passwordField;
    private boolean authenticated = false;
    private String currentUserRole = null;
    private DatabaseUtil dbUtil;

    public LoginDialog(JFrame parent) {
        super(parent, "Đăng nhập", true);
        dbUtil = new DatabaseUtil();
        initializeUI();
    }

    private void initializeUI() {
        setLayout(new BorderLayout());
        setUndecorated(true);
        setSize(800, 400);
        setResizable(false);

        // Create main panel with border
        JPanel mainPanel = new JPanel(new BorderLayout());
        mainPanel.setBorder(BorderFactory.createLineBorder(new Color(255, 105, 180), 2));

        // Thay thế nút đóng bằng JLabel để không bị cắt chữ
        JLabel closeLabel = new JLabel("×");
        closeLabel.setFont(new Font("Arial", Font.BOLD, 32));
        closeLabel.setForeground(Color.WHITE);
        closeLabel.setHorizontalAlignment(SwingConstants.RIGHT);
        closeLabel.setCursor(new Cursor(Cursor.HAND_CURSOR));
        closeLabel.setBounds(750, 10, 40, 40);
        closeLabel.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                dispose();
            }
        });
        // LayeredPane để nút luôn nổi trên cùng
        JLayeredPane layeredPane = new JLayeredPane();
        layeredPane.setPreferredSize(new Dimension(800, 400));
        mainPanel.setBounds(0, 0, 800, 400);
        layeredPane.add(mainPanel, JLayeredPane.DEFAULT_LAYER);
        layeredPane.add(closeLabel, JLayeredPane.PALETTE_LAYER);
        add(layeredPane);

        // Left panel (login form)
        JPanel leftPanel = new JPanel();
        leftPanel.setBackground(new Color(15, 18, 54));
        leftPanel.setLayout(new BoxLayout(leftPanel, BoxLayout.Y_AXIS));
        leftPanel.setBorder(BorderFactory.createEmptyBorder(40, 40, 40, 40));
        leftPanel.setPreferredSize(new Dimension(350, 400));

        // Username field
        usernameField = new JTextField();
        usernameField.setFont(new Font("Arial", Font.PLAIN, 16));
        usernameField.setBorder(BorderFactory.createCompoundBorder(
            BorderFactory.createLineBorder(new Color(255, 105, 180), 2),
            BorderFactory.createEmptyBorder(10, 10, 10, 10)));
        usernameField.setBackground(new Color(15, 18, 54));
        usernameField.setForeground(Color.WHITE);
        usernameField.setCaretColor(Color.WHITE);
        usernameField.setAlignmentX(Component.LEFT_ALIGNMENT);
        usernameField.setMaximumSize(new Dimension(Integer.MAX_VALUE, 40));
        usernameField.setToolTipText("Tài khoản");
        usernameField.setText("");
        leftPanel.add(usernameField);
        leftPanel.add(Box.createRigidArea(new Dimension(0, 20)));

        // Password field
        passwordField = new JPasswordField();
        passwordField.setFont(new Font("Arial", Font.PLAIN, 16));
        passwordField.setBorder(BorderFactory.createCompoundBorder(
            BorderFactory.createLineBorder(new Color(255, 105, 180), 2),
            BorderFactory.createEmptyBorder(10, 10, 10, 10)));
        passwordField.setBackground(new Color(15, 18, 54));
        passwordField.setForeground(Color.WHITE);
        passwordField.setCaretColor(Color.WHITE);
        passwordField.setAlignmentX(Component.LEFT_ALIGNMENT);
        passwordField.setMaximumSize(new Dimension(Integer.MAX_VALUE, 40));
        passwordField.setToolTipText("Mật khẩu");
        leftPanel.add(passwordField);
        leftPanel.add(Box.createRigidArea(new Dimension(0, 10)));

        // Show/hide password
        JCheckBox showPassword = new JCheckBox("Hiển thị mật khẩu");
        showPassword.setForeground(new Color(255, 192, 203));
        showPassword.setBackground(new Color(15, 18, 54));
        showPassword.setFocusPainted(false);
        showPassword.setFont(new Font("Arial", Font.PLAIN, 14));
        showPassword.setAlignmentX(Component.LEFT_ALIGNMENT);
        showPassword.addActionListener(e -> {
            passwordField.setEchoChar(showPassword.isSelected() ? (char)0 : '\u2022');
        });
        leftPanel.add(showPassword);
        leftPanel.add(Box.createRigidArea(new Dimension(0, 30)));

        // Login button
        JButton loginButton = new JButton("Đăng nhập");
        loginButton.setFont(new Font("Arial", Font.BOLD, 18));
        loginButton.setBackground(new Color(233, 30, 99));
        loginButton.setForeground(Color.WHITE);
        loginButton.setFocusPainted(false);
        loginButton.setBorder(BorderFactory.createEmptyBorder(15, 0, 15, 0));
        loginButton.setAlignmentX(Component.LEFT_ALIGNMENT);
        loginButton.setMaximumSize(new Dimension(Integer.MAX_VALUE, 50));
        loginButton.addActionListener(e -> handleLogin());
        leftPanel.add(loginButton);

        // Right panel (logo background)
        JPanel rightPanel = new JPanel(new BorderLayout());
        rightPanel.setBackground(new Color(15, 18, 54));
        rightPanel.setPreferredSize(new Dimension(450, 400));

        // Load and display logo
        ImageIcon logoIcon = new ImageIcon("src/main/resources/images/logoFinal.png");
        Image logoImage = logoIcon.getImage().getScaledInstance(450, 400, Image.SCALE_SMOOTH);
        JLabel logoLabel = new JLabel(new ImageIcon(logoImage));
        logoLabel.setHorizontalAlignment(SwingConstants.CENTER);
        rightPanel.add(logoLabel, BorderLayout.CENTER);

        mainPanel.add(leftPanel, BorderLayout.WEST);
        mainPanel.add(rightPanel, BorderLayout.EAST);

        // Căn giữa dọc phần nhập liệu, thêm khoảng cách phía trên
        leftPanel.add(Box.createVerticalStrut(60), 0);
        leftPanel.add(Box.createVerticalGlue(), 1);
        leftPanel.add(Box.createVerticalGlue());

        setLocationRelativeTo(getParent());
        setDefaultCloseOperation(DISPOSE_ON_CLOSE);
    }

    private void handleLogin() {
        String username = usernameField.getText();
        String password = new String(passwordField.getPassword());
        
        if (username.isEmpty() || password.isEmpty()) {
            JOptionPane.showMessageDialog(this,
                "Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu",
                "Lỗi",
                JOptionPane.ERROR_MESSAGE);
            return;
        }
        
        try (Connection conn = dbUtil.getConnection()) {
            String sql = "SELECT * FROM staff WHERE username = ? AND password = ?";
            try (PreparedStatement pstmt = conn.prepareStatement(sql)) {
                pstmt.setString(1, username);
                pstmt.setString(2, password);
                
                try (ResultSet rs = pstmt.executeQuery()) {
                    if (rs.next()) {
                        authenticated = true;
                        currentUserRole = rs.getString("role").toUpperCase();
                        dispose();
                    } else {
                        JOptionPane.showMessageDialog(this,
                            "Tên đăng nhập hoặc mật khẩu không đúng",
                            "Lỗi đăng nhập",
                            JOptionPane.ERROR_MESSAGE);
                    }
                }
            }
        } catch (SQLException ex) {
            JOptionPane.showMessageDialog(this,
                "Lỗi kết nối cơ sở dữ liệu: " + ex.getMessage(),
                "Lỗi",
                JOptionPane.ERROR_MESSAGE);
        }
    }

    public boolean isAuthenticated() {
        return authenticated;
    }

    public String getCurrentUserRole() {
        return currentUserRole;
    }
} 
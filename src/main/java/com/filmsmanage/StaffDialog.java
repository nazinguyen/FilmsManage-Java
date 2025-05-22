package com.filmsmanage;

import javax.swing.*;
import java.awt.*;
import java.sql.*;
import java.util.Vector;

public class StaffDialog extends JDialog {
    private JTextField idField;
    private JTextField nameField;
    private JTextField usernameField;
    private JPasswordField passwordField;
    private JComboBox<String> roleComboBox;
    private boolean confirmed = false;
    private Staff staff;

    public StaffDialog(JFrame parent, String title, Staff staff) {
        super(parent, title, true);
        this.staff = staff;
        
        setLayout(new BorderLayout());
        setSize(400, 300);
        setLocationRelativeTo(parent);
        
        // Create form panel
        JPanel formPanel = new JPanel(new GridBagLayout());
        GridBagConstraints gbc = new GridBagConstraints();
        gbc.insets = new Insets(5, 5, 5, 5);
        gbc.fill = GridBagConstraints.HORIZONTAL;
        
        // Staff ID
        gbc.gridx = 0; gbc.gridy = 0;
        formPanel.add(new JLabel("Mã nhân viên:"), gbc);
        gbc.gridx = 1;
        idField = new JTextField(20);
        if (staff != null) {
            idField.setText(String.valueOf(staff.getId()));
            idField.setEditable(false);
        }
        formPanel.add(idField, gbc);
        
        // Staff Name
        gbc.gridx = 0; gbc.gridy = 1;
        formPanel.add(new JLabel("Tên nhân viên:"), gbc);
        gbc.gridx = 1;
        nameField = new JTextField(20);
        if (staff != null) nameField.setText(staff.getName());
        formPanel.add(nameField, gbc);
        
        // Username
        gbc.gridx = 0; gbc.gridy = 2;
        formPanel.add(new JLabel("Tên đăng nhập:"), gbc);
        gbc.gridx = 1;
        usernameField = new JTextField(20);
        if (staff != null) usernameField.setText(staff.getUsername());
        formPanel.add(usernameField, gbc);
        
        // Role
        gbc.gridx = 0; gbc.gridy = 3;
        formPanel.add(new JLabel("Quyền:"), gbc);
        gbc.gridx = 1;
        roleComboBox = new JComboBox<>(new String[]{"ADMIN", "STAFF"});
        if (staff != null) roleComboBox.setSelectedItem(staff.getRole());
        formPanel.add(roleComboBox, gbc);
        
        // Password
        gbc.gridx = 0; gbc.gridy = 4;
        formPanel.add(new JLabel("Mật khẩu:"), gbc);
        gbc.gridx = 1;
        passwordField = new JPasswordField(20);
        if (staff != null) passwordField.setText(staff.getPassword());
        formPanel.add(passwordField, gbc);
        
        // Buttons
        JPanel buttonPanel = new JPanel(new FlowLayout(FlowLayout.RIGHT));
        JButton saveButton = new JButton("Lưu");
        JButton cancelButton = new JButton("Hủy");
        
        saveButton.addActionListener(e -> {
            if (validateInput()) {
                confirmed = true;
                dispose();
            }
        });
        
        cancelButton.addActionListener(e -> dispose());
        
        buttonPanel.add(saveButton);
        buttonPanel.add(cancelButton);
        
        add(formPanel, BorderLayout.CENTER);
        add(buttonPanel, BorderLayout.SOUTH);
    }
    
    private boolean validateInput() {
        if (nameField.getText().trim().isEmpty()) {
            JOptionPane.showMessageDialog(this, "Vui lòng nhập tên nhân viên");
            return false;
        }
        if (usernameField.getText().trim().isEmpty()) {
            JOptionPane.showMessageDialog(this, "Vui lòng nhập tên đăng nhập");
            return false;
        }
        if (passwordField.getPassword().length == 0) {
            JOptionPane.showMessageDialog(this, "Vui lòng nhập mật khẩu");
            return false;
        }
        return true;
    }
    
    public boolean isConfirmed() {
        return confirmed;
    }
    
    public Staff getStaff() {
        int id = staff != null ? staff.getId() : 0;
        return new Staff(
            id,
            nameField.getText().trim(),
            usernameField.getText().trim(),
            new String(passwordField.getPassword()),
            (String) roleComboBox.getSelectedItem()
        );
    }
} 
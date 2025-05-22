package com.filmsmanage;

import javax.swing.*;
import java.awt.*;
import java.time.LocalDate;
import java.time.format.DateTimeFormatter;

/**
 * Cải tiến định dạng customerdialog.java: Thêm JavaDoc cho lớp và các trường để rõ ràng và dễ bảo trì hơn.
 */
public class CustomerDialog extends JDialog {
    // Cải tiến định dạng customerdialog.java: Sử dụng camelCase và thêm access modifiers.
    private JTextField txtCustomerId;
    private JTextField txtFullName;
    private JTextField txtDateOfBirth;
    private JTextField txtAddress;
    private JTextField txtPhoneNumber;
    private JTextField txtIdCard;
    private JTextField txtLoyaltyPoints;
    private boolean confirmed = false;
    private Customer customer;

    /**
     * Cải tiến định dạng customerdialog.java: Constructor sử dụng tên tham số mô tả.
     */
    public CustomerDialog(Frame owner, Customer customer) {
        super(owner, "Thông tin khách hàng", true);
        this.customer = customer;
        initializeComponents();
        if (customer != null) {
            loadCustomerData();
        }
        pack();
        setLocationRelativeTo(owner);
    }

    /**
     * Cải tiến định dạng customerdialog.java: Đặt tên và định dạng phương thức hợp lý.
     */
    private void initializeComponents() {
        setLayout(new BorderLayout());
        JPanel formPanel = new JPanel(new GridBagLayout());
        GridBagConstraints gbc = new GridBagConstraints();
        gbc.insets = new Insets(5, 5, 5, 5);
        gbc.fill = GridBagConstraints.HORIZONTAL;

        gbc.gridx = 0; gbc.gridy = 0;
        formPanel.add(new JLabel("Mã khách hàng:"), gbc);
        gbc.gridx = 1;
        txtCustomerId = new JTextField(20);
        formPanel.add(txtCustomerId, gbc);

        gbc.gridx = 0; gbc.gridy = 1;
        formPanel.add(new JLabel("Họ tên:"), gbc);
        gbc.gridx = 1;
        txtFullName = new JTextField(20);
        formPanel.add(txtFullName, gbc);

        gbc.gridx = 0; gbc.gridy = 2;
        formPanel.add(new JLabel("Ngày sinh:"), gbc);
        gbc.gridx = 1;
        txtDateOfBirth = new JTextField(20);
        formPanel.add(txtDateOfBirth, gbc);

        gbc.gridx = 0; gbc.gridy = 3;
        formPanel.add(new JLabel("Địa chỉ:"), gbc);
        gbc.gridx = 1;
        txtAddress = new JTextField(20);
        formPanel.add(txtAddress, gbc);

        gbc.gridx = 0; gbc.gridy = 4;
        formPanel.add(new JLabel("Số điện thoại:"), gbc);
        gbc.gridx = 1;
        txtPhoneNumber = new JTextField(20);
        formPanel.add(txtPhoneNumber, gbc);

        gbc.gridx = 0; gbc.gridy = 5;
        formPanel.add(new JLabel("CCCD:"), gbc);
        gbc.gridx = 1;
        txtIdCard = new JTextField(20);
        formPanel.add(txtIdCard, gbc);

        gbc.gridx = 0; gbc.gridy = 6;
        formPanel.add(new JLabel("Điểm tích lũy:"), gbc);
        gbc.gridx = 1;
        txtLoyaltyPoints = new JTextField(20);
        formPanel.add(txtLoyaltyPoints, gbc);

        add(formPanel, BorderLayout.CENTER);

        JPanel buttonPanel = new JPanel();
        JButton btnSave = new JButton("Lưu");
        JButton btnCancel = new JButton("Hủy");

        btnSave.addActionListener(e -> {
            if (validateInput()) {
                saveCustomer();
                confirmed = true;
                dispose();
            }
        });

        btnCancel.addActionListener(e -> dispose());

        buttonPanel.add(btnSave);
        buttonPanel.add(btnCancel);
        add(buttonPanel, BorderLayout.SOUTH);
    }

    /**
     * Cải tiến định dạng customerdialog.java: Đặt tên và định dạng phương thức hợp lý.
     */
    private void loadCustomerData() {
        txtCustomerId.setText(customer.getCustomerId());
        txtFullName.setText(customer.getFullName());
        txtDateOfBirth.setText(customer.getDateOfBirth().format(DateTimeFormatter.ofPattern("dd/MM/yyyy")));
        txtAddress.setText(customer.getAddress());
        txtPhoneNumber.setText(customer.getPhoneNumber());
        txtIdCard.setText(customer.getIdCard());
        txtLoyaltyPoints.setText(String.valueOf(customer.getLoyaltyPoints()));
    }

    /**
     * Cải tiến định dạng customerdialog.java: Đặt tên và định dạng phương thức hợp lý.
     */
    private boolean validateInput() {
        if (txtCustomerId.getText().trim().isEmpty() ||
            txtFullName.getText().trim().isEmpty() ||
            txtDateOfBirth.getText().trim().isEmpty() ||
            txtAddress.getText().trim().isEmpty() ||
            txtPhoneNumber.getText().trim().isEmpty() ||
            txtIdCard.getText().trim().isEmpty() ||
            txtLoyaltyPoints.getText().trim().isEmpty()) {
            JOptionPane.showMessageDialog(this, "Vui lòng điền đầy đủ thông tin!");
            return false;
        }
        return true;
    }

    /**
     * Cải tiến định dạng customerdialog.java: Đặt tên và định dạng phương thức hợp lý.
     */
    private void saveCustomer() {
        String customerId = txtCustomerId.getText().trim();
        String fullName = txtFullName.getText().trim();
        LocalDate dateOfBirth = LocalDate.parse(txtDateOfBirth.getText().trim(), 
            DateTimeFormatter.ofPattern("dd/MM/yyyy"));
        String address = txtAddress.getText().trim();
        String phoneNumber = txtPhoneNumber.getText().trim();
        String idCard = txtIdCard.getText().trim();
        int loyaltyPoints = Integer.parseInt(txtLoyaltyPoints.getText().trim());

        customer = new Customer(customerId, fullName, dateOfBirth, address, 
            phoneNumber, idCard, loyaltyPoints);
    }

    /**
     * Cải tiến định dạng customerdialog.java: Đặt tên và định dạng getter hợp lý.
     */
    public Customer getCustomer() {
        return customer;
    }

    /**
     * Cải tiến định dạng customerdialog.java: Đặt tên và định dạng getter hợp lý.
     */
    public boolean isConfirmed() {
        return confirmed;
    }
} 
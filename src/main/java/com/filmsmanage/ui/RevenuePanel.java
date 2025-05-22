package com.filmsmanage.ui;

import javax.swing.*;
import javax.swing.table.DefaultTableModel;
import java.awt.*;
import java.sql.*;
import com.filmsmanage.DatabaseUtil;

public class RevenuePanel extends JPanel {
    private JTable revenueTable;
    private DefaultTableModel tableModel;
    private JComboBox<String> periodComboBox;
    private JButton refreshButton;

    public RevenuePanel() {
        setLayout(new BorderLayout());
        
        // Period selection
        JPanel controlPanel = new JPanel();
        String[] periods = {"Hôm nay", "Tuần này", "Tháng này", "Năm nay"};
        periodComboBox = new JComboBox<>(periods);
        refreshButton = new JButton("Làm mới");
        controlPanel.add(new JLabel("Thời gian:"));
        controlPanel.add(periodComboBox);
        controlPanel.add(refreshButton);
        add(controlPanel, BorderLayout.NORTH);

        // Table
        String[] columns = {"Ngày", "Doanh thu", "Số vé bán"};
        tableModel = new DefaultTableModel(columns, 0);
        revenueTable = new JTable(tableModel);
        JScrollPane scrollPane = new JScrollPane(revenueTable);
        add(scrollPane, BorderLayout.CENTER);

        // Add refresh action
        refreshButton.addActionListener(e -> refreshData());
        periodComboBox.addActionListener(e -> refreshData());

        // Initial data load
        refreshData();
    }

    private void refreshData() {
        tableModel.setRowCount(0);
        String period = (String) periodComboBox.getSelectedItem();
        
        try (Connection conn = DatabaseUtil.getConnection()) {
            String sql = "SELECT DATE(order_date) as date, " +
                        "SUM(total_amount) as revenue, " +
                        "COUNT(*) as ticket_count " +
                        "FROM orders " +
                        "WHERE " + getDateCondition(period) +
                        "GROUP BY DATE(order_date) " +
                        "ORDER BY date DESC";
            
            try (PreparedStatement stmt = conn.prepareStatement(sql)) {
                ResultSet rs = stmt.executeQuery();
                while (rs.next()) {
                    Object[] row = {
                        rs.getDate("date"),
                        String.format("%,.0f VNĐ", rs.getDouble("revenue")),
                        rs.getInt("ticket_count")
                    };
                    tableModel.addRow(row);
                }
            }
        } catch (SQLException ex) {
            ex.printStackTrace();
            JOptionPane.showMessageDialog(this, 
                "Lỗi khi tải dữ liệu doanh thu: " + ex.getMessage(),
                "Lỗi",
                JOptionPane.ERROR_MESSAGE);
        }
    }

    private String getDateCondition(String period) {
        switch (period) {
            case "Hôm nay":
                return "DATE(order_date) = DATE('now') ";
            case "Tuần này":
                return "DATE(order_date) >= DATE('now', 'weekday 0', '-7 days') AND DATE(order_date) <= DATE('now') ";
            case "Tháng này":
                return "strftime('%Y-%m', order_date) = strftime('%Y-%m', 'now') ";
            case "Năm nay":
                return "strftime('%Y', order_date) = strftime('%Y', 'now') ";
            default:
                return "1=1 ";
        }
    }
} 
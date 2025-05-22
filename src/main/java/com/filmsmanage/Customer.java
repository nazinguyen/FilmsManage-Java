package com.filmsmanage;

import java.time.LocalDate;

/**
 * Cải tiến định dạng customer.java: Thêm JavaDoc cho lớp và các trường để rõ ràng và dễ bảo trì hơn.
 */
public class Customer {
    // Cải tiến định dạng customer.java: Sử dụng camelCase và thêm access modifiers.
    private String customerId;
    private String fullName;
    private LocalDate dateOfBirth;
    private String address;
    private String phoneNumber;
    private String idCard;
    private int loyaltyPoints;

    /**
     * Cải tiến định dạng customer.java: Constructor sử dụng tên tham số mô tả.
     */
    public Customer(String customerId, String fullName, LocalDate dateOfBirth, 
                   String address, String phoneNumber, String idCard, int loyaltyPoints) {
        this.customerId = customerId;
        this.fullName = fullName;
        this.dateOfBirth = dateOfBirth;
        this.address = address;
        this.phoneNumber = phoneNumber;
        this.idCard = idCard;
        this.loyaltyPoints = loyaltyPoints;
    }

    // Cải tiến định dạng customer.java: Đặt tên và định dạng getter, setter hợp lý.
    public String getCustomerId() { return customerId; }
    public void setCustomerId(String customerId) { this.customerId = customerId; }

    public String getFullName() { return fullName; }
    public void setFullName(String fullName) { this.fullName = fullName; }

    public LocalDate getDateOfBirth() { return dateOfBirth; }
    public void setDateOfBirth(LocalDate dateOfBirth) { this.dateOfBirth = dateOfBirth; }

    public String getAddress() { return address; }
    public void setAddress(String address) { this.address = address; }

    public String getPhoneNumber() { return phoneNumber; }
    public void setPhoneNumber(String phoneNumber) { this.phoneNumber = phoneNumber; }

    public String getIdCard() { return idCard; }
    public void setIdCard(String idCard) { this.idCard = idCard; }

    public int getLoyaltyPoints() { return loyaltyPoints; }
    public void setLoyaltyPoints(int loyaltyPoints) { this.loyaltyPoints = loyaltyPoints; }
} 
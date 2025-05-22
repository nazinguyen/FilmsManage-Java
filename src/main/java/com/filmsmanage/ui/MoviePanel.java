package com.filmsmanage.ui;

import com.filmsmanage.model.Movie;
import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionListener;

public class MoviePanel extends JPanel {
    private Movie movie;
    private JLabel titleLabel;
    private JLabel posterLabel;
    private JButton bookButton;

    public MoviePanel(Movie movie, ActionListener bookListener) {
        this.movie = movie;
        setLayout(new BorderLayout());
        setBorder(BorderFactory.createLineBorder(Color.GRAY));
        setPreferredSize(new Dimension(200, 300));

        // Title
        titleLabel = new JLabel(movie.getTitle());
        titleLabel.setHorizontalAlignment(SwingConstants.CENTER);
        add(titleLabel, BorderLayout.NORTH);

        // Poster
        posterLabel = new JLabel();
        if (movie.getPosterUrl() != null && !movie.getPosterUrl().isEmpty()) {
            ImageIcon icon = new ImageIcon(movie.getPosterUrl());
            Image image = icon.getImage().getScaledInstance(180, 250, Image.SCALE_SMOOTH);
            posterLabel.setIcon(new ImageIcon(image));
        }
        add(posterLabel, BorderLayout.CENTER);

        // Book button
        bookButton = new JButton("Đặt vé");
        bookButton.addActionListener(bookListener);
        add(bookButton, BorderLayout.SOUTH);
    }

    public Movie getMovie() {
        return movie;
    }
} 
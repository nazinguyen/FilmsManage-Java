package com.filmsmanage;

import java.util.ArrayList;
import java.util.List;

public class Movie {
    private int id;
    private String title;
    private String content;
    private int duration;
    private String startDate;
    private String endDate;
    private String director;
    private String description;
    private String imagePath;
    private String genres;

    public Movie(int id, String title, String content, int duration, String startDate, String endDate,
                String director, String description, String imagePath, String genres) {
        this.id = id;
        this.title = title;
        this.content = content;
        this.duration = duration;
        this.startDate = startDate;
        this.endDate = endDate;
        this.director = director;
        this.description = description;
        this.imagePath = imagePath;
        this.genres = genres;
    }

    // Getters
    public int getId() { return id; }
    public String getTitle() { return title; }
    public String getContent() { return content; }
    public int getDuration() { return duration; }
    public String getStartDate() { return startDate; }
    public String getEndDate() { return endDate; }
    public String getDirector() { return director; }
    public String getDescription() { return description; }
    public String getImagePath() { return imagePath; }
    public String getGenres() { return genres; }

    // Setters
    public void setId(int id) { this.id = id; }
    public void setTitle(String title) { this.title = title; }
    public void setContent(String content) { this.content = content; }
    public void setDuration(int duration) { this.duration = duration; }
    public void setStartDate(String startDate) { this.startDate = startDate; }
    public void setEndDate(String endDate) { this.endDate = endDate; }
    public void setDirector(String director) { this.director = director; }
    public void setDescription(String description) { this.description = description; }
    public void setImagePath(String imagePath) { this.imagePath = imagePath; }
    public void setGenres(String genres) { this.genres = genres; }
} 
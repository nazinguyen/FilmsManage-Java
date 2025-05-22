#!/bin/bash

# Remove existing database if it exists
rm -f movies.db

# Create and populate the database
sqlite3 movies.db < sample_data.sql

echo "Database initialized successfully!" 
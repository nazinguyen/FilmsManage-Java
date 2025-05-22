-- Clear existing data
DELETE FROM tickets;
DELETE FROM orders;
DELETE FROM schedules;
DELETE FROM movie_genres;
DELETE FROM movies;
DELETE FROM genres;
DELETE FROM formats;
DELETE FROM theaters;
DELETE FROM screens;
DELETE FROM foods;
DELETE FROM customers;

-- Reset auto-increment counters
DELETE FROM sqlite_sequence;

-- Now insert sample data
-- Insert sample movies
INSERT INTO movies (title, content, duration, start_date, end_date, director, description) VALUES
('Avengers: Endgame', 'The epic conclusion to the Infinity Saga', 181, '2024-05-01', '2024-06-30', 'Anthony Russo', 'After the devastating events of Infinity War, the Avengers must assemble once more.'),
('The Dark Knight', 'A crime thriller featuring Batman', 152, '2024-05-15', '2024-07-15', 'Christopher Nolan', 'When the menace known as the Joker wreaks havoc on Gotham City.'),
('Inception', 'A mind-bending thriller', 148, '2024-06-01', '2024-08-01', 'Christopher Nolan', 'A thief who steals corporate secrets through dream-sharing technology.');

-- Insert sample genres
INSERT INTO genres (name) VALUES
('Action'),
('Drama'),
('Sci-Fi'),
('Thriller');

-- Insert movie-genre relationships
INSERT INTO movie_genres (movie_id, genre_id) VALUES
(1, 1), -- Avengers: Endgame - Action
(1, 3), -- Avengers: Endgame - Sci-Fi
(2, 1), -- The Dark Knight - Action
(2, 2), -- The Dark Knight - Drama
(3, 3), -- Inception - Sci-Fi
(3, 4); -- Inception - Thriller

-- Insert sample screens
INSERT INTO screens (id, name) VALUES
('SC001', 'Screen 1 - Standard'),
('SC002', 'Screen 2 - IMAX'),
('SC003', 'Screen 3 - 3D');

-- Insert sample theaters
INSERT INTO theaters (id, name, screen_id, total_seats, rows, seats_per_row) VALUES
('T001', 'Theater 1', 'SC001', 100, 10, 10),
('T002', 'Theater 2', 'SC002', 150, 15, 10),
('T003', 'Theater 3', 'SC003', 120, 12, 10);

-- Insert sample formats
INSERT INTO formats (id, name, screen_id) VALUES
('F001', '2D', 'SC001'),
('F002', 'IMAX', 'SC002'),
('F003', '3D', 'SC003');

-- Insert sample schedules
INSERT INTO schedules (id, movie_id, theater_id, original_price, show_date, start_time, end_time) VALUES
('SCH001', 1, 'T001', 120000, '2024-05-01', '10:00', '13:01'),
('SCH002', 2, 'T002', 150000, '2024-05-01', '14:00', '16:32'),
('SCH003', 3, 'T003', 130000, '2024-05-01', '19:00', '21:28');

-- Insert sample customers
INSERT INTO customers (customer_id, full_name, date_of_birth, address, phone_number, id_card, loyalty_points) VALUES
('C001', 'Nguyen Van A', '1990-01-01', '123 Nguyen Hue, HCM', '0123456789', '123456789', 100),
('C002', 'Tran Thi B', '1995-05-15', '456 Le Loi, HCM', '0987654321', '987654321', 50);

-- Insert sample orders
INSERT INTO orders (movie_id, show_date, created_at) VALUES
(1, '2024-05-01', CURRENT_TIMESTAMP),
(2, '2024-05-01', CURRENT_TIMESTAMP);

-- Fix: allow order_id to be NULL in tickets table
PRAGMA foreign_keys=off;

CREATE TABLE IF NOT EXISTS tickets_new (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    order_id INTEGER,
    schedule_id VARCHAR(20) NOT NULL,
    seat_id VARCHAR(20) NOT NULL,
    status VARCHAR(20) NOT NULL,
    price DECIMAL(10,2) NOT NULL,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (order_id) REFERENCES orders(id),
    FOREIGN KEY (schedule_id) REFERENCES schedules(id)
);

INSERT INTO tickets_new (id, order_id, schedule_id, seat_id, status, price, created_at)
SELECT id, order_id, schedule_id, seat_id, status, price, created_at FROM tickets;

DROP TABLE tickets;
ALTER TABLE tickets_new RENAME TO tickets;

PRAGMA foreign_keys=on;

-- Insert sample foods
INSERT INTO foods (name, description, price, category, image_path) VALUES
('Popcorn', 'Fresh popped popcorn', 45000, 'Snacks', 'images/popcorn.jpg'),
('Coca Cola', 'Cold drink', 25000, 'Drinks', 'images/coca.jpg'),
('Hot Dog', 'Classic hot dog', 55000, 'Snacks', 'images/hotdog.jpg'); 
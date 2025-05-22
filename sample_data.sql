-- Create tables if they don't exist
CREATE TABLE IF NOT EXISTS movies (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    title TEXT NOT NULL,
    content TEXT,
    duration INTEGER,
    start_date TEXT,
    end_date TEXT,
    director TEXT,
    description TEXT,
    image_path TEXT
);

CREATE TABLE IF NOT EXISTS genres (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    name TEXT NOT NULL UNIQUE
);

CREATE TABLE IF NOT EXISTS movie_genres (
    movie_id INTEGER,
    genre_id INTEGER,
    PRIMARY KEY (movie_id, genre_id),
    FOREIGN KEY (movie_id) REFERENCES movies(id),
    FOREIGN KEY (genre_id) REFERENCES genres(id)
);

CREATE TABLE IF NOT EXISTS screens (
    id VARCHAR(20) PRIMARY KEY,
    name VARCHAR(100) NOT NULL
);

CREATE TABLE IF NOT EXISTS theaters (
    id VARCHAR(20) PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    screen_id VARCHAR(20) NOT NULL,
    total_seats INTEGER NOT NULL,
    rows INTEGER NOT NULL,
    seats_per_row INTEGER NOT NULL,
    FOREIGN KEY (screen_id) REFERENCES screens(id)
);

CREATE TABLE IF NOT EXISTS formats (
    id VARCHAR(20) PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    screen_id VARCHAR(20) NOT NULL,
    FOREIGN KEY (screen_id) REFERENCES screens(id)
);

CREATE TABLE IF NOT EXISTS schedules (
    id VARCHAR(20) PRIMARY KEY,
    movie_id INTEGER NOT NULL,
    theater_id VARCHAR(20) NOT NULL,
    original_price DECIMAL(10,2) NOT NULL,
    show_date DATE NOT NULL,
    start_time TIME NOT NULL,
    end_time TIME NOT NULL,
    FOREIGN KEY (movie_id) REFERENCES movies(id),
    FOREIGN KEY (theater_id) REFERENCES theaters(id)
);

CREATE TABLE IF NOT EXISTS customers (
    customer_id VARCHAR(20) PRIMARY KEY,
    full_name VARCHAR(100) NOT NULL,
    date_of_birth DATE NOT NULL,
    address VARCHAR(200) NOT NULL,
    phone_number VARCHAR(20) NOT NULL,
    id_card VARCHAR(20) NOT NULL UNIQUE,
    loyalty_points INTEGER DEFAULT 0
);

CREATE TABLE IF NOT EXISTS orders (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    movie_id INTEGER NOT NULL,
    show_date DATE NOT NULL,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (movie_id) REFERENCES movies(id)
);

CREATE TABLE IF NOT EXISTS tickets (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    order_id INTEGER NOT NULL,
    schedule_id VARCHAR(20) NOT NULL,
    seat_id VARCHAR(20) NOT NULL,
    status VARCHAR(20) NOT NULL,
    price DECIMAL(10,2) NOT NULL,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (order_id) REFERENCES orders(id),
    FOREIGN KEY (schedule_id) REFERENCES schedules(id)
);

CREATE TABLE IF NOT EXISTS foods (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    name VARCHAR(100) NOT NULL,
    description TEXT,
    price DECIMAL(10,2) NOT NULL,
    category VARCHAR(50) NOT NULL,
    image_path TEXT
);

CREATE TABLE IF NOT EXISTS staff (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    name TEXT NOT NULL,
    username TEXT NOT NULL UNIQUE,
    password TEXT NOT NULL,
    role TEXT NOT NULL
);

-- Insert default admin and staff users
INSERT OR IGNORE INTO staff (name, username, password, role) VALUES
('Admin', 'admin', 'admin123', 'ADMIN'),
('Staff', 'staff', 'staff123', 'STAFF');

-- Insert sample movies
INSERT INTO movies (title, content, duration, start_date, end_date, director, description, image_path) VALUES
('Địa Đạo: Mặt Trời Trong Bóng Tối', 'Phim về cuộc chiến đấu anh dũng của quân và dân ta trong thời kỳ kháng chiến chống Mỹ', 120, '2024-03-01', '2024-05-30', 'Trần Bảo Sinh', 'Câu chuyện về những người lính đặc công trong hệ thống địa đạo Củ Chi.', 'images/diadao.jpg'),
('Thám Tử Kiên: Kỳ Án Không Đầu', 'Phim trinh thám hình sự Việt Nam', 110, '2024-03-15', '2024-06-15', 'Nguyễn Quang Dũng', 'Thám tử Kiên phải giải quyết một vụ án mạng bí ẩn với nạn nhân bị mất đầu.', 'images/thamtu.jpg'),
('Quật Mộ Trùng Ma (Exhuma)', 'Phim kinh dị Hàn Quốc', 134, '2024-03-20', '2024-06-20', 'Jang Jae-hyun', 'Câu chuyện về một nhóm thầy pháp phải đối mặt với những thế lực siêu nhiên khi khai quật một ngôi mộ cổ.', 'images/exhuma.jpg');

-- Insert sample genres
INSERT INTO genres (name) VALUES
('Hành động'),
('Trinh thám'),
('Kinh dị'),
('Chiến tranh'),
('Tâm lý');

-- Insert movie-genre relationships
INSERT INTO movie_genres (movie_id, genre_id) VALUES
(1, 1), -- Địa Đạo - Hành động
(1, 4), -- Địa Đạo - Chiến tranh
(2, 2), -- Thám Tử Kiên - Trinh thám
(2, 5), -- Thám Tử Kiên - Tâm lý
(3, 3), -- Exhuma - Kinh dị
(3, 5); -- Exhuma - Tâm lý

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
('SCH001', 1, 'T001', 120000, '2024-03-01', '10:00', '12:00'),
('SCH002', 2, 'T002', 150000, '2024-03-15', '14:00', '15:50'),
('SCH003', 3, 'T003', 130000, '2024-03-20', '19:00', '21:14');

-- Insert sample customers
INSERT INTO customers (customer_id, full_name, date_of_birth, address, phone_number, id_card, loyalty_points) VALUES
('C001', 'Nguyễn Văn A', '1990-01-01', '123 Nguyễn Huệ, HCM', '0123456789', '123456789', 100),
('C002', 'Trần Thị B', '1995-05-15', '456 Lê Lợi, HCM', '0987654321', '987654321', 50);

-- Insert sample orders
INSERT INTO orders (movie_id, show_date, created_at) VALUES
(1, '2024-03-01', CURRENT_TIMESTAMP),
(2, '2024-03-15', CURRENT_TIMESTAMP);

-- Insert sample tickets
INSERT INTO tickets (order_id, schedule_id, seat_id, status, price) VALUES
(1, 'SCH001', 'T001-1-1', 'sold', 120000),
(1, 'SCH001', 'T001-1-2', 'sold', 120000),
(2, 'SCH002', 'T002-1-1', 'sold', 150000);

-- Insert sample foods
INSERT INTO foods (name, description, price, category, image_path) VALUES
('Bắp rang', 'Bắp rang bơ thơm ngon', 45000, 'Snacks', 'images/bắp.jpg'),
('Coca Cola', 'Nước ngọt có ga', 25000, 'Drinks', 'images/coca.jpg'),
('Hot Dog', 'Hot dog truyền thống', 55000, 'Snacks', 'images/hotdog.jpg'); 
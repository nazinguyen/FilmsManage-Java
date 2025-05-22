package com.filmsmanage;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.sql.Statement;
import java.sql.ResultSet;

public class DatabaseUtil {
    private static final String DB_FILE = "movies.db";
    private static final String DB_URL = "jdbc:sqlite:" + DB_FILE;

    static {
        initializeDatabase();
    }

    private static void initializeDatabase() {
        try (Connection conn = getConnection()) {
            createMoviesTable(conn);
            createGenresTable(conn);
            createCustomersTable(conn);
            // Tạo bảng movie_genres cho quan hệ nhiều-nhiều
            createMovieGenresTable(conn);

            // Tạo bảng formats
            createFormatsTable(conn);

            // Tạo bảng schedules
            createSchedulesTable(conn);

            // Tạo bảng foods
            createFoodsTable(conn);

            // Tạo bảng staff
            createStaffTable(conn);

            // Xóa và tạo lại bảng orders
            try (Statement stmt = conn.createStatement()) {
                stmt.execute("DROP TABLE IF EXISTS orders");
            }
            createOrdersTable(conn);

            // Tạo bảng tickets
            createTicketsTable(conn);
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    private static void createMoviesTable(Connection conn) throws SQLException {
        String sql = "CREATE TABLE IF NOT EXISTS movies (" +
                    "id INTEGER PRIMARY KEY AUTOINCREMENT," +
                    "title TEXT NOT NULL," +
                    "content TEXT," +
                    "duration INTEGER," +
                    "start_date TEXT," +
                    "end_date TEXT," +
                    "director TEXT," +
                    "description TEXT," +
                    "image_path TEXT" +
                    ")";
        
        try (Statement stmt = conn.createStatement()) {
            stmt.execute(sql);
        }
    }

    private static void createGenresTable(Connection conn) throws SQLException {
        String sql = "CREATE TABLE IF NOT EXISTS genres (" +
                    "id INTEGER PRIMARY KEY AUTOINCREMENT," +
                    "name TEXT NOT NULL UNIQUE" +
                    ")";
        
        try (Statement stmt = conn.createStatement()) {
            stmt.execute(sql);
        }
    }

    private static void createCustomersTable(Connection conn) throws SQLException {
        String sql = "CREATE TABLE IF NOT EXISTS customers (" +
                    "customer_id VARCHAR(20) PRIMARY KEY," +
                    "full_name VARCHAR(100) NOT NULL," +
                    "date_of_birth DATE NOT NULL," +
                    "address VARCHAR(200) NOT NULL," +
                    "phone_number VARCHAR(20) NOT NULL," +
                    "id_card VARCHAR(20) NOT NULL UNIQUE," +
                    "loyalty_points INTEGER DEFAULT 0" +
                    ")";
        
        try (Statement stmt = conn.createStatement()) {
            stmt.execute(sql);
        }
    }

    private static void createMovieGenresTable(Connection conn) throws SQLException {
        String sql = "CREATE TABLE IF NOT EXISTS movie_genres (" +
                    "movie_id INTEGER," +
                    "genre_id INTEGER," +
                    "PRIMARY KEY (movie_id, genre_id)," +
                    "FOREIGN KEY (movie_id) REFERENCES movies(id)," +
                    "FOREIGN KEY (genre_id) REFERENCES genres(id)" +
                    ")";
        
        try (Statement stmt = conn.createStatement()) {
            stmt.execute(sql);
        }
    }

    private static void createFormatsTable(Connection conn) throws SQLException {
        String sql = "CREATE TABLE IF NOT EXISTS formats (" +
                    "id VARCHAR(20) PRIMARY KEY," +
                    "name VARCHAR(100) NOT NULL," +
                    "screen_id VARCHAR(20) NOT NULL," +
                    "FOREIGN KEY (screen_id) REFERENCES screens(id)" +
                    ")";
        
        try (Statement stmt = conn.createStatement()) {
            stmt.execute(sql);
        }
    }

    private static void createSchedulesTable(Connection conn) throws SQLException {
        String sql = "CREATE TABLE IF NOT EXISTS schedules (" +
                    "id VARCHAR(20) PRIMARY KEY," +
                    "movie_id INTEGER NOT NULL," +
                    "theater_id VARCHAR(20) NOT NULL," +
                    "original_price DECIMAL(10,2) NOT NULL," +
                    "show_date DATE NOT NULL," +
                    "start_time TIME NOT NULL," +
                    "end_time TIME NOT NULL," +
                    "FOREIGN KEY (movie_id) REFERENCES movies(id)," +
                    "FOREIGN KEY (theater_id) REFERENCES theaters(id)" +
                    ")";
        
        try (Statement stmt = conn.createStatement()) {
            stmt.execute(sql);
        }
    }

    private static void createFoodsTable(Connection conn) throws SQLException {
        String sql = "CREATE TABLE IF NOT EXISTS foods (" +
                    "id INTEGER PRIMARY KEY AUTOINCREMENT," +
                    "name VARCHAR(100) NOT NULL," +
                    "description TEXT," +
                    "price DECIMAL(10,2) NOT NULL," +
                    "category VARCHAR(50) NOT NULL," +
                    "image_path TEXT" +
                    ")";
        
        try (Statement stmt = conn.createStatement()) {
            stmt.execute(sql);
        }
    }

    private static void createOrdersTable(Connection conn) throws SQLException {
        String sql = "CREATE TABLE IF NOT EXISTS orders (" +
                    "id INTEGER PRIMARY KEY AUTOINCREMENT," +
                    "customer_id VARCHAR(20) NOT NULL," +
                    "movie_id INTEGER NOT NULL," +
                    "showtime_id VARCHAR(20) NOT NULL," +
                    "seat_number TEXT NOT NULL," +
                    "total_amount DECIMAL(10,2) NOT NULL," +
                    "order_date DATETIME DEFAULT CURRENT_TIMESTAMP," +
                    "FOREIGN KEY (customer_id) REFERENCES customers(customer_id)," +
                    "FOREIGN KEY (movie_id) REFERENCES movies(id)" +
                    ")";
        
        try (Statement stmt = conn.createStatement()) {
            stmt.execute(sql);
        }
    }

    private static void createTicketsTable(Connection conn) throws SQLException {
        String sql = "CREATE TABLE IF NOT EXISTS tickets (" +
                    "id INTEGER PRIMARY KEY AUTOINCREMENT," +
                    "order_id INTEGER NOT NULL," +
                    "schedule_id VARCHAR(20) NOT NULL," +
                    "seat_id VARCHAR(20) NOT NULL," +
                    "status VARCHAR(20) NOT NULL," +
                    "price DECIMAL(10,2) NOT NULL," +
                    "created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP," +
                    "FOREIGN KEY (order_id) REFERENCES orders(id)," +
                    "FOREIGN KEY (schedule_id) REFERENCES schedules(id)" +
                    ")";
        
        try (Statement stmt = conn.createStatement()) {
            stmt.execute(sql);
        }
    }

    private static void createStaffTable(Connection conn) throws SQLException {
        try (Statement stmt = conn.createStatement()) {
            stmt.execute("""
                CREATE TABLE IF NOT EXISTS staff (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    name TEXT NOT NULL,
                    username TEXT UNIQUE NOT NULL,
                    password TEXT NOT NULL,
                    role TEXT NOT NULL
                )
            """);
            
            // Thêm tài khoản admin mặc định nếu bảng rỗng
            ResultSet rs = stmt.executeQuery("SELECT COUNT(*) FROM staff");
            if (rs.next() && rs.getInt(1) == 0) {
                stmt.execute("""
                    INSERT INTO staff (name, username, password, role)
                    VALUES ('Admin', 'admin', 'admin123', 'ADMIN'),
                           ('Staff', 'staff', 'staff123', 'STAFF')
                """);
            }
        }
    }

    public static Connection getConnection() throws SQLException {
        return DriverManager.getConnection(DB_URL);
    }
} 
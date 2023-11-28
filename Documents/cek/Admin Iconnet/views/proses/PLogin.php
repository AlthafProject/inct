<?php
session_start();

include "../../koneksi.php"; // Adjust the path based on your file structure

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    // Get the input data from the form
    $kode = $_POST['kode_admin'];
    $password = $_POST['password'];

    // Validate and sanitize the input (you may add more validation)
    $username = strip_tags(trim($kode));
    $password = strip_tags(trim($password));

    // Query to check user credentials
    $query = "SELECT * FROM user WHERE kode_admin='$username'";
    $result = $conn->query($query);
    

    if ($result->num_rows == 1) {
        // User found, check the password
        $row = $result->fetch_assoc();

        // Basic password hashing for demonstration purposes
        if ($password === $row['password']) {
            // Login successful
            $_SESSION['username'] = $username;
            header("Location: ../menu.php");
            exit();
        } else {
            // Incorrect password
            echo "Login failed. Check your username and password.";
        }
    } else {
        // User not found
        echo "User not found.";
    }
}

$conn->close();
?>

<?php
// Mulai sesi
session_start();

// Periksa apakah pengguna sudah login
if (!isset($_SESSION['username'])) {
    // Jika belum login, arahkan ke halaman login
    header("Location: views/login.php");
    exit(); // Pastikan untuk keluar setelah mengarahkan ke halaman login
}

// Jika pengguna sudah login, Anda dapat melanjutkan eksekusi skrip di sini

// Misalnya, tampilkan pesan selamat datang


// Jangan lupa untuk menutup tag PHP jika tidak ada HTML setelahnya
?>

<?php
// Contoh koneksi ke database
$conn = new mysqli("localhost", "root", "", "iconnet");

// Pastikan koneksi berhasil
if ($conn->connect_error) {
    die("Koneksi database gagal: " . $conn->connect_error);
}

?>

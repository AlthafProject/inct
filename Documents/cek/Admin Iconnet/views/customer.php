<?php
include "../koneksi.php"; // Include your database connection file

// Check if the connection is successful
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}

// CRUD operations
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    // Create operation
    if (isset($_POST["email"]) && isset($_POST["name"]) && isset($_POST["nik"]) && isset($_POST["phone"]) && isset($_POST["meter_code"]) && isset($_POST["address"]) && isset($_POST["village"]) && isset($_POST["subdistrict"]) && isset($_POST["city"]) && isset($_POST["location"]) && isset($_POST["service"]) && isset($_POST["status"]) && isset($_POST["updated_at"])) {

        // Sanitize input data to prevent SQL injection
        $email = mysqli_real_escape_string($conn, $_POST["email"]);
        $name = mysqli_real_escape_string($conn, $_POST["name"]);
        $nik = mysqli_real_escape_string($conn, $_POST["nik"]);
        $phone = mysqli_real_escape_string($conn, $_POST["phone"]);
        $meter_code = mysqli_real_escape_string($conn, $_POST["meter_code"]);
        $address = mysqli_real_escape_string($conn, $_POST["address"]);
        $village = mysqli_real_escape_string($conn, $_POST["village"]);
        $subdistrict = mysqli_real_escape_string($conn, $_POST["subdistrict"]);
        $city = mysqli_real_escape_string($conn, $_POST["city"]);
        $location = mysqli_real_escape_string($conn, $_POST["location"]);
        $service = mysqli_real_escape_string($conn, $_POST["service"]);
        $status = mysqli_real_escape_string($conn, $_POST["status"]);
        $updated_at = mysqli_real_escape_string($conn, $_POST["updated_at"]);

        // Use prepared statements to prevent SQL injection
      // Use prepared statements to prevent SQL injection
// Use prepared statements to prevent SQL injection
$stmt = $conn->prepare("INSERT INTO pelanggan (email, name, nik, no_hp, kd_meteran, alamat, kelurahan, kecamatan, kota, lokasi, layanan, status, updated_at) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)");

$stmt->bind_param("sssssssssssss", $email, $name, $nik, $phone, $meter_code, $address, $village, $subdistrict, $city, $location, $service, $status, $updated_at);

if ($stmt->execute()) {
    echo "Data inserted successfully";
} else {
    echo "Error: " . $stmt->error;
}

$stmt->close();
// Close the prepared statement

    }
}

$conn->close(); // Close the database connection
?>


<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Data Management</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            color: #333;
        }

        h2 {
            color: #004080;
        }

        form {
            margin-bottom: 20px;
        }

        table {
            width: 100%;
            border-collapse: collapse;
            margin-top: 10px;
        }

        th, td {
            border: 1px solid #ddd;
            padding: 10px;
            text-align: left;
        }

        th {
            background-color: #004080;
            color: #fff;
        }

        input[type="text"] {
            width: 70%;
            padding: 8px;
            margin-right: 5px;
        }

        input[type="submit"], input[type="button"] {
            padding: 8px 15px;
            background-color: #004080;
            color: #fff;
            border: none;
            border-radius: 4px;
            cursor: pointer;
        }

        input[type="submit"]:hover, input[type="button"]:hover {
            background-color: #003366;
        }
        h2 {
            color: #004080;
        }

        form {
            margin-bottom: 20px;
        }

        form, h1, table{
            margin-left:10px;
        }

        label {
            display: block;
            margin-bottom: 8px;
        }

        input, select {
            width: 100%;
            padding: 10px;
            margin-bottom: 15px;
            box-sizing: border-box;
        }

        input[type="submit"] {
            padding: 10px 15px;
            background-color: #004080;
            color: #fff;
            border: none;
            border-radius: 4px;
            cursor: pointer;
        }

        input[type="submit"]:hover {
            background-color: #003366;
        }
    </style>
</head>
<body>
    <div class="container">
    <H1>Input Data Pelanggan</H1> <br>
    <form action="#" method="post">
    <label for="email">Email:</label>
    <input type="email" id="email" name="email" required>

    <label for="name">Nama:</label>
    <input type="text" id="name" name="name" required>

    <label for="nik">NIK:</label>
    <input type="text" id="nik" name="nik" required>

    <label for="phone">Nomor HP:</label>
    <input type="tel" id="phone" name="phone" required>

    <label for="meter_code">Kode Meteran:</label>
    <input type="text" id="meter_code" name="meter_code" required>

    <label for="address">Alamat:</label>
    <input type="text" id="address" name="address" required>

    <label for="village">Kelurahan:</label>
    <input type="text" id="village" name="village" required>

    <label for="subdistrict">Kecamatan:</label>
    <input type="text" id="subdistrict" name="subdistrict" required>

    <label for="city">Kota:</label>
    <input type="text" id="city" name="city" required>

    <label for="location">Lokasi:</label>
    <input type="text" id="location" name="location" required>

    <label for="service">Layanan:</label>
    <select id="service" name="service">
        <option value="10 Mbps">10 Mbps</option>
        <option value="20 Mbps">20 Mbps</option>
        <option value="50 Mbps">50 Mbps</option>
        <option value="100 Mbps">100 Mbps</option>
        <!-- Tambahkan pilihan layanan lainnya sesuai kebutuhan -->
    </select>

    <label for="status">Status:</label>
    <!-- <select id="status" name="status" >
        <option value="active">Aktif</option>
        <option value="inactive">Nonaktif</option>
    </select> -->
    <input type="text" name="status" id="" readonly value="Proses">

    <label for="updated_at">Update At:</label>
    <input type="text" id="updated_at" name="updated_at" value="<?php echo date('Y-m-d'); ?>" readonly>

    <input type="submit" name="register" value="Register">
</form>

    <hr>
    <h1>Data Management</h1> <br>

        <form action="#" method="post">
            <input type="text" name="search" placeholder="Cari data...">
            <input type="submit" value="Cari" name="src">
        </form>
        <br>
        <table>
            <thead>
                <tr>
                    <th>ID</th>
                    <th>Email</th>
                    <th>Nama</th>
                    <th>NIK</th>
                    <th>Nomor HP</th>
                    <th>Kode Meteran</th>
                    <th>Alamat</th>
                    <th>Kelurahan</th>
                    <th>Kecamatan</th>
                    <th>Kota</th>
                    <th>Lokasi</th>
                    <th>Layanan</th>
                    <th>Status</th>
                    <th>Update At</th>
                    <th>Action</th>
                </tr>
            </thead>
            <tbody>
            <?php
include "../koneksi.php";

// Handle delete operation
if ($_SERVER["REQUEST_METHOD"] == "GET" && isset($_GET["action"]) && $_GET["action"] === "delete" && isset($_GET["id"])) {
    $id = mysqli_real_escape_string($conn, $_GET["id"]);
    
    // Use prepared statement to prevent SQL injection
    $stmt = $conn->prepare("DELETE FROM pelanggan WHERE id_pelanggan = ?");
    $stmt->bind_param("s", $id);

    if ($stmt->execute()) {
        echo "";
    } else {
        echo "Error: " . $stmt->error;
    }

    $stmt->close();
}



// Handle update status operation
if ($_SERVER["REQUEST_METHOD"] == "GET" && isset($_GET["action"]) && $_GET["action"] === "update_status" && isset($_GET["id"])) {
    $id = mysqli_real_escape_string($conn, $_GET["id"]);
    
    // Use prepared statement to prevent SQL injection
    $stmt = $conn->prepare("UPDATE pelanggan SET status = 'Success' WHERE id_pelanggan = ?");
    $stmt->bind_param("s", $id);

    if ($stmt->execute()) {
        echo "Status updated successfully";
    } else {
        echo "Error: " . $stmt->error;
    }

    $stmt->close();
}

// Fetch data for display
$sql = "SELECT id_pelanggan, email, name, nik, no_hp, kd_meteran, alamat, kelurahan, kecamatan, kota, lokasi, layanan, status, updated_at FROM pelanggan";
$result = $conn->query($sql);

if ($result->num_rows > 0) {
    while ($row = $result->fetch_assoc()) {
        echo "<tr>
                <td>" . $row["id_pelanggan"] . "</td>
                <td>" . $row["email"] . "</td>
                <td>" . $row["name"] . "</td>
                <td>" . $row["nik"] . "</td>
                <td>" . $row["no_hp"] . "</td>
                <td>" . $row["kd_meteran"] . "</td>
                <td>" . $row["alamat"] . "</td>
                <td>" . $row["kelurahan"] . "</td>
                <td>" . $row["kecamatan"] . "</td>
                <td>" . $row["kota"] . "</td>
                <td>" . $row["lokasi"] . "</td>
                <td>" . $row["layanan"] . "</td>
                <td>" . $row["status"] . "</td>
                <td>" . $row["updated_at"] . "</td>
                <td>
                    <a href='#' onclick='confirmDelete(" . $row["id_pelanggan"] . ")' >Delete</a>
                    <a href='#' onclick='confirmUpdateStatus(" . $row["id_pelanggan"] . ")'>Status</a>
                </td>
            </tr>";
    }
} else {
    echo "<tr><td colspan='13'>No data available</td></tr>";
}
?>

<script>
    function confirmUpdateStatus(id) {
        var confirmUpdate = confirm("Are you sure you want to update the status to Success?");
        if (confirmUpdate) {
            window.location.href = 'menu.php?open=customer&action=update_status&id=' + id;
        }
    }

    function confirmDelete(id) {
        var confirmDelete = confirm("Are you sure you want to delete this data?");
        if (confirmDelete) {
            window.location.href = 'menu.php?open=customer&action=delete&id=' + id;
        }
    }
</script>



            </tbody>
        </table>
        </div>
</body>
</html>

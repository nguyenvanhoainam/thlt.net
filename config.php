<?php
$servername = "localhost"; // Địa chỉ máy chủ
$username = "username"; // Tên người dùng
$password = "password"; // Mật khẩu
$dbname = "database_name"; // Tên cơ sở dữ liệu

// Kết nối tới cơ sở dữ liệu
$conn = mysqli_connect($servername, $username, $password, $dbname);

// Kiểm tra kết nối
if (!$conn) {
    die("Kết nối thất bại: " . mysqli_connect_error());
}
?>

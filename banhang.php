<?php
session_start();
include 'config.php'; // Kết nối cơ sở dữ liệu

// Truy vấn danh sách sản phẩm
$query = "SELECT * FROM products";
$result = mysqli_query($conn, $query);
?>

<!DOCTYPE html>
<html lang="vi">
<head>
    <meta charset="UTF-8">
    <title>Trang Bán Hàng</title>
</head>
<body>
    <h1>Danh Sách Sản Phẩm</h1>
    <table border="1">
        <tr>
            <th>Mã sản phẩm</th>
            <th>Tên sản phẩm</th>
            <th>Giá</th>
            <th>Thao tác</th>
        </tr>
        <?php while ($row = mysqli_fetch_assoc($result)): ?>
        <tr>
            <td><?php echo $row['id']; ?></td>
            <td><?php echo $row['name']; ?></td>
            <td><?php echo number_format($row['price'], 0, ',', '.'); ?> VNĐ</td>
            <td>
                <a href="add_cart.php?id=<?php echo $row['id']; ?>">Thêm vào giỏ hàng</a>
            </td>
        </tr>
        <?php endwhile; ?>
    </table>
</body>
</html>

<?php
session_start();
include 'config.php'; // Kết nối cơ sở dữ liệu

// Khởi tạo giỏ hàng nếu chưa có
if (!isset($_SESSION['cart'])) {
    $_SESSION['cart'] = [];
}

// Kiểm tra xem sản phẩm có được gửi không
if (isset($_GET['id'])) {
    $productId = $_GET['id'];

    // Kiểm tra xem sản phẩm đã có trong giỏ hàng chưa
    if (array_key_exists($productId, $_SESSION['cart'])) {
        $_SESSION['cart'][$productId]++; // Tăng số lượng sản phẩm
    } else {
        $_SESSION['cart'][$productId] = 1; // Thêm sản phẩm mới vào giỏ hàng
    }
}

// Hiển thị giỏ hàng
echo "<h1>Giỏ Hàng</h1>";
if (empty($_SESSION['cart'])) {
    echo "Giỏ hàng của bạn đang trống.";
} else {
    echo "<table border='1'>
            <tr>
                <th>Mã sản phẩm</th>
                <th>Số lượng</th>
            </tr>";
    foreach ($_SESSION['cart'] as $id => $quantity) {
        echo "<tr>
                <td>$id</td>
                <td>$quantity</td>
              </tr>";
    }
    echo "</table>";
}

echo '<a href="banhang.php">Quay lại trang bán hàng</a>';
?>

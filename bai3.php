<?php
$tenChuHo = "";
$chiSoCu = "";
$chiSoMoi = "";
$donGia = 2000; 
$thanhTien = "";

if ($_SERVER["REQUEST_METHOD"] == "POST") {
   $tenChuHo = $_POST['tenChuHo'] ;
   $chiSoCu = $_POST['chiSoCu'] ;
   $chiSoMoi = $_POST['chiSoMoi'] ;

   $thanhTien = ($chiSoMoi - $chiSoCu) * $donGia;
}
?>

<!DOCTYPE html>
<html lang="vi">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Thanh toán tiền điện</title>
</head>
<body>
    <style>
        div{
            width: 100%;
            background-color: yellow;
            height: 30px;
        }
        h2{
            margin-top: 0px;
            color: red;
        }
        *{
			padding: 0;
			margin: 20;		
			box-sizing: border-box;
		}
		form{
			margin: auto;
			border: 1px solid #000;
			text-align: center;
			width: 30%;
			height: 60%;
            background-color: pink;
		}
    </style>
    
    <form action="" method="post" name="formDienTich">
        <div><i><h2>Thanh toán tiền điện</h2></i></div>
        <label>Tên chủ hộ:</label>
        <input type="text" name="tenChuHo" value="<?php echo $tenChuHo; ?>"required>
        <br>

        <label>Chỉ số cũ:</label>
        <input type="number" name="chiSoCu" value="<?php echo $chiSoCu; ?>"required>
        <label>(KW)</label>
        <br>

        <label>Chỉ số mới:</label>
        <input type="number" name="chiSoMoi" value="<?php echo $chiSoMoi; ?>"required>
        <label>(KW)</label>
        <br>

        <label>Đơn giá:</label>
        <input type="number" name="donGia" value="<?php echo $donGia; ?>">
        <label>(VNĐ)</label>
        <br>

        <label>Số tiền thanh toán:</label>
        <input type="text" name="thanhTien" value="<?php echo $thanhTien; ?>"readonly>
        <label>(VNĐ)</label>
        <br>
        <button type="submit">Tính</button>
    </form>
</body>
</html>
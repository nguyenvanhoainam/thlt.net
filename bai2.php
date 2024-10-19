<?php
$banKinh = "";
$dienTich = "";
$chuVi = "";

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $banKinh = $_POST['banKinh'] ;
    $pi = 3.14;

    $dienTich = $pi * pow($banKinh, 2);
    $chuVi = 2 * $pi * $banKinh; 
}
?>

<!DOCTYPE html>
<html lang="vi">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Tính Diện Tích Hình Chữ Nhật</title>
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
        <div><i><h2>Diện Tích Và Chu Vi Hình Tròn</h2></i></div>
        <label>Bán kính:</label>
        <input type="text" name="banKinh" value="<?php echo $banKinh; ?>"required>
        <br>

        <label>Diện tích:</label>
        <input type="text" name="dienTich" value="<?php echo $dienTich; ?>"readonly>
        <br>

        <label>Chu vi:</label>
        <input type="text" name="chuVi" value="<?php echo $chuVi; ?>"readonly>
        <br>    
        <button type="submit">Tính</button>
    </form>
</body>
</html>
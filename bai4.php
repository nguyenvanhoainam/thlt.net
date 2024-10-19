<?php
$cạnhA = "";
$cạnhB = "";
$cạnhHuyen = "";

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $cạnhA = $_POST['cạnhA'] ;
    $cạnhB = $_POST['cạnhB'] ;

    // Tính cạnh huyền
    $cạnhHuyen = sqrt(pow($cạnhA, 2) + pow($cạnhB, 2));
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
        <div><i><h2>Tính Cạnh Huyền Tam Giác</h2></i></div>
        <label>Cạnh A:</label>
        <input type="text" name="cạnhA" value="<?php echo $cạnhA; ?>"required>
        <br>

        <label>Cạnh B:</label>
        <input type="text" name="cạnhB" value="<?php echo $cạnhB; ?>"required>
        <br>

        <label>Cạnh Huyền:</label>
        <input type="text" name="cạnhHuyen" value="<?php echo $cạnhHuyen; ?>" readonly>
        <br>    
        <button type="submit">Tính</button>
    </form>
</body>
</html>
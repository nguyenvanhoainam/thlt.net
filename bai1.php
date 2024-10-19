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
    
    <form method="post" action="">
        <div><i><h2>Tính Diện Tích Hình Chữ Nhật</h2></i></div>
        <label for="dai">Chiều dài:</label>
        <input type="number" name="dai" id="dai" required>
        <br>
        
        <label for="rong">Chiều rộng:</label>
        <input type="number" name="rong" id="rong" required>
        <br>
        <?php
    
        $dt = ""; 
        if ($_SERVER["REQUEST_METHOD"] == "POST") {
        $dai = $_POST['dai'] ; 
        $rong = $_POST['rong']; 

        $dt = $dai * $rong;
        }
        ?>
        <label for="dien_tich">Diện tích:</label>
        <input type="text" id="dien_tich" value="<?php echo $dt; ?>" readonly> <br>
        <input type="submit" value="Tính">
    </form>

    
</body>
</html>
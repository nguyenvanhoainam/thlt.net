
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
<style>
        div {
            background-color: yellow;
            height: 30px;
        }
        h2 {
            margin-top: 0px;
            color: blue;
        }
        * {
            padding: 0;
            margin: 20;        
            box-sizing: border-box;
        }
        form {
            margin: auto;
            border: 1px solid #000;
            text-align: center;
            width: 30%;
            height: 30%;
            background-color: pink;
        }
    </style>
    <form action="" method="post" >
        <div><h2>CHÀO THEO GIỜ</h2></div>
        <label for="hour">Nhập giờ:</label>
        <input type="text" id="hour" name="hour" min="1" max="24"  >
        <br>
        <?php
        if ($_SERVER["REQUEST_METHOD"] == "POST") {
            
            $hour = intval($_POST['hour']);

            if ($hour > 0 && $hour <= 12) {
                echo "<h2>Chào buổi sáng!</h2>";
            } elseif ($hour > 12 && $hour <= 17 ) {
                echo "<h2>Chào buổi chiều!</h2>";
            }elseif ($hour > 17 && $hour <= 24 ) {
                echo "<h2>Chào buổi tối!</h2>";
            }  else {
                echo "<h2>Giờ không hợp lệ! Vui lòng nhập giờ từ 0 đến 23.</h2>";
            }
        }
        ?>
        <button type="submit">Chào</button>
    </form>
    
</body>
</html>
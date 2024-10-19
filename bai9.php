<?php 
$a = "";
$b = "";
$result = "";

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $a = $_POST['a'] ;
    $b = $_POST['b'] ;

    if ($a == 0) {
        if ($b == 0) {
            $result = "Phương trình có vô số nghiệm";
        } else {
            $result = "Phương trình vô nghiệm";
        }
    } else {
        $x = -$b / $a;
        $result = " x = " . $x;
    }
}
?>

<!DOCTYPE html>
<html lang="vi">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Giải Phương Trình Bậc Nhất</title>
</head>
<body>
    <style>
        div {
            width: 100%;
            background-color: yellow;
            height: 30px;
        }
        h2 {
            margin-top: 0px;
            color: red;
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
            width: 35%;
            height: 60%;
            background-color: pink;
        }
        .in{
            width: 40px;
        }
        .in1{
            width: 35%;
        }
    </style>
    
    <form action="" method="post" name="formGiaiPT">
        <div><i><h2>Giải Phương Trình Bậc Nhất</h2></i></div>
        <label for="a">Phương trình:</label>
        <input class="in" type="text" id="a" name="a" value="<?php echo $a; ?>">
        <label for="a">x +</label>
        <input class="in" type="text" id="b" name="b" value="<?php echo $b; ?>">
        <label for="a">= 0</label>
        <br><br>
        <label for="result">Nghiệm:</label>
        <input class="in1" type="text" name="result" value="<?php echo $result; ?>" readonly>        
        <br><br>
        <button type="submit">Giải Phương Trình</button>
    </form>
</body>
</html>

<!DOCTYPE html>
<html lang="vi">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Các Số Chia Hết</title>
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
            width: 30%;
            height: 60%;
            background-color: pink;
        }
    </style>

    <form method="post" action="">
        <div><i><h2>Các Số Chia Hết Cho A và B</h2></i></div>
        <label for="n">Nhập N:</label>
        <input type="number" name="n" id="n" required>
        <br>

        <label for="a">Nhập A:</label>
        <input type="number" name="a" id="a" required>
        <br>

        <label for="b">Nhập B:</label>
        <input type="number" name="b" id="b" required>
        <br>

        <?php
        function kt_so($so, $a, $b) {
            return ($so % $a == 0 && $so % $b == 0) ? 1 : 0;
        }

        if ($_SERVER["REQUEST_METHOD"] == "POST") {
            $n = $_POST['n'];
            $a = $_POST['a'];
            $b = $_POST['b'];
            $chuoi = "";

            for ($i = 1; $i <= $n; $i++) {
                if (kt_so($i, $a, $b) == 1) {
                    $chuoi .= $i . " ";
                }
            }
            echo "Các số <= N chia hết cho A và B là: " . (isset($chuoi) ? $chuoi : '');
        }
        
        ?>
        <br>
        <input type="submit" value="Các số chia hết cho A và B">
    </form>

    
</body>
</html>

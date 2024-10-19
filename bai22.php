

<!DOCTYPE html>
<html lang="vi">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Giải Phương Trình Bậc Hai</title>
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
        .in {
            width: 40px;
        }
        .in1 {
            width: 300px;
        }
    </style>
</head>
<body>
    <form action="" method="post" name="formGiaiPT">
        <div><i><h2>Giải Phương Trình Bậc Hai</h2></i></div>
        <label for="a">Phương trình:</label>
        <input class="in" type="text" id="a" name="a"  required>
        <label for="a">x<sup>2</sup> + </label>
        <input class="in" type="text" id="b" name="b"  required>
        <label for="b">x + </label>
        <input class="in" type="text" id="c" name="c"  required>
        <label for="c">= 0</label>
        <br>
        <?php
        $a = "";
        $b = "";
        $c = "";
        $result = "";

        function giai_ptb1($b, $c) {
            if ($b == 0) {
                return ($c == 0) ? "Phương trình có vô số nghiệm" : "Phương trình vô nghiệm";
            }
            return "Nghiệm: x = " . (-$c / $b);
        }

        function giai_ptb2($a, $b, $c) {
            if ($a == 0) {
                return giai_ptb1($b, $c);
            } else {
                $delta = $b * $b - 4 * $a * $c;
                if ($delta < 0) {
                    return "Phương trình vô nghiệm";
                } elseif ($delta == 0) {
                    $x = -$b / (2 * $a);
                    return "Phương trình có nghiệm kép: x1 = x2 = " . $x;
                } else {
                    $x1 = (-$b + sqrt($delta)) / (2 * $a);
                    $x2 = (-$b - sqrt($delta)) / (2 * $a);
                    return "Hai nghiệm p/b : x1 = " . $x1 . ", x2 = " . $x2;
                }
            }
        }

        if ($_SERVER["REQUEST_METHOD"] == "POST") {
            $a = $_POST['a'];
            $b = $_POST['b'];
            $c = $_POST['c'];
            $result = giai_ptb2($a, $b, $c);
        }
        ?><br>
        <label for="result">Nghiệm:</label>
        <input class="in1" type="text" name="result" value="<?php echo $result; ?>" readonly>        
        <br><br>
        <button type="submit">Giải Phương Trình</button>
    </form>
</body>
</html>

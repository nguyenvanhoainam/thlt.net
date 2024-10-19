<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <style>
        *{
            box-sizing: border-box;
        }
        form{
            margin: auto;
            border: solid 1px;
            width: 200px;
            text-align: center;
        }
        div{
        }
    </style>
    <form action="" method="post">
        <div><h1>kết quả học tập</h1></div>
        <label for="hk1">Điểm học kì 1</label><br>
        <input type="number" name="hk1" id="hk1">
        <label for="hk2">Điểm học kì 2</label>
        <input type="number" name="hk2" id="hk2"><br>
        <?php
            $hk1 = "";
            $hk2 = "";
            $tb = "";
            $kq = "";
            $xl = "";
            if($_SERVER["REQUEST_METHOD"] == "POST"){
                $hk1 = floatval($_POST['hk1']);
                $hk2 = floatval($_POST['hk2']);
                $tb = ($hk1 + $hk2 * 2)/3;
                $kq = ($tb >= 5) ? "đc lên lớp":"ở lại lớp";
                if($tb>=8){
                    $xl = "giỏi";
                }elseif($tb>6.5){
                    $xl= "khá";
                }elseif($tb>=5){
                    $xl = "trung bình";
                }else{
                    $xl= " yếu";
                }
            } 
        ?>
        <br>
        <label for="tb">Điểm trung bình</label>
        <input type="number" name="tb" id="tb" value="<?php echo $tb; ?>" readonly ><br>
        <label for="kq">Kết quả</label>
        <input type="text" name="kq" id="kq"value="<?php echo $kq; ?>" readonly><br>
        <label for="xl">Xếp loại</label>
        <input type="text" name="xl" id="xl"value="<?php echo $xl; ?>" readonly><br>
        <button type="submit">kết quả </button>

    </form>
</body>
</html>
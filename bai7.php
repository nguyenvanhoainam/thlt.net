

<!DOCTYPE html>
<html lang="vi">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Kết Quả Học Tập</title>
    <style>
        div {
            width: 100%;
            background-color: yellow;
            height: 30px;
            border-radius: 10px 10px 0 0 ;
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
            height: auto;
            background-color: pink;
            border-radius: 10px;
        }
    </style>
</head>
<body>
    <form action="" method="post">
        <div><h2>Kết Quả Học Tập</h2></div>
        
        <label>Điểm HK1:</label>
        <input type="number" name="diemHK1"  required>
        <br>

        <label>Điểm HK2:</label>
        <input type="number" name="diemHK2"  required>
        <br> 
        <?php  
        $diemHK1 = "";
        $diemHK2 = "";
        $dtb = "";
        $result = "";
        $xepLoai = "";

        if ($_SERVER["REQUEST_METHOD"] == "POST") {
            $diemHK1 = floatval($_POST['diemHK1'] );
            $diemHK2 = floatval($_POST['diemHK2'] );
            

            $dtb = ($diemHK1 + $diemHK2 * 2) / 3;

        
            $result = ($dtb >= 5) ? "Được lên lớp" : "Ở lại lớp";

            
            if ($dtb >= 8) {
                $xepLoai = "Giỏi";
            } elseif ($dtb >= 6.5) {
                $xepLoai = "Khá";
            } elseif ($dtb >= 5) {
                $xepLoai = "Trung bình";
            } else {
                $xepLoai = "Yếu";
            }
            
        }
        ?>
            <label>Điểm Trung Bình:</label>
            <input type="text" name="dtb" value="<?php echo $dtb; ?>" readonly>
            <br>

            <label>Kết Quả:</label>
            <input type="text" name="result" value="<?php echo $result; ?>" readonly>
            <br>

            <label>Xếp Loại Học Lực:</label>
            <input type="text" name="xepLoai" value="<?php echo $xepLoai; ?>" readonly>
            <br>

        <button type="submit">Xem Kết Quả</button>
    </form>
</body>
</html>

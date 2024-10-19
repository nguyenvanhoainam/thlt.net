

<!DOCTYPE html>
<html lang="vi">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Kết Quả Thi Đại Học</title>
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
            height: auto;
            background-color: pink;
        }
    </style>
</head>
<body>
    <form action="" method="post">
        <div><h2>Kết Quả Thi Đại Học</h2></div>
        
        <label>Điểm Toán:</label>
        <input type="number" name="diemToan" value="<?php echo $diemToan; ?>" required>
        <br>

        <label>Điểm Lý:</label>
        <input type="number" name="diemLy" value="<?php echo $diemLy; ?>" required>
        <br>

        <label>Điểm Hóa:</label>
        <input type="number" name="diemHoa" value="<?php echo $diemHoa; ?>" required>
        <br>

        <label>Điểm Chuẩn:</label>
        <input type="number" name="diemChuan" value="<?php echo $diemChuan; ?>" required>
        <br>
            <?php  
            $diemToan = "";
            $diemLy = "";
            $diemHoa = "";
            $diemChuan = "";
            $tongDiem = "";
            $ketQua = ""; 

            if ($_SERVER["REQUEST_METHOD"] == "POST") {
                $diemToan = floatval($_POST['diemToan'] );
                $diemLy = floatval($_POST['diemLy'] );
                $diemHoa = floatval($_POST['diemHoa'] );
                $diemChuan = floatval($_POST['diemChuan'] );
                
                $tongDiem = $diemToan + $diemLy + $diemHoa;

                if ($diemToan > 0 && $diemLy > 0 && $diemHoa > 0 && $tongDiem >= $diemChuan) {
                    $ketQua = "Đậu";
                } else {
                    $ketQua = "Rớt";
                }
                
            }
            ?>
            <label>Tổng Điểm:</label>
            <input type="text" name="tongDiem" value="<?php echo $tongDiem; ?>" readonly>
            <br>

            <label>Kết Quả Thi:</label>
            <input type="text" name="ketQua" value="<?php echo $ketQua; ?>" readonly>
            <br>

        <button type="submit">Xem Kết Quả</button>
    </form>
</body>
</html>

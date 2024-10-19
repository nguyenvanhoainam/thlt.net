<!DOCTYPE html>
<html lang="vi">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Tìm thứ trong tuần</title>
</head>
<body>
    <h1>Tìm thứ trong tuần</h1>
    <form method="post" action="">
        <label for="ngay">Ngày:</label>
        <input type="number" name="ngay" required min="1" max="31">
        <br>
        <label for="thang">Tháng:</label>
        <input type="number" name="thang" required min="1" max="12">
        <br>
        <label for="nam">Năm:</label>
        <input type="number" name="nam" required>
        <br>
        <button type="submit">Tìm thứ trong tuần</button>
        <br><br>
        <label for="thu">Thứ:</label>
        <input type="text" name="thu" value="<?php if (isset($thu)) echo $thu; ?>" readonly>
    </form>

    <?php
    if ($_SERVER["REQUEST_METHOD"] == "POST") {
        $ngay = $_POST['ngay'];
        $thang = $_POST['thang'];
        $nam = $_POST['nam'];
        $thu = "";

        // Tính số ngày Julian
        $jd = cal_to_jd(CAL_GREGORIAN, $thang, $ngay, $nam);
        // Lấy thứ trong tuần (0: Chủ nhật, 1: Thứ hai, ..., 6: Thứ bảy)
        $day = jddayofweek($jd, 0);

        // Đọc thứ trong tuần
        switch ($day) {
            case 0:
                $thu = "Chủ nhật";
                break;
            case 1:
                $thu = "Thứ hai";
                break;
            case 2:
                $thu = "Thứ ba";
                break;
            case 3:
                $thu = "Thứ tư";
                break;
            case 4:
                $thu = "Thứ năm";
                break;
            case 5:
                $thu = "Thứ sáu";
                break;
            case 6:
                $thu = "Thứ bảy";
                break;
        }
    }
    ?>
</body>
</html>

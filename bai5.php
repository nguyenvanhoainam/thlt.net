<?php 
$soA = "";
$soB = "";
$solonhon = "";

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $soA = $_POST['cạnhA'] ;
    $soB = $_POST['cạnhB'] ;

    $solonhon = max($soA, $soB);
}
?>

<!DOCTYPE html>
<html lang="vi">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Tìm Số Lớn Hơn</title>
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
    
    <form action="" method="post" name="formTimSoLonNhat">
        <div><i><h2>Tìm Số Lớn Nhất</h2></i></div>
        <label>Cạnh A:</label>
        <input type="text" name="cạnhA" value="<?php echo htmlspecialchars($soA); ?>"required>
        <br>

        <label>Cạnh B:</label>
        <input type="text" name="cạnhB" value="<?php echo htmlspecialchars($soB); ?>"required>
        <br>

        <label>Số Lớn Hơn:</label>
        <input type="text" name="sốLớnNhất" value="<?php echo htmlspecialchars($solonhon); ?>" readonly>
        <br>    
        <button type="submit">Tìm</button>
    </form>
</body>
</html>
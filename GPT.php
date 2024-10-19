<!DOCTYPE html>
<html>
<head>
  <title>Tính Năm Âm Lịch</title>
  <style>
    body {
      font-family: Arial, sans-serif;
      background-color: #f0f8ff;
      display: flex;
      justify-content: center;
      align-items: center;
      height: 900px;
      margin: 0;
    }
    .container {
      background-color: #0066cc;
      color: white;
      padding: 20px;
      border-radius: 10px;
      text-align: center;
      width: 400px;
    }
    .container h2 {
      font-size: 24px;
      margin: 0;
    }
    .form-group {
      margin-top: 20px;
    }
    .form-group label {
      font-weight: bold;
    }
    .form-group input[type="text"] {
      padding: 5px;
      border: 1px solid #ccc;
      border-radius: 5px;
      width: 150px;
      text-align: center;
    }
    .form-group input[readonly] {
      background-color: #e0e0e0;
      color: black;
    }
    .button {
      margin-top: 10px;
    }
    .button button {
      padding: 5px 20px;
      background-color: #ff9933;
      color: white;
      border: none;
      border-radius: 5px;
      cursor: pointer;
    }
    .button button:hover {
      background-color: #cc7a00;
    }
  </style>
</head>
<body>
  <div class="container">
    <h2>TÍNH NĂM ÂM LỊCH</h2>
    <form name="formTinhNamAmLich" method="post" action="">
      <div class="form-group">
        <label for="namDuong">Năm dương lịch:</label>
        <input type="text" id="namDuong" name="namDuong" placeholder="2007">
      </div>
      <div class="button">
        <button type="button" onclick="tinhNamAmLich()">=></button>
      </div>
      <div class="form-group">
        <label for="namAmLich">Năm âm lịch:</label>
        <input type="text" id="namAmLich" name="namAmLich" readonly>
      </div>
    </form>
  </div>

  <script>
    function tinhNamAmLich() {
      const namDuong = parseInt(document.getElementById("namDuong").value);
      let can, chi;

      // Tính Can
      switch (namDuong % 10) {
        case 0: can = "Canh"; break;
        case 1: can = "Tân"; break;
        case 2: can = "Nhâm"; break;
        case 3: can = "Quý"; break;
        case 4: can = "Giáp"; break;
        case 5: can = "Ất"; break;
        case 6: can = "Bính"; break;
        case 7: can = "Đinh"; break;
        case 8: can = "Mậu"; break;
        case 9: can = "Kỷ"; break;
      }

      // Tính Chi
      switch (namDuong % 12) {
        case 0: chi = "Thân"; break;
        case 1: chi = "Dậu"; break;
        case 2: chi = "Tuất"; break;
        case 3: chi = "Hợi"; break;
        case 4: chi = "Tý"; break;
        case 5: chi = "Sửu"; break;
        case 6: chi = "Dần"; break;
        case 7: chi = "Mão"; break;
        case 8: chi = "Thìn"; break;
        case 9: chi = "Tỵ"; break;
        case 10: chi = "Ngọ"; break;
        case 11: chi = "Mùi"; break;
      }

      // Hiển thị kết quả
      document.getElementById("namAmLich").value = can + " " + chi;
    }
  </script>
</body>
</html>

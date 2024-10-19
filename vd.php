<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title></title>
</head>
<body>
	<style>
		*{
			padding: 0;
			margin: 20;
			
			box-sizing: border-box;
		}
		form{
			margin: auto;
			border: 1px solid #000;
			text-align: center;
			 width: 30%;
			 height: 60%;
			 border-radius: 10px ;
			 box-shadow: 0 0 10px;
		}
		input{
			border-radius: 5px;
		}
		button[type="submit"]{
			background-color: green;
			border-radius: 5px;

		}
		button[type="reset"]{
			background-color: blue;
			border-radius: 5px;
		}
	</style>
<div>
	<?php 
	if(isset($_POST['them1'])){
	
    $tendt=$_POST['tendt'];
    $hang=$_POST['hang'];
    $nam=$_POST['nam'];
    require_once('ketnoi.php');
    $them="INSERT INTO hang(tendt,a,b) value ('$tendt','$hang','$nam')";
    mysqli_query($con,$them);}
	 ?>
	<form action="" method="post">
		<p>ten dien thoai
			<input type="text" name="tendt"></p>
		<p>a
			<input type="text" name="hang"></p>	
		<p>b
			<input type="text" name="nam"></p>	
		<button type="submit" name="them1">them</button>
		<button type="reset" >nhap lai</button>
		<br>
	</form>
	<form action="them.php" method="post">
		<p>ma dien thoai
			<input type="text" name="madt"></p>
			<p>hang san xuat
			<input type="text" name="hang"></p>	
		<p>nam san xuat
			<input type="text" name="nam"></p>	
		<button type="submit" >them</button>
		<button type="reset" >nhap lai</button>

		<p>ten dien thoai </p>
		<select name="tendt" >
                        <!--Xử lý mã lớp  -->
                        <?php
                            require_once 'ketnoi.php';
                            $sql = "SELECT hang.tendt, mobi.tendt from hang WHERE 1";
                            $data = mysqli_query($con, $sql);
                            if(mysqli_num_rows($data) > 0) {
                                while($row = mysqli_fetch_array($data)) {
                                    echo '<option value="'.$row['tendt'].'">'.$row['tendt'].'</option>';
                                }
                            }

                            mysqli_close($con);
                        ?>
                    </select>
		
	</form>
</div>
</body>
</html>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="css/menu.css">
    <link rel="icon" href="Assets/logo iconnet.png">
</head>
<body>
    <div class="container">
     <header>
        <img src="Assets/acehiklan.png" alt="">
     </header>
     <aside>
        <ul>
            <li><a href="?open=dashboard">Dashboard</a></li>
            <li><a href="?open=customer">Customer</a></li>
            <li class="logout"><a href="login.php">LogOut</a></li>
        </ul>
    </aside>
     <main>
        <?php
        if(isset($_GET ['open'])){
            include "" .$_GET['open'] . ".php";
        }else{
            include "dashboard.php";
        }
        ?>
     </main>
     <footer>Copyright &copy; 2022, Aceh Iklan</footer>
    </div>
</body>
</html>
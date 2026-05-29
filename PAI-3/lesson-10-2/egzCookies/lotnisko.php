<?php
$name = "ciasteczko";
$value = "mk";
setcookie($name, $value, time() + (60*60*2), "/");
?>
<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Port Lotniczy</title>
    <link rel="stylesheet" href="styl5.css">
</head>

<body>
    <header>
        <section class="headLeft"><img src="zad5.png" alt="logo lotnisko"></section>
        <section class="headCenter">
            <h1>Przyloty</h1>
        </section>
        <section class="headRight">
            <h3>
                Przydatne linki
            </h3>
            <a href="kwerendy.txt">Pobierz...</a>
        </section>
    </header>
    <main>
        <table>
            <tr>
                <th>CZAS</th>
                <th>KIERUNEK</th>
                <th>NUMER REJSU</th>
                <th>STATUS</th>
            </tr>
            <?php
                $serwer = "localhost";
                $user = "root";
                $password = "";
                $dbName = "lotnisko";
                $mysql = mysqli_connect($serwer, $user, $password, $dbName);
                $query = mysqli_query($mysql, "SELECT przyloty.czas, przyloty.kierunek, przyloty.nr_rejsu, przyloty.status_lotu
                    FROM przyloty
                    ORDER BY przyloty.czas ASC");

                while($row = mysqli_fetch_row($query)){
                    echo "<tr>
                            <td>$row[0]</td> 
                            <td>$row[1]</td> 
                            <td>$row[2]</td> 
                            <td>$row[3]</td> 
                        </tr>";
                }

            ?>
        </table>
    </main>
    <footer>
        <section class="footerLeft">
            <?php
                if(isset($_COOKIE[$name])){
                    echo "<p>Witaj ponownie na stronie lotniska</p>";
                }
                else{
                    echo "<p>Dzień dobry! Strona lotniska używa ciasteczek</p>";
                }
            ?>
        </section>
        <section class="footerRight">Autor: 000000000</section>
    </footer>
    <?php
        mysqli_close($mysql);
    ?>
</body>

</html>
<!DOCTYPE html>
<html lang="pl">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Opinie klientów</title>
    <link rel="stylesheet" href="style3.css">
</head>

<body>
    <?php
        $dbserver = "localhost";
        $user = "root";
        $password = "";
        $dbName = "egzamin3_Opinie";
        $mysqli = mysqli_connect($dbserver,$user,$password,$dbName);
    ?>
    <header>
        <h1>Hurtownia spożywcza</h1>
    </header>
    <main>
        <h2>Opinie naszych klientów</h2>
        <?php
            $sqlQuerry2 = mysqli_query($mysqli, "SELECT klienci.zdjecie, klienci.imie, opinie.opinia
                                                FROM klienci
                                                INNER JOIN opinie on klienci.id = opinie.Klienci_id
                                                INNER JOIN typy on klienci.Typy_id = typy.id
                                                WHERE klienci.Typy_id = 2 OR klienci.Typy_id = 3");

            while($row = mysqli_fetch_row($sqlQuerry2)){
                echo "<div class='blockOpinion'>";
                echo "
                    <div><img src='obrazy/".$row[0]."' alt='klient'></div>
                        <div>
                            <div class='com'<p>".$row[2]."</p></div>
                            <div><h4>".$row[1]."</h4></div>
                        </div>
                    ";
                echo "</div>";

            }
        ?>
    </main>
    <footer>
        <section>
            <h3>Współpracuj z nami</h3>
            <a href="http://sklep.pl">Sklep 1</a>
        </section>
        <section>
            <h3>Nasi top klienci</h3>
            <?php
                $sqlQuerry = mysqli_query($mysqli, "SELECT klienci.imie, klienci.nazwisko, klienci.punkty
                                                    FROM klienci
                                                    ORDER BY klienci.punkty
                                                    DESC LIMIT 3");
                echo "<ol>";
                while($row = mysqli_fetch_row($sqlQuerry)){
                    echo "<li>".$row[0]." ".$row[1].", ".$row[2]."pkt.</li>";
                }
                echo "</ol>";
            ?>
        </section>
        <section>
            <h3>Skontaktuj się</h3>
            <p>telefon: 111222333</p>
        </section>
        <section>
            <h3>Autor: Maksim</h3>
        </section>
    </footer>
</body>

</html>
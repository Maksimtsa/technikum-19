<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="styl4.css">
    <title>Wycieczki krajoznawcze</title>
</head>
<body>
    <?php
        $dbserver = "localhost";
        $user = "root";
        $password = "";
        $dbName = "egzamin3";
        $mysqli = mysqli_connect($dbserver,$user,$password,$dbName);
    ?>
    <header>
        <h1>
            WITAMY W BIURZE PODRÓŻY
        </h1>
    </header>

    
        <article>
            <h3>
                ARCHIWUM WYCIECZEK
            </h3>
            <?php
                $query1 = mysqli_query($mysqli, "SELECT id, cel, cena
                FROM wycieczki
                WHERE dostepna = FAlSE");  
                while($row = mysqli_fetch_array($query1)){
                        echo "$row[0]. $row[1], cena: $row[2]";
                        print("<br>");
                }
            ?>
        </article>
        <main>
        <section>
            <h3>
                NAJTANIEJ...
            </h3>
            <table>
                <tr>
                    <td>Włochy</td>
                    <td>od 1200 zł</td>
                </tr>
                <tr>
                    <td>Francja</td>
                    <td>od 1200 zł</td>
                </tr>
                <tr>
                    <td>Hiszpania</td>
                    <td>od 1400 zł</td>
                </tr>
            </table>
        </section>
        <section class=sectionCenter>
            <h3>
                TU BYLIŚMY
            </h3>
            <?php
                $query2 = mysqli_query($mysqli, "SELECT nazwaPliku, podpis
                FROM zdjecia
                ORDER BY podpis DESC");  
                while($row = mysqli_fetch_array($query2)){
                    echo "<img src='obrazy/$row[0]' alt='$row[1]'>";
                }
            ?>
        </section>
        <section>
            <h3>
                SKONTAKTUJ SIĘ
            </h3>
            <a href="http://wycieczki@wycieczki.pl">napisz do nas</a>
            <p>telefon: 555666777</p>
        </section>
    </main>
    <footer>
        <p>Stronę wykonał: Maksim Tsaryk</p>
    </footer>
    <?php
        mysqli_close($mysqli)
    ?>
</body>
</html>

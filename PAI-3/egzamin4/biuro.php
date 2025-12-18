<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="styl4.css">
    <title>Wycieczki krajoznawcze</title>
</head>
<body>
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
                $dbserver = "localhost";
                $user = "root";
                $password = "";
                $dbName = "egzamin4";
                $mysqli = mysqli_connect($dbserver,$user,$password,$dbName);
                $result = mysqli_query($mysqli, "SELECT id, cel, cena
                FROM wycieczki
                WHERE dostepna = FAlSE");  
                echo "<pre>";
                while($row = mysqli_fetch_array($result, MYSQLI_ASSOC)){
                    foreach($row as $key=>$value) {
                        echo $key.": ".$value." ";
                    }
                    echo "<br>";
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
        <p>Stronę wykonał: </p>
    </footer>
</body>
</html>
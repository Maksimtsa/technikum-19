<!DOCTYPE html>
<html lang="pl-PL">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Twój wskaźnik BMI</title>
    <link rel="stylesheet" href="styl4.css">
</head>

<body>
    <?php
        $server = 'localhost';
        $user = 'root';
        $password = '';
        $dbName = 'egzBMI';
        $mysql = mysqli_connect($server, $user, $password, $dbName);
        $result = "";
        $przedzial = "";

        if(isset($_POST['send'])){
            if(!empty($_POST["waga"]) && !empty($_POST["wzrost"])){
                $waga = $_POST['waga'];
                $wzrost = $_POST['wzrost'];
                $BMI = $waga / pow($wzrost, 2) * 10000;
                $result = "Twoja waga: ". $waga .", Twój wzrost: ". $wzrost . "<br>BMI wynosi: ". $BMI;
                if($BMI > 0 && $BMI < 19) $przedzial = 1;
                if($BMI > 19 && $BMI < 26) $przedzial = 2;
                if($BMI > 26 && $BMI < 31) $przedzial = 3;
                if($BMI > 31 && $BMI < 100) $przedzial = 4;

                $data = DATE("Y-m-d");
                mysqli_query($mysql, "INSERT INTO wynik VALUES (NULL, $przedzial, '$data', $BMI);");
            }                      
        }
    ?>
    <header>
        <div class="banner">
            <h2>Oblicz wskaźnik BMI</h2>
        </div>
        <div class="bannerLogo"><img src="wzor.png" alt="liczymy BMI"></div>
    </header>
    <div class="block">
        <div class="blockLeft"><img src="rys1.png" alt="zrzuć kalorie!"></div>
        <div class="blockRight">
            <form method="post">
                <h1>Podaj dane</h1>
                Waga: <input type="number" name="waga"><br>
                Wzrost [cm]: <input type="number" name="wzrost"><br>
                <input type="submit" name='send' value="Licz MBI i zapisz wynik"><br>
                <?php echo $result; ?>
            </form>
        </div>
    </div>
    <main>
        <table>
            <tr>
                <th>lp.</th>
                <th>Interpretacja</th>
                <th>zaczyna się od...</th>
            </tr>
            <?php
                $query = mysqli_query($mysql, "SELECT bmi.id, bmi.informacja, bmi.wart_min FROM bmi");

                while($row = mysqli_fetch_array($query)){
                    echo "<tr>
                            <td>$row[0]</td>
                            <td>$row[1]</td>
                            <td>$row[2]</td>
                    </tr>";
                }
            ?>
        </table>
    </main>
    <footer>
        Autor: 000000000 <a href="kw2.jpg">Wynik działania kweredny 2</a>
    </footer>
</body>

</html>
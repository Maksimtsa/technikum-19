<!DOCTYPE html>
<html lang="pl">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Biblioteka publiczna</title>
    <link rel="stylesheet" href="styl.css">
</head>

<body>
    <header>
        <h1>Biblioteka w Książkowicach Wielkich</h1>
    </header>
    <main>
        <div class="leftBlock">
            <h3>Polecamy działa autorów.</h1>
                <?php
                    $serwer = 'localhost';
                    $user = 'root';
                    $password = '';
                    $db = 'biblioteka';

                    $mysql = mysqli_connect($serwer, $user, $password, $db);

                    $query = mysqli_query($mysql, "SELECT autorzy.imie, autorzy.nazwisko 
                                            FROM autorzy
                                            ORDER BY autorzy.nazwisko ASC");

                    echo "<ol>";
                    while($row = mysqli_fetch_array($query)){
                        echo "<li>$row[0] $row[1]</li>";
                    }
                    echo "</ol>";
                ?>
                
        </div>
        <div class="centralBlock">
            <h3>ul. Czytelnicza 25, Książkowice&nbsp;Wielkie</h3>
            <a href="mailto:sekretariat@biblioteka.pl">Napisz do nas</a><br>
            <img src="biblioteka.png" alt="książki">
        </div>
        <div class="rightBlock">
            <div class="rightTop">
                <h3>
                    Dodaj czytelnika
                </h3>
                <form method="post">
                    <label>Imię: <input type="text" name="name"></label><br>
                    <label>Nazwisko: <input type="text" name="surname"></label><br>
                    <label>Symbol: <input type="number" name="symbol"></label><br>
                    <button type="submit" name="send">DODAJ</button>
                </form>
                <?php
                    $name = '';
                    $surname = '';
                    $code = '';
                    $result = '';

                    if(isset($_POST['send'])){
                        if(!empty($_POST['name']) && !empty($_POST['surname']) && !empty($_POST['symbol'])){
                            $name = $_POST['name'];
                            $surname = $_POST['surname'];
                            $code = $_POST['symbol'];
                            
                            $result = "Czytelnik $name $surname został(a) dodany do bazy danych.";
                            $query1 = mysqli_query($mysql, "INSERT INTO czytelnicy VALUES(NULL, '$name', '$surname', '$code')");
                        }
                        else{
                            $result = "Wypełnij wszystkie pola.";
                        }
                    }
                    
                ?>
            </div>
            <div class="rightBottom">
                <?php
                    echo "<p>$result</p>";
                ?>
            </div>
        </div>
    </main>
    <footer>
        <p>Projekt strony: 111222333444</p>
    </footer>
    <?php
        mysqli_close($mysql);  
    ?>
</body>

</html>
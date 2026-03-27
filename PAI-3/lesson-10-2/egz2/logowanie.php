<!DOCTYPE html>
<html lang="pl">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Forum o psach</title>
    <link rel="stylesheet" href="styl4.css">
</head>

<body>
    <header>
        <h1>Forum wielbicieli psów</h1>
    </header>
    <main>
        <div class="blockLeft">
            <img src="obraz.jpg" alt="foksterier">
        </div>
        <div class="blockRight">
            <div class="topBlock">
                <h2>Zapisz się</h2>
                <form method="post">
                    <label>
                        login:<input type="text" name="login">
                    </label><br>
                    <label>
                        hasło:<input type="password" name="password">
                    </label><br>
                    <label>
                        powtórz hasło:<input type="password" name="passwordR">
                    </label><br>
                    <button type="submit" name="send">Zapisz</button>
                </form>

                <?php
                    $server = 'localhost';
                    $user = 'root';
                    $passwordDB = '';
                    $dbName = 'psy2';
                    $mysql = mysqli_connect($server, $user, $passwordDB, $dbName);
                    $error = FALSE;

                    if(isset($_POST['send'])){
                        if(isset($_POST['login']) && isset($_POST['password']) && isset($_POST['passwordR'])){
                            $login = $_POST['login'];
                            $pass = $_POST['password'];
                            $passR = $_POST['passwordR'];

                            if($login == '' || $pass == '' || $passR == ''){
                                echo "Wypełnij wszystkie pola";
                                $error = true;
                            }

                            elseif($pass != $passR){
                                echo "<p>Hasła nie są takie same, konto nie zostało dodane</p>";
                                $error = true;
                            }
                            else{
                                $query = "SELECT uzytkownicy.login FROM uzytkownicy";
                                $result = mysqli_query($mysql, $query);
                                while($row = mysqli_fetch_row($result)){
                                    if($login == $row[0]){
                                        echo "<p>Login występuje w bazie danych, konto nie zostało dodane</p>";
                                        $error = true;
                                    }
                                }
                            }

                            if($error == false){
                                $passSzyfr = sha1($pass);
                                $query = "INSERT INTO uzytkownicy VALUES (NULL, '$login', '$passSzyfr');";
                                echo "<p>Konto zostało dodane</p>";
                                mysqli_query($mysql, $query);
                            }
                        }
                    }
                    mysqli_close($mysql);
                ?>
            </div>
            <div class="bottomBlock">
                <h2>Zapraszamy wszystkich</h2>
                <ol>
                    <li>właścicieli psów</li>
                    <li>weterynarzy</li>
                    <li>tych, co chcą kupić psa</li>
                    <li>tych, co lubią psy</li>
                </ol>
                <a href="regulamin.html">Przeczytaj regulamin forum</a>
            </div>
        </div>
    </main>
    <footer>
        Stronę wykonał: 000000000000
    </footer>
</body>

</html>
<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
        body {
            line-height: 200%;
            background-color: rgb(255, 255, 255);
        }

        fieldset {
            background-color: rgb(104, 170, 196);
            border-color: rgb(36, 36, 36);
        }
    </style>
</head>

<body>

    <form method="POST">
        <fieldset>
            <label>
                Imię: <input type="text" name="name">
            </label><br>

            <label>
                Nazwisko: <input type="text" name="surname">
            </label><br>

            <label>
                Email: <input type="text" name="email">
            </label><br>

            <fieldset>
                <label>Ile będzie 5 + 2 = </label>
                <select name="math">
                    <option disabled selected>Wybierz</option>
                    <option value="4">4</option>
                    <option value="8">8</option>
                    <option value="7">7</option>
                </select><br>
            </fieldset><br>

            <fieldset>
                <label>Ronaldo or Messi?</label><br>
                <input type="radio" value="Ronaldo" id="radio1" name="player"><label for="radio1">Ronaldo</label><br>
                <input type="radio" value="Messi" id="radio2" name="player"><label for="radio2">Messi</label><br>
            </fieldset><br>

            <fieldset>
                <label>Dwie kolejne cyfry po 2 </label><br>
                <input type="checkbox" name="num[]" value="3"><label>3</label><br>
                <input type="checkbox" name="num[]" value="1"><label>1</label><br>
                <input type="checkbox" name="num[]" value="4"><label>4</label><br>
                <input type="checkbox" name="num[]" value="0"><label>0</label><br>
            </fieldset><br>

            <input type="submit" name="send" value="Sprawdź">
        </fieldset>
    </form>
        
    <?php
        if (isset($_POST['send'])) {

            $punkty = 0;

            if ($_POST['math'] == 7) $punkty++;

            if ($_POST['player'] == "Ronaldo") $punkty++;

            if (!empty($_POST['num'])) {
                if (in_array("3", $_POST['num'])) {
                    $punkty++;
                }
                if (in_array("4", $_POST['num'])) {
                    $punkty++;
                }
            }

            echo "<fieldset><h2>Odebrane dane:</h2>";

            echo "Imię: " . $_POST['name'] . "<br>";
            echo "Nazwisko: " . $_POST['surname'] . "<br>";
            echo "Email: " . $_POST['email'] . "<br>";
            echo "Odpowiedź 5+2: " . $_POST['math'] . "<br>";
            echo "Piłkarz: " . $_POST['player'] . "<br>";
            echo "Wybrane cyfry: ";
            if(!empty($_POST['num'])){
                implode(", ", $_POST['num']);
            }
            else{
                echo "Brak";
            }
            echo "<h3>Punkty: $punkty / 4</h3></fieldset>";
        }
?>



</body>

</html>

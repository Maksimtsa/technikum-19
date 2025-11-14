<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
        body{
            line-height: 200%;
        }
        table, th, td{
            border: 1px solid black;
            border-collapse: collapse;
        }
    </style>
</head>

<body>
    <h2>Tabliczka mnożenia</h2>
    <form method="post">
        <label>
            <strong>Podaj liczbę początkową:</strong>
            <input type="text" name="numA">
        </label><br>

        <label>
            <strong>Podaj liczbę końcową:</strong>
            <input type="text" name="numB">
        </label><br>

        <button type="submit" name="send">Utwórz</button>
    </form>

    <?php
        if (isset($_POST['send'])) {

            if(isset($_POST['numA']) && isset($_POST['numB'])){
                $num1 = $_POST['numA'];
                $num2 = $_POST['numB'];

                if($num1 > $num2){
                    echo "<p><strong>Początek nie może być większy od końca!</strong></p>";
                }
                else{
                    echo "<p>a = $num1, b = $num2</p>";
                    echo "<table>";
                    for ($i = $num1; $i <= $num2; $i++) {
                        echo "<tr>\n";
                        for ($j = $num1; $j <= $num2; $j++) {
                            echo "<td>" . ($i * $j) . "</td>\n";
                        }
                        echo "</tr>\n";
                    }
                    echo "</table>";
                }
            }
        }
    ?>
</body>

</html>

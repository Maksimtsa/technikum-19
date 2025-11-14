<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
        body {
            line-height: 200%;
        }
    </style>
</head>
<body>
    <h2>Równanie kwadratowe</h2>
    <p><strong>ax<sup>2</sup> + bx + c = 0</strong></p>

    <form method="post">
        <label>
            Podaj liczbę a:
            <input type="text" name="a" required>
        </label>
        <br>
        <label>
            Podaj liczbę b:
            <input type="text" name="b" required>
        </label>
        <br>
        <label>
            Podaj liczbę c:
            <input type="text" name="c" required>
        </label>
        <br>
        <button type="submit">Rozwiąż równanie</button>
    </form>

    <?php
        if (isset($_POST["a"]) && isset($_POST["b"]) && isset($_POST["c"])) {

            $a = $_POST["a"];
            $b = $_POST["b"];
            $c = $_POST["c"];

            echo "<p>a = $a, b = $b, c = $c</p>";

            if (!(is_numeric($a) && is_numeric($b) && is_numeric($c))) {
                echo "<p><strong>Kazda zmienna musi byc liczba</strong></p>";
                return;
            }

            $a = intval($a);
            $b = intval($b);
            $c = intval($c);

            if ($a == 0) {
                echo "<p>To nie jest równanie kwadratowe (a = 0).</p>";
                return;
            } 
            
            $del = pow($b, 2) - 4 * $a * $c;
            $deltaN = number_format($del, 2, ", ", " ");
            echo "<p>Delta = $deltaN</p>";

            if ($del > 0) {
                $x1 = (-$b - sqrt($del)) / (2 * $a);
                $x2 = (-$b + sqrt($del)) / (2 * $a);
                $pier1 = number_format($x1, 2, ", ", " ");
                $pier2 = number_format($x2, 2, ", ", " ");
                echo "<p>Równanie ma dwa pierwiastki rzeczywiste:</p>";
                echo "<p>x<sub>1</sub> = $pier1</p>";
                echo "<p>x<sub>2</sub> = $pier2</p>";
            } elseif ($del == 0) {
                $x0 = -$b / (2 * $a);
                $pier0 = number_format($x0, 2, ", ", " ");
                echo "<p>Równanie ma jeden pierwiastek podwójny:</p>";
                echo "<p>x<sub>0</sub> = $pier0</p>";
            } else {
                echo "<p>Równanie nie ma pierwiastków rzeczywistych.</p>";
            }
        }
    ?>
</body>
</html>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
        $num1 = rand(1, 99);
        $num2 = rand(1, 99);

        $quotient = $num1 / $num2;
        $floor = floor($quotient);
        $ceil = ceil($quotient);
        $round = round($quotient, 3);

        echo <<<END
            <p>Pierwsza liczba: $num1</p>
            <p>Pierwsza liczba: $num2</p>
            <p>Liczba całkowita ograniczająca iloraz z dołu: $floor</p>
            <p>Liczba całkowita ograniczająca iloraz z góry: $ceil</p>
            <p>Przybliżenie ilorazu do trzech miejsc po przecinku: $round</p>
        END;
    ?>
</body>
</html>
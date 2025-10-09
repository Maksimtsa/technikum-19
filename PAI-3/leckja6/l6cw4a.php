<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>

    <?php
        $a1 = 5;
        $b1 = 3;
        $h1 = 2;

        $a2 = 7;
        $b2 = 4;
        $h2 = 3;

        function areaTrapeze($a, $b, $h) {
            $area = (($a + $b) * $h) / 2;
            return number_format($area, 2, ',', ' ');
        }

        echo "a = $a1, b = $b1, h = $h1<br>";
        echo "P = " . areaTrapeze($a1, $b1, $h1) . "<br><br>";

        echo "a = $a2, b = $b2, h = $h2<br>";
        echo "P = " . areaTrapeze($a2, $b2, $h2) . "<br>";
    ?>

</body>
</html>
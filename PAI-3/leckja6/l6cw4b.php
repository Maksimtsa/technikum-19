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
        $a2 = 7;
        $b1 = 3;
        $b2 = 4;
        $h1 = 2;
        $h2 = 3;

        function areaTrapeze($a, $b, $h, $jednostka = "cm^2") {
            $area = (($a + $b) * $h) / 2;
            return number_format($area, 2, ',', ' ') . " " . $jednostka;
        }

        echo "a = $a1, b = $b1, h = $h1<br>";
        echo "P = " . areaTrapeze($a1, $b1, $h1) . "<br><br>";
        echo "a = $a2, b = $b2, h = $h2<br>";
        echo "P = " . areaTrapeze($a2, $b2, $h2, "dm^2") . "<br>";
        ?>

</body>
</html>
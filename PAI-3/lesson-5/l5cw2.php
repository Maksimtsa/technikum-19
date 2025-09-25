<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
        $a = 2;
        $b = 3;
        $c = 1;

        $d = pow($b, 2) - 4*$a*$c;
        
        echo 'a: ', $a, '<br>';
        echo 'b: ', $b, '<br>';
        echo 'c: ', $c, '<br>';
        echo 'delta: ', $d, '<br>';


        if ($d < 0) {
            echo "0 pierwiastków";
        } elseif ($d == 0) {
            $x = -$b / (2 * $a);
            echo "1 pierwiastek";
        } else {
            $pD = sqrt($d);
            $x1 = (-$b - $pD) / (2 * $a);
            $x2 = (-$b + $pD) / (2 * $a);
            echo "2 pierwiastki<br>";
            echo "x1 = $x1<br>";
            echo "x2 = $x2";
        }
    ?>
</body>
</html>
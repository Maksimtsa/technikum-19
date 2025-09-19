<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
        define('exchangeEuro', 4.26);

        $sumE = 100.11;
        $sumP = $sumE * exchangeEuro;
        $sumPend = number_format($sumP, 2, ",", " ");

        echo $sumPend; 
    ?>
</body>
</html>
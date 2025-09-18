<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
        table, th, td{
            border: 1px solid black;
            border-collapse: collapse;
        }
    </style>
</head>

<body>
    <?php
    $ilosc1 = 2;
    $cena1 = 15.90;
    $ilosc2 = 1;
    $cena2 = 12.90;
    $suma = ($ilosc1 * $cena1) + ($ilosc2 * $cena2);


    $cenaA = number_format($cena1, 2, ',', '.');
    $cenaB =  number_format($cena2, 2, ',', '.');
    $kosztA = number_format($suma, 2, ',', '.');
    
    echo<<<KONIEC
    <h1>Twoje zamówienie</h1>
        <table>
        <tr>
            <th>Nazwa</th>
            <th>Liczba</th>
            <th>Cena</th>
        </tr>
        <tr>
            <td>placek po węgiersku</td>
            <td>$ilosc1</td>
            <td>$cenaA</td>
        </tr>
        <tr>
            <td>pierogi zbójnickie</td>
            <td>$ilosc2</td>
            <td>$cenaB</td>
        </tr>
        <tr>
            <td>Do zapłaty</td>
            <td>-</td>
            <td>$kosztA</td>
        </tr>
    </table>
    <h1>Dziękujemy!</h1>
    KONIEC;
    ?>
    

</body>
</html>
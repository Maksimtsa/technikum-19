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
    $ilosc2 = 0;
    $cena2 = 12.90;
    $dystans = 1.5;
    $nazwaDania1 = "Placek po więgiersku";
    $nazwaDania2 = "Pierogi zbójnickie";


    if($ilosc2 > 0){
        $suma = ($ilosc1 * $cena1) + ($ilosc2 * $cena2);
        $kosztA = number_format($suma, 2, ',', '.');
        $cenaD = 0;
        $txt = 'Skorzystałeś z promocji <strong>dostawa gratis!</strong>';
    }
    else{
        $suma = ($ilosc1 * $cena1) + ($ilosc2 * $cena2);
        $cenaK = $suma + ($dystans * 2.5);
        $cena3 = $dystans * 2.5;
        $cenaD = number_format($cena3, 2, ',', '.');
        $kosztA = number_format($cenaK, 2, ',', '.');
        $txt = 'Niestety nie skorzystałeś z naszej promocji :(';
    }


    $cenaA = number_format($cena1, 2, ',', '.');
    $cenaB = number_format($cena2, 2, ',', '.');
    
    echo<<<KONIEC
    <h1>Twoje zamówienie</h1>
        <table>
        <tr>
            <th>Nazwa</th>
            <th>Liczba</th>
            <th>Cena</th>
        </tr>
        <tr>
            <td>$nazwaDania1</td>
            <td>$ilosc1</td>
            <td>$cenaA</td>
        </tr>
        <tr>
            <td>$nazwaDania2</td>
            <td>$ilosc2</td>
            <td>$cenaB</td>
        </tr>
        <tr>
            <td>Dostawa</td>
            <td>-</td>
            <td>$cenaD</td>
        </tr>
        <tr>
            <td>Do zapłaty</td>
            <td>-</td>
            <td>$kosztA</td>
        </tr>
    </table>
    <h1>Dziękujemy!</h1>
    <p>$txt</p>
    KONIEC;
    ?>
    

</body>
</html>
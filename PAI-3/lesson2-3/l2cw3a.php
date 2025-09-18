<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<style>
    table, th, td {
        border:1px solid black;
        border-collapse: collapse;
    }
</style>
<body>

    <?php

        echo<<<KONIEC
        <table>
            <tr>
                <th> </th>
                <th>Kolumna 1</th>
                <th>Kolumna 2</th>
            </tr>
            <tr>
                <td>Wiersz 1</td>
                <td>Kom11</td>
                <td>Kom12</td>
            </tr>
            <tr>
                <td>Wiersz 2 </td>
                <td>Kom21</td>
                <td>Kom22</td>
            </tr>
        </table>
        KONIEC;

    ?>


</body>
</html>
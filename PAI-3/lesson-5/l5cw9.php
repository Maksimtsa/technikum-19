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
    <table>
        <?php
        for ($i = 1; $i <= 10; $i++) {
        echo "<tr>\n";

        for ($j = 1; $j <= 10; $j++) {
        echo "<td>";
        echo $j * $i;
        echo "</td>\n";
        }

        echo "</tr>\n";
        }
        ?>
</table>
</body>
</html>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
        $products = ['banan', 'jabłko', 'gruszka', 'śliwka', 'pomidor'];

        echo "<h3>Wyświetlenie tablicy trzema różnymi funkcjami</h3>";
        echo "<pre>";
        print_r($products);
        echo "</pre>";
        echo "<pre>";
        var_dump($products);
        echo "</pre>";
        echo "<pre>";
        var_export($products);
        echo "</pre>";
        sort($products);

        echo "<h3>Tablica po sortowaniu rosnącym:</h3>";
        echo "<pre>";
        print_r($products);
        echo "</pre>";

        echo "<h3>Dodanie nowego produktu na początku tablicy</h3>";
        array_unshift($products, 'ogórek');
        $count = count($products);
        echo "<pre>";
        print_r($products);
        echo "</pre>";
        echo "Liczba elementów w tablicy: $count<br>";

        echo "<h3>Usunięcie ostatniego elementu i sortowanie malejące</h3>";
        array_shift($products);
        rsort($products);
        echo "<pre>";
        print_r($products);
        echo "</pre>";

        echo "<h3>Wyświetlenie listy numerowanej</h3>";
        echo "<h2>Lista zakupów</h2>";
        echo "<ol>";
        foreach($products as $item) {
            echo "<li>$item</li>";
        }
        echo "</ol>";
    ?>
</body>
</html>
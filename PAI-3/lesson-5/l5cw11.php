<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
        $przedmioty = array("matematyka", "fizyka", "informatyka", "biologia", "chemia");

        foreach ($przedmioty as $i) {
            echo $i, "<br>";
        }

        echo "<pre>";
        print_r($przedmioty);
        echo "</pre>";


        for($i = 0; $i < count($przedmioty); $i++){
            echo "<li>$przedmioty[$i]</li>";
        }
        ?>

</body>
</html>
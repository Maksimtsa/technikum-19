<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
        $partie = array(
            "partia1" => 20.4,
            "partia2" => 18.2,
            "partia3" => 12.2,
        );

        foreach ($partie as $nazwa => $poparcie) {
            echo "partia: $nazwa poparcie: $poparcie%<br>";
        }

        echo "<pre>";
        print_r($partie);
        echo "</pre>";


    ?>
</body>
</html>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
        echo "<h3>a)</h3>";
        echo "<h3>sposób 1</h3>";
        for($i = 13; $i <= 390; $i += 13){
            $tabFor[] = $i; 
        }
        for($i = 0; $i < count($tabFor); $i++){
            echo $tabFor[$i];
            if($i < count($tabFor) - 1) {
                echo "=>";
            }
        }

        echo "<h3>sposób 2</h3>";
        $tabRange = range(13, 390, 13);
        echo implode("=>", $tabRange);


        echo "<h3>b)</h3>";
        $folder = "L7_2funkcje";
        $plik = $folder . "/ciag.txt";
        $fp = fopen($plik, "a");
        if ($fp) {
            $ciag = implode("=>", $tabRange) . "\n";
            fwrite($fp, $ciag);
            fclose($fp);
        }
    ?>
</body>
</html>
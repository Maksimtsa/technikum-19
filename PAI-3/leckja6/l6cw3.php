<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <title>Formatowanie tekstu</title>
</head>
<body>

<?php
    function textFormat($text) {
    $color = "blue";
    $font = "Arial";
    $size = "20px";

    echo "<p style='color: $color; font-family: $font; font-size: $size;'>$text</p>";
}

    textFormat("To jest przykładowy tekst.");
?>
</body>
</html>

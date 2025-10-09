<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <title>Formatowanie tekstu - parametry</title>
</head>
<body>

<?php
function formatujTekst($text, $color, $font, $size) {
    echo "<p style='color: $color; font-family: $font; font-size: $size;'>$text</p>";
}

formatujTekst("To jest przykładowy tekst.", "red", "Times New Roman", "24px");
formatujTekst("To jest przykładowy tekst.", "green", "Courier New", "18px");
?>

</body>
</html>

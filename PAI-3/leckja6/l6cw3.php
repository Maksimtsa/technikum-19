<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <title>Formatowanie tekstu</title>
</head>
<body>

<?php
    function formatujTekst($text) {
        return "<p style=\"color: blue; font-family: Arial; font-size: 20px;\">$text</p>";
    }


    echo formatujTekst("To jest przykładowy tekst.");

?>

</body>
</html>

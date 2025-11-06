<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <form method="post">
        <label for="color">Wybierz kolor tła strony:</label><br>
        <select name="color">
            <option value="white">Biały</option>
            <option value="red">Czerwony</option>
            <option value="blue">Niebieski</option>
            <option value="green">Zielony</option>
            <option value="pink">Różowy</option>
            <option value="white">Biały</option>
        </select><br>

        <input type="submit" name="send" value="Zmień kolor strony">
    </form>
    <?php
        if(isset( $_POST['send']))
    ?>
</body>
</html>

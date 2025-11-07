<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <?php
    $backGround = "white";
        if (isset($_POST['send'])) {
            $color = $_POST['color'];
            $backGround = $_POST['color'];
        }
    ?>
    <style>
        body{
            background-color: <?php echo $backGround; ?>;
            line-height: 200%;
        }
    </style>
</head>
<body>
    <h1><strong>Wybór koloru strony</strong></h1>
    <form method="post">
        <label>Wybierz kolor tła strony:<br></label>
        <select name="color">
            <option value="white">Biały</option>
            <option value="red">Czerwony</option>
            <option value="blue">Niebieski</option>
            <option value="green">Zielony</option>
            <option value="pink">Różowy</option>
            <option value="orange">Pomarańczowy</option>
        </select>
        <br>
        <input type="submit" name="send" value="Zmień kolor strony"></input>
    </form>
    
</body>
</html>

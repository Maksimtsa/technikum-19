<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <?php
    if (isset($_POST['send'])) {
        $p = $_POST['p'];
        
        
    }
    ?>
    <style>
        body{
            line-height: 200%;
        }
    </style>
</head>
<body>
    <h1><strong>Piramida znaków</strong></h1>
    <form action="" method="post">
        <label>Wybierz znak:<br></label>
        <select name="char">
            <option value="*">*</option>
            <option value="$">$</option>
            <option value="#">#</option>
            <option value="^">^</option>
            <option value="%">%</option>
        </select><br>
        <label>Wypisz ilość poziomów piramidy</label>
        <input type="number" name="p">
        <br>
        <input type="submit" name="send" value="Utwórz"></input>
    </form>
    
</body>
</html>

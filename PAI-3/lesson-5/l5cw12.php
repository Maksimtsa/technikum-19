<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
        $subjects = [
            'matematyka' => 4.5,
            'fizyka' => 4.0,
            'informatyka' => 5.0,
            'biologia' => 3.8,
            'chemia' => 4.2
        ];

        foreach($subjects as $subject => $avg){
            echo "$subject: średnia $avg<br>";
        }
    ?>
</body>
</html>
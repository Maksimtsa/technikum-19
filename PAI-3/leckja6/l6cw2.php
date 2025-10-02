<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
        function gradeCom($grade = 3) {
            switch ($grade) {
                case 1:
                case 2:
                    echo "Sporo pracy przed Tobą.<br>";
                    break;
                case 3:
                    echo "Jeszcze trochę, a będzie ok.<br>";
                    break;
                case 4:
                case 5:
                case 6:
                    echo "Okej.<br>";
                    return;
                default:
                    echo "Nieprawidłow wartość.";
                    break;
                    
            }
        }
        gradeCom(1);
        gradeCom(2);
        gradeCom(3);
        gradeCom(4);
        gradeCom(6);
        gradeCom();
    ?>
</body>
</html>
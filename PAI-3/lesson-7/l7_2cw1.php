<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
        echo "Witamy dnia " . date("d.m.Y") . "<br>"; 

        $day = date("l");
        $month = date("F");
        switch ($day) {
            case "Monday": $day = "poniedziałek"; break;
            case "Tuesday": $day = "wtorek"; break;
            case "Wednesday": $day = "środa"; break;
            case "Thursday": $day = "czwartek"; break;
            case "Friday": $day = "piątek"; break;
            case "Saturday": $day = "sobota"; break;
            case "Sunday": $day = "niedziela"; break;
        }
        switch ($month) {
            case "January": $month = "stycznia"; break;
            case "February": $month = "lutego"; break;
            case "March": $month = "marca"; break;
            case "April": $month = "kwietnia"; break;
            case "May": $month = "maja"; break;
            case "June": $month = "czerwca"; break;
            case "July": $month = "lipca"; break;
            case "August": $month = "sierpnia"; break;
            case "September": $month = "września"; break;
            case "October": $month = "października"; break;
            case "November": $month = "listopada"; break;
            case "December": $month = "grudnia"; break;
        }
        echo "Witamy w " . $day . ", dnia " . date("d") . " $month " . date("Y") . " roku";
    ?>
</body>
</html>
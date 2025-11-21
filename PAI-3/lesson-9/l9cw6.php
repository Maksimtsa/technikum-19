<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
        body {
            line-height: 200%;
        }
        .red_label { 
            color: red; 
        }
        img{
            height: 168px;
            width: 400px;
        }
    </style>
</head>

<body>
    <?php
    $nameError = $name = "";
    $car = "";
    $result = "";
        if(isset($_POST['send'])){
            $car = $_POST['car'];
            $name = $_POST['name'];
            if($name==""){
                $nameError = "Podaj imie";
            }
            
            if($nameError == ""){
                switch($car){
                    case "toyota":
                        $result = "$name, samochód wybrany przez Ciebie może wyglądać tak:<br><img src='photo/toyota.jpg'>";
                        break;
                    case "audi":
                        $result = "$name, samochód wybrany przez Ciebie może wyglądać tak:<br><img src='photo/audi.jpg'>";
                        break;
                    case "bmw":
                        $result = "$name, samochód wybrany przez Ciebie może wyglądać tak:<br><img src='photo/bmw.jpg'>";
                        break;
                    case "volkswagen":
                        $result = "$name, samochód wybrany przez Ciebie może wyglądać tak:<br><img src='photo/volkswagen.jpg'>";
                        break;
                    case "opel":
                        $result = "$name, samochód wybrany przez Ciebie może wyglądać tak:<br><img src='photo/opel.jpg'>";
                        break;
                    case "landRover":
                        $result = "$name, samochód wybrany przez Ciebie może wyglądać tak:<br><img src='photo/landRover.jpg'>";
                        break;
                    default:
                        $result = "Błąd";    
                }
            }
        }
    ?>
    <h1><strong>Ulubiony samochód</strong></h1>
    <form action="" method="post">
        <label>Podaj swoje imię: </label><br>
        <input type="text" name="name">
        <?php echo "<span class='red_label'>".$nameError."</span>";?><br>

        <label>Wybierz ulubiony samochód:</label><br>
        <input type="radio" name="car" value="toyota" id="toyota" <?php if ($car == "toyota" ) echo "checked" ; ?>>
        <label for="toyota">Toyota</label><br>
        <input type="radio" name="car" value="audi" id="audi" <?php if ($car == "audi" ) echo "checked" ; ?>>
        <label for="audi">Audi</label><br>
        <input type="radio" name="car" value="bmw" id="bmw" <?php if ($car == "bmw" ) echo "checked" ; ?>>
        <label for="bmw">BWM</label><br>
        <input type="radio" name="car" value="volkswagen" id="volkswagen" <?php if ($car == "volkswagen" ) echo "checked" ; ?>>
        <label for="volkswagen">Volkswagen</label><br>
        <input type="radio" name="car" value="opel" id="opel" <?php if ($car == "opel" ) echo "checked" ; ?>>
        <label for="opel">Opel</label><br>
        <input type="radio" name="car" value="landRover" id="landRover" <?php if ($car == "landRover" ) echo "checked" ; ?>>
        <label for="landRover">Land Rover</label><br>
        <input type="submit" name="send" value="Pokaż"><br>
    </form>
    <?php
        if ($result !== "") {
            echo "<h3>$result</h3>";
        }
    ?>
</body>

</html>
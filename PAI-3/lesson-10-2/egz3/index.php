<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Forum o psach</title>
    <link rel="stylesheet" href="styl.css">
</head>

<body>
<header>
    <h1>Forum miłośników psów</h1>
</header>

<main>

    <section class="blockLeft">
        <img src="Avatar.png" alt="Użytkownik forum">
        <?php
            $serwer = 'localhost';
            $user = 'root';
            $password = '';
            $db = 'forumpsy';

            $mysql = mysqli_connect($serwer, $user, $password, $db);

            $query = mysqli_query($mysql, "SELECT konta.nick, konta.postow, pytania.pytanie
                                    FROM konta
                                    INNER JOIN pytania ON konta.id = pytania.konta_id
                                    WHERE pytania.konta_id = 1;");

            while($row = mysqli_fetch_array($query)) {
				echo "<h4>Użytkownik: $row[0]</h4>
					<p>$row[1] postów na forum</p>
					<p>$row[2]</p>";
			}
        ?>

        <video src="video.mp4" controls loop></video>
    </section>

    <section class="blockRight">

        <form method="post">
				<textarea name="odp" rows="4" cols="40"></textarea><br/>
				<button type="submit" name="send">Dodaj odpowiedź</button>
			</form>
        <?php
            if(isset($_POST["send"])){
                if(!empty($_POST['odp'])) {
                    $odp = $_POST['odp'];
                    mysqli_query($mysql, "INSERT INTO odpowiedzi VALUES (NULL, 1, 5, '$odp');");
                }
            }
		?>
		<h2>Odpowiedzi na pytanie</h2>
		<ol>
			<?php
				$query2 = mysqli_query($mysql, "SELECT odpowiedzi.odpowiedz, konta.nick FROM odpowiedzi, konta WHERE odpowiedzi.konta_id = konta.id AND odpowiedzi.Pytania_id = 1;");
				while($row = mysqli_fetch_row($query2)) {
					echo "<li>$row[0] $row[1]</li>";
				}
			?>
		</ol>

    </section>

</main>

<footer>
    Autor: 0000000000
    <a href="http://mojestrony.pl/" target="blank">Zobacz nasze realizacje</a>
</footer>
    <?php
        mysqli_close($mysql);  
    ?>  
</body>
</html>

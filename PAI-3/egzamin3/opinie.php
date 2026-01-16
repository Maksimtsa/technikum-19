<!DOCTYPE html>
<html lang="pl">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Opinie klientów</title>
    <link rel="stylesheet" href="style3.css">
</head>

<body>
    <?php
        $dbserver = "localhost";
        $user = "root";
        $password = "";
        $dbName = "egzamin2";
        $mysqli = mysqli_connect($dbserver,$user,$password,$dbName);
    ?>
    <header>
        <h1>Hurtownia spożywcza</h1>
    </header>
    <main>
        <h2>Opinie naszych klientów</h2>

    </main>
    <footer>
        <section>
            <h3>Współpracuj z nami</h3>
            <a href="http://sklep.pl">Sklep 1</a>
        </section>
        <section>
            <h3>Nasi top klienci</h3>

        </section>
        <section>
            <h3>Skontaktuj się</h3>
            <p>telefon: 111222333</p>
        </section>
        <section>
            <h3>Autor: Maksim</h3>
        </section>
    </footer>
</body>

</html>
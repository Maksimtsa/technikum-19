<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
        $text = "
        Ooo, ale jazz!  Hardkorowo pada deszcz  
        Tak na maksa wieje też  
        Ja łagodnie uśmiechnięta  
        Błyska gdzieś  
        Na mej dłoni czuję dreszcz  
        Moje oczy błyszczą też  
        Ja łagodnie uśmiechnięta  
        Ooooo, hardkorowo pada deszcz  
        Ja łagodnie uśmiechnięta";

        echo "<h2>a)</h2>";
        echo "<pre>$text</pre>";

        echo "<h2>b)</h2>";
        $char = strlen($text);
        $words = str_word_count($text, 0);
        $charFormated = number_format($char, 2);
        $wordsFormated = number_format($words, 3);
        echo "Tekst składa się z " . $charFormated . " znaków oraz " . $wordsFormated . " słów<br>";

        echo "<h2>c)</h2>";
        $pos = strpos($text, 'deszcz');
        $sentence = substr($text, 0, $pos + strlen("deszcz"));
        echo $sentence;

        echo "<h2>d)</h2>";
        if (strstr($text, "ą") !== false) {
            echo "jest ą";
        } 
        else {
            echo "brak litery ą";
        }


        echo "<h2>e)</h2>";
        echo substr($text, -24);

        echo "<h2>f)</h2>";
        $line = explode("\n", $text);
        $lastSentence = trim(end($line));

        $J = strrpos($text, 'J');
        echo $lastSentence . "<br>";
        echo "pozycja ostatniej J: " . $J;

        echo "<h2>g)</h2>";
        $textReplaced = str_replace("łagodnie", "krzywo", $text);
        echo "<pre>$textReplaced</pre>";

        echo "<h2>h)</h2>";
        $textRemoved = str_replace("Ooo, ", '', $text);
        echo "<pre>" . $textRemoved . "</pre>";

        echo "<h2>i)</h2>";
        echo "<pre>" . str_replace("Ja łagodnie uśmiechnięta", "", $text) . "</pre>";

        echo "<h2>j)</h2>";
        $textWithIntro = "To piosenka Sanah: " . $text;
        echo "<pre>" . $textWithIntro . "</pre>"; 

        echo "<h2>k)</h2>";
        $textUpper = mb_strtoupper($text, "UTF-8");
        echo "<pre>" . $textUpper . "</pre>";

        echo "<h2>l)</h2>";
        $wordsArray = explode(" ", $text);
        echo "<pre>";
        print_r($wordsArray);
        echo "</pre>";

        echo "<h2>m)</h2>";
        $textCh = str_replace(" ", "***", $text);
        echo "<pre>$textCh</pre>";

        echo "<h2>n) Sposób 1</h2>";
        $linesN = explode("\n", $text);
        for ($i = 0; $i < 5; $i++) {
            echo $linesN[$i] . "<br>";
        }

        echo "<h2>n) Sposób 2</h2>";
        $linesN = preg_split('/\r?\n/', $text);
        
        for ($i = 0; $i <= 4; $i++) {
            echo $linesN[$i] . "<br>";
        }
    ?>
</body>
</html>

<?php
 session_start();
  include_once("db.php");
?>

<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="utf-8" />

<link rel="stylesheet" type="text/css" href="CSS/style.css"/>
       
    </head>
    <body>
        <?php
            
require_once("nbbc/nbbc.php");
$bbcode = new BBCode;
$sql = "SELECT * FROM post ORDER BY id DESC";
$res = mysqli_query($db,$sql) or die (mysqli_errror());
$posts = "";
if (mysqli_num_rows($res) > 0) {
    while ($row = mysqli_fetch_assoc($res)){
        $id =  $row['id'];
        $name =  $row['name'];
        $text =  $row['text'];
        $date =  $row['date'];

        $output = $bbcode->parse($text);


        $posts .="<div class='sd'><h1>$name</h1><h2>$date</h2><p>$output</p></div>";

    }
    echo $posts;
}else{
    echo "ther no post in the  - close to  you  -";
}
            
        ?>

    </body>
</html>

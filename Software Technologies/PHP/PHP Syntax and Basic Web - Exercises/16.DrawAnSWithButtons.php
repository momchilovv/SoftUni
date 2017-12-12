<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
</head>
<body>
<?php
for($col = 1; $col<=9; $col++) {
    for($row = 1; $row <= 5; $row++) {
        if($col == 1 || $col == 5 || $col ==9 || ($col>=2 && $col<5 && $row == 1) || ($col>=6 && $col<9 && $row == 5)) {
            echo "<button style='background-color:blue'>1</button>";
        } else {
            echo "<button>0</button>";
        }
    }
    echo "<br>";
}
?>
</body>
</html>
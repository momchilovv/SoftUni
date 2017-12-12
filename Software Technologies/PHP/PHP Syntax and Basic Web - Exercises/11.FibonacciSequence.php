<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
    <form>
        N: <input type="text" name="num" />
        <input type="submit" />
    </form>
    <?php
    $current = 0;
    $previous = 1;
        if (isset($_GET['num'])){
            $n = intval($_GET['num']);
            for ($i = 1; $i <= $n; $i++){
                $currentSum = $current + $previous;
                $current = $previous;
                $previous = $currentSum;
                echo $current . " ";
            }
        }
    ?>
</body>
</html>
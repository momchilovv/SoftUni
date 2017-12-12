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
        $first = 0;
        $second = 1;
        $third = 1;
        if (isset($_GET['num'])){
            $n = intval($_GET['num']);
            for ($i = 1; $i <= $n; $i++){
                $currentSum = $first + $second + $third;
                $first = $second;
                $second = $third;
                $third = $currentSum;
                echo $first . " ";
            }
        }
    ?>
</body>
</html>
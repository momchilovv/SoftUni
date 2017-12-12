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
        if (isset($_GET['num'])){
            $n = intval($_GET['num']);
            $sum = 1;
            if ($n == 1){
                echo "1";
            }
            else {
                for ($i = 2; $i <= $n; $i++) {
                    $sum *= $i;
                }
                echo $sum;
            }
        }
    ?>
</body>
</html>
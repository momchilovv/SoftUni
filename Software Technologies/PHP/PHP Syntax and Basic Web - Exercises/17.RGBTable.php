<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
	<style>
		table * {
			border: 1px solid black;
			width: 50px;
			height: 50px;
		}
    </style>
</head>
<body>
<table>
    <tr>
        <td>
            Red
        </td>
        <td>
            Green
        </td>
        <td>
            Blue
        </td>
    </tr>
    <?php
        for ($c = 51; $c <= 255; $c+=51){
            echo "<tr><td style='background-color: rgb($c, 0, 0)'></td><td style='background-color: rgb(0, $c, 0)'></td>
                     <td style='background-color: rgb(0, 0, $c)'></td> </tr>";
        }
    ?>
</table>
</body>
</html>
/**
 * Created by Cvetelin Momchilov on 11/7/2017.
 */
function integerSum(str) {
    let arr = str[0].split(' ').map(Number);
    console.log(check(arr[0], arr[1], arr[2]) ||
        check(arr[0], arr[2], arr[1]) || check(arr[1], arr[2], arr[0]) || "No");

    function check(firstNumber, secondNumber, sum) {
        if(firstNumber > secondNumber){
            [firstNumber, secondNumber] = [secondNumber, firstNumber];
        }
        if(firstNumber + secondNumber == sum){
            return "" + firstNumber + " + " + secondNumber + " = " + sum;
        }
    }
}
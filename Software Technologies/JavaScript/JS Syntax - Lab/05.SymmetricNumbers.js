/**
 * Created by Cvetelin Momchilov on 11/7/2017.
 */
function symmetricNumbers(arr) {
    let n = Number(arr[0]);
    for(let i = 1; i <= n; i++) {
        if(isSymetricNumber("" + i)){
            console.log((i));
        }
    }
    function isSymetricNumber(num) {
        for(let i = 0; i < num.length; i++) {
            if(num[i] != num[num.length - 1 - i]) {
                return false;
            }
        }
        return true;
    }
}
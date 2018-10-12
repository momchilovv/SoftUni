function npnumbers(arr){
    let input = arr.map(Number);
    let negativeArr = [];
    let positiveArr = [];

    for(let i = 0; i < arr.length; i++) {

        if (input[i] < 0) {
            negativeArr.unshift(Number(arr[i]));
        }
        else if (input[i] >= 0) {
            positiveArr.push(Number(arr[i]));
        }
    }
    console.log(negativeArr.join('\n'));
    console.log(positiveArr.join('\n'));
}
npnumbers(['7', '-2', '8', '9']);
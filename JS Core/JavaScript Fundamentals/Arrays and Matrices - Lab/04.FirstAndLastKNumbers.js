function falkNumbers(input){
    let arr = [];
    let secondArr = [];
    let firstLine = "";
    let secondLine = "";

    for(let i = 0; i < input.length; i++){
        arr.push(input[i]);
    }
    let count = arr[0];
    arr.shift();

    for(let i = 0; i < count; i++){
        firstLine += arr[i] + ' ';
    }

    arr.reverse();
    for(let i = 0; i < count; i++){
        secondArr.push(arr[i]);
    }
    secondArr.reverse();
    for(let i = 0; i < count; i++){
        secondLine += secondArr[i] + ' ';
    }
    console.log(firstLine);
    console.log(secondLine);
}
falkNumbers(['3', '6', '7', '8', '9']);
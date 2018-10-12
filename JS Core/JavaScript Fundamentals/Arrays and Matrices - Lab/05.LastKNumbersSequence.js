function lastkNumbers(input){
    let length = Number(input[0]);
    let numbers = Number(input[1]);

    let sequence = [1];

    let result = 0;

    for(let i = 1; i < numbers; i++){
        let first = Math.max(0, i - numbers);
        let arr = sequence.slice(first, first + length);
        result = arr.reduce((a, b)=>a + b);
    }

    console.log(result);
}
lastkNumbers(['8', '3']);
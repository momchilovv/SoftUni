function oddNums(input){
    let arr = [];
    let odd = [];

    for(let i = 0; i < input.length; i++){
        arr.push(input[i] * 2);
    }

    for(let i = 0; i < arr.length; i++){
        if(i % 2 != 0){
            odd.push(arr[i]);
        }
    }

    odd.reverse();
    console.log(odd.join(' '));
}
oddNums(['3', '0', '10', '4', '7', '3']);
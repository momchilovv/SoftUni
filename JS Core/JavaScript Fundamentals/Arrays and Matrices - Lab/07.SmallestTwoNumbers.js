function smallestTwo(input){
    let result = input.sort((a, b)=> a - b).slice(0, 2);
    console.log(result.join(' '));
}
smallestTwo(['3', '0','4', '3', '10']);
function evenPos(input){
    let str = "";

    for(let i = 0; i < input.length; i++){
        if(i % 2 == 0){
            str += input[i] + " ";
        }
    }
    console.log(str);
}
evenPos(['20', '30', '40'])
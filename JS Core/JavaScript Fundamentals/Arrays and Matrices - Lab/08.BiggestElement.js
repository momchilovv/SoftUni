function biggestElement(input){


    return input.map(function(getArray){
        var biggest = [];
        var result = [];
        //for(let i = 0; i < getArray.length; i++){
         //   biggest.push(getArray[i]);
        //}

        biggest.push(Math.max.apply(null, getArray));

        for(let i = 0; i < biggest.length; i++){
            result.push(biggest[i]);
        }
        console.log(Math.max(result));
        //console.log(biggest.sort((a,b)=> a - b));
    });

    
}
biggestElement([[3, 5, 7, 12], [-1, 4, 33, 2], [8, 3, 0, 4]]);
function triangleOfStars(n){
    let str = "";

    for(let i = 0; i < n; i++){   
        str += '*';    
        for(let j = 0; j < i; j++){
            str += '*';
        }
        str += '\n';
    }

    for(i = 0; i < n; i++) {
        for (j = 0; j < n - i - 1; j++) {
            str += '*';
        }
        str += '\n';
    }
    console.log(str);
}
triangleOfStars(3);
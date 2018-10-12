function calculator(num1, num2, operation){
    
    if(operation === '/'){
        console.log(num1 / num2);
    }
    else if(operation === '*'){
        console.log(num1 * num2);
    }
    else if(operation === '+'){
        console.log(num1 + num2);
    }
    else if(operation === '-'){
        console.log(num1 - num2);
    }
}
calculator(18, -1, '*');
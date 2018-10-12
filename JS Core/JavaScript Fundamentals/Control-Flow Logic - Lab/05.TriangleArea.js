function triangle(num1, num2, num3){
    let sum = (num1 + num2 + num3) / 2;
    let area = Math.sqrt(sum * (sum - num1) * (sum - num2) * (sum - num3));

    console.log(area);
}
triangle(2, 3.5, 4);
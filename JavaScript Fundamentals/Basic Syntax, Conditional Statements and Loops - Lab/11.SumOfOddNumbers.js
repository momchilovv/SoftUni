function printOddNumbersSum(number) {
    let sum = 0;

    for (let i = 0; i < number * 2; i++) {
        if (i % 2 == 1) {
            sum += i;
            console.log(i);
        }
    }

    console.log(`Sum: ${sum}`);
}
function letterInString(str, letter) {
    let occurred = 0;
    for (let i=0; i<str.length; i++)
        if (str[i] == letter) 
            occurred++;
    console.log(occurred);
}
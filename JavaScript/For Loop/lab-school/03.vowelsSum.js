function vowelsSum(input) {
    let counter = 0;
    for (let i = 0; i < input.length; i++) {
        if (input[i] === 'a') {
            counter += 1;
        } else if (input[i] === 'e') {
            counter += 2;
        } else if (input[i] === 'i') {
            counter += 3;
        } else if (input[i] === 'o') {
            counter += 4;
        } else if (input[i] === 'u') {
            counter += 5;
        }
    }

    console.log(counter);
}

// vowelsSum('hello');
vowelsSum('bamboo');
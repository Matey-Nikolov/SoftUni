function biggestNumber(input) {
    let currentBiggestNumber = input.shift();

    while (input[0] !== 'Stop' || input.length > 1) {
        if (Number(input[0]) > currentBiggestNumber) {
            currentBiggestNumber = Number(input[0]);
        }
        input.shift();
    }

    console.log(currentBiggestNumber)
}

biggestNumber(['100', '99', '80', '70', 'Stop'])
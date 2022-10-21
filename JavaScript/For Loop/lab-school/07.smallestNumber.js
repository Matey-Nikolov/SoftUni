function smallestNumber(input) {
    let currentSmallestNumber = input.shift();

    while (input[0] !== 'Stop' || input.length > 1) {
        if (Number(input[0]) < currentSmallestNumber) {
            currentSmallestNumber = Number(input[0]);
        }
        input.shift();
    }

    console.log(currentSmallestNumber);
}

smallestNumber(['100', '99', '80', '70', 'Stop'])
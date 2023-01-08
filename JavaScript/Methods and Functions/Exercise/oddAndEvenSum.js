function oddAndEvenSum(number) {
    let evenSum = 0;
    let oddSum = 0;

    while (number > 0) {
        let digit = number % 10;

        if (digit % 2 === 0) {
            evenSum += digit;
        } else {
            oddSum += digit;
        }

        number = number.toString().substring(0, number.toString().length - 1);
    }

    console.log(`Odd sum = ${oddSum}, Even sum = ${evenSum}`);

}

oddAndEvenSum(1000435);
oddAndEvenSum(3495892137259234);
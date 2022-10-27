function sumPrimeNonPrime(input) {
    let isPrime = true;
    let sumPrime = 0;
    let sumNonPrime = 0;

    for (number of input) {

        let numberConvert = Number(number);

        if (number < 0) {
            console.log('Number is negative.');
            continue;
        }

        for (let i = 2; i < numberConvert; i++) {

            if (numberConvert % i == 0) {
                isPrime = false;
                break;
            }
            isPrime = true;
        }

        if (number === 'stop') {
            break;
        } else if (isPrime) {
            sumPrime += numberConvert;
        } else {
            sumNonPrime += numberConvert;
        }
    }



    console.log(`Sum of all prime numbers is: ${sumPrime}`);
    console.log(`Sum of all non prime numbers is: ${sumNonPrime}`);
}

sumPrimeNonPrime(["3",
    "9",
    "0",
    "7",
    "19",
    "4",
    "stop"
]);
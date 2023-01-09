function factorialDivision(firstNumber, secondNumber) {

    const firstResult = factorial(firstNumber);
    const secondResult = factorial(secondNumber);

    function factorial(input) {
        if (input === 0) {
            return 1;
        } else {
            return input * factorial(input - 1);
        }
    }

    console.log((firstResult / secondResult).toFixed(2));
}

factorialDivision(5, 2);
factorialDivision(6, 2);
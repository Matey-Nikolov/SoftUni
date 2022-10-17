function calculator(number, operator, secondNumber) {
    let sum = 0;

    switch (operator) {
        case '+':
            sum = number + secondNumber;
            break;
        case '-':
            sum = number - secondNumber;
            break;
        case '/':
            sum = number / secondNumber;
            break;
        case '*':
            sum = number * secondNumber;
            break;
    }

    console.log(sum.toFixed(2));
}

calculator(5, '+', 10);
calculator(25.5, '-', 3);
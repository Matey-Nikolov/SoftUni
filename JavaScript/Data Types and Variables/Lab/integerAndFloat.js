function integerAndFloat(firstNum, secondNum, thirdNum) {
    let sum = firstNum + secondNum + thirdNum;

    if (sum % 1 === 0) {
        console.log(`${typeof(sum)} - Integer`);
    } else {
        console.log(`${typeof(sum)} - Float`);
    }
}

integerAndFloat(9, 100, 1.1);
integerAndFloat(100, 200, 303);
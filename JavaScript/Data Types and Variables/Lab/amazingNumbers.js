function amazingNumbers(input) {

    let numbers = input.toString();
    let sum = 0;

    for (let i = 0; i < numbers.length; i++) {
        sum += Number(numbers[i]);
    }

    let result = sum.toString().includes('9');

    if (result) {
        console.log(`${input} Amazing? True`);
    } else {
        console.log(`${input} Amazing? False`);
    }
}

amazingNumbers(1233);
amazingNumbers(999);
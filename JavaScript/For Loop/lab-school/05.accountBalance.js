function accountBalance(input) {
    let sum = 0;
    while (input[0] !== 'NoMoreMoney' || input.length > 1) {
        if (Number(input[0]) < 0) {
            console.log('Invalid operation!');
        } else {
            console.log('Increase: ' + Number(input[0]).toFixed(2));
            sum = sum + Number(input[0]);
        }
        input.shift();
    }

    console.log('Total: ' + sum.toFixed(2));
}

accountBalance(['5.51', '69.42', '100', 'NoMoreMoney'])
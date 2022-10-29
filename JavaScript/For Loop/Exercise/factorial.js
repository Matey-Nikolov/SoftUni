function factorial(n) {
    let sum = 1;
    for (let i = 1; i <= n; i++) {
        sum *= i
    }

    console.log(sum);
}

factorial(4);
factorial(8);
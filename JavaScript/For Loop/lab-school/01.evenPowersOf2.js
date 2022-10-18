function evenPowersOfTwo(input) {
    for (let i = 0; i <= input; i++) {
        if (i % 2 === 0) {
            console.log(Math.pow(2, i));
        }
    }
}

// evenPowersOfTwo(3);
// evenPowersOfTwo(4);
evenPowersOfTwo(5);
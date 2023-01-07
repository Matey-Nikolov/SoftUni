function palindromeIntegers(array) {

    array.forEach(number => {
        let temp = Number(number.toString().split('').reverse().join(''));


        if (temp === number) {
            console.log(true);
        } else {
            console.log(false);
        }
    });
}

palindromeIntegers([123, 323, 421, 121]);
palindromeIntegers([123, 323, 421, 121]);
function triplesLatinLetters(input) {

    // 

    for (let firstNum = 0; firstNum < input; firstNum++) {
        for (let secondNum = 0; secondNum < input; secondNum++) {
            for (let thirdNum = 0; thirdNum < input; thirdNum++) {

                let firstLetter = String.fromCharCode(97 + firstNum);
                let secondLetter = String.fromCharCode(97 + secondNum);
                let thirdLetter = String.fromCharCode(97 + thirdNum);

                console.log(`${firstLetter}${secondLetter}${thirdLetter}`);
            }
        }
    }
}

triplesLatinLetters(3);
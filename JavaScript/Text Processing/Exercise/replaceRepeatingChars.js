function replaceRepeatingChars(text) {
    let currentChar = '';
    let prevChar = '';
    let concatCahrs = ' ';

    for (let i = 0; i < text.length; i++) {
        currentChar = text[i];
        if (currentChar !== prevChar) {
            concatCahrs += currentChar;
            prevChar = currentChar;
        }
    }

    console.log(concatCahrs);
}

replaceRepeatingChars('aaaaabbbbbcdddeeeedssaa');
replaceRepeatingChars('qqqwerqwecccwd');
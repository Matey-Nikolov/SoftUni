function charactersInRange(firstChar, secondChar) {

    let result = [];
    let firstCharCode = firstChar.charCodeAt();
    let secondCharCode = secondChar.charCodeAt();

    if (firstCharCode > secondCharCode) {
        for (let i = secondCharCode; i < firstCharCode; i++) {

            result.push(String.fromCharCode(i));
        }
    } else {
        for (let i = firstCharCode; i < secondCharCode; i++) {

            result.push(String.fromCharCode(i));
        }
    }

    result.shift();
    console.log(result.join(' '));
}

charactersInRange('a', 'd');
charactersInRange('#', ':');
charactersInRange('C', '#');
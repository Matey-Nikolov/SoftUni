function rightPlace(firstString, symbol, secondString) {
    let replacedString = firstString.replace('_', symbol);
    let result = replacedString === secondString ? 'Matched' : 'Not Matched';

    console.log(result);
}

rightPlace('Str_ng', 'I', 'Strong');
rightPlace('Str_ng', 'i', 'String');
function stringSubstring(searchedWord, sentence) {
    if (sentence.toLowerCase().includes(searchedWord)) {
        console.log(searchedWord);
    } else {
        console.log(`${searchedWord} not found!`);
    }
}

stringSubstring('javascript', 'JavaScript is the best programming language');
stringSubstring('python', 'JavaScript is the best programming language');
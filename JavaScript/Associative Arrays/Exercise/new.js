function wordTracker(inputArray) {

    let inputWords = inputArray.shift().split(' ');
    let wordsCount = {};

    inputWords.forEach(element => {
        wordsCount[element] = 0;
    });

    inputArray.forEach(element => {
        if (element in wordsCount) {
            wordsCount[element]++;
        }
    });

    inputWords.sort((a, b) => wordsCount[b] - wordsCount[a]);

    inputWords.forEach(element => {
        console.log(`${element} - ${wordsCount[element]}`);
    })

}

wordTracker(['this sentence', 'In', 'this', 'sentence', 'you', 'have', 'to', 'count', 'the', 'occurances', 'of', 'the', 'words', 'this', 'and', 'sentence', 'because', 'this', 'is', 'your', 'task']);
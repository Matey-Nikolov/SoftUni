function wordTracker(inputArray) {

    let associativeArray = {};
    let input = inputArray[0].split(' ');

    let letterOne = '';
    let letterTwo = '';
    let countOne = 0;
    let countTwo = 0;


    letterOne = input[0];
    letterTwo = input[1];

    for (let key of inputArray) {

        if (letterOne === key) {
            countOne++;
            associativeArray[letterOne] = countOne;
        }


        if (letterTwo === key) {
            countTwo++;
            associativeArray[letterTwo] = countTwo;
        }
    }

    for (let key in associativeArray) {
        console.log(`${key} - ${associativeArray[key]}`);
    }

}
wordTracker(['this sentence', 'In', 'this', 'sentence', 'you', 'have', 'to', 'count', 'the', 'occurances', 'of', 'the', 'words', 'this', 'and', 'sentence', 'because', 'this', 'is', 'your', 'task']);
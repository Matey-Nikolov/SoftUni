function pascalCaseSplitter(text) {
    //https://stackoverflow.com/questions/26188882/split-pascal-case-in-javascript-certain-case
    let result = text.replace(/([A-Z][a-z])/g, ' $1').replace(/(\d)/g, ' $1');

    let splitResult = result.split(' ');
    splitResult.shift();

    console.log(splitResult.join(', '));
}

pascalCaseSplitter('SplitMeIfYouCanHaHaYouCantOrYouCan');
pascalCaseSplitter('HoldTheDoor');
pascalCaseSplitter('ThisIsSoAnnoyingToDo');
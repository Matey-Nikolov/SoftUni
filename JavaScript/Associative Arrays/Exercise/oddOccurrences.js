function solve(input) {

    let p = input.toString().toLowerCase().split(' ');
    let obj = new Map();
    for (const iterator of p) {

        obj.set(iterator, 0);
    }

    for (let index = 0; index < p.length; index++) {
        if (obj.has(p[index])) {
            let l = obj.get(p[index])
            obj.set(p[index], l + 1);
        }

    }
    let set = [];
    // let sorted = Array.from(obj).sort((a, b)=>b[1]-a[1]);
    for (const [key, value] of obj) {
        if (value % 2 != 0)
            set.push(key);
    }
    console.log(set.join(' '));
}


/*
function oddOccurrences(input) {
    let wordsArr = input.split(' ');
    let obj = {};

    wordsArr.forEach(element => {
        let word = element.toLowerCase();

        if (!obj[word]) {
            obj[word] = 1;
        } else {
            obj[word]++;
        }
    });

    let filteredWords = Object.keys(obj)
        .filter(word => obj[word] % 2 !== 0);

    let sortedWords = filteredWords.sort((a, b) => {
        b - a
    });

    console.log(sortedWords.join(' '));

}
*/
/*
function oddOccurrences(input) {
    let splitInput = input.toLowerCase().split(' ');
    let mapInput = new Map();

    for (const element of splitInput) {
        mapInput.set(element, 0);
    }

    for (let i = 0; i < splitInput.length; i++) {
        if (mapInput.has(splitInput[i])) {
            let num = mapInput.get(splitInput[i]);
            mapInput.set(splitInput[i, num + 1]);
        }
    }

    let set = [];

    for (const [key, value] of mapInput) {
        if (value % 2 !== 0) {
            set.push(key);
        }
    }

    console.log(set.join(' '));
}
*/
oddOccurrences('Java C# Php PHP Java PhP 3 C# 3 1 5 C#');
function race(input) {

    let splitInputNames = input.shift().split(', ');
    let lineInput = input.shift();

    let nameAndDistance = {};

    while (lineInput !== 'end of race') {
        let patternName = /[A-Za-z]/g;
        let name = lineInput.match(patternName).join('');

        let patternDistanse = /[0-9]/g;
        let distance = lineInput.match(patternDistanse).join('');

        let distanceSum = 0;

        for (let i = 0; i < distance.length; i++) {
            distanceSum += Number(distance[i]);
        }

        if (splitInputNames.includes(name)) {
            //https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Object/hasOwnProperty
            if (!nameAndDistance.hasOwnProperty(name)) {
                nameAndDistance[name] = distanceSum;
            } else {
                nameAndDistance[name] += distanceSum;
            }
        }
        lineInput = input.shift();
    }

    let arrayObjects = [];
    for (const key in nameAndDistance) {
        arrayObjects.push([key, nameAndDistance[key]]);
    }

    arrayObjects.sort((a, b) => b[1] - a[1]); // sort by value

    console.log(`1st place: ${arrayObjects[0][0]}`); // Махаме резултата така
    console.log(`2nd place: ${arrayObjects[1][0]}`);
    console.log(`3rd place: ${arrayObjects[2][0]}`);

}

race(["George, Peter, Bill, Tom",
    "G4e@55or%6g6!68e!!@",
    "R1@!3a$y4456@",
    "B5@i@#123ll",
    "G@e54o$r6ge#",
    "7P%et^#e5346r",
    "T$o553m&6",
    "end of race"
]);
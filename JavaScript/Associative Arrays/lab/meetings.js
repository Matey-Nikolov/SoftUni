function meetings(input) {
    let meetings1 = {};

    for (let line of input) {
        let [weekday, name] = line.split(' ');

        if (meetings1.hasOwnProperty(weekday)) {
            console.log(`Conflict on ${weekday}!`);
        } else {
            meetings1[weekday] = name;
            console.log(`Scheduled for ${weekday}`);
        }
    }

    for (const item in meetings1) {
        console.log(`${item} -> ${meetings1[item]}`);
    }

}

meetings(['Monday Peter',
    'Wednesday Bill',
    'Monday Tim',
    'Friday Tim'
]);
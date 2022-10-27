function trainTrainers(input) {
    let numberOfPeople = Number(input[0]);
    let grades = 0.0;
    let count = 0;

    for (let i = 1; i < numberOfPeople; i++) {

        if (input[i] == 'Finish') {
            break;
        }

        let NameOfPresentation = input[i];

        for (let item of input) {

            if (count > 0) {

                if (Number(item) > 0) {
                    grades += Number(item);
                    count++;
                }

                if (numberOfPeople === count - 1) {
                    break;
                }
            } else if (Number(item) > 0) {
                count++;
            }
        }

        let averageGrade = grades / count - 1;
        console.log(`${ NameOfPresentation } - ${averageGrade} `);

        count = 0;
        i += numberOfPeople;
    }
}

trainTrainers(["2",
    "While-Loop",
    "6.00",
    "5.50",
    "For-Loop",
    "5.84",
    "5.66",
    "Finish"
]);

trainTrainers(["3",
    "Arrays",
    "4.53",
    "5.23",
    "5.00",
    "Lists",
    "5.83",
    "6.00",
    "5.42",
    "Finish"
]);
function examPreparation(input) {
    let unsatisfactoryGrades = Number(input[0]);
    let countUnsatisfactoryGrades = 0;
    let taskName = '';

    let averageScore = 0;
    let grade = 0;
    let numberOfProblems = 0;

    for (let i = 1; i < input.length; i++) {
        if (input[i] === 'Enough') {
            break;
        } else {
            taskName = input[i];
            i++;
            grade = Number(input[i]);
            numberOfProblems++;
        }

        if (grade <= 4) {
            countUnsatisfactoryGrades++;
        }

        if (countUnsatisfactoryGrades === unsatisfactoryGrades) {
            console.log(`You need a break, ${countUnsatisfactoryGrades} poor grades.`);
            return;
        }

        averageScore += grade;
    }

    averageScore = averageScore / numberOfProblems;
    console.log(`Average score: ${averageScore.toFixed(2)}`);

    console.log(`Number of problems: ${numberOfProblems}`);
    console.log(`Last problem: ${taskName}`);
}

examPreparation(["3",
    "Money",
    "6",
    "Story",
    "4",
    "Spring Time",
    "5",
    "Bus",
    "6",
    "Enough"
]);

examPreparation(["2",
    "Income",
    "3",
    "Game Info",
    "6",
    "Best Player",
    "4"
])
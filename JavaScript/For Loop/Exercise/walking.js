function walking(input) {
    let totalSteps = 0;

    for (step of input) {
        if (step === 'Going home') {
            continue;
        } else {
            totalSteps += Number(step);
        }
    }

    if (totalSteps >= 10000) {
        console.log('Goal reached! Good job!');
        console.log(`${totalSteps - 10000} steps over the goal! `);
    } else {
        console.log(`${10000 - totalSteps} more steps to reach goal.`);
    }
}

walking(["1000", "1500", "2000", "6500"]);
walking(["1500", "3000", "250", "1548", "2000", "Going home", "2000"]);
walking(["1500", "300", "2500", "3000", "Going home", "200"]);
walking(["125", "250", "4000", "30", "2678", "4682"]);
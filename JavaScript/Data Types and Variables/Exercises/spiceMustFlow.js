function spiceMustFlow(number) {
    const workersConsume = 26;
    let workersExhausted = 26;

    let totalSpiceExtracted = number;
    let totalAmountOfSpice = 0;
    let daysCount = 0;

    while (totalSpiceExtracted >= 100) {

        totalAmountOfSpice += totalSpiceExtracted;
        totalAmountOfSpice -= workersConsume;

        totalSpiceExtracted -= 10;
        daysCount++;
    }

    totalAmountOfSpice -= workersExhausted;

    if (totalAmountOfSpice < 0) {
        totalAmountOfSpice = 0;
    }

    console.log(daysCount);
    console.log(totalAmountOfSpice);
}

spiceMustFlow(111);
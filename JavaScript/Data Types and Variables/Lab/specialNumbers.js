function specialNumbers(inputNum) {
    for (let i = 1; i <= inputNum; i++) {
        let num = i.toString()
        let sum = 0;

        for (const item of num) {
            sum += Number(item);
        }

        if (sum === 5 || sum === 7 || sum === 11) {
            console.log(`${num} -> True`);
        } else {
            console.log(`${num} -> False`);
        }
    }
}

specialNumbers(15);
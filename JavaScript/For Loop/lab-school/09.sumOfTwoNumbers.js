function sumOfTwoNumbers(start, end, magicNum) {
    let counter = 0;
    let flag = false;
    for (let i = start; i <= end; i++) {
        if (flag) {
            break;
        }
        let num1 = i;
        for (let j = start; j <= end; j++) {
            counter++;
            let num2 = j;
            if (num1 + num2 === magicNum) {
                flag = true;
                console.log(`Combination N:${counter} (${num1} + ${num2} = ${magicNum})`);
                break;
            }
        }
    }

    if (!flag) {
        console.log(`${counter} combinations - neither equals ${magicNum}`);
    }
}

sumOfTwoNumbers(1,
    10,
    5)

sumOfTwoNumbers(23,
    24,
    20)

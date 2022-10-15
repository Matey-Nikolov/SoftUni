function sumDigits(number) {
    let stringNum = number.toString();
    let sum = 0;


    for (const num of stringNum) {
        sum += Number(num);
    }

    console.log(sum);
}

sumDigits(245678);
sumDigits(97561);
sumDigits(543);
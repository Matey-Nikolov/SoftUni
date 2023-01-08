function NxNMatrix(number) {
    let linesNXN = '';

    for (let i = 0; i < number; i++) {
        for (let j = 0; j < number; j++) {
            linesNXN += number + ' ';
        }
        linesNXN += '\n';
    }
    console.log(linesNXN);
}

NxNMatrix(3);
NxNMatrix(7);
NxNMatrix(2);
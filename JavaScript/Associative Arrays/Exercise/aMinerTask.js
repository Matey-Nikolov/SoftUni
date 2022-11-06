function minerTask(inputArray) {

    let miner = {};

    for (let i = 0; i < inputArray.length; i += 2) {

        let resource = inputArray[i];
        let quantity = Number(inputArray[i + 1]);

        if (!miner.hasOwnProperty(resource)) {
            miner[resource] = 0;
        }

        miner[resource] += quantity;
    }

    for (const nameTotal in miner) {
        console.log(`${nameTotal} -> ${miner[nameTotal]}`);
    }
}

minerTask([
    'Gold',
    '155',
    'Silver',
    '10',
    'Copper',
    '17'
]);
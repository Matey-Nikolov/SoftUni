function fuelMoney(inputDistance, inputPassengers, inputPrice) {
    //let distance = inputDistance;
    //let passengers = inputPassengers;
    //let pricePerLetter = inputPrice;

    let totalFuel = (inputDistance / 100) * 7 + (inputPassengers * 100) / 1000;
    let totalSum = inputPrice * totalFuel;

    console.log(`Needed money for that trip is ${totalSum.toFixed(2)} lv.`);
}

fuelMoney(260, 9, 2.49);
fuelMoney(90, 14, 2.88);
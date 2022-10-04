function fishingBoat(budget, season, fishermens) {

    let priceSeason = 0;
    let fishermensParse = Number(fishermens);

    switch (season) {
        case 'Spring':
            priceSeason = 3000;
            break;
        case 'Summer':
            priceSeason = 4200;
            break;
        case 'Autumn':
            priceSeason = 4200;
            break;
        case 'Winter':
            priceSeason = 2600;
            break;
    }

    const specialDiscount = 0.05;
    let totalPrice = 0;

    if (fishermensParse <= 6) {
        totalPrice = priceSeason - (priceSeason * 0.1);
    } else if (fishermensParse >= 7 && fishermensParse <= 11) {
        totalPrice = priceSeason - (priceSeason * 0.15);
    } else if (fishermensParse >= 12) {
        totalPrice = priceSeason - (priceSeason * 0.25);
    }

    if (fishermens % 2 === 0 && season !== 'Autumn') {
        totalPrice = totalPrice - (totalPrice * specialDiscount);
    }

    if (budget >= totalPrice) {
        totalPrice = budget - totalPrice;
        console.log(`Yes! You have ${totalPrice.toFixed(2)} leva left.`);

    } else {
        totalPrice = totalPrice - budget;
        console.log(`Not enough money! You need ${Math.abs(totalPrice).toFixed(2)} leva.`);
    }

}

fishingBoat('3000', 'Summer', '11');
fishingBoat('3600', 'Autumn', '6');
fishingBoat('2000', 'Winter', '13');
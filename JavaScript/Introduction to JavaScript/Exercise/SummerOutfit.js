function summerOutfit(degrees, period) {
    let clothing;
    let shoes;

    switch (period) {
        case 'Morning':
            if (10 <= degrees && degrees <= 18) {
                clothing = 'Sweatshirt';
                shoes = 'Sneakers';
            } else if (18 < degrees && degrees <= 24) {
                clothing = 'Shirt';
                shoes = 'Moccasins';
            } else if (degrees >= 25) {
                clothing = 'T-Shirt';
                shoes = 'Sandals';
            }
            break;
        case 'Afternoon':
            if (10 <= degrees && degrees <= 18) {
                clothing = 'Shirt';
                shoes = 'Moccasins';
            } else if (18 < degrees && degrees <= 24) {
                clothing = 'T-Shirt';
                shoes = 'Sandals';
            } else if (degrees >= 25) {
                clothing = 'Swim Suit';
                shoes = 'Barefoot';
            }
            break;
        case 'Evening':
            if (10 <= degrees && degrees <= 18) {
                clothing = 'Shirt';
                shoes = 'Moccasins';
            } else if (18 < degrees && degrees <= 24) {
                clothing = 'Shirt';
                shoes = 'Moccasins';
            } else if (degrees >= 25) {
                clothing = 'Shirt';
                shoes = 'Moccasins';
            }
            break;
    }

    console.log(`It's ${degrees} degrees, get your ${clothing} and ${shoes}.`);
}

summerOutfit('16', 'Morning');
summerOutfit('22', 'Afternoon');
summerOutfit("28", 'Evening');
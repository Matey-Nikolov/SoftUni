function journey(budget, season) {
    const destinationBulgaria = 'Somewhere in Bulgaria';
    const destinationBalkans = 'Somewhere in Balkans';
    const destinationEurope = 'Somewhere in Europe';
    const camp = 'Camp';
    const hotel = 'Hotel';

    let CampOrHotel = 0;
    let parseBudget = Number(budget);

    if (parseBudget <= 100) {
        switch (season) {
            case 'summer':
                CampOrHotel = parseBudget * 0.3;
                console.log(`${destinationBulgaria}`);
                console.log(`${camp} - ${CampOrHotel.toFixed(2)}`);
                break
            case 'winter':
                CampOrHotel = parseBudget * 0.7;
                console.log(`${destinationBulgaria}`);
                console.log(`${hotel} - ${CampOrHotel.toFixed(2)}`);
                break
        }
    } else if (parseBudget > 100 && budget <= 1000) {
        switch (season) {
            case 'summer':
                CampOrHotel = parseBudget * 0.4;
                console.log(`${destinationBalkans}`);
                console.log(`${camp} - ${CampOrHotel.toFixed(2)}`);
                break
            case 'winter':
                CampOrHotel = parseBudget * 0.8;
                console.log(`${destinationBalkans}`);
                console.log(`${hotel} - ${CampOrHotel.toFixed(2)}`);
                break
        }
    } else if (parseBudget >= 1000) {
        CampOrHotel = parseBudget * 0.9;
        console.log(`${destinationEurope}`);
        console.log(`${hotel} - ${CampOrHotel.toFixed(2)}`);
    }
}

journey("50", "summer");
journey("75", "winter");
journey("312", "summer");
journey("678.53", "winter");
journey("1500", "summer");
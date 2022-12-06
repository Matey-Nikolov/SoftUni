function travelTime(inputArray) {
    let countryTowmTravel = {
        CountryName: '',
        TownName: '',
        TravelCost: 0
    };

    for (const info of inputArray) {
        const [country, town, travel] = info.split(' > ');

        if (!countryTowmTravel.entries(country)) {
            countryTowmTravel.CountryName = country;
            countryTowmTravel.TownName = town;
            countryTowmTravel.TravelCost = travel;
        }
    }
}

travelTime([
    "Bulgaria > Sofia > 500",
    "Bulgaria > Sopot > 800",
    "France > Paris > 2000",
    "Albania > Tirana > 1000",
    "Bulgaria > Sofia > 200"
]);
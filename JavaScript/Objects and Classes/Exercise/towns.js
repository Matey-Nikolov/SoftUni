function towns(input) {
    for (const row of input) {
        let [town, latitude, longitude] = row.split(' | ');

        let latitudeToFixed = Number(latitude);
        latitudeToFixed = latitudeToFixed.toFixed(2);

        let longitudeToFixed = Number(longitude);
        longitudeToFixed = longitudeToFixed.toFixed(2);

        let objectTowns = {
            town: town,
            latitude: latitudeToFixed,
            longitude: longitudeToFixed
        };

        console.log(objectTowns);
    }
}

towns(['Sofia | 42.696552 | 23.32601', 'Beijing | 39.913818 | 116.363625']);
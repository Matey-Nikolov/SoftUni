function inventory(input) {
    let inventory = [];
    input.forEach(element => {
        let heroNameLevelItems = element.split(' / ');

        let heroName = heroNameLevelItems[0];
        let heroLevel = heroNameLevelItems[1];
        let items = heroNameLevelItems[2];

        let objectInventory = {
            name: heroName,
            heroLevel: heroLevel,
            items: items
        };

        inventory.push(objectInventory);


    });

    //https://www.scaler.com/topics/javascript-sort-an-array-of-objects/
    inventory = inventory.sort((a, b) => {
        return a.heroLevel - b.heroLevel;
    });

    // inventory.sort((a, b) => {
    //     return a.items - b.items;
    // });

    let itemsSort = [];
    inventory.forEach(element => {
        console.log(`Hero: ${element.name}`);
        console.log(`level => ${element.heroLevel}`);

        itemsSort = element.items.split(', ');
        console.log(`items => ${itemsSort.sort((a, b) => a.localeCompare(b)).join(', ')}`);
    });
}

inventory([
    "Isacc / 25 / Apple, GravityGun",
    "Derek / 12 / BarrelVest, DestructionSword",
    "Hes / 1 / Desolator, Sentinel, Antara"
]);
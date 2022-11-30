function storeProvision(storageArray, deliveryArray) {
    let obj = {};

    let product = '';
    let quantity = '';

    for (let i = 0; i < storageArray.length; i += 2) {

        product = storageArray[i];
        quantity = storageArray[i + 1];

        obj[product] = Number(quantity);
    }

    for (let j = 0; j < deliveryArray.length; j += 2) {
        product = deliveryArray[j];
        quantity = deliveryArray[j + 1];

        if (obj[product]) {
            obj[product] += Number(quantity);
        } else {
            obj[product] = Number(quantity);
        }

    }

    for (const key in obj) {
        const element = obj[key];
        console.log(`${key} -> ${element}`);
    }
}

storeProvision(['Chips', '5', 'CocaCola', '9', 'Bananas', '14', 'Pasta', '4', 'Juice', '2'], ['Flour', '44', 'Oil', '12', 'Pasta', '7', 'Tomatoes', '70', 'Bananas', '30']);
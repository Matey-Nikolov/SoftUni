function storage(input) {
    let storageMap = new Map();

    for (const interator of input) {
        let [product, quantity] = interator.split(' ');
        quantity = Number(quantity);

        if (!storageMap.has(product)) {
            storageMap.set(product, quantity);
        } else {
            let currentQuantity = storageMap.get(product);
            currentQuantity += quantity;
            storageMap.set(product, currentQuantity);
        }
    }

    for (let item of storageMap) {
        console.log(`${item[0]} -> ${item[1]}`);
    }
}

storage(['tomatoes 10',
    'coffee 5',
    'olives 100',
    'coffee 40'
]);
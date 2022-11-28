function catalogue(input) {
    let productName = '';
    let productPrice = '';
    let products = [];

    input.forEach(element => {
        let splitProductAndPrice = element.split(' : ');

        productName = splitProductAndPrice[0];
        productPrice = Number(splitProductAndPrice[1]);

        let objProducts = {
            name: productName,
            price: productPrice
        };

        products.push(objProducts);
    });

    //https://dev.to/madanlal/how-to-sort-array-of-object-using-object-keys-in-javascript-58f1
    products = products.sort(function(a, b) {
        let x = a.name.toLowerCase();
        let y = b.name.toLowerCase();

        if (x > y) { return 1; }
        if (x < y) { return -1; }
        return 0;
    });

    let currentChar = '';
    let prevChar = '';
    for (const nameAndPrice of products) {
        currentChar = nameAndPrice.name.charAt(0);

        if (currentChar !== prevChar) {
            console.log(currentChar);
            prevChar = currentChar;
        }

        console.log(`  ${nameAndPrice.name}: ${nameAndPrice.price}`);
    }
}


catalogue([
    'Appricot : 20.4',
    'Fridge : 1500',
    'TV : 1499',
    'Deodorant : 10',
    'Boiler : 300',
    'Apple : 1.25',
    'Anti-Bug Spray : 15',
    'T-Shirt : 10'
]);
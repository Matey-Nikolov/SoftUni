function furniture(input) {

    let pattern = new RegExp(/>>(?<name>[A-Z{0,}a-z]+)+<<(?<price>[\d*\.?\d+]+)+!(?<quant>[\d+]+)/gm);
    let furniture = [];
    let currentMoney = 0;
    let quantity = 0;
    let spendMoney = 0;
    let match = [];

    let commandFurniturOrPurchase = input.shift();
    while (commandFurniturOrPurchase !== 'Purchase') {

        match = commandFurniturOrPurchase.match(pattern);
        match = pattern.exec(match);

        if (match !== null) {
            furniture.push(match.groups['name']);
            currentMoney = Number(match.groups['price']);
            quantity = Number(match.groups['quant']);

            spendMoney += currentMoney * quantity;
        }

        commandFurniturOrPurchase = input.shift();
    }

    console.log('Bought furniture:');
    console.log(furniture.join('\n'));
    console.log(`Total money spend: ${spendMoney.toFixed(2)}`);
}

furniture([">>Sofa<<312.23!3",
    ">>TV<<300!5",
    ">Invalid<<!5",
    "Purchase"
]);
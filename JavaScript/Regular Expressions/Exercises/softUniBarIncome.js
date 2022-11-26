function softUniBarIncome(input) {
    let pattern = /%(?<customer>[A-Z][a-z]+)%[^\|$%\.0-9]*<(?<product>[A-Z][a-z]+)>[^\|$%\.0-9]*\|(?<count>\d+)\|[^\|$%\.0-9]*(?<price>\d+\.?\d*)\$/gm;

    let income = [];
    let bar = {};
    let customerProductCountPrice = input.shift();
    let match = [];

    while (customerProductCountPrice != 'end of shift') {

        match = customerProductCountPrice.match(pattern);
        match = pattern.exec(match);

        if (match !== null) {
            let customer = match.groups['customer'];
            let product = match.groups['product'];
            let count = Number(match.groups['count']);
            let price = Number(match.groups['price']);

            bar = {
                customerName: customer,
                customerProduct: product,
                customerCount: count,
                customerPrice: price * count
            };

            income.push(bar);
        }

        customerProductCountPrice = input.shift();
    }

    let total = 0;
    income.forEach(element => {
        total += element['customerPrice'];
        console.log(`${element['customerName']}: ${element['customerProduct']} - ${element['customerPrice'].toFixed(2)}`);
    });
    console.log(`Total income: ${total.toFixed(2)}`);
}

softUniBarIncome(["%George%<Croissant>|2|10.3$",
    "%Peter%<Gum>|1|1.3$",
    "%Maria%<Cola>|1|2.4$",
    "end of shift"
]);

softUniBarIncome(['%InvalidName%<Croissant>|2|10.3$',
    '%Peter%<Gum>1.3$', '%Maria%<Cola>|1|2.4',
    '%Valid%<Valid>valid|10|valid20$',
    'end of shift'
]);
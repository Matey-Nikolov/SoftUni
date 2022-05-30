let fruit = 'orange';
let weight = 2500;
let price = 1.80;

SolveFruit(fruit, weight, price);

function SolveFruit( product, weight, price )
{
    let fruit = product;

    let currWeight = weight / 1000;
    let money = currWeight * price

    console.log( `I need $${ money.toFixed( 2 ) } to buy ${ currWeight.toFixed( 2 ) } kilograms ${ fruit }.` );
}
let number = 4;

numLayers(number);

function numLayers(number){

    let total = 0;

    total =  0.0005 * Math.pow(2, number);
    console.log(total.toFixed(3) + 'm');
}
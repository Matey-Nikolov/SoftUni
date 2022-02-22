let input1 = 'chocolate';
let input2 = 'ice cream';
let input3 = 'cake';


CalculateAverageLength(input1, input2, input3);

function CalculateAverageLength(input1, input2, input3){

    let sum = 0;

    for(let i = 0; i < input1.length; i++){
        sum++;
    }

    for(let j = 0; j < input2.length; j++){
        sum++;
    }
    for(let j = 0; j < input3.length; j++){
        sum++;
    }
    
    let average = sum / 3;

    console.log(sum);
    console.log(Math.floor(average));
}
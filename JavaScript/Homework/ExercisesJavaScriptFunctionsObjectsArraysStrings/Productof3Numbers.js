let xYZ = [-3, -4, 5];

NegativePositive(xYZ);

function NegativePositive(xYZ){

    let x = xYZ[0];
    let y = xYZ[1];
    let z = xYZ[2];

    if(x * y >= 0 && z >= 0){
        console.log('Positive');
    }
    else{
        console.log('Negative');
    }
}
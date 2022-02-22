let arrayNumbers = [1, 2, 4, 6, 8, 10];

MisingNumbersSum(arrayNumbers);

function MisingNumbersSum(numArray){

    let n = arrayNumbers.length;
    let count = 0;

    for(let i = 0; i < numArray.length; i++){
        while(n < numArray[i]){
            count += n;
            n++;
        }
        n = numArray[i] + 1;
    }
    console.log(count);
}
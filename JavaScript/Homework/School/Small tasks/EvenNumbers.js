let arrayNumber = [2, 4, 6, 8, 10, 3, 120, 9, 5, 1];
                // 0  1  2  3   4  5  6    7  8  9
FilterArray(arrayNumber);

function FilterArray(arrayNumber){

    let result = [];

    for(let i = 0; i <  arrayNumber.length; i++){
        if(arrayNumber[i] % 2 == 0 && i % 2 == 0){
            result[i] = arrayNumber[i];
        }
    }

    console.log(result);
}
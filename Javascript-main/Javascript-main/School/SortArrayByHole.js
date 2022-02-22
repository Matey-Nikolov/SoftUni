let numbersArray = [1, 9, 8, 5, 3, 2, 1, 0];

SortByHoles(numbersArray);

function SortByHoles(numArr){
    
    let hole = [ 1, 0, 0, 0, 1, 0, 1, 0, 2, 1 ];
        //       0  1  2  3  4  5  6  7  8  9
    let first = 0;
    let second = 0;
    let bool = true;

    while(bool){
        for(let i = 0; i < numArr.length - 1; i++){

            first = numArr[i];
            second = numArr[i + 1];
    
            if(hole[first] > hole[second]){
                bool = true;
                numArr[i] = second;
                numArr[i + 1] = first;
            }
            else{
                bool = false;
            }
        }
    }


    console.log(numArr);
}
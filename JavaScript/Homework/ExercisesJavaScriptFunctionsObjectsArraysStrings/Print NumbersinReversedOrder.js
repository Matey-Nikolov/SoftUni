let arrayNumber = [10, 15, 20];

ReverseArray(arrayNumber);

function ReverseArray(numbersArr){

    numbersArr.reverse();

    numbersArr.forEach(element => {
        console.log(element);
    });
}

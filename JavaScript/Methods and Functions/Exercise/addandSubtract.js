function addAndSubtract(first, second, third) {

    let sum = 0;

    //let firstToAdd = first;
    //let secondToAdd = second;

    add(first, second);

    function add(firstToAdd, secondToAdd) {
        sum = firstToAdd + secondToAdd;
    }

    subtract(sum, third);

    function subtract(аddProduct, subtractNumber) {
        sum = аddProduct - subtractNumber
    }

    console.log(sum);
}

addAndSubtract(23, 6, 10);
addAndSubtract(1, 17, 30);
addAndSubtract(42, 58, 100);
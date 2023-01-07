function smallestNumber(first, second, third) {

    let numbers = [first, second, third];

    console.log(Math.min(...numbers));
}

smallestNumber(2, 5, 3);
smallestNumber(600, 342, 123);
smallestNumber(25, 21, 4);
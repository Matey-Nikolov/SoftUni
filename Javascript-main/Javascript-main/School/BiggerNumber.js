function biggerNumber(input) {
    let firstNumber = Number(input[0]);
    let secondNumber = Number(input[1]);
    
    if (firstNumber > secondNumber){
    console.log(firstNumber);
    } else {
    console.log(secondNumber);
    }
}

let number = [50, 20];
biggerNumber(number);
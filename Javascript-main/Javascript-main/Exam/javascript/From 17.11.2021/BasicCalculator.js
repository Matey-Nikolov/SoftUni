let numberAndOperation = [2, '+', 2];

calculator(numberAndOperation);

function calculator(numberAndOperation){

    let number1 = Number(numberAndOperation[0]);
    let operation = numberAndOperation[1];
    let number2 = Number(numberAndOperation[2]);
    let total = 0;

    switch(operation){
        case '+':
            total = number1 + number2;
            console.log(total);
        break;

        case '-':
            total = number1 - number2;
            console.log(total);
        break;

        case '/':
            if(number1 == 0 || number2 == 0){
                console.log("Can't divide by 0!");
                return;
            }
            total = number1 / number2;
            console.log(total);
        break;

        case '*':
            total = number1 * number2;
            console.log(total);
        break;
    }
}
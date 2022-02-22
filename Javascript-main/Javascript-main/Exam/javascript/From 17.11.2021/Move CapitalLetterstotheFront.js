let input = "hApPy";

capToFront(input);

function capToFront(input){

    let lowCase = "";
    let upCase = "";

    for(let i = 0; i < input.length; i++){

        let currentChar = input[i];

        if(currentChar >= 'A' && 'Z' <= currentChar){
            lowCase += currentChar;
        }
        else{
            upCase += currentChar;
        }
    }

    console.log(upCase + "" + lowCase);
}
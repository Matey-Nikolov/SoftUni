let number = 5;
let str = '5';

type(number, str);

function type(number, str){
    if(number % 2 == 0){
        console.log("even number");
    }else{
        console.log("odd number");
    }

    if(number === str){
        console.log(true);
    }else{
        console.log(false);
    }

    if(number == str){
        console.log(true);
    }else{
        console.log(false);
    }

}
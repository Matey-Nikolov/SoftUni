let strA = "Hello";
let strB = "Hello";

EqualLength(strA, strB);

function EqualLength(strA, strB){
    if(strA.length == strB.length){
        console.log("True");
    }
    else{
        console.log("false");
    }
}
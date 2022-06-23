
/*
task 5
let age = 21;

GetDaysFromAge(age);

function GetDaysFromAge(age){
    let days = 0;
    days += age * 365;

    console.log(days);
}
*/
/*
task 7
let strA = "joiwjr3sd";

function CopyStr(strA);

function CopyStr(strA){
    let strCopy = "";

    for(let i = 0; i < strA.length; i++){
        strCopy = strCopy + (strA[i] + strA[i]);
    }
    console.log(strCopy);
}
*/
/*
task 8
let strArray = ["324", "ewf", "efrv", "zw", "cw2", "a2wsw", "2wsda2xb"];

SortArray(strArray)

function SortArray(strArray){
    
    for(let i = 0; i < strArray.length - 1; i++){
        if(strArray[i].length < strArray[i + 1].length){
            let a = strArray[i + 1].length;
            let b = strArray[i];
            strArray[i] = a;
            strArray[i + 1].length = b;
        }
    }
    
    strArray.sort((x,y) => y.length - x.length);

    console.log(strArray);
}
*/
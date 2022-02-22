let trueFalseArray = [true, false, true, true];

Filter(trueFalseArray);

function Filter(trueFalseArray){
    let count = 0;

    for(let i = 0; i < trueFalseArray.length; i++){
        if(trueFalseArray[i] == true){
            count++;
        }
    }

    console.log(count);
}
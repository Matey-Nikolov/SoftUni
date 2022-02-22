let numBox = ([4, 2, 4], [3, 3, 3], [1, 1, 2], [2, 1, 1]);

totalVolume(numBox);

function totalVolume(numBox){

    let total = 0;

    for(let i = 0; i < numBox[0].length; i++){
       
        for(let j = 0; i < numBox[i].length; j++){
            total *= numBox[j];
        }
    }

    console.log(total);
}
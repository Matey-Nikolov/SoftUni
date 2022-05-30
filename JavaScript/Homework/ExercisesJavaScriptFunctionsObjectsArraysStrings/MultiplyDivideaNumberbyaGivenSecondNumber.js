let nX = [3, 2];

MultiplyDivide(nX);

function MultiplyDivide(nX){

    if(nX[1] >= nX[0]){
        console.log(nX[0] * nX[1]);
    }
    else if(nX[0] >= nX[1]){
        console.log(nX[0] / nX[1]);
    }
}
let numbers = [54, 23, 11, 17, 10];

secondLargest(numbers);

function secondLargest(numbers){

    let largest = -1;
    let seconLageNum = -1;

    for (i = 0 ;i < numbers.length; i++){
        
        if (numbers[i] > largest){
            seconLageNum = largest ;
            largest = numbers[i]
        }
        else if (numbers[i] != largest && numbers[i] > seconLageNum ){
            seconLageNum = numbers[i];
        }
    }
    console.log(seconLageNum);
}
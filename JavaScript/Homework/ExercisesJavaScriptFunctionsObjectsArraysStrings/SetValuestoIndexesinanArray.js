

function setIndex(text)
{
    let count = Number(text[0]);
    let newArray = [];
    for(let i = 1; i < text.length; i++) {
        let [index, value] = text[i].split( ' - ' );
        newArray[index] = value;
    }

    for(let j = 0; j < count; j++) {
        if(newArray[j] == undefined) {
            console.log(0);
        }
        else {
            console.log(newArray[j]);
        }
    }
}
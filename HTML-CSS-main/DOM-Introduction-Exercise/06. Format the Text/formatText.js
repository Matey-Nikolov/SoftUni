function solve() {
    let getString = document.getElementById('input').value;
    let output = document.getElementById('output');

    let splitString = getString.split('.').filter(x => x.length > 0);

    let writeParagraph = '';
    let arryText = [];

    /*
    let lastSentence = splitString.pop();
    splitString.push(lastSentence);

    splitString.forEach(element => {
        console.log(splitString);
        arryText.push(element);
        if (arryText.length === 3) {
            writeParagraph = arryText.join('. ') + '.';
            arryText = [];
            output.innerHTML += `<p>${writeParagraph}</p>`;
        }

        if (lastSentence === element) {
            output.innerHTML += `<p>${element}</p>`;
        }
    });
    */

    for (let i = 0; i < splitString.length; i += 3) {
        arryText = [];
        for (let j = 0; j < 3; j++) {
            //console.log(splitString[i + j]);
            if (splitString[i + j]) { // Проверява дали е undefined.
                arryText.push(splitString[i + j]);
            }
        }
    }

    writeParagraph = arryText.join('. ') + '.';
    output.innerHTML += `<p>${writeParagraph}</p>`;
}
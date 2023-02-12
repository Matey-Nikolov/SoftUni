function extractText() {
    const items = document.getElementById('items').children;
    let resultElement = document.getElementById('result');

    let result = Array.from(items).map(x => x.textContent);
    resultElement.value = ' ';
    result.forEach(x => resultElement.value += `${x}\n`);
}
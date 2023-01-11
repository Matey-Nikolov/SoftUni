function solve() {
    let text = document.getElementById('text').value;
    let namingConvention = document.getElementById('naming-convention').value;
    let result = document.getElementById('result');

    text = text.toLowerCase();

    if (namingConvention === 'Camel Case') {
        text = camelize(text);
        result.textContent = text;
    } else if (namingConvention === 'Pascal Case') {
        text = toPascalCase(text)
        result.textContent = text;
    } else {
        result.textContent = 'Error!';
    }

}

//https://lodash.com/docs/4.17.15#camelCase
// https://stackoverflow.com/questions/2970525/converting-any-string-into-camel-case
function camelize(str) {
    return str.replace(/(?:^\w|[A-Z]|\b\w)/g, function(word, index) {
        return index === 0 ? word.toLowerCase() : word.toUpperCase();
    }).replace(/\s+/g, '');
}


// https://stackoverflow.com/questions/4068573/convert-string-to-pascal-case-aka-uppercamelcase-in-javascript
function toPascalCase(string) {
    return `${string}`
        .replace(new RegExp(/[-_]+/, 'g'), ' ')
        .replace(new RegExp(/[^\w\s]/, 'g'), '')
        .replace(
            new RegExp(/\s+(.)(\w*)/, 'g'),
            ($1, $2, $3) => `${$2.toUpperCase() + $3}`
        )
        .replace(new RegExp(/\w/), s => s.toUpperCase());
}
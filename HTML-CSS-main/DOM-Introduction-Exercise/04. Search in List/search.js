function search() {
    let searchText = document.getElementById('searchText').value;
    let divResult = document.getElementById('result');
    let townsTable = document.querySelectorAll('ul li');

    let count = 0;

    for (const tr of townsTable) {

        if (tr.textContent.includes(searchText)) {
            let text = `<bold><u>${tr.textContent}</u></bold>`;
            tr.innerHTML = text;
            console.log(tr.textContent);
            count++;
        }
    }

    divResult.textContent = `${count} matches found`;
}
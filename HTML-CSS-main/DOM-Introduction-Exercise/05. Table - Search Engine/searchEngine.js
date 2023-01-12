function solve() {
    document.querySelector('#searchBtn').addEventListener('click', onClick);

    function onClick() {
        let inputText = document.getElementById('searchField').value;
        let inputTable = document.querySelectorAll('tbody tr');

        //console.log(inputTable);

        for (const tr of inputTable) {
            if (tr.textContent.includes(inputText)) {
                tr.classList.add('select');
            }
        }

        inputText.textContent = '';
    }
}
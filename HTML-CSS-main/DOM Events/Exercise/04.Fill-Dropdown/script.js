function addItem() {
    let getNewItemText = document.getElementById('newItemText'); // .value
    let getNewItemValue = document.getElementById('newItemValue'); // value
    let menu = document.getElementById('menu');

    let opt = document.createElement('option');
    opt.textContent = getNewItemText.value;
    opt.value = getNewItemValue.value;
    menu.appendChild(opt);

    //console.log(menu);

    getNewItemText.value = '';
    getNewItemValue.value = '';
}
function addItem() {
    let text = document.getElementById("newItemText").value;
    let list = document.getElementById("items");
    let entry = document.createElement('li');
    list.appendChild(document.createTextNode(text));
    list.appendChild(entry);
}
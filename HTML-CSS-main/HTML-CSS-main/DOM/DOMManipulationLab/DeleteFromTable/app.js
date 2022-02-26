function deleteByEmail() {
    //TODO:
 let getEmail = document.getElementsByName("email")[0].value;
 let secondColum = document.querySelectorAll("#customers tr td:nth-child(2)");

    for(let td of secondColum){
        if(td.textContent == getEmail){
            let row = td.parentNode;
            row.parentNode.removeChild(row);
        }
    }
}
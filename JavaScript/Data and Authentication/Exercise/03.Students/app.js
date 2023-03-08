const firstNameInput = document.getElementsByName('firstName')[0];
const lastNameInput = document.getElementsByName('lastName')[0];
const facultyNumberInput = document.getElementsByName('facultyNumber')[0];
const gradeinput = document.getElementsByName('grade')[0];

const btnSubmit = document.getElementById('submit');


btnSubmit.addEventListener('click', async (event) =>{
    event.preventDefault();

    displayInformations();


    if(firstNameInput.value !== '' &&
        lastNameInput.value !== '' && 
        facultyNumberInput.value !== '' &&
        gradeinput.value !== ''){

        const student =
        {
            "firstName": firstNameInput.value, 
            "lastName": lastNameInput.value,
            "facultyNumber": facultyNumberInput.value,
            "grade": gradeinput.value
        };
    
        await fetch(`http://localhost:3030/jsonstore/collections/students`, {
            method: 'post',
            headers: { 'Content-type': 'application/json' },
            body: JSON.stringify(student),
        });

    }

});
 
async function displayInformations(){

    const getData =  await fetch(`http://localhost:3030/jsonstore/collections/students`)
        .then(response => response.json());

    const table = document.querySelector('#results > tbody');
    table.innerHTML = '';

    for (const key in getData) {

        const tdFirstName = el('td');
        const tdLastName = el('td');
        const tdFacultyNumber = el('td');
        const tdGrade = el('td');

        const tr = el('tr');

        tdFirstName.innerHTML = getData[key].firstName;
        tdLastName.innerHTML = getData[key].lastName;
        tdFacultyNumber.innerHTML = getData[key].facultyNumber;
        tdGrade.innerHTML = getData[key].grade;
        
        tr.appendChild(tdFirstName);
        tr.appendChild(tdLastName);
        tr.appendChild(tdFacultyNumber);
        tr.appendChild(tdGrade);

        table.appendChild(tr);

    }
    console.log(table);
}

function el(type){
    const element = document.createElement(type);
    return element;
}
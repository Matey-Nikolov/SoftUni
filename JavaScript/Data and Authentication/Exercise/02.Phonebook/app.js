function attachEvents() {
    const ul = document.getElementById('phonebook');
    
    const btnLoad = document.getElementById('btnLoad');
    const btnCreate = document.getElementById('btnCreate');

    btnLoad.addEventListener('click', async () =>{
        ul.textContent = '';
        // console.log(data);
        setDelete(ul, false);
    });

    btnCreate.addEventListener('click', async () =>{
        const personName = document.getElementById('person');
        const phoneNumber = document.getElementById('phone');
        const liCreate = document.createElement('li');

        let dataSend = {
            "person": personName.value,
            "phone": phoneNumber.value
        };

        const dataPost = await fetch(`http://localhost:3030/jsonstore/phonebook`, {
            method: 'post',
            headers: { 'Content-type': 'application/json' },
            body: JSON.stringify(dataSend),
        })
        .then(response => response.json());

        setDelete(ul, true, dataPost._id);

        // console.log(dataPost._id);

        // const li = document.createElement('li');
        // const btnDelete = document.createElement('button');

        // btnDelete.id = dataPost._id;
        // btnDelete.textContent = 'Delete';

        // li.append(personName.value + ": ");
        // li.append(phoneNumber.value + " ");
        // li.append(btnDelete);
        
        // ul.append(li);

        // console.log(btnLoad.click);

    });
}

async function setDelete(ul, bool, id){

    const data = await fetch(`http://localhost:3030/jsonstore/phonebook`)
    .then(response => response.json());

    let createLoadData = {};

    if (bool) {
        // bool = false;
        for (const key in data) {
            if (data[key]._id === id) {
                createLoadData = data[key];
                break;
            }
        }
        console.log(createLoadData);

        const li = document.createElement('li');
        const btnDelete = document.createElement('button');

        btnDelete.id = createLoadData._id;
        btnDelete.textContent = 'Delete';
        
        li.append(createLoadData.person + ": ");
        li.append(createLoadData.phone + " ");
        li.append(btnDelete);
        
        ul.append(li);

        btnDelete.addEventListener('click', async () =>{
            await fetch(`http://localhost:3030/jsonstore/phonebook/${btnDelete.id}`,{
                method: 'delete'
            });
        
            li.outerHTML = '';
        });

    }else{
        for (const key in data) {
            
            const li = document.createElement('li');
            const btnDelete = document.createElement('button');

            btnDelete.id = data[key]._id;
            btnDelete.textContent = 'Delete';
            
            li.append(data[key].person + ": ");
            li.append(data[key].phone + " ");
            li.append(btnDelete);
            
            ul.append(li);

            btnDelete.addEventListener('click', async () =>{
                await fetch(`http://localhost:3030/jsonstore/phonebook/${btnDelete.id}`,{
                    method: 'delete'
                });
            
                li.outerHTML = '';
            });

            if (bool) {
                bool = false;
                break;
            }
        }
    } 
}

attachEvents();
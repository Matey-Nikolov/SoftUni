const btnLoadBook = document.getElementById('loadBooks');
const btnSubmit = document.getElementById('submit');

const titleInput = document.getElementsByName('title')[0];
const authorInput = document.getElementsByName('author')[0];

const editBtns = document.getElementsByName('edit');
const deleteBtns = document.getElementsByName('delete');
let getSaveBtn;

const formSubmit = document.getElementById('formSubmit');

function deleteBook(){
    deleteBtns.forEach(element => {
        element.addEventListener('click', async (event) =>{
            /*
            console.log(element.id);
            fetch('https://example.com/delete-item/' + id, {
                    method: 'DELETE',
                })
            */
            await fetch(`http://localhost:3030/jsonstore/collections/books/${element.id}`, 
            {
                method: 'DELETE'
            });
        });
    });
}


function editBook(){
    editBtns.forEach(element => {
        element.addEventListener('click', async (event) =>{
            event.preventDefault();
            console.log(element.id);
        
            const getBook =  await fetch(`http://localhost:3030/jsonstore/collections/books/${element.id}`)
            .then(response => response.json());
            //.catch(err => );

            const formEdit = document.createElement('form');

            formSubmit.innerHTML = `
            <form>
                <h3>Edit FORM</h3>
                <label>TITLE</label>
                <input type="text" id="editTitle" value="${getBook.title}">
                <label>AUTHOR</label>
                <input type="text" id="editAuthor" value="${getBook.author}">
                <button id="save">Save</button>
            </form>`;

            getSaveBtn = document.getElementById('save');

            
            getSaveBtn.addEventListener('click', async (event) => {
                //event.preventDefault();

                console.log(formSubmit);

                const editTitleInput = document.getElementById('editTitle');
                const editAuthorInput = document.getElementById('editAuthor');

                const book = 
                {
                    "author": editTitleInput.value,
                    "title": editAuthorInput.value,
                    "_id": element.id
                };
    
                editTitleInput.innerHTML = '';
                editAuthorInput.innerHTML = '';

                //https://jasonwatmore.com/post/2021/09/20/fetch-http-put-request-examples
                const response = await fetch(`http://localhost:3030/jsonstore/collections/books/${element.id}`, {
                    method: 'PUT',
                    headers: { 'Content-Type': 'application/json' },
                    body: JSON.stringify(book) 
                });
            });
        });
    });


}



btnSubmit.addEventListener('click', async (event) => {
    event.preventDefault();

    if(authorInput.value !== '' && titleInput.value !== ''){

        //console.log('ok');
        const book = 
        {
            "author": authorInput.value,
            "title": titleInput.value,
        };
    
        authorInput.value = '';
        titleInput.value = '';

        await fetch(`http://localhost:3030/jsonstore/collections/books`, {
            method: 'post',
            headers: { 'Content-type': 'application/json' },
            body: JSON.stringify(book),
        });
    }
});

btnLoadBook.addEventListener('click', async (event) =>{
    event.preventDefault();

    const table = document.querySelector('#results > tbody');
    table.innerHTML = '';

    const getBooks =  await fetch(`http://localhost:3030/jsonstore/collections/books`)
    .then(response => response.json());

    for (const key in getBooks) {

        const tdTitle= el('td');
        const tdAuthor = el('td');
        const tdAction = el('td');

        tdAction.innerHTML = 
        `<td>
            <button id=${getBooks[key]._id} name="edit">Edit</button>
            <button id=${getBooks[key]._id} name="delete">Delete</button>
        </td>`

        tdTitle.innerHTML = getBooks[key].title;
        tdAuthor.innerHTML = getBooks[key].author;

        const tr = el('tr');
        tr.appendChild(tdTitle);
        tr.appendChild(tdAuthor);
        tr.appendChild(tdAction);

        table.appendChild(tr);
    }

    deleteBook();
    editBook();
});

function el(type){
    const element = document.createElement(type);
    return element;
}
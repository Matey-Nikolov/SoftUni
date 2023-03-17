async function solution() {

    const section = document.getElementById('main');

    const articlesList = await fetch(`http://localhost:3030/jsonstore/advanced/articles/list`)
    .then(response => response.json());

    for (const key in articlesList) {

        console.log(articlesList[key]);
        const div = document.createElement('div');

        div.innerHTML = 
        `<div class="accordion">
            <div class="head">
                <span>${articlesList[key].title}</span>
                <button class="button" id="${articlesList[key]._id}">More</button>
            </div>
            <div class="extra" style="display: none;">
                <p></p>
            </div>
        </div>`
        section.appendChild(div);

        console.log(section);
    }

    const getBtn = document.getElementsByClassName('button');

    let count = 1;

    for (const el of getBtn) {
        const getDivAccordion = document.getElementsByClassName('extra')[count++ - 1];
        
        // console.log();

        el.addEventListener('click', async () =>{
            // console.log(getDivAccordion);
            // console.log(el.id);

            if (getDivAccordion.style.display === 'none') {
                const data = await fetch(`http://localhost:3030/jsonstore/advanced/articles/details/${el.id}`);
                const desData = await data.json();
                el.textContent = 'Less';
                getDivAccordion.style.display = 'block';
                getDivAccordion.children[0].textContent = desData.content;
            } else {
                el.textContent = 'More';
                getDivAccordion.style.display = 'none';
            }
        });
    }
}

document.addEventListener('DOMContentLoaded', solution)
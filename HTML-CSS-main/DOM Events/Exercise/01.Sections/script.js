function create(words) {
    words.forEach(element => {

        let p = document.createElement('p');
        let div = document.createElement('div');

        p.textContent = element;
        p.style.display = 'none';

        div.appendChild(p);
        //console.log(div);
        div.addEventListener('click', () => {
            p.style.display = 'block';
        });

        let contet = document.getElementById('content');
        contet.appendChild(div);
    });
}
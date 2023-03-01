async function lockedProfile() {

    const data = await fetch(`http://localhost:3030/jsonstore/advanced/profiles`)
	const dataJSON = await data.json()
    
    const main = document.getElementById('main');
    main.innerHTML = '';

    const div = document.createElement('div');
    const btn = document.createElement('button');

    for (const key in dataJSON)
    {
        btn.textContent = 'Show more';
        div.className = 'profile';
        div.innerHTML = `
        <img src="./iconProfile2.png" class="userIcon"> />
        <label>Lock</label>
        <input type="radio" name="user${dataJSON[key].id}Locked" value="lock" checked>
        <label>Unlock</label>
        <input type="radio" name="user${dataJSON[key].id}Locked" value="unlock"><br>
        <hr>
        <label>Username</label>
        <input type="text" name="user${dataJSON[key].id}Username" value=${dataJSON[key].username} disabled readonly />
        <div id="user2HiddenFields">
            <hr>
            <label>Email:</label>
            <input type="email" name="user${dataJSON[key].id}Email" value=${dataJSON[key].email} disabled readonly />
            <label>Age:</label>
            <input type="email" name="user${dataJSON[key].id}Age" value=${dataJSON[key].age} disabled readonly />
        </div>
        <button>Show more</button>`;

        btn.addEventListener('click', () => {
            const checked = div.querySelector('input[type=radio]:checked')
            if (checked && checked.value === 'unlock') {
                if (btn.innerText === 'Show more') {
                    div.querySelector(`#user${dataJSON[key].id}HiddenFields`).style.display = 'block'
                    btn.innerText = 'Hide it'
                } else {
                    div.querySelector(`#user${dataJSON[key].id}HiddenFields`).style.display = 'none'
                    btn.innerText = 'Show more'
                }
            }
        })

        div.appendChild(btn);
        main.appendChild(div);
    }

    

}
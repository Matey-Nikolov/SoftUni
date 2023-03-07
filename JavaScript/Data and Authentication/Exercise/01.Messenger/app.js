function attachEvents() {
    //const data = {title:'First Post', content:'Hello, Server!'};

    const submitBtn = document.getElementById('submit');
    const refreshBtn = document.getElementById('refresh');
    const textarea = document.getElementById('messages');

    submitBtn.addEventListener('click', async () =>{

        const authorText = document.getElementById('controls').children[1];
        const contentText = document.getElementById('controls').children[4];

        //console.log('ook');
        const aurhorAndContent = 
        {
            author: authorText.value,  
            content:  contentText.value
        };

        authorText.value = '';
        contentText.value = '';

        await fetch(`http://localhost:3030/jsonstore/messenger`, {
            method: 'post',
            headers: { 'Content-type': 'application/json' },
            body: JSON.stringify(aurhorAndContent),
        }); 


    });

    refreshBtn.addEventListener('click', async () =>{
        
        textarea.textContent = '';
        const getMessage = await fetch(`http://localhost:3030/jsonstore/messenger`)
        .then(response => response.json());

        for (const key in getMessage) {
            textarea.textContent += `${getMessage[key].author}: ${getMessage[key].content}`;
            textarea.textContent += '\n';
        }
    });
}

attachEvents();
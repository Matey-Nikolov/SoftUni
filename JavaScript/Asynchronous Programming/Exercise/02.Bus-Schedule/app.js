function solve() {

    let getInfo = document.getElementById('info');
    let buttonDepart = document.getElementById('depart');
    let buttonArrive = document.getElementById('arrive');

   async function getData(){
        const stops = await fetch(`http://localhost:3030/jsonstore/bus/schedule/${nextStop}`) // schedule/serdtfdepot
        .then(response => response.json())
        .catch(err => 
            {
                getInfo.textContent = 'Error';
                buttonDepart.disabled = true;
                buttonArrive.disabled = true;
            });

        return stops;
    }

    let nextStop = 'depot';

    async function depart() {
        buttonDepart.disabled = true;
        buttonArrive.disabled = false;

        nextStop = await getData();

        //console.log(nextStop);
        getInfo.textContent = `Next stop ${nextStop.name}`;
    }

    function arrive() {
        buttonDepart.disabled = false;
        buttonArrive.disabled = true;
        
        getInfo.textContent = `Arriving at ${nextStop.name}`;

        nextStop = nextStop.next;
    }

    return {
        depart,
        arrive
    };
}

let result = solve();
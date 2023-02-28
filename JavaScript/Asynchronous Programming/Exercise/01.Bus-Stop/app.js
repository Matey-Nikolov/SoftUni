async function getInfo() {
    let stopId = document.getElementById('stopId').value;
    let resultStopName = document.getElementById('stopName');
    let resultBuses = document.getElementById('buses');
    
    //console.log(stopId);

    async function getData(){

        resultBuses.textContent = '';
        const response  = await fetch(`http://localhost:3030/jsonstore/bus/businfo/${stopId}`)
        .then(response => response.json())
        .catch(err => 
            {
                resultStopName.textContent = 'Error'
            });

        return response;
    }

  

    //console.log(response);
    let dataJSON = await getData()

    //console.log(dataJSON);

    for (const key in dataJSON) {
      // console.log(dataJSON[key]);

        if(key === 'name'){
            console.log(dataJSON[key]);
            resultStopName.textContent = dataJSON[key];
        }else{
            for (const stopBuses in dataJSON[key]) {
                //console.log(stopBuses);

                const e = document.createElement('li');
                e.innerHTML = `Bus ${stopBuses} arrives in ${dataJSON[key][stopBuses]}`;

                resultBuses.appendChild(e);
            }
        }
    }

}
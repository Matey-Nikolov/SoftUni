function attachEvents() {
    
    const btnGetWeather = document.getElementById('submit');

    btnGetWeather.addEventListener('click', () => displayinformations());
}



async function getData(nameURL){
    const dataForeCaster = await fetch(`http://localhost:3030/jsonstore/forecaster/${nameURL}`)
    .then(response => response.json());

    return dataForeCaster;
}

async function displayinformations(){

    const inputLocation = document.getElementById('location').value;

    outputVisibility('block');

    const getForecasterLocations = await getData('locations');
    //console.log(getForecasterLocations);
    const getForecasterToday = await getData(`today/${inputLocation}`);
    //console.log(getForecasterToday);
    const get_3_Day_Forecast = await getData(`upcoming/${inputLocation}`);
    console.log(get_3_Day_Forecast);

}



attachEvents();
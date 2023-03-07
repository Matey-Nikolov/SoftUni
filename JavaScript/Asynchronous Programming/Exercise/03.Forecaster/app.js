async function getData(nameURL){
    const dataForeCaster = await fetch(`http://localhost:3030/jsonstore/forecaster/${nameURL}`)
    .then(response => response.json())
    .catch(err => 
        {
            //divForecast.textContent = 'Error';
        });

    return dataForeCaster;
}

function weather3Days(days3Forecast){

    let divNew = document.createElement('div');
    divNew.className = 'forecasts-info';

    let getSymbol;
    let getLowTemperature;
    let getHighTemperature;
    let getCondition;

    for (const key in days3Forecast) {
        days3Forecast[key].forEach(element => {

            switch(element.condition){
                case 'Sunny':
                    getSymbol = '&#x2600;';
                    break;
                case 'Partly sunny':
                    getSymbol = '&#x26C5;';
                    break;
                case 'Overcast':
                    getSymbol = '&#x2601;';
                    break;
                case 'Rain':
                    getSymbol = '&#x2614;';
                    break;
           }

            getLowTemperature = element.low;
            getHighTemperature = element.high;
            getCondition = element.condition;


            let div3Days = document.createElement('div');
            div3Days.innerHTML = `
                <span class="upcoming">
                    <span classs="symbol">${getSymbol}</span>
                    <span classs="forecast-data">${getLowTemperature}&#176;/${getHighTemperature}&#176;</span>
                    <span classs="forecast-data">${getCondition}</span>
                </span>`

            divNew.appendChild(div3Days);
        });
        break;
    }
    
   return divNew;
}

function weatherToday(getForecasterToday){
    //London - Rain
    let getSymbol;
    let getNameCity;
    let getCondition;
    let getLowTemperature;
    let getHighTemperature;

    for (const key in getForecasterToday) {

        getNameCity = getForecasterToday.name;
        getCondition = getForecasterToday[key].condition;
        getLowTemperature = getForecasterToday[key].low;
        getHighTemperature = getForecasterToday[key].high;

        // New York, London
        switch(getForecasterToday[key].condition){
            case 'Sunny':
                getSymbol = '&#x2600;';
                break;
            case 'Partly sunny':
                getSymbol = '&#x26C5;';
                break;
            case 'Overcast':
                getSymbol = '&#x2601;';
                break;
            case 'Rain':
                getSymbol = '&#x2614;';
                break;
       }

       break;
    }

    const divToday = document.createElement('div');
    divToday.className = 'forecasts';
    divToday.innerHTML = `<span class="condition symbol">${getSymbol}</span>
        <span class="condition">
            <span classs="forecast-data">${getNameCity}</span>
            <span classs="forecast-data">${getLowTemperature}&#176;/${getHighTemperature}&#176;</span>
            <span classs="forecast-data">${getCondition}</span>
        </span>`
    
    //console.log(divToday);

    return divToday;
}

async function displayInformations(){

    const inputLocation = document.getElementById('location').value;
    const divForecast = document.getElementById('forecast');
    const divCurrentConditions = document.getElementById('current');
    const divThreeDayForecast = document.getElementById('upcoming');

    divForecast.style.display = 'block';
    //clearSections();
   

    const getForecasterLocation = await getData('locations');

    let getNameLocationCode;

    for (const key in getForecasterLocation) {
        if(getForecasterLocation[key].name === inputLocation){
            getNameLocationCode = getForecasterLocation[key].code;
        }
    }

    const getForecasterToday = await getData(`today/${getNameLocationCode}`);

    const getTodayWeather = weatherToday(getForecasterToday);
    divCurrentConditions.appendChild(getTodayWeather);

    const get_3_Day_Forecast = await getData(`upcoming/${getNameLocationCode}`);

    const get3DaysWeather = weather3Days(get_3_Day_Forecast);
    divThreeDayForecast.appendChild(get3DaysWeather);
}

function attachEvents() {
    
    const btnGetWeather = document.getElementById('submit');

    btnGetWeather.addEventListener('click', () => displayInformations());
}

attachEvents();
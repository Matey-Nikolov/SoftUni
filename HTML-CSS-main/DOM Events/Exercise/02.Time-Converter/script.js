function attachEventsListeners() {

    let days = document.getElementById('days');
    let hours = document.getElementById('hours');
    let minutes = document.getElementById('minutes');
    let seconds = document.getElementById('seconds');


    let daysBtn = document.getElementById('daysBtn');
    let hoursBtn = document.getElementById('hoursBtn');
    let minutesBtn = document.getElementById('minutesBtn');
    let secondsBtn = document.getElementById('secondsBtn');


    daysBtn.addEventListener('click', () => {
        hours.value = days.value * 24;
        minutes.value = hours.value * 60;
        seconds.value = minutes.value * 60;
    });

    hoursBtn.addEventListener('click', () => {
        days.value = hours.value / 24;
        minutes.value = hours.value * 60;
        seconds.value = minutes.value * 60;
    });

    minutesBtn.addEventListener('click', () => {
        days.value = hours.value / 24;
        hours.value = seconds.value / 60;
        //console.log(seconds);
        seconds.value = minutes.value * 60;
    });

    secondsBtn.addEventListener('click', () => {
        //console.log('ok');
        days.value = hours.value / 24;
        hours.value = minutes.value / 60;
        minutes.value = seconds.value / 24;
    });

    /*
        let btnAll = [];
        btnAll.unshift(daysBtn, hoursBtn, minutesBtn, secondsBtn);
        console.log(btnAll);

        btnAll.forEach(btn => {
            btn.addEventListener('click', () => {


                if (daysBtn === btn) {
                    //console.log('ok');

                    hours.value = days.value * 24;
                    minutes.value = hours.value * 60;
                    seconds.value = minutes.value * 60;

                    //console.log(hours, minutes, seconds);
                } else if (hoursBtn === btn) {
                    seconds.value = minutes.value * 60;
                    minutes.value = hours.value * 60;
                    days.value = hours.value / 24;
                } else if (minutesBtn === btn) {
                    seconds.value = minutes.value * 60;
                    hours.value = seconds.value / 60;
                    days.value = hours.value / 24;
                } else {
                    //console.log('ok');
                    minutes.value = seconds.value / 24;
                    hours.value = minutes.value / 60;
                    days.value = hours.value / 24;
                }
            });
        });
    */
}
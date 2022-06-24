let hours = 24;
let minutes = 34;

SecondsFtomHoursAndMinutes(hours, minutes)

function SecondsFtomHoursAndMinutes(hours, minutes){
    let seconds = 0;
    seconds = (hours * 60) * 60 + (minutes * 60);

    console.log(seconds);
}
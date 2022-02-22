let areaCountry = ["Iran", 1648195];

areaOfCountry(areaCountry);

function areaOfCountry(areaCountry){

    let country = areaCountry[0];
    let area = Number(areaCountry[1]);

    let worldlandmass = 148940000;

    let percent = (area/worldlandmass) * 100;
    
    console.log(country + " is " + percent.toFixed(2) + "% of the total world's landmass");
}
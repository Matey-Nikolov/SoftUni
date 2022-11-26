function netherRealm(input) {

    let nameHealthDamages = [];
    let splitOptions = /[,? ?]+/g;

    let codeText = input.split(splitOptions);
    //console.log(codeText);


    const patternWordHealth = /[A-za-z]+/g;
    const patternDamage = /[-?\d.?]+/g;
    const paternMultiaOrDivision = /[\/|*]+/g;

    codeText.forEach(text => {

        let health = 0;
        let damage = 0;
        let letter = '';

        let codeWordMatch = [...text.matchAll(patternWordHealth)];

        codeWordMatch.forEach(chr => {
            letter += chr.toString();
        });
        //console.log(letter); // ok

        letter.split('').forEach(chr => {
            health += Number(chr.charCodeAt(0));
        });
        //console.log(health); // ok

        let codeNumbers = [...text.matchAll(patternDamage)];

        codeNumbers.forEach(digit => {
            damage += Number(digit.toString());
        });
        //console.log(damage); // Ok 50%

        let multiAndDivision = [...text.matchAll(paternMultiaOrDivision)];

        multiAndDivision.forEach(item1 => {
            let getChars = item1[0].split('');

            getChars.forEach(item2 => {
                if (item2 === '*') {
                    damage *= 2;
                } else if (item2 === '/') {
                    damage /= 2;
                }
            });
        });
        ///console.log(damage); // Ok 100%

        let nameHealthDamage = {
            name: text,
            health: health,
            damage: damage
        };

        nameHealthDamages.push(nameHealthDamage);
    });

    nameHealthDamages = nameHealthDamages.sort((a, b) => a.name.localeCompare(b.name));

    nameHealthDamages.forEach(NHD => {
        console.log(`${NHD.name} - ${NHD.health} health, ${(NHD.damage).toFixed(2)} damage`);
    });

}

netherRealm('M3ph-0.5s-0.5t0.0**');
netherRealm('M3ph1st0**, Azazel');
netherRealm('Gos/ho');
function dictionary(input) {

    let dictionary = {};

    input.forEach(text => {
        //https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/JSON/parse
        //https://www.tutorialrepublic.com/javascript-tutorial/javascript-json-parsing.php
        let termAndDefinition = JSON.parse(text);
        dictionary = Object.assign(dictionary, termAndDefinition);
    });

    // https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Object/keys
    let sortByKeys = Object.keys(dictionary).sort((a, b) => a.localeCompare(b))

    sortByKeys.forEach(termDefin => {

        console.log(`Term: ${termDefin} => Definition: ${dictionary[termDefin]}`);
    });
}


dictionary([
    '{"Coffee":"A hot drink made from the roasted and ground seeds(coffee beans) of a tropical shrub."}',
    '{"Bus":"A large motor vehiclecarrying passengers by road, typically one serving the public on a fixed route and for a fare."}',
    '{"Boiler":"A fuel-burning apparatus or container for heating water."}',
    '{"Tape":"A narrow strip ofmaterial, typically used to hold or fasten something."}',
    '{"Microphone":"An instrument for converting sound waves into electrical energy variations which may then be amplified, transmitted, or recorded."}'
]);
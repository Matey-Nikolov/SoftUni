function partyTime(inputArray) {
    let normalSet = new Set();
    let vipSet = new Set();
    let counter = 0;

    for (let element of inputArray) {

        if (element === 'PARTY') {
            break;
        }

        if (Number(element[0]) >= 0) {
            vipSet.add(element);
        } else {
            normalSet.add(element);
        }

        counter++;
    }

    let after = inputArray.splice(inputArray.indexOf("PARTY"));
    after.shift();

    for (let el of after) {

        if (normalSet.has(el)) {
            normalSet.delete(el);
            counter--;
        } else if (vipSet.has(el)) {
            vipSet.delete(el)
            counter--;
        }
    }

    console.log(counter);
    console.log(Array.from(vipSet).concat(Array.from(normalSet)).join('\n'));
    //console.log(Array.from(normalSet).join('\n'));

}


partyTime(['m8rfQBvl',
    'fc1oZCE0',
    'UgffRkOn',
    '7ugX7bm0',
    '9CQBGUeJ',
    '2FQZT3uC',
    'dziNz78I',
    'mdSGyQCJ',
    'LjcVpmDL',
    'fPXNHpm1',
    'HTTbwRmM',
    'B5yTkMQi',
    '8N0FThqG',
    'xys2FYzn',
    'MDzcM9ZK',
    'PARTY',
    '2FQZT3uC',
    'dziNz78I',
    'mdSGyQCJ',
    'LjcVpmDL',
    'fPXNHpm1',
    'HTTbwRmM',
    'B5yTkMQi',
    '8N0FThqG',
    'm8rfQBvl',
    'fc1oZCE0',
    'UgffRkOn',
    '7ugX7bm0',
    '9CQBGUeJ'
])
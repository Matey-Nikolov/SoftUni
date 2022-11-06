function addressBook(input) {

    let addressBook1 = {};

    for (let line of input) {
        let [name, address] = line.split(':');
        addressBook1[name] = address;
    }
    let sorted = Object.entries(addressBook1);

    sorted.sort((a, b) => a[0].localeCompare(b[0]));

    for (let [key, value] of sorted) {

        console.log(`${key} -> ${value}`);

    }

}

addressBook(['Tim:Doe Crossing',
    'Bill:Nelson Place',
    'Peter:Carlyle Ave',
    'Bill:Ornery Rd'
])
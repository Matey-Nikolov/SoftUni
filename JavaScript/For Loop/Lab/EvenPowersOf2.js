function EvenPowersOf2(input) {

    let element = parseInt(input)
    let number = 1
    for (let i = 0; i <= element; i += 2) {
        console.log(number)
        number = number * 2 * 2
    }
}

EvenPowersOf2([("6")])
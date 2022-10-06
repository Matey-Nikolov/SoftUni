function invalidNumber(input) {
    const number = Number(input)

    if (number === 0) {
        return
    }

    if (number >= 100 && number <= 200) {
        return
    }


    console.log('invalid')
}

invalidNumber(220)
invalidNumber(0)
invalidNumber(200)
invalidNumber(-1)
invalidNumber(199)
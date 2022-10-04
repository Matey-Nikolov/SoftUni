function cinema(type, row, col) {

    let numberOfRows = Number(row)
    let numberOfColumns = Number(col)
    let totalPrice = 0
    switch (type) {
        case 'Premiere':
            totalPrice = numberOfRows * numberOfColumns * 12.00
            break
        case 'Normal':
            totalPrice = numberOfRows * numberOfColumns * 7.50
            break
        case 'Discount':
            totalPrice = numberOfRows * numberOfColumns * 5.00
            break
    }

    console.log(`${totalPrice.toFixed(2)} leva`)
}

cinema("Premiere", "10", "12")
cinema("Normal", "21", "13")
cinema("Discount", "12", "30")
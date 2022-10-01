function fruitShop(product, dayOfWeek, quantity) {

    let quantityint = Number(quantity)
    let price = 0

    switch (dayOfWeek) {
        case 'Saturday':
            switch (product) {
                case 'banana':
                    price = 2.70
                    break
                case 'apple':
                    price = 1.25
                    break
                case 'orange':
                    price = 0.90
                    break
                case 'grapefruit':
                    price = 1.60
                    break
                case 'kiwi':
                    price = 3.00
                    break
                case 'pineapple':
                    price = 5.60
                    break
                case 'grapes':
                    price = 4.20
                    break
            }
            break
        case 'Sunday':
            switch (product) {
                case 'banana':
                    price = 2.70
                    break
                case 'apple':
                    price = 1.25
                    break
                case 'orange':
                    price = 0.90
                    break
                case 'grapefruit':
                    price = 1.60
                    break
                case 'kiwi':
                    price = 3.00
                    break
                case 'pineapple':
                    price = 5.60
                    break
                case 'grapes':
                    price = 4.20
                    break
            }
            break
        default:

            if ('Workday' === dayOfWeek) {
                break
            }

            switch (product) {
                case 'banana':
                    price = 2.50
                    break
                case 'apple':
                    price = 1.20
                    break
                case 'orange':
                    price = 0.85
                    break
                case 'grapefruit':
                    price = 1.45
                    break
                case 'kiwi':
                    price = 2.70
                    break
                case 'pineapple':
                    price = 5.50
                    break
                case 'grapes':
                    price = 3.85
                    break
            }
            break
    }

    let totalPrice = quantityint * price

    if (totalPrice === 0) {
        console.log('error')
        return
    }

    console.log(totalPrice.toFixed(2))
}

fruitShop('grapes',
    'Saturday',
    '0.5')

fruitShop('apple',
    'Saturday',
    '2')

fruitShop('grapefruit',
    'Saturday',
    '1.25')

fruitShop('apple',
    'Workday',
    '2')
function shop(product, city, quantity) {

    let quantityInt = Number(quantity);
    let totalPrice = 0

    switch (city) {
        case 'Sofia':
            switch (product) {
                case 'coffee':
                    totalPrice = quantityInt * 0.50
                    break
                case 'water':
                    totalPrice = quantityInt * 0.80
                    break
                case 'juice':
                    totalPrice = quantityInt * 1.20
                    break
                case 'sweets':
                    totalPrice = quantityInt * 1.45
                    break
                case 'peanuts':
                    totalPrice = quantityInt * 1.60
                    break
            }
            break

        case 'Plovdiv':
            switch (product) {
                case 'coffee':
                    totalPrice = quantityInt * 0.40
                    break
                case 'water':
                    totalPrice = quantityInt * 0.70
                    break
                case 'juice':
                    totalPrice = quantityInt * 1.15
                    break
                case 'sweets':
                    totalPrice = quantityInt * 1.30
                    break
                case 'peanuts':
                    totalPrice = quantityInt * 1.50
                    break
            }
            break

        case "Varna":
            switch (product) {
                case "coffee":
                    totalPrice = quantityInt * 0.45
                    break
                case "water":
                    totalPrice = quantityInt * 0.70
                    break
                case "juice":
                    totalPrice = quantityInt * 1.10
                    break
                case "sweets":
                    totalPrice = quantityInt * 1.35
                    break
                case "peanuts":
                    totalPrice = quantityInt * 1.55
                    break
            }
            break
    }

    console.log(totalPrice)
}

shop('coffee', 'Sofia', '2')
shop('juice', 'Sofia', '6')
shop("sweets", "Sofia", "2.23")
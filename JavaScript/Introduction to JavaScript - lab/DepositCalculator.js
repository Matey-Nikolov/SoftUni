function depositCalculator(amount, deposit, rate) {

    let depositPeriod = amount + deposit * ((amount * rate / 100) / 12)

    console.log(depositPeriod)
}

depositCalculator(200, 3, 5.7)
depositCalculator(2350, 6, 7)
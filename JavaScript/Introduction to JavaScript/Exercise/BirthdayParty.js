function birthdayParty(input) {
    let hall = input
    let priceCake = hall * 0.2
    let priceDrinks = priceCake - (priceCake * 0.45)
    let priceAnimator = 1 / 3 * hall

    let budgetNeeded = hall + priceCake + priceDrinks + priceAnimator;
    console.log(budgetNeeded)
}

birthdayParty(2250)
birthdayParty(3720)
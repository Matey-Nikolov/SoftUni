function fruitOrVegetable(plantName) {

    const fruit = ['banana', 'apple', 'kiwi', 'cherry', 'lemon', 'grapes']
    const vegetable = ['tomato', 'cucumber', 'pepper', 'carrot']

    for (let i = 0; i <= fruit.length; i++) {
        if (plantName === fruit[i]) {
            console.log('fruit');
            return
        }
    }

    for (let i = 0; i <= vegetable.length; i++) {
        if (plantName === vegetable[i]) {
            console.log('vegetable');
            return
        }
    }

    console.log('unknown')
}

fruitOrVegetable('banana')
fruitOrVegetable('apple')
fruitOrVegetable('water')
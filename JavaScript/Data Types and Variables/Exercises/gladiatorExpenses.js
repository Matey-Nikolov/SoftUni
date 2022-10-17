function gladiatorExpenses(arg1, arg2, arg3, arg4, arg5) {

    let lostFightsCount = arg1;
    let helmetPrice = arg2;
    let swordPrice = arg3;
    let shieldPrice = arg4;
    let armorPrice = arg5;

    let helmetBroken = 0;
    let swordBroken = 0;
    let shieldBroken = 0;
    let armourBroken = 0;

    let shieldCount = 0;

    for (let i = 1; i <= lostFightsCount; i++) {

        if (i % 2 === 0) {
            helmetBroken++;
            if (i % 3 === 0) {
                swordBroken++;
                shieldBroken++;
                shieldCount++;
            }
        } else if (i % 3 === 0) {
            swordBroken++;
        }

        if (shieldCount == 2) {
            shieldCount = 0;
            armourBroken++;
        }
    }

    let expenses = helmetBroken * helmetPrice;
    expenses += (swordBroken * swordPrice);
    expenses += (shieldBroken * shieldPrice);
    expenses += (armourBroken * armorPrice);

    console.log(`Gladiator expenses: ${expenses.toFixed(2)} aureus`);
}

gladiatorExpenses(7, 2, 3, 4, 5);
gladiatorExpenses(23, 12.50, 21.50, 40, 200);
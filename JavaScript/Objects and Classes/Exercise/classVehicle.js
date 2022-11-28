class Vehicle {

    constructor(type, model, parts, fuel) {

        this.type = type;
        this.model = model;
        this.parts = {
                engine: parts[0],
                power: parts[1],
                quality: () => {
                    engine * power;
                }
            },
            this.fuel = fuel;
    };

    drive(input) {
        return this.fuel -= input;
    }
};

let parts = { engine: 6, power: 100 };
let vehicle = new Vehicle('a', 'b', parts, 200);
vehicle.drive(100);
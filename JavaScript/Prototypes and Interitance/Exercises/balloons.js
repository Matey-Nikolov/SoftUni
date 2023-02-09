function solution(){
    class Balloon{
        constructor(color, gasWeight){
            this.color = color;
            this.gasWeight = gasWeight;
        }
    }

    class PartyBalloon extends Balloon{
        constructor(color, gasWeight, ribbonColor, ribbonLength){
            super(color, gasWeight);
            this.ribbonColor = ribbonColor;
            this.ribbonLength = ribbonLength;
            this._ribbon1 = 
            {
                color: this.ribbonColor, 
                length: this.ribbonLength
            };
        }

        get ribbon(){
            return this._ribbon1;
        }
    }

    class BirthdayBalloon extends PartyBalloon{
        constructor(ribbonColor, ribbonLength, text){
            super(ribbonColor, ribbonLength);
            this._text1 = text;
        }

        get text(){
            return this._text1;
        }
    }

    return{
        Balloon: Balloon,
        PartyBalloon: PartyBalloon,
        BirthdayBalloon: BirthdayBalloon
    }
}

let classes = solution();

let testBalloon = new classes.Balloon("Tumno-bqlo", 20.5);
let testPartyBalloon = new classes.PartyBalloon("Tumno-bqlo", 20.5, "Svetlo-cherno", 10.25);
let ribbon = testBalloon.ribbon;

console.log(testBalloon.gasWeight);
console.log(testBalloon);
console.log(testPartyBalloon);
console.log(ribbon);
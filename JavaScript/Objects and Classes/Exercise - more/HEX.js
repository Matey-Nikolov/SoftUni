class Hex {

    constructor(iputHEX){
        this.HEX = iputHEX;
    }

    valueOf(){
        return this.HEX;
    }

    toString(){
        //https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Number/toString
        //return '0x' + this.Hex.toString(16);
        return `0x${(this.HEX.toString(16)).toUpperCase()}`
    }

    plus(number){
        let newHEX = 0;
        newHEX = this.HEX + Number(number.valueOf());
        return new Hex(newHEX);
    }

    minus(number){
        let newHEX = 0;
        newHEX = this.HEX - Number(number.valueOf());
        return new Hex(newHEX);
    }

    parse(string) {
        return parseInt(string, 16);
    }
}


let FF = new Hex(255);
console.log(FF.toString());
FF.valueOf() + 1 == 256;
let a = new Hex(10);
let b = new Hex(5);
console.log(a.plus(b).toString());
console.log(a.plus(b).toString()==='0xF');
console.log(Hex.parse('AAA'));
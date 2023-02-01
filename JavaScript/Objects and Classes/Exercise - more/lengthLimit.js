class Stringer{

    constructor(stringInput, lengthIput){
        this.innerString = stringInput;
        this.innerLength = lengthIput;
    }

    increase(length){
        this.innerLength += length;
    }

    decrease(length){
        this.innerLength -= length;

        if (this.innerLength < 0) {
            this.innerLength = 0;
        }
    }

    toString() {
        if(this.innerLength === 0){
            return '...';
        }
        
        if(this.innerString.length === this.innerLength){
            return this.innerString;
        }else{
           // return '...' + this.innerString.substring(this.innerString.length, this.innerLength);
           return this.innerString.substring(0, this.innerLength) + '...';
        }
    }
}

let test = new Stringer("Test", 5);
console.log(test.toString()); // Test

test.decrease(3);
console.log(test.toString()); // Te...

test.decrease(5);
console.log(test.toString()); // ...

test.increase(4);
console.log(test.toString()); // Test
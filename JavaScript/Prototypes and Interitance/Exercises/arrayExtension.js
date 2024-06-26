let myArr = [1, 2, 3];

Array.prototype.last = () =>{
    return this[this.length - 1];
};

Array.prototype.skip = () =>{
    let result = [];

    for (let i = 0; i < this.length; i++) {
        result.push(this[i]);
    }

    return result;
};

Array.prototype.take = (n) =>{
    let result = [];

    for (let i = 0; i < n; i++) {
        result.push(this[i]);
    }

    return result;
};

Array.prototype.sum = () =>{
    let sum = 0;

    for (let i = 0; i < this.length; i++) {
        sum += this[i];
    }

    return sum;
};

Array.prototype.average = () => {
    return this.sum / this.length;
};

(function solve() {
    Array.prototype.last = function () {
        return this[this.length - 1];
    };
    
    Array.prototype.skip = function (n) {
        let result = [];
        for (var i = n; i < this.length; i++) {
            result.push(this[i]);
        }
        return result;
    }

    Array.prototype.take = function (n) {
        let result = [];
        result = this.slice(0, n);
        return result;
    }

    Array.prototype.sum = function () {
        let sum = 0;
        for (var i = 0; i < this.length; i++) {
            sum += this[i];
        }
        return sum;
    }

    Array.prototype.average = function () {
        let sum = 0;
        for (var i = 0; i < this.length; i++) {
            sum += this[i];
        }
        return sum / this.length;
    }
})();
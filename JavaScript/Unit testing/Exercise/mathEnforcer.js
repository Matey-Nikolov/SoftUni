let mathEnforcer = {
    addFive: function(num) {
        if (typeof(num) !== 'number') {
            return undefined;
        }
        return num + 5;
    },
    subtractTen: function(num) {
        if (typeof(num) !== 'number') {
            return undefined;
        }
        return num - 10;
    },
    sum: function(num1, num2) {
        if (typeof(num1) !== 'number' || typeof(num2) !== 'number') {
            return undefined;
        }
        return num1 + num2;
    }
};


const { expect } = require('chai');

describe('mathEnforcer', () => {

    describe('addFive', () => {
        it('should return correct result with a non-number parameter', () => {
            expect(mathEnforcer.addFive('a')).to.be.undefined;
        });

        it('Return result 55', () => {
            expect(mathEnforcer.addFive(50)).to.be.equal(55);
        });

        it('Return result 15.001', () => {
            expect(mathEnforcer.addFive(10.001)).equal(15.001)
        });

        it("Should return undefined", function() {
            expect(mathEnforcer.addFive({ pesho: 23 })).to.equal(undefined);
        });
    });

    describe('subtractTen', () => {
        it('should return correct result with a non-number parameter', () => {
            expect(mathEnforcer.subtractTen('aswdefrgthyj')).to.be.undefined;
        });

        it('Return result 40', () => {
            expect(mathEnforcer.subtractTen(50)).to.be.equal(40);
        });

        it('Return result 10.001 - 10', () => {
            expect(mathEnforcer.subtractTen(10.001)).equal(10.001 - 10)
        });

        it("Should return undefined", function() {
            expect(mathEnforcer.subtractTen({ pesho: 5 })).to.equal(undefined);
        });
    });

    describe('sum', () => {
        it('should return correct result with a non-number parameter', () => {
            expect(mathEnforcer.sum('oiwqe', 78)).to.be.undefined;
        });

        it('should return correct result with a non-number parameter', () => {
            expect(mathEnforcer.sum(14, '78')).to.be.undefined;
        });

        it('Return result 73', () => {
            expect(mathEnforcer.sum(50, 23)).to.be.equal(73);
        });

        it('Return result 15.001', () => {
            expect(mathEnforcer.sum(10.001, 5)).equal(15.001)
        });

        it("Should return undefined", function() {
            expect(mathEnforcer.sum(213456, 'w')).to.equal(undefined);
        });
    });
});
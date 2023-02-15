function sum(arr) {
    let sum = 0;
    for (let num of arr) {
        sum += Number(num);
    }
    return sum;
}

const { expect } = require('chai');

describe('Sum of Numbers', () => {
    it('with numbers and strings', () => {
        expect(sum([2, 3, 4, '4'])).to.equal(13);
    });

    it('only numbers', () => {
        expect(sum([2, 3, 4, 200])).to.equal(209);
    });
});
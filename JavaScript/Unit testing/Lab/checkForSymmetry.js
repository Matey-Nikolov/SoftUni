function isSymmetric(arr) {
    if (!Array.isArray(arr)) {
        return false; // Non-arrays are non-symmetric
    }
    let reversed = arr.slice(0).reverse(); // Clone and reverse
    let equal = (JSON.stringify(arr) == JSON.stringify(reversed));
    return equal;
}

const { expect } = require('chai');

describe('Is symmetric', () => {

    it('symmetric', () => {
        expect(isSymmetric([])).to.be.true;
    });

    it('symmetric', () => {
        expect(isSymmetric([1, 2, 1])).to.be.true;
    });

    it('non-symmetric', () => {
        expect(isSymmetric([2, 'we', 4])).to.be.false;
    });

    it('non-symmetric', () => {
        expect(isSymmetric([1, 2, 1, 'qweqw'])).to.be.false;
    });

    it('non-symmetric', () => {
        expect(isSymmetric([1])).to.be.true;
    });

    it('should return false on isSymmetric(["2",2])', () => {
        expect(isSymmetric(["2", 2])).to.be.false;
    });
});
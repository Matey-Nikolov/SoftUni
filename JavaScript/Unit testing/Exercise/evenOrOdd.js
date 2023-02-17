function isOddOrEven(string) {
    if (typeof(string) !== 'string') {
        return undefined;
    }

    if (string.length % 2 === 0) {
        return 'even';
    }

    return 'odd';
}

const { expect } = require('chai');

describe('even or odd', () => {
    it('is string', () => {
        expect(isOddOrEven(3)).to.undefined;
    });

    it('is odd', () => {
        expect(isOddOrEven('a')).to.equal('odd');
    });

    it('is even', () => {
        expect(isOddOrEven('aa')).to.equal('even');
    });
});
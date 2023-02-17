function lookupChar(string, index) {
    if (typeof(string) !== 'string' || !Number.isInteger(index)) {
        return undefined;
    }

    if (string.length <= index || index < 0) {
        return "Incorrect index";
    }

    return string.charAt(index);
}

const { expect } = require('chai');

describe('Lookup', () => {

    it('Not string', () => {
        expect(lookupChar(3, 'string')).to.undefined;
    });

    it('Not number', () => {
        expect(lookupChar('we', '3')).to.undefined;
    });

    it('Out of range', () => {
        expect(lookupChar('123123', 8)).to.equal('Incorrect index');
    });

    it('Out of range', () => {
        expect(lookupChar('123123', -1)).to.equal('Incorrect index');
    });

    it('Work 1', () => {
        expect(lookupChar('123123', 1)).to.equal('2');
    });

    it('Work 2', () => {
        expect(lookupChar('123123', 5)).to.equal('3');
    });

    /*
    it('Work 3', () => {
        expect(lookupChar('1', 1)).to.undefined;
    });
    */
});
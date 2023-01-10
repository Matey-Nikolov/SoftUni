function createCalculator() {
    let value = 0;
    return {
        add: function(num) { value += Number(num); },
        subtract: function(num) { value -= Number(num); },
        get: function() { return value; }
    }
}

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
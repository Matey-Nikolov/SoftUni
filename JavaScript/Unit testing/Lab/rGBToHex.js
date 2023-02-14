function rgbToHexColor(red, green, blue) {
    if (!Number.isInteger(red) || (red < 0) || (red > 255)) {
        return undefined; // Red value is invalid
    }
    if (!Number.isInteger(green) || (green < 0) || (green > 255)) {
        return undefined; // Green value is invalid
    }
    if (!Number.isInteger(blue) || (blue < 0) || (blue > 255)) {
        return undefined; // Blue value is invalid
    }
    return "#" +
        ("0" + red.toString(16).toUpperCase()).slice(-2) +
        ("0" + green.toString(16).toUpperCase()).slice(-2) +
        ("0" + blue.toString(16).toUpperCase()).slice(-2);
}

const { expect } = require('chai');

describe('RGB to Hex', () => {
    it('Red out of range', () => {
        expect(rgbToHexColor(256, 21, 21)).to.be.undefined;
    });

    it('Red out of range (negative)', () => {
        expect(rgbToHexColor(-20, 20, 20)).to.be.undefined;
    });

    it('Green out of range', () => {
        expect(rgbToHexColor(10, 257, 20)).to.be.undefined;
    });

    it('Green out of range (negative)', () => {
        expect(rgbToHexColor(10, -50, 20)).to.be.undefined;
    });

    it('Blue out of range', () => {
        expect(rgbToHexColor(10, 10, 266)).to.be.undefined;
    });

    it('Blue out of range (negative)', () => {
        expect(rgbToHexColor(10, 10, -50)).to.be.undefined;
    });

    it('Work', () => {
        expect(rgbToHexColor(222, 20, 20)).to.be.equal('#DE1414');
    });

});
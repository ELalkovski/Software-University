let expect = require("chai").expect;
let PaymentPackage = require('../02. Payment Package/PaymentPackage.js')

describe("PaymentPackage class", function () {
    let pp
    beforeEach(function () {
        pp = new PaymentPackage('Consultation', 800)
    });

    it('has functions attached to prototype', function () {
        expect(Object.getPrototypeOf(pp).hasOwnProperty('name')).to.equal(true, "Missing name property");
        expect(Object.getPrototypeOf(pp).hasOwnProperty('value')).to.equal(true, "Missing value property");
        expect(Object.getPrototypeOf(pp).hasOwnProperty('VAT')).to.equal(true, "Missing VAT property");
        expect(Object.getPrototypeOf(pp).hasOwnProperty('active')).to.equal(true, "Missing active property");
        expect(Object.getPrototypeOf(pp).hasOwnProperty('toString')).to.equal(true, "Missing toString function");
    });
    it("should create instance of the class with given input name and value", function () {
        let pp = new PaymentPackage('Test', 20)
        expect(pp instanceof PaymentPackage).to.be.equal(true);
    });
    it("should throw Error with empty name parameter", function () {
        expect(() => new PaymentPackage(20)).to.throw(Error);
    });
    it("should throw Error with empty value parameter", function () {
        expect(() => new PaymentPackage('Gosho')).to.throw(Error);
    });
    it("should throw Error with no input parameters", function () {
        expect(() => new PaymentPackage()).to.throw(Error);
    });
    it("should throw Error with negative value parameter", function () {
        expect(() => new PaymentPackage('Gosho', -15)).to.throw(Error);
    });
    it("name getter should return Consultation", function () {
        expect(pp.name).to.be.equal('Consultation');
    });
    it("name setter should change name value from 'Consultation' to 'Changed'", function () {
        pp.name = 'Changed'
        expect(pp.name).to.be.equal('Changed');
    });
    it("name setter should throw Error with non-string parameter", function () {
        expect(() => pp.name = 5).to.throw(Error);
    });
    it("name setter should throw Error with empty string parameter", function () {
        expect(() => pp.name = '').to.throw(Error);
    });
    it("value getter should return 800", function () {
        expect(pp.value).to.be.equal(800);
    });
    it("value setter should change value from 800 to 2000", function () {
        pp.value = 2000
        expect(pp.value).to.be.equal(2000);
    });
    it("value setter should change value from 2000 to 0", function () {
        pp.value = 0
        expect(pp.value).to.be.equal(0);
    });
    it("value setter should throw Error with non-number parameter", function () {
        expect(() => pp.value = 'Gosho').to.throw(Error);
    });
    it("value setter should throw Error with negative number parameter", function () {
        expect(() => pp.value = -2000).to.throw(Error);
    });
    it("VAT getter should return default value of 20", function () {
        expect(pp.VAT).to.be.equal(20);
    });
    it("VAT setter should change the VAT value from 20 to 500", function () {
        pp.VAT = 500
        expect(pp.VAT).to.be.equal(500);
    });
    it("VAT setter should change the VAT value from 500 to 0", function () {
        pp.VAT = 0
        expect(pp.VAT).to.be.equal(0);
    });
    it("VAT setter should throw Error with non-number parameter", function () {
        expect(() => pp.VAT = 'Gosho').to.throw(Error);
    });
    it("VAT setter should throw Error with negative number parameter", function () {
        expect(() => pp.VAT = -2000).to.throw(Error);
    });
    it("active getter should return default value true", function () {
        expect(pp.active).to.be.equal(true);
    });
    it("active setter should change the active value from true to false", function () {
        pp.active = false
        expect(pp.active).to.be.equal(false);
    });
    it("active setter should throw Error with non-boolean parameter", function () {
        expect(() => pp.active = -2000).to.throw(Error);
    });
    it("toString method should return overview for the instance", function () {
        let expectedResult = [
            `Package: ${pp.name}` + (pp.active === false ? ' (inactive)' : ''),
            `- Value (excl. VAT): ${pp.value}`,
            `- Value (VAT ${pp.VAT}%): ${pp.value * (1 + pp.VAT / 100)}`
          ]
        expect(pp.toString()).to.be.equal(expectedResult.join('\n'));
    });
    it("toString method should return overview for the instance", function () {
        pp.active = false
        let expectedResult = [
            `Package: ${pp.name}` + (pp.active === false ? ' (inactive)' : ''),
            `- Value (excl. VAT): ${pp.value}`,
            `- Value (VAT ${pp.VAT}%): ${pp.value * (1 + pp.VAT / 100)}`
          ]
        expect(pp.toString()).to.be.equal(expectedResult.join('\n'));
    });
});
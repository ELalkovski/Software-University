let expect = require("chai").expect;
let mathEnforcer = require('../04. Math Enforcer.js')

describe("mathEnforcer", function() {

  describe("addFive", function() {

    it("should return 5 for num = 0", function() {
      expect(mathEnforcer.addFive(0)).to.be.equal(5);
    });
    it("should return -5 for num = -10", function() {
      expect(mathEnforcer.addFive(-10)).to.be.equal(-5);
    });
    it("should return 7.5 for num = 2.5", function() {
      expect(mathEnforcer.addFive(2.5)).equal(2.5 + 5);
    });
    it("should return undefined for num = 'str'", function() {
      expect(mathEnforcer.addFive('str')).to.be.undefined;
    });
  });

  describe("subtractTen", function() {

    it("should return 0 for num = 10", function() {
      expect(mathEnforcer.subtractTen(10)).to.be.equal(0);
    });
    it("should return 0.5 for num = 10.5", function() {
      expect(mathEnforcer.subtractTen(10.5)).equal(10.5 - 10)
    });
    it("should return -30 for num = -20", function() {
      expect(mathEnforcer.subtractTen(-20)).to.be.equal(-30);
    });
    it("should return undefined for num = '10'", function() {
      expect(mathEnforcer.subtractTen('10')).to.be.undefined;
    });
  });

  describe("sum", function() {

    it("should return 20 for num1 = 10, num2 = 10", function() {
      expect(mathEnforcer.sum(10, 10)).to.be.equal(20);
    });
    it("should return 20 for num1 = -20, num2 = 10", function() {
      expect(mathEnforcer.sum(-20, 10)).to.be.equal(-10);
    });
    it("should return 20 for num1 = 10, num2 = -20", function() {
      expect(mathEnforcer.sum(10, -20)).to.be.equal(-10);
    });
    it("should return 20 for num1 = 10, num2 = -20", function() {
      expect(mathEnforcer.sum(10.5, -20)).equal(-9.5);
    });
    it("should return 20 for num1 = 10, num2 = -20", function() {
      expect(mathEnforcer.sum(10, -20.5)).equal(-10.5);
    });
    it("should return 20 for num1 = 10, num2 = -20", function() {
      expect(mathEnforcer.sum(10.5, -20.5)).equal(-10);
    });
    it("should return undefined for num1 = '10', num2 = 10", function() {
      expect(mathEnforcer.sum('10', 10)).to.be.undefined;
    });
    it("should return undefined for num1 = 15, num2 = '8'", function() {
      expect(mathEnforcer.sum(15, '8')).to.be.undefined;
    });
    it("should return undefined for num1 = 15, num2 = ''", function() {
      expect(mathEnforcer.sum(15)).to.be.undefined;
    });
    it("should return undefined for num1 = '', num2 = 15", function() {
      expect(mathEnforcer.sum('', 15)).to.be.undefined;
    });
  });
});
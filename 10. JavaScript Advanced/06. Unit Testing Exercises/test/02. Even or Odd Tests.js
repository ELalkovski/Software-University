let expect = require("chai").expect;
let isOddOrEven = require('../02. Even Or Odd.js')

describe("isOddOrEven(string)", function() {

  it("should return 'even' for 'test'", function() {
    expect(isOddOrEven('test')).to.be.equal('even');
  });
  it("should return 'odd' for 'tes'", function() {
    expect(isOddOrEven('tes')).to.be.equal('odd');
  });
  it("should return undefined for 1", function() {
    expect(isOddOrEven(1)).to.be.undefined;
  });
});
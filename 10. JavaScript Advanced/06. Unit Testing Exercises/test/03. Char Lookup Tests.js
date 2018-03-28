let expect = require("chai").expect;
let lookupChar = require('../03. Char Lookup.js')

describe("lookupChar(string, index)", function() {

  it("should return 'e' for 'test', 1", function() {
    expect(lookupChar('test', 1)).to.be.equal('e');
  });
  it("should return undefined for [], 1", function() {
    expect(lookupChar([], 1)).to.be.undefined;
  });
  it("should return undefined for 'test', 1.5", function() {
    expect(lookupChar('test', 1.5)).to.be.undefined;
  });
  it("should return 'Incorrect index' for 'test', 4", function() {
    expect(lookupChar('test', 4)).to.be.equal('Incorrect index');
  });
  it("should return 'Incorrect index' for 'test', -1", function() {
    expect(lookupChar('test', -1)).to.be.equal('Incorrect index');
  });
});
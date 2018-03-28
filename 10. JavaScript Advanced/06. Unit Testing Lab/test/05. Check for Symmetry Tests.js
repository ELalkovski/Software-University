let expect = require("chai").expect;
const Symmetry = require('../05. Check for Symmetry.js')

describe("isSymmetric(arr)", function() {
  it("should return false for 'test'", function() {
    expect(Symmetry('test')).to.be.equal(false);
  }); 
  it("should return true for [1, 2, 2, 1]", function() {
    expect(Symmetry([1, 2, 2, 1])).to.be.equal(true);
  }); 
  it("should return false for [1, 2, 3, 4]", function() {
    expect(Symmetry([1, 2, 3, 4])).to.be.equal(false);
  });  
  it("should return true for []", function() {
    expect(Symmetry([])).to.be.equal(true);
  });   
  it("should return false for [5,'hi',{a:5},new Date(),{X:5},'hi',5]", function() {
    expect(Symmetry([5,'hi',{a:5},new Date(),{X:5},'hi',5])).to.be.equal(false);
  }); 
  it("should return true for [5,'hi',{a:5},new Date(),{a:5},'hi',5]", function() {
    expect(Symmetry([5,'hi',{a:5},new Date(),{a:5},'hi',5])).to.be.equal(true);
  }); 
});
let expect = require("chai").expect;
let Sumator = require('../02. Sumator Class/sumator.js')

describe("String builder class", function() {

    let testSumator
    beforeEach(function () {
        testSumator = new Sumator();
    });

    it('has functions attached to prototype', function () {
        expect(Object.getPrototypeOf(testSumator).hasOwnProperty('add')).to.equal(true, "Missing add function");
        expect(Object.getPrototypeOf(testSumator).hasOwnProperty('sumNums')).to.equal(true, "Missing sumNums function");
        expect(Object.getPrototypeOf(testSumator).hasOwnProperty('removeByFilter')).to.equal(true, "Missing removeByFilter function");
        expect(Object.getPrototypeOf(testSumator).hasOwnProperty('toString')).to.equal(true, "Missing toString function");
    });
    it("property data should be an empty array when Sumator class is initialized", function() {
      expect(testSumator.data).eql([]);
    });
    it("should add item to the end of the data arr", function() {
        testSumator.add(1)
        expect(testSumator.data[0]).to.be.equal(1)
    });
    it("should add different types of elements to the data arr", function() {
        testSumator.add({})
        testSumator.add([])
        testSumator.add('fdsfsdfsd')
        expect(testSumator.data.length).to.be.equal(3)
    });
    it("should return 10 after summing only number elements from the data arr", function() {
        testSumator.add(1)
        testSumator.add(5)
        testSumator.add('Pesho')
        testSumator.add('Gosho')
        testSumator.add({})                
        testSumator.add(4)            
        expect(testSumator.sumNums()).to.be.equal(10)
    });
    it("should return undefined after summing empty data", function() {       
        expect(testSumator.sumNums()).to.be.equal(0)
    });
    it("should return data length 1 after filtering non-matching elements by given function", function() {
        function filter(x) {
            if (x % 2 === 0) {
                return true
            }

            return false
        }
        testSumator.add(4)
        testSumator.add(6)
        testSumator.add(8)
        testSumator.add({})
        testSumator.add('yoyo')                
        testSumator.add(3)        
        testSumator.removeByFilter(filter)     
        expect(testSumator.data.length).to.be.equal(3)
    });
    it("should return data at position 0 equal to 3 after filtering non-matching elements by given function", function() {
        function filter(x) {
            if (x % 2 === 0) {
                return true
            }

            return false
        }
        testSumator.add(4)
        testSumator.add(6)
        testSumator.add(8)
        testSumator.add(3)        
        testSumator.removeByFilter(filter)     
        expect(testSumator.data[0]).to.be.equal(3)
    });
    it("should return all items joined by comma and space after calling toString", function() {
        testSumator.add(4)
        testSumator.add('Gosho')
        testSumator.add(8)
        testSumator.add([])
        testSumator.add({})        
        testSumator.add('Tosho')        
        expect(testSumator.toString()).to.be.equal(testSumator.data.join(', '))
    });
    it("should return '(empty)' when calling toString with an empty data collection", function() { 
        expect(testSumator.toString()).to.be.equal('(empty)')
    });
});
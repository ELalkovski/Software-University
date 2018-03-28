let expect = require("chai").expect;
let createCalculator = require('../07. Add and Subtract')

describe("createCalculator()", function() {
    
     let calc

     beforeEach(function () {
        calc = createCalculator()
     })

     describe("Nominal cases (valid input)", function() {
        it("should return 0 for newly initialized calculator", function() {
            let value = calc.get()
            expect(value).to.be.equal(0);
        });  
        it("should return 5 after {add 2, add 3}", function() {
            calc.add(2)
            calc.add(3)
            let value = calc.get()
            expect(value).to.be.equal(5);
        });
        it("should return 5 after {add '2', add '3'}", function() {
            calc.add('2')
            calc.add('3')
            let value = calc.get()
            expect(value).to.be.equal(5);
        });
        it("should return 1 after {add 2, add 3, subtract 4}", function() {
            calc.add(2)
            calc.add(3)
            calc.subtract(4)
            let value = calc.get()
            expect(value).to.be.equal(1);
        });
        it("should return -4 after {subtract 4}", function() {
            calc.subtract(4)
            let value = calc.get()
            expect(value).to.be.equal(-4);
        }); 
        it("should return -2 after {subtract '-2'}", function() {
            calc.subtract('2')
            let value = calc.get()
            expect(value).to.be.equal(-2);
        });          
      });
});
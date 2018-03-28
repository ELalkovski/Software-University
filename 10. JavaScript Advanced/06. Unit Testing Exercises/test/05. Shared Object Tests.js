const jsdom = require('jsdom-global')()
const $ = require('jquery')
let sharedObject = require('../05. Shared Object/shared-object.js')
let expect = require("chai").expect;

document.body.innerHTML = `<div id="wrapper">
        <input type="text" id="name">
        <input type="text" id="income">
    </div>`;

describe("sharedObject", function() {
    before(()=>global.$ = $);

    describe("initially name and income should be null", function() {
        it("object should not be null", function() {
            expect(sharedObject).not.to.be.equal(null);
        });  
        it("name should be null", function() {
            expect(sharedObject.name).to.be.equal(null);
        });
        it("income should be null", function() {
            expect(sharedObject.income).to.be.equal(null);
        });  
    });

    describe("changeName function", function() {
        it("should return name 'Gosho' for param = 'Gosho'", function() {
            sharedObject.changeName('Gosho');
            expect(sharedObject.name).to.equal('Gosho');
            expect($('#name').val()).to.equal('Gosho');
        });
        it("should return number for number param", function() {
            sharedObject.changeName(15);
            expect(sharedObject.name).to.equal(15);
            expect($('#name').val()).to.equal('15');
        });
        it("should return previous set value(Pesho) for empty param", function() {
            sharedObject.changeName('Pesho');
            sharedObject.changeName('');
            expect(sharedObject.name).to.equal('Pesho');
            expect($('#name').val()).to.equal('Pesho');
        });
    });

    describe("changeIncome function", function() {
        it("should change income to 20 for param = 20", function() {
            sharedObject.changeIncome(20);
            expect(sharedObject.income).to.equal(20);
            expect($('#income').val()).to.equal('20');
        });
        it("should return previous income value(20) for not number param", function() {
            sharedObject.changeIncome(50);
            sharedObject.changeIncome('20')
            expect(sharedObject.income).to.equal(50);
            expect($('#income').val()).to.equal('50');
        });
        it("should return previous income value(10) for negative number param", function() {
            sharedObject.changeIncome(10);
            sharedObject.changeIncome(-40)
            expect(sharedObject.income).to.equal(10);
            expect($('#income').val()).to.equal('10');
        });
        it("should return previous income value(10) for param = 0", function() {
            sharedObject.changeIncome(10);
            sharedObject.changeIncome(0)
            expect(sharedObject.income).to.equal(10);
            expect($('#income').val()).to.equal('10');
        });          
    });

    describe("updateName function", function() {
        it("should change name to 'Gosho' for input param = 'Gosho'", function() {
            $('#name').val('Gosho')
            sharedObject.updateName();
            expect(sharedObject.name).to.equal('Gosho');
            expect($('#name').val()).to.equal('Gosho');
        });
        it("should return previous name value 'Pesho' for empty input param", function() {
            $('#name').val('Pesho')  
            sharedObject.updateName(); 
            $('#name').val('')              
            sharedObject.updateName();
            expect(sharedObject.name).to.equal('Pesho');
            expect($('#name').val()).to.equal('');
        });
        it("should change name to 15 for input param = '15'", function() {
            $('#name').val('15')
            sharedObject.updateName();
            expect(sharedObject.name).to.equal('15');
            expect($('#name').val()).to.equal('15');
        });
    });

    describe("updateIncome function", function() {
        it("should change income to 50 for input param = '50'", function() {
            $('#income').val('50')
            sharedObject.updateIncome();
            expect(sharedObject.income).to.equal(50);
            expect($('#income').val()).to.equal('50');
        });
        it("should return previous income value '50' for NaN input param", function() {
            $('#income').val('50')
            sharedObject.updateIncome();
            $('#income').val('[]')
            sharedObject.updateIncome();
            expect(sharedObject.income).to.equal(50);
            expect($('#income').val()).to.equal('[]');
        });
        it("should return previous income value '20' for not integer input param", function() {
            $('#income').val('20')
            sharedObject.updateIncome();
            $('#income').val('5.55')
            sharedObject.updateIncome();
            expect(sharedObject.income).to.equal(20);
            expect($('#income').val()).to.equal('5.55');
        });
        it("should return previous income value '40' for negative input param", function() {
            $('#income').val('40')
            sharedObject.updateIncome();
            $('#income').val('-5')
            sharedObject.updateIncome();
            expect(sharedObject.income).to.equal(40);
            expect($('#income').val()).to.equal('-5');
        });
        it("should return previous income value '8' for input param = 0", function() {
            $('#income').val('8')
            sharedObject.updateIncome();
            $('#income').val('0')
            sharedObject.updateIncome();
            expect(sharedObject.income).to.equal(8);
            expect($('#income').val()).to.equal('0');
        });
    });
});
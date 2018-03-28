let expect = require("chai").expect;
let StringBuilder = require('../02. String Builder/string-builder')

describe("String builder class", function() {
    let sb

    it("should not throw exception when instantied without param", function() {
      let initEmpty = () => sb = new StringBuilder()
      expect(initEmpty).to.not.throw();
    });
    it("should not throw exception when instantied with string param", function() {
        let initStr = () => sb = new StringBuilder('hello')
        expect(initStr).to.not.throw();
    });

    describe('with empty constructor', function () {
        beforeEach(function () {
            builder = new StringBuilder();
        });

        it('has all properties', function () {
            expect(builder.hasOwnProperty('_stringArray')).to.equal(true, "Missing _stringArray property");
        });

        it('has functions attached to prototype', function () {
            expect(Object.getPrototypeOf(builder).hasOwnProperty('append')).to.equal(true, "Missing append function");
            expect(Object.getPrototypeOf(builder).hasOwnProperty('prepend')).to.equal(true, "Missing prepend function");
            expect(Object.getPrototypeOf(builder).hasOwnProperty('insertAt')).to.equal(true, "Missing insertAt function");
            expect(Object.getPrototypeOf(builder).hasOwnProperty('remove')).to.equal(true, "Missing remove function");
            expect(Object.getPrototypeOf(builder).hasOwnProperty('toString')).to.equal(true, "Missing toString function");
        });

        it('must initialize data to an empty array', function () {
            expect(builder._stringArray instanceof Array).to.equal(true, 'Data must be of type array');
            expect(builder._stringArray.length).to.equal(0, 'Data array must be initialized empty');
        });
    });
    describe('constructor with param', function () {
        it("should add the input str at the end of the storage", function() {
            sb.append(', there')
            expect(sb.toString()).to.be.equal('hello, there');
        });
        it("should add the input str at the begining of the storage", function() {
            sb.prepend('User, ')
            expect(sb.toString()).to.be.equal('User, hello, there');
        });
        it("should add the input str at the given index", function() {
            sb.insertAt('woop', 5)
            expect(sb.toString()).to.be.equal('User,woop hello, there');
        });
        it("should remove chars from startIndex 6 with length 3", function() {
            sb.remove(6, 3)
            expect(sb.toString()).to.be.equal('User,w hello, there');
        });
        it("should throw TypeError for non-string input param", function() {
            expect(() => sb.append([])).to.throw(TypeError);
        });
        it("should throw TypeError for non-string input param", function() {
            expect(() => sb.prepend({})).to.throw(TypeError);
        });
        it("should throw TypeError for non-string input param", function() {
            expect(() => sb.insertAt({}, 5)).to.throw(TypeError);
        });
        it("should return all elements joined by ''", function() {
            expect(sb.toString()).to.be.equal(sb._stringArray.join(''));
        });
        it('invalid constructor parameter', function () {
            let willThrow = () => builder = new StringBuilder(5);
            expect(willThrow).to.throw();
        });
    })
  });
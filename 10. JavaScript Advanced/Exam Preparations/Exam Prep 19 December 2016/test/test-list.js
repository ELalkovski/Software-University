let expect = require("chai").expect;
let makeList = require('../02. Add Left or Right or Clear List/list-add-left-right-clear')

describe("makeList function", function () {
    let myList = {};

    beforeEach(function () {
        myList = makeList();
    });

    it("should return empty arr after fresh initialization", function () {
        expect(`[${myList}]`).eql('[]');        
    });
    it("should return [2, 1] after addLeft 1, 2", function () {
        myList.addLeft(1)
        myList.addLeft(2)
        expect(`[${myList}]`).eql('[2, 1]');        
    });
    it("should return [5, 2, 3] after addRight 2, 3 and then addLeft 5", function () {
        myList.addRight(2)
        myList.addRight(3)
        myList.addLeft(5)
        expect(`[${myList}]`).eql('[5, 2, 3]');        
    });
    it("should return [1, 2, 3] after addRight 1, 2, 3", function () {
        myList.addRight(1)
        myList.addRight(2)
        myList.addRight(3)
        expect(`[${myList}]`).eql('[1, 2, 3]');        
    });
    it("should return [2, 1, 8] after addLeft 1, 2 and then addRight 8", function () {
        myList.addLeft(1)
        myList.addLeft(2)
        myList.addRight(8)
        expect(`[${myList}]`).eql('[2, 1, 8]');        
    });
    it("should return empty arr after adding some elements and call clear", function () {
        myList.addRight(1)
        myList.addRight(2)
        myList.addRight(3)
        myList.clear()
        expect(`[${myList}]`).eql('[]');        
    });
});
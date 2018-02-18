function getTwoSmallestElements(array) {

    array = array.map(Number);
    
        console.log(array.sort((a, b) => a - b).slice(0, 2).join(" "));
}

getTwoSmallestElements([30, 15, 50, 5])
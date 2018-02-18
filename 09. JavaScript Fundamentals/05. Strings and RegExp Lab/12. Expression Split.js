function splitAndPrintExpression(str) {

    let pattern = /[(),.;\s]+/
    str = str.split(pattern).forEach(element => {
        console.log(element)
    });
}

splitAndPrintExpression('let sum = 1 + 2;if(sum > 2){\tconsole.log(sum);}')
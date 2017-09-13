function solve(arr){

    let negativesCounter = 0;

    for(let i = 0; i < arr.length; i++){

        let currNum = Number(arr[i]);

        if(currNum < 0){
            negativesCounter++;
        }
    }
    if(negativesCounter % 2 == 0){
        return "Positive";
    } else {
        return "Negative";
    }
}

console.log(solve(['12', '-3', '-1']));

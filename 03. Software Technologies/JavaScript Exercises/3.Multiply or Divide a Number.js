function solve(arr){
    let num1 = Number(arr[0]);
    let num2 = Number(arr[1]);

    if(num2 >= num1){
        return num1 * num2;
    } else {
        return num1 / num2;
    }
}

console.log(solve(['12', '3']));
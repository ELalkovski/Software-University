function solve(arr){

    let n = arr[0];
    let newArr = [];

    for(let i = 1; i < arr.length; i++){
        let temp = arr[i].split(' - ');
        let index = Number(temp[0]);
        let value = Number(temp[1]);
        newArr[index] = value;
    }
    for(let i = 0; i < n; i++){
        if(newArr[i] == undefined){
            console.log(0);
        } else {
            console.log(newArr[i]);
        }
    }
}

solve(['5', '0 - 3', '3 - -1', '4 - 2']);

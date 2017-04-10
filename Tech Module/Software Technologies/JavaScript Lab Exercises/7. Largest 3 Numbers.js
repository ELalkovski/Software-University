function solve(arr){
    arr = arr.map(Number);
    arr = arr.sort((a,b) => b - a );

    let total = Math.min(arr.length, 3);

    for(let i = 0; i < total; i++){
        console.log(arr[i]);
    }

}


solve(['10', '30', '15', '20', '50', '5']);

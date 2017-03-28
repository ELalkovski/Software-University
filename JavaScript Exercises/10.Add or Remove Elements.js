function solve(arr){
    let newArr = [];

    for(let i = 0; i < arr.length; i++){
        let temp = arr[i].split(' ');
        let command = temp[0];
        let num = Number(temp[1]);

        if(command === 'add'){

            newArr.push(num);
        }
        if(command === 'remove'){
            if(num >= 0 && num < newArr.length){
                newArr.splice(num, 1);
            }
        }
    }
    for(let i = 0; i < newArr.length; i++){
        console.log(newArr[i]);
    }
}

solve(['add 3',
    'add 5',
    'add 7']);

solve(['add 3',
    'add 5',
    'remove 1',
    'add 2']);

solve(['add 3',
    'add 5',
    'remove 2',
    'remove 0',
    'add 7']);

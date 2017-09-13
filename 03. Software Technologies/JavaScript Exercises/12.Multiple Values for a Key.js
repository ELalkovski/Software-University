function solve(arr){

    let obj = {};

    for(let i = 0; i < arr.length - 1; i++){
        let tokens = arr[i].split(' ');
        let key = tokens[0];
        let value = tokens[1];

        if(obj[key]){
            obj[key].push(value);
        } else {
            obj[key] = [value];
        }

    }
    let wantedToken = arr[arr.length - 1];

    if(obj[wantedToken] == undefined){
        console.log('None')
    } else {

        for(let value of obj[wantedToken]){
            console.log(value);
        }

    }

}

solve(['key value',
    'key eulav',
    'test tset',
    'key']);

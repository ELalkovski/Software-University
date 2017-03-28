function solve(arr) {
    let result = {};

    for(let i = 0; i < arr.length; i++){
        let townIncome = JSON.parse(arr[i]);
        let name = townIncome.town;
        let income = townIncome.income;

        if(result[name]){
            result[name] += income;
        } else {
            result[name] = income;
        }
    }

    let towns = Object.keys(result).sort();

    for(let i = 0; i < towns.length; i++){

        console.log(`${towns[i]} -> ${result[towns[i]]}`);
    }
}

solve([
    '{"town":"Sofia","income":200}',
    '{"town":"Varna","income":120}',
    '{"town":"Pleven","income":60}',
    '{"town":"Varna","income":70}'
]);
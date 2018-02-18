function cook(array) {
    
    let number = array[0]

    for (let i = 1; i < array.length; i++) {
        
        let operation = array[i]
        number = performOperation(number, operation)
        console.log(number)
    }

    function performOperation(num, operator){

        switch (operator) {
            case 'chop':
                return num / 2
                break;
            case 'dice':
                return Math.sqrt(num)
                break;
            case 'spice':
                return num + 1
                break;
            case 'bake':
                return num * 3
                break;  
            case 'fillet':
                return num - (0.2 * num)
                break;      
            default:
                break;
        }
    }
}

cook([32, 'chop', 'chop', 'chop', 'chop', 'chop'])
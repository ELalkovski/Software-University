function censoreString(str, array) {

    for (const current of array) {
        
        let replaced = '-'.repeat(current.length)

        while (str.indexOf(current) > -1) {
            
            str = str.replace(current, replaced)
        }
    }

    console.log(str)
}

censoreString('roses are red, violets are blue', [', violets are', 'red'])
function parseEmployeeData(array) {

    let match
    let pattern = /^([A-Z][A-Za-z]*) - ([1-9][0-9]*) - ([a-zA-Z0-9 -]+)$/

    for (let data of array) {
        
        if (match = pattern.exec(data)) {
            
            console.log(`Name: ${match[1]}`)
            console.log(`Position: ${match[3]}`)
            console.log(`Salary: ${match[2]}`)
        }
    }
}

parseEmployeeData(['Jonathan - 2000 - Manager',
    'Peter- 1000- Chuck',
    'George - 1000 - Team Leader'])
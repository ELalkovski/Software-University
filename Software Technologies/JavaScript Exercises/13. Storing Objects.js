function solve(arr){

    let studentsData = arr
        .map(studentsString => studentsString.split(' -> '))
        .map(tokens => {
            return{
                name: tokens[0],
                age: tokens[1],
                grade: tokens[2]
            };
        });
    studentsData.forEach(student => {
        console.log(`Name: ${student.name}`);
        console.log(`Age: ${student.age}`);
        console.log(`Grade: ${student.grade}`);
    })
}

solve(['Pesho -> 13 -> 6.00',
    'Ivan -> 12 -> 5.57',
    'Toni -> 13 -> 4.90'
]);

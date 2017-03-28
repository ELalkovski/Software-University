function solve(arr){
    let studentData = arr.map(student =>
    student.split(' -> '));

    let student = {};

    studentData.forEach(tokens => {
        let key = tokens[0];
        let value = tokens[1];

        if(key === 'age' || key === 'grade'){
            value = Number(tokens[1]);
        }
        student[key] = value;
    });

    console.log(JSON.stringify(student));
}

solve(['name -> Angel',
    'surname -> Georgiev',
    'age -> 20',
    'grade -> 6.00',
    'date -> 23/05/1995',
    'town -> Sofia'
    ]);

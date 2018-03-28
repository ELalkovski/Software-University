function getPersonBmi(name, age, weight, height) {
    
    let bmi = Math.round(weight /(height * height / 10000))
    let person = {
        name: name, 
        personalInfo: {
            age: age, 
            weight: weight, 
            height: height},
        BMI: bmi
    }

    person.status = person.BMI < 18.5 ? "underweight" : person.BMI < 25 ? "normal" : person.BMI < 30 ? "overweight" : "obese";
     
    if(person.status == "obese"){
        person.recommendation = "admission required";
    }
    
     return person
}
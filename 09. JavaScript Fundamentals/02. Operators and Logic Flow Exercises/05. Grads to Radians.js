function convertGradianToDegree(grad){

    let diffDeg = 400 / 360
    let degrees = (grad / diffDeg) % 360

    if(degrees < 0){
        degrees += 360
        
    } 
    
    console.log(degrees)
}

convertGradianToDegree(850)
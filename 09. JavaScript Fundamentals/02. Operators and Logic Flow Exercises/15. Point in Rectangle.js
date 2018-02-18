function checkIfPointInsideRectangle(array){

    let x = array[0]
    let y = array[1]
    let xMin = array[2]
    let xMax = array[3]
    let yMin = array[4]
    let yMax = array[5]

    if(x >= xMin && x <= xMax 
      && y >= yMin && y <= yMax){
          
            console.log('inside')
      } else {

            console.log('outside')
      }
}

checkIfPointInsideRectangle([8, -1, 2, 12, -3, 3])
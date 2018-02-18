function calculateVolume(array) {

    for (var i = 0; i < array.length; i+=3) {
        let x = array[i]
        let y = array[i + 1]
        let z = array[i + 2]
        
        console.log(isInside(x, y, z) ? 'inside' : 'outside')
    }

    
function isInside(x, y, z) {
    
        let x1 = 10, x2 = 50
        let y1 = 20, y2 = 80
        let z1 = 15, z2 = 50
    
        if(x >= x1 && x <= x2) {
            if(y >= y1 && y <= y2) {
                if (z >= z1 && z <= z2) {
                    return true
                } 
            }
        } else {
            return false
        }
    }
}

//calculateVolume([8, 20, 22])

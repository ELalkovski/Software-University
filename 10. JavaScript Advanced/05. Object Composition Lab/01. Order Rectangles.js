function orderRects(measures) {

    let rects = []

    for (let [width, height] of measures) {
        let currentRect = createRect(width, height)
        rects.push(currentRect)    
    }

    rects.sort((a, b) => a.compareTo(b))
    return rects

    function createRect(width, height) {
        
        let rect = {
            width: width,
            height: height,
            area: () => rect.width * rect.height,
            compareTo: function (other) {
                let result = other.area() - rect.area()

                return result || (other.width - rect.width)
            }
        }

        return rect
    }
}

console.log(sortRectangles([[10,5],[5,12]]))
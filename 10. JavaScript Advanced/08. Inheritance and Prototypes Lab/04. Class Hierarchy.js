function getFigures() {
    class Figure {
        constructor() {
            if (new.target === Figure) {
                throw new Error('Cannot construct Figure instances directly')
            }
        }

        get area() {
            return undefined
        }

        toString() {
            return `${this.constructor.name}`
        }
    }
    
    class Circle extends Figure {
        constructor (radius){
            super()
            this.radius = radius
        }

        get area() {
            return Math.PI * this.radius * this.radius
        }

        toString() {
            return `${super.toString()} - radius: ${this.radius}`
        }
    }

    class Rectangle extends Figure {
        constructor (width, height) {
            super()
            this.width = width
            this.height = height
        }

        get area() {
            return this.width * this.height
        }

        toString() {
            return `${super.toString()} - width: ${this.width}, height: ${this.height}`
        }
    }
}
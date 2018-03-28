(function () {

    String.prototype.ensureStart = function (str) {
        if (!this.toString().startsWith(str)) {
            return str + this.toString()
        }
        return this.toString()
    }

    String.prototype.ensureEnd = function (str) {
        if (!this.toString().endsWith(str)) {
            return this.toString() + str
        }
        return this.toString()
    }

    String.prototype.isEmpty = function () {
        return this.toString().localeCompare('') === 0
    }

    String.prototype.truncate = function (n) {
        if (n <= 3) {
            return '.'.repeat(n)
        } else if (this.toString().length <= n) {
            return this.toString()
        } else {
           let lastIndex = this.toString().substr(0, n - 2).lastIndexOf(' ')
           if (lastIndex !== -1) {
               return this.toString().substr(0, lastIndex) + '...'
           } else {
               return this.toString().substr(0, n - 3) + '...'
           }
        }
    }

    String.format = function (str, ...params) {

        for (let i = 0; i < params.length; i++) {
            let index = str.toString().indexOf('{' + i + '}')
            while (index !== -1) {
                str = str.toString().replace('{' + i + '}', params[i])
                index = str.toString().indexOf('{' + i + '}')
            }
        }

        return str.toString()
    }
})()

let str = 'hello my string'
str = String.format('The {0} {1} fox',
'quick', 'brown');

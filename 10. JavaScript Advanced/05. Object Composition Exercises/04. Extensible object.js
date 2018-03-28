function getExtendableObject() {
    
    let myObj = {
        extend: function (template) {

            for (let key in template) {
                if (typeof(template[key]) === 'function') {
                    Object.getPrototypeOf(this)[key] = template[key]
                } else {
                    this[key] = template[key]
                }
            }
        }
    }

    return myObj
}
var template = {
    health: 100,
    mana: 50
};
let instance = getExtendableObject()
instance.extend(template)
  console.log(instance)
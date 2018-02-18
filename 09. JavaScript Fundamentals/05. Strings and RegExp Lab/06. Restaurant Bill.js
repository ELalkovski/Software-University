function getPurchasesAndTotalSum(array) {

    let productName = ''
    let productPrice = 0
    let totalSum = 0
    let products = []
    
    for (let i = 0; i < array.length; i++) {
        
        if (i % 2 === 0) {
            
            productName = array[i]
            products.push(productName)
        } else {

            productPrice = Number(array[i])
            totalSum += productPrice
        }
    }

    console.log('You purchased ' + products.join(', ') + ' for a total sum of ' + totalSum)
}

getPurchasesAndTotalSum(['Beer Zagorka', '2.65', 'Tripe soup', '7.80','Lasagna', '5.69'])
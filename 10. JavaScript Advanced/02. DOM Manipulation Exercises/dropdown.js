function addItem() {
    let newItemText = document.getElementById('newItemText').value
    let newItemValue = document.getElementById('newItemValue').value

    let firstOption = document.createElement('option')
    firstOption.textContent = newItemText
    firstOption.value = newItemValue

    document.getElementById('menu').appendChild(firstOption)
    document.getElementById('newItemText').value = ''
    document.getElementById('newItemValue').value = ''
}

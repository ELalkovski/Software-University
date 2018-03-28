function attachEventsListeners() {

    let btn = document.getElementById('convert')
    let unitsToMeters = [1000, 1, 0.01, 0.001, 1609.34, 0.9144, 0.3048, 0.0254]

    btn.addEventListener('click', function () {
        let inputDimension = document.querySelector('#inputUnits').value
        let inputIndex = document.querySelector('#inputUnits').selectedIndex
        let outputDimension = document.querySelector('#outputUnits').value
        let outputIndex = document.querySelector('#outputUnits').selectedIndex
        let input = document.getElementById('inputDistance').value

        let inputToMeters = Number(input) * unitsToMeters[inputIndex]
        let output = inputToMeters / unitsToMeters[outputIndex]
        document.getElementById('outputDistance').value = output
    })
}
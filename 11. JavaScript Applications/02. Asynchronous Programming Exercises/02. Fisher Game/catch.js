function attachEvents() {
    let kinveyAppUrl = 'https://baas.kinvey.com/appdata/kid_BkJLiDvcM'
    $('#addForm button.add').click(addCatch)
    $('#aside button.load').click(getAllCatches)

    function getAllCatches() {
        $.ajax({
            url: `${kinveyAppUrl}/biggestCatches`,
            headers: {
                'Authorization': 'Basic ' + btoa('flyelmos:2233')
            },
            success: listAllCatches
        })

        function listAllCatches(data) {
            $('#catches').empty()

            for (const entry of data) {
                let catchDiv = $('<div>').addClass('catch').attr('data-id', entry._id)
                let anglerInput = $('<input>').addClass('angler').val(entry.angler).attr('type', 'text')
                let weightInput = $('<input>').addClass('weight').val(entry.weight).attr('type', 'number')
                let speciesInput = $('<input>').addClass('species').val(entry.species).attr('type', 'text')
                let locationInput = $('<input>').addClass('location').val(entry.location).attr('type', 'text')
                let baitInput = $('<input>').addClass('bait').val(entry.bait).attr('type', 'text')
                let captureTimeInput = $('<input>').addClass('captureTime').val(entry.captureTime).attr('type', 'number')
                let updateBtn = $('<button>').addClass('update').text('Update').click(updateCatch)
                let deleteBtn = $('<button>').addClass('delete').text('Delete').click(deleteCatch)

                catchDiv
                    .append($('<label>').text('Angler'))
                    .append(anglerInput)
                    .append($('<label>').text('Weight'))
                    .append(weightInput)
                    .append($('<label>').text('Species'))
                    .append(speciesInput)
                    .append($('<label>').text('Location'))
                    .append(locationInput)
                    .append($('<label>').text('Bait'))
                    .append(baitInput)
                    .append($('<label>').text('Capture Time'))
                    .append(captureTimeInput)
                    .append(updateBtn)
                    .append(deleteBtn)

                $('#catches').append(catchDiv)
            }
        } 
    }

    function addCatch() {
        let angler = $('#addForm input.angler').val()
        $('#addForm input.angler').val('')
        let weight = Number($('#addForm input.weight').val())
        $('#addForm input.weight').val('')
        let species = $('#addForm input.species').val()
        $('#addForm input.species').val('')
        let location = $('#addForm input.location').val()
        $('#addForm input.location').val('')
        let bait = $('#addForm input.bait').val()
        $('#addForm input.bait').val('')
        let captureTime = Number($('#addForm input.captureTime').val())
        $('#addForm input.captureTime').val('')
        let data = {
            "angler": angler,
            "weight": weight,
            "species": species,
            "location": location,
            "bait": bait,
            "captureTime": captureTime
        }

        $.ajax({
            url: `${kinveyAppUrl}/biggestCatches`,
            method: 'POST',
            data: JSON.stringify(data),
            headers: {
                'Content-type': 'application/json',
                'Authorization': 'Basic ' + btoa('flyelmos:2233')
            },
            success: getAllCatches
        })
    }

    function updateCatch() {
        let parentDiv = $(this).parent()
        let angler = $(parentDiv).children('input.angler').val()
        let weight = Number($(parentDiv).children('input.weight').val())
        let species = $(parentDiv).children('input.species').val()
        let location = $(parentDiv).children('input.location').val()
        let bait = $(parentDiv).children('input.bait').val()
        let captureTime = Number($(parentDiv).children('input.captureTime').val())

        let data = {
            "_id": parentDiv.attr('data-id'),
            "angler": angler,
            "weight": weight,
            "species": species,
            "location": location,
            "bait": bait,
            "captureTime": captureTime
        }

        $.ajax({
            url: `${kinveyAppUrl}/biggestCatches/${parentDiv.attr('data-id')}`,
            method: 'PUT',
            data: JSON.stringify(data),
            headers: {
                'Content-type': 'application/json',
                'Authorization': 'Basic ' + btoa('flyelmos:2233')
            },
            success: getAllCatches
        })
    }

    function deleteCatch() {
        let parentDiv = $(this).parent()

        $.ajax({
            url: `${kinveyAppUrl}/biggestCatches/${parentDiv.attr('data-id')}`,
            method: 'DELETE',
            headers: {
                'Content-type': 'application/json',
                'Authorization': 'Basic ' + btoa('flyelmos:2233')
            },
            success: getAllCatches
        })
    }
}
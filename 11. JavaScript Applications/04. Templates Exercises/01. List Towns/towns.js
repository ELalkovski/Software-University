function attachEvents() {
    $('#btnLoadTowns').click(getTowns)

    function getTowns() {
        let towns = $('#towns').val()
        $('#towns').val('')

        towns = towns.split(',')
            .map(el => ({
                town: el
            }))
            .filter(el => el.town !== '')

        displayTowns(towns)
    }

    async function displayTowns(towns) {
        let source = await $.get('town-template.hbs')
        let compiled = Handlebars.compile(source)
        let template = compiled({
            towns
        })
        $('#root').html(template)
    }
}
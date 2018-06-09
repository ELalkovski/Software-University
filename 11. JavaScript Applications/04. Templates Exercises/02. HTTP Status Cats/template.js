$(() => {
    renderCatTemplate();

    async function renderCatTemplate() {
        let cats = window.cats
        let source = await $.get('cat-block-template.hbs')
        let compiled = Handlebars.compile(source)
        let template = compiled({
            cats
        })

        $('#allCats').html(template)
        attachEvents()
    }

    function attachEvents() {
        $('button.btn.btn-primary').click(function () {
            let statusDiv = $(this).parent().find('div')

            if (statusDiv.css('display') == 'none') {
                $(this).text('Hide status code')
                statusDiv.css('display', 'block')
            } else {
                $(this).text('Show status code')
                statusDiv.css('display', 'none')
            }
        })
    }
})

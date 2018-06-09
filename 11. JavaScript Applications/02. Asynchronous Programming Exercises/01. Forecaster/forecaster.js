function attachEvents() {
    let weatherBaseUrl = 'https://judgetests.firebaseio.com/locations.json'
    let conditionsBaseUrl = 'https://judgetests.firebaseio.com/forecast'
    let weatherConditions = {
        "Sunny": "&#x2600;",
        "Partly sunny": "&#x26C5;",
        "Overcast": "&#x2601;",
        "Rain": "&#x2614;",
        "Degrees": "&#176;",
    }

    $('#submit').click(displayWeatherInfo)

    function displayWeatherInfo() {
        $.get(weatherBaseUrl)
            .then(requestCityInfo)
            .catch(displayError)

        function displayError(error) {
            $('div#current').css('display', 'block')
            $('div#current').text(`Error: ${error} ${error.message}`)
        }

        function requestCityInfo(data) {
            let requestedCityName = $('#location').val()
            let requestedCityCode = ''
            $('#location').val('')

            for (const city of data) {
                if (city.name === requestedCityName) {
                    requestedCityCode = city.code
                    break
                }
            }

            $.get(`${conditionsBaseUrl}/today/${requestedCityCode}.json`)
                .then(renderTodayWeather)
                .catch(displayError)

            $.get(`${conditionsBaseUrl}/upcoming/${requestedCityCode}.json`)
                .then(renderUpcomingWeather)
                .catch(displayError)

            function renderTodayWeather(forecastInfo) {
                let title = $('<div>')
                    .addClass('label')
                    .text('Current conditions')
                let spanIcon = $('<span>')
                    .addClass('condition symbol')
                    .html(weatherConditions[forecastInfo.forecast.condition])
                let spanCondition = $('<span>').addClass('condition')
                let spanName = $('<span>').addClass('forecast-data').text(forecastInfo.name)
                let spanDegrees = $('<span>')
                    .addClass('forecast-data')
                    .html(`${forecastInfo.forecast.low}${weatherConditions['Degrees']}/${forecastInfo.forecast.high}${weatherConditions['Degrees']}`)
                let spanWeather = $('<span>').addClass('forecast-data').text(forecastInfo.forecast.condition)

                spanCondition
                    .append(spanName)
                    .append(spanDegrees)
                    .append(spanWeather)

                $('#current').empty()
                $('#current')
                    .append(title)
                    .append(spanIcon)
                    .append(spanCondition)

                $('#forecast').css('display', 'block')
            }

            function renderUpcomingWeather(forecast) {
                $('div#upcoming').empty()
                let title = $('<div>').addClass('label').text('Three-day forecast')
                $('div#upcoming').append(title)
                for (const day of forecast.forecast) {
                    let baseSpan = $('<span>').addClass('upcoming')
                    let spanIcon = $('<span>')
                        .addClass('symbol')
                        .html(weatherConditions[day.condition])
                    let spanDegrees = $('<span>')
                        .addClass('forecast-data')
                        .html(`${day.low}${weatherConditions['Degrees']}/${day.high}${weatherConditions['Degrees']}`)
                    let spanWeather = $('<span>').addClass('forecast-data').text(day.condition)

                    baseSpan
                        .append(spanIcon)
                        .append(spanDegrees)
                        .append(spanWeather)

                    $('div#upcoming').append(baseSpan)
                }
            }
        }
    }
}
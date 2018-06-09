let requester = (() => {
    const kinveyBaseUrl = "https://baas.kinvey.com/";
    const kinveyAppKey = "kid_S1px-0e3z";
    const kinveyAppSecret = "3d3f4d5d0c804f34a06d41b59a713b9c";

    // Creates the authentication header
    function makeAuth(type) {
        return type === 'basic'
            ? 'Basic ' + btoa(kinveyAppKey + ':' + kinveyAppSecret)
            : 'Kinvey ' + sessionStorage.getItem('authtoken');
    }

    // Creates request object to kinvey
    function makeRequest(method, module, endpoint, auth) {
        let req = {
            method,
            url: kinveyBaseUrl + module + '/' + kinveyAppKey + '/' + endpoint,
            headers: {
                'Authorization': makeAuth(auth),
            }
        }

        /* if (endpoint === '') {
            req.headers['Content-type'] = 'application/json'
        } */

        return req
    }

    // Function to return GET promise
    function get(module, endpoint, auth) {
        return $.ajax(makeRequest('GET', module, endpoint, auth));
    }

    // Function to return POST promise
    function post(module, endpoint, auth, data) {
        let req = makeRequest('POST', module, endpoint, auth);
        req.data = data;
        if (endpoint === 'entries' || endpoint === 'receipts' || endpoint.startsWith('receipts')) {
            req.headers['Content-type'] = 'application/json'
        }
        return $.ajax(req);
    }

    // Function to return PUT promise
    function update(module, endpoint, auth, data) {
        let req = makeRequest('PUT', module, endpoint, auth);
        req.data = data;
        req.headers['Content-type'] = 'application/json'
        return $.ajax(req);
    }

    // Function to return DELETE promise
    function remove(module, endpoint, auth) {
        return $.ajax(makeRequest('DELETE', module, endpoint, auth));
    }

    return {
        get,
        post,
        update,
        remove
    }
})()
let requester = (() => {
    const kinveyBaseUrl = "https://baas.kinvey.com/";
    const kinveyAppKey = "kid_SyIRbOjsz";
    const kinveyAppSecret = "271849f052ec4090a747e05336ad777e";

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

        if (endpoint === '') {
            req.headers['Content-type'] = 'application/json'
        }
        
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
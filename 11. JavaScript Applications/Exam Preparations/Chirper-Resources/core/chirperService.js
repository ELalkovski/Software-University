let chirperService = (() => {
    async function loadChirps(subs) {
        // Request chirps from db
        return await requester.get('appdata', `chirps?query={"author":{"$in": ${subs}}}&sort={"_kmd.ect": 1}`, 'kinvey')
    }

    function loadMyChirps(inputUsername) {
        let username
        
        if (inputUsername !== undefined) {
            username = inputUsername
        } else {
            username = sessionStorage.getItem('username')
        }

        return requester.get('appdata', `chirps?query={"author":"${username}"}&sort={"_kmd.ect": 1}`, 'kinvey');
    }

    async function loadChirpsCount(inputUsername) {
        let username
        
        if (inputUsername !== undefined) {
            username = inputUsername
        } else {
            username = sessionStorage.getItem('username')
        }
        let count = await requester.get('appdata', `chirps?query={"author":"${username}"}`, 'kinvey')

        return count.length
    }

    async function loadFollowingCount(inputUsername) {
        let username
        
        if (inputUsername !== undefined) {
            username = inputUsername
        } else {
            username = sessionStorage.getItem('username')
        }
        let user = await requester.get('user', `?query={"username":"${username}"}`, 'kinvey')

        return user[0].subscriptions.length
    }

    async function loadFollowersCount(username) {
        let subscribedUsers = await requester.get('user', `?query={"subscriptions":"${username}"}`, 'kinvey')

        return subscribedUsers.length
    }

    function createChirp(text, author) {
        let data = {text, author}
        return requester.post('appdata', 'chirps', 'kinvey', data)
    }

    function removeChirp(chirpId) {

        return requester.remove('appdata', 'chirps/' + chirpId, 'kinvey')
    }

    function discover() {
        return requester.get('user', '', 'kinvey')
    }

    function getUser(id) {
        return requester.get('user', id, 'kinvey')
    }

    function updateUser(id, username, subscriptions) {
        let userData = JSON.stringify({
            username: username,
            subscriptions: subscriptions            
        })

        return requester.update('user', id, 'kinvey', userData)
    }

    function calcTime(dateIsoFormat) {
        let diff = new Date - (new Date(dateIsoFormat))
        diff = Math.floor(diff / 60000);
        if (diff < 1) return 'less than a minute'
        if (diff < 60) return diff + ' minute' + pluralize(diff)
        diff = Math.floor(diff / 60)
        if (diff < 24) return diff + ' hour' + pluralize(diff)
        diff = Math.floor(diff / 24)
        if (diff < 30) return diff + ' day' + pluralize(diff)
        diff = Math.floor(diff / 30)
        if (diff < 12) return diff + ' month' + pluralize(diff)
        diff = Math.floor(diff / 12)
        return diff + ' year' + pluralize(diff)
        function pluralize(value) {
            if (value !== 1) return 's'
            else return ''
        }
    }   


    return {
        loadChirps,
        loadMyChirps,
        createChirp,
        removeChirp,
        calcTime,
        loadChirpsCount,
        loadFollowingCount,
        loadFollowersCount,
        discover,
        getUser,
        updateUser,
    }
})()
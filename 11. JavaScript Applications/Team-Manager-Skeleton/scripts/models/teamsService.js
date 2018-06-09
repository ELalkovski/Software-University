let teamsService = (() => {
    function loadTeams() {
        // Request teams from db
        return requester.get('appdata', 'teams', 'kinvey');
    }

    function loadTeamDetails(teamId) {
        return requester.get('appdata', 'teams/' + teamId, 'kinvey');
    }

    function edit(teamId, name, description) {
        let teamData = {
            name: name,
            comment: description,
            author: sessionStorage.getItem('username')
        };

        return requester.update('appdata', 'teams/' + teamId, 'kinvey', teamData);
    }

    function createTeam(name, comment) {
        let teamData = {
            name: name,
            comment: comment
        };

        return requester.post('appdata', 'teams', 'kinvey', teamData);
    }

    function addUserInTeam(teamId, userId, username) {
        let data = {
            teamId: teamId,
            userId: userId,
            username: username
        }

        return requester.post('appdata', 'teamsMembers', 'kinvey', data)
    }

    function getAllTeamsUsers() {
        return requester.get('appdata', 'teamsMembers', 'kinvey')
    }

    function deleteTeamUser(id) {
        return requester.remove('appdata', 'teamsMembers/' + id, 'kinvey')
    }

    function joinTeam(teamId) {
        let userData = {
            username: sessionStorage.getItem('username'),
            teamId: teamId
        };

        return requester.update('user', sessionStorage.getItem('userId'), 'kinvey', userData);
    }

    function leaveTeam() {
        let userData = {
            username: sessionStorage.getItem('username'),
            teamId: ''
        };

       return requester.update('user', sessionStorage.getItem('userId'), userData, 'kinvey');
    }


    return {
        loadTeams,
        loadTeamDetails,
        edit,
        createTeam,
        joinTeam,
        leaveTeam,
        addUserInTeam,
        getAllTeamsUsers,
        deleteTeamUser,
    }
})()
function printSong(array){

    let songName = array[0]
    let artist = array[1]
    let duration = array[2]

    console.log(`Now Playing: ${artist} - ${songName} [${duration}]`)
}

printSong(['Number One', 'Nelly', '4:09'])
function countOccurences(searchWord, str) {
    
    let occurencesCount = 0
    let searchWordIndex = str.indexOf(searchWord)

    while (searchWordIndex >= 0) {
        
        searchWordIndex = str.indexOf(searchWord, searchWordIndex + 1)
        occurencesCount++
    }

    console.log(occurencesCount)
}

countOccurences('ma', 'Marine mammal training is the training and caring for marine life such as, dolphins, killer whales, sea lions, walruses, and other marine mammals. It is also a duty of the trainer to do mental and physical exercises to keep the animal healthy and happy.')
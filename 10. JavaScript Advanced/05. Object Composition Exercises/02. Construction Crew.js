function modifyWorker(worker) {
    
    if (worker.handsShaking) {
        worker.handsShaking = false
        worker.bloodAlcoholLevel += worker.weight * 0.1 * worker.experience
    }

    return worker
}

console.log(modifyWorker({ weight: 80,
    experience: 1,
    bloodAlcoholLevel: 0,
    handsShaking: true }
  ))
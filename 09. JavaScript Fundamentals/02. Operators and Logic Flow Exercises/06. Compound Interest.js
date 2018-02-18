function calculateInterest(array) {

    let principalSum = array[0]
    let interestRatePercentage = array[1]
    let compoundingPeriodMonths = array[2]
    let totalTimeSpanYears = array[3]
    let compoundingFrequency = 12 / compoundingPeriodMonths
    let nt = totalTimeSpanYears * compoundingFrequency
    let nominalInterestRate = ((interestRatePercentage / 100) / 1) * (1000 / 1000)

    let compoundInterest = principalSum * Math.pow((1 + nominalInterestRate / compoundingFrequency), nt)

    console.log(compoundInterest.toFixed(2))
}

calculateInterest([100000, 5, 12, 25])
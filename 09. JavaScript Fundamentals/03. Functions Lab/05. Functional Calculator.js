function calculate(firstNum, secondNum, sign) {

    switch (sign) {
        case '+': console.log(firstNum + secondNum); break
        case '-': console.log(firstNum - secondNum); break
        case '/': console.log(firstNum / secondNum); break
        case '*': console.log(firstNum * secondNum); break
    }
}

calculate(2, 4, '+')
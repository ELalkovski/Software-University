function sumNumbers() {
    let num1 = document.getElementById('num1').value;
    let num2 = document.getElementById('num2').value;

    let sum = Number(num1) + Number(num2);

    document.getElementById('result').innerHTML = sum;
}/**
 * Created by Embata on 21-Mar-17.
 */

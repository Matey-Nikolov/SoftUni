function subtract() {
    let firstNumber = document.getElementById('firstNumber').value;
    let secondNumber = document.getElementById('secondNumber').value;
    let divResult = document.getElementById('result');

    let sum = firstNumber - secondNumber;

    divResult.textContent += sum;
}
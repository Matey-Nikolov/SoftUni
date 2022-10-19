function password(input) {
    let name = input.shift();
    let password = input.shift();

    for (let i = 0; i < input.length; i++) {
        if (password === input[i]) {
            console.log('Welcome ' + name + '!');
            return;
        }
    }
}

password(['Nakov', '1234', 'pass', '1324', '1234']);    
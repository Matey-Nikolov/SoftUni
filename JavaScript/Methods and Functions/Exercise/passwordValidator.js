function passwordValidator(password) {
    let patternRegex = '[a-zA-Z]+[0-9]{2,}';
    let reguarExp = new RegExp(patternRegex);

    if (reguarExp.test(password)) {
        console.log('Password is valid');
        return;
    }

    if (password.length > 6 && 10 >= password.length) {} else {
        console.log('Password must be between 6 and 10 characters');
    }

    patternRegex = '[!@#$%^&*()_]+';
    reguarExp = new RegExp(patternRegex);
    if (reguarExp.test(password)) {
        console.log('Password must consist only of letters and digits');
    }


    patternRegex = '[0-9]{2,}';
    reguarExp = new RegExp(patternRegex);

    if (!reguarExp.test(password)) {
        console.log('Password must have at least 2 digits');
    }
}

//passwordValidator('logIn');
//passwordValidator('MyPass123');
passwordValidator('Pa$s$s');
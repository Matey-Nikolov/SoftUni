function validate() {
    let re = /(([a-z^<>()[\]\\.,;:@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-z\-0-9]+\.)+[a-zA-Z]{2,}))/gm;

    let inputMail = document.getElementById('email');


    inputMail.addEventListener('change', () => {
        if (re.test(inputMail.value)) {
            inputMail.removeAttribute('class');
            return;
        }
        
        inputMail.className = 'error';
    });
}
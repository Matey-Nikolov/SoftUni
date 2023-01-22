function lockedProfile() {
    let buttons = document.getElementsByTagName('button');

    let user1 = document.getElementById('user1HiddenFields');
    let user2 = document.getElementById('user2HiddenFields');
    let user3 = document.getElementById('user3HiddenFields');

    buttons[0].addEventListener('click', () => {

        // https://stackoverflow.com/questions/9618504/how-to-get-the-selected-radio-button-s-value

        let user1Locked = document.querySelector('input[name="user1Locked"]:checked').value;

        if (user1Locked === 'unlock') {
            if (buttons[0].textContent === 'Show more') {
                user1.style.display = 'inline-block';
                buttons[0].textContent = 'Hide it';
            } else if (buttons[0].textContent === 'Hide it') {
                user1.style.display = 'none';
                buttons[0].textContent = 'Show more';
            }
        } else {
            user1.style.display = 'none';
            buttons[0].textContent = 'Show more';
        }

    });

    buttons[1].addEventListener('click', () => {

        let user2Locked = document.querySelector('input[name="user2Locked"]:checked').value;

        if (user2Locked === 'unlock') {
            if (buttons[1].textContent === 'Show more') {
                user2.style.display = 'inline-block';
                buttons[1].textContent = 'Hide it';
            } else if (buttons[1].textContent === 'Hide it') {
                user2.style.display = 'none';
                buttons[1].textContent = 'Show more';
            }
        } else {
            user2.style.display = 'none';
            buttons[1].textContent = 'Show more';
        }

    });

    buttons[2].addEventListener('click', () => {

        let user3Locked = document.querySelector('input[name="user3Locked"]:checked').value;

        if (user3Locked === 'unlock') {
            if (buttons[2].textContent === 'Show more') {
                user3.style.display = 'inline-block';
                buttons[2].textContent = 'Hide it';
            } else if (buttons[2].textContent === 'Hide it') {
                user3.style.display = 'none';
                buttons[2].textContent = 'Show more';
            }
        } else {
            user3.style.display = 'none';
            buttons[2].textContent = 'Show more';
        }

    });
}
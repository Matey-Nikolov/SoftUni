function notify(message) {
    console.log('todo')

    let divNotification = document.getElementById('notification');

    divNotification.textContent = message;
    console.log(divNotification.textContent);

    divNotification.style.display = 'block';

    //https://developer.mozilla.org/en-US/docs/Web/API/setTimeout
    setTimeout(() => {
        divNotification.style.display = 'none';

    }, 1000)
}
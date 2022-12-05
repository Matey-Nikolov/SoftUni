function modernTimes(sentence) {

    //https://stackoverflow.com/questions/23476532/check-if-string-contains-only-letters-in-javascript
    sentence.split(' ').forEach(word => {

        if (/#[a-zA-Z]+/.test(word)) {
            console.log(word.slice(1));
        }

    });
}

modernTimes('Nowadays everyone uses #2 to tag a #special word in #socialMedia');
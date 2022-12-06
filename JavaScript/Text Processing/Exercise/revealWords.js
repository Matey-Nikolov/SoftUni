function revealWords(words, sentence) {
    let text = '';

    words.split(', ').forEach(word => {
        text = sentence.replace('*'.repeat(word.length), word);
        sentence = text;
    });
    console.log(text);
}

revealWords('great', 'softuni is ***** place for learning new programming languages');
revealWords('great, learning', 'softuni is ***** place for ******** new programming languages');
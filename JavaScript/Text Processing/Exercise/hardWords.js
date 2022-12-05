function hardWord(input) {
    const pattern = '[_]+';

    let text = input[0];
    let arrayWords = input[1];

    // Ще ги сортираме по дължина, за да ни е по лесно намирането. 
    arrayWords = arrayWords.sort((a, b) => b.length - a.length);

    arrayWords.forEach(word => {
        text = text.replace('_'.repeat(word.length), word);
    });
    console.log(text);
}

hardWord(['Hi, grandma! I\'m so ____ to write to you. ______ the winter vacation, so _______ things happened.My dad bought me a sled.Mom started a new job as a __________.My brother\'s ankle is ________, and now it bothers me even more. Every night Mom cooks ___ on your recipe because it is the most delicious.I hope this year Santa will _____ me a robot. ', ['pie', 'bring', 'glad', 'During', 'amazing', 'pharmacist', 'sprained']]);
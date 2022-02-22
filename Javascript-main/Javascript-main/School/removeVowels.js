function removeVowels(message){
    const vowels = ['a', 'e', 'o', 'u', 'i'];
    const result = [];
    for(const symbol of message){
        if(!(vowels.includes(symbol.toLowerCase()))){
            result.push(symbol);
        }
    }

    console.log(result.join(' '));
}

removeVowels('I love apple');
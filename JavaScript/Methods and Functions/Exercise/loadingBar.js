function loadingBar(number) {
    let result = number / 10;
    let loading = [];

    for (let i = 0; i < 10; i++) {
        loading[i] = '.';
    }

    for (let i = 0; i < result; i++) {
        loading[i] = '%';
    }

    if (result === 10) {
        console.log('100% Complete!');
        console.log(`[${loading.join('')}]`);
    } else {
        console.log(`${number}% [${loading.join('')}]`);
        console.log('Still loading...');
    }

}

loadingBar(30);
loadingBar(50);
loadingBar(100);
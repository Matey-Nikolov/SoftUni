function cutAndReverse(input) {

    const concatHalftOne = input.slice(0, input.length / 2).split('')
        .reverse()
        .join('');
    const concatHalftTwo = input.slice(input.length / 2).split('')
        .reverse()
        .join('');;


    console.log(concatHalftOne);
    console.log(concatHalftTwo);
}

cutAndReverse('tluciffiDsIsihTgnizamAoSsIsihT');
cutAndReverse('sihToDtnaCuoYteBIboJsihTtAdooGoSmI');
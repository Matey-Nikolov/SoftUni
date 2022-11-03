function schoolGrades(input) {
    let map = new Map();

    for (let line of input) {

        let arr = line.split(' ');
        let name = arr[0];
        let grades = arr.splice(1, arr.length).map(Number);

        if (!map.has(name)) {
            map.set(name, []);
            map.set(name, map.get(name).concat(grades));
        } else {
            map.set(name, map.get(name).concat(grades));
        }
    }

    let sorted = Array.from(map).sort((a, b) => average(a, b))

    function average(a, b) {
        let aSum = 0;
        for (let i = 0; i < a[1].length; i++) {
            aSum += a[1][i];
        }

        let bSum = 0;
        for (let j = 0; j < b[1].length; j++) {
            bSum += b[1][j];
        }

        let aAverage = aSum / a[1].length;
        let bAverage = bSum / b[1].length;

        return aAverage - bAverage;
    }

    for (let [key, value] of sorted) {
        console.log(`${key}: ${value.join(', ')}`);
    }
}

schoolGrades(['Lilly 4 6 6 5',
    'Tim 5 6',
    'Tammy 2 4 3',
    'Tim 6 6'
]);
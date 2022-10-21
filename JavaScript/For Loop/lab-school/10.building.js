function building(floors, rooms) {
    for (let i = 0; i < floors; i++) {
        let row = '';
        for (let j = 0; j < rooms; j++) {
            if (i === 0) {
                row += `L${floors - i}${j} `;
            } else if (floors % 2 === 0) {
                if (i % 2 === 0) {
                    row += `O${floors - i}${j} `;
                } else if (i % 2 !== 0) {
                    row += `A${floors - i}${j} `;
                }
            } else if (floors % 2 !== 0) {
                if (i % 2 !== 0) {
                    row += `O${floors - i}${j} `;
                } else if (i % 2 === 0) {
                    row += `A${floors - i}${j} `;
                }
            }
        }
        console.log(row);
    }
}

// building(6, 4);
building(9, 5);
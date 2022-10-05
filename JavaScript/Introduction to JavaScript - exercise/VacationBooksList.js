function booksForSummer(pages, pagesPerHour, days) {
    let totalReading = pages / pagesPerHour
    let requiredHours = totalReading / days

    console.log(requiredHours);
}

booksForSummer(212, 20, 2)
booksForSummer(432, 15, 4)
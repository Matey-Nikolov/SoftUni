function movies(input) {

    let movies = [];

    for (const row of input) {

        let regexDirector = /directedBy/;
        let regexDate = /onDate/;


        if (row.startsWith("addMovie")) {
            let obj = {
                name: row.substring(8)
            };

            movies.push(obj);

        } else if (row.search(regexDirector)) {
            let [movieName, director] = row.split(' directedBy ');

            for (const element of movies) {
                if (movies.name === movieName) {

                }
            }

        } else if (row.search(regexDate)) {
            let [movieName, date] = row.split(' onDate ');
        }
    }

}

movies([
    'addMovie Fast and Furious',
    'addMovie Godfather', 'Inception directedBy Christopher Nolan',
    'Godfather directedBy Francis Ford Coppola',
    'Godfather onDate 29.07.2018',
    'Fast and Furious onDate 30.07.2018',
    'Batman onDate 01.08.2018',
    'Fast and Furious directedBy Rob Cohen'
]);
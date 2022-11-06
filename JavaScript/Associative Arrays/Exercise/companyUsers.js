function companyUsers(inputArray) {
    let employeesUsers = {};

    inputArray.forEach(element => {

        let [companyName, employeeId] = element.split(' -> ');

        if (!employeesUsers.hasOwnProperty(companyName)) {
            employeesUsers[companyName] = [];
        }
        if (!employeesUsers[companyName].includes(employeeId)) {
            employeesUsers[companyName].push(employeeId);
        }
    });

    let sortCompany = Object.keys(employeesUsers).sort((a, b) => a.localeCompare(b));

    for (let employee of sortCompany) {
        console.log(employee);
        for (let compId of employeesUsers[employee]) {
            console.log(`-- ${compId}`);
        }

    }
}


companyUsers([
    'SoftUni -> AA12345',
    'SoftUni -> BB12345',
    'Microsoft -> CC12345',
    'HP -> BB12345'
]);
class Company {
    constructor(){
        this.departments = {};
    }

    addEmployee(username, salary, position, department){

        /*
        if((username === "" || position === "" || department === "") ||
           (username === undefined || position === undefined || department === undefined) ||
           (username === null || position === null || department === null)){

            throw new Error('Invalid input!');
        } else if(salary <= 0){
            throw new Error('Invalid input!');
        }
        */

        //https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Operators/Logical_NOT
        //https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Statements/throw
        if(!username || !salary || !position || !department){
            throw new Error('Invalid input!');
        } else if(salary <= 0){
            throw new Error('Invalid input!');
        }

        if(!this.departments[department]){
            this.departments[department] = [];
        }

        this.departments[department].push({username, salary, position});
    }

    bestDepartment(){

        let bestDepartment;
        let bestDepartmentSalary = 0;

        for (let department in this.departments) {
            let departmentSalary = 0;

            for (let employee of this.departments[department]) {
                departmentSalary += employee.salary;
            }

            let averageSalary = (departmentSalary / this.departments[department].length).toFixed(2);
            
            if (averageSalary > bestDepartmentSalary) {
                bestDepartmentSalary = averageSalary;
                bestDepartment = department;
            }
        }

        this.departments[bestDepartment].sort((a, b) => {
            if (b.salary === a.salary) {
                return a.username.localeCompare(b.username);
            }
            return b.salary - a.salary;
        });

        let result = `Best Department is: ${bestDepartment}\nAverage salary: ${bestDepartmentSalary}\n`;
        
        for (let employee of this.departments[bestDepartment]) {
            result += `${employee.username} ${employee.salary} ${employee.position}\n`;
        }
        
        return result;
    }
}

let c = new Company();
//c.addEmployee("Stanimir", "", "", "Construction");
//c.addEmployee("Stanimir", 132, "", "Construction");

c.addEmployee("Stanimir", 2000, "engineer", "Construction");
c.addEmployee("Pesho", 1500, "electrical engineer", "Construction");
c.addEmployee("Slavi", 500, "dyer", "Construction");
c.addEmployee("Stan", 2000, "architect", "Construction");
c.addEmployee("Stanimir", 1200, "digital marketing manager", "Marketing");
c.addEmployee("Pesho", 1000, "graphical designer", "Marketing");
c.addEmployee("Gosho", 1350, "HR", "Human resources");
console.log(c.bestDepartment());
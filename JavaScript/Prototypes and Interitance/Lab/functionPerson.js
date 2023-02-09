function Person(firstName, lastName){
    this.firstName = firstName;
    this.lastName = lastName;

    Object.defineProperty(this, "fullName", {
        set: function(value){
            let[firstName, lastName] = value.split(' ');
            this.value = value;
            this.firstName = firstName;
            this.lastName = lastName;
        },
        get: function(){
            return `${this.firstName} ${this.lastName}`;
        }
    });
}

let person = new Person("Peter", "Ivanov");
console.log(person.fullName); //Peter Ivanov
person.firstName = "George";
console.log(person.fullName); //George Ivanov
person.lastName = "Peterson";
console.log(person.fullName); //George Peterson
person.fullName = "Nikola Tesla";
console.log(person.firstName); //Nikola
console.log(person.lastName); //Tesla
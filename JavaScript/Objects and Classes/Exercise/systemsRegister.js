function systemsRegister(input) {

    let registers = {};

    input.forEach(SysNameCompNameSybcompName => {
        let splitSystemNameComponentNameAndSubcomponentName = SysNameCompNameSybcompName.split(' | ');

        let systemName = splitSystemNameComponentNameAndSubcomponentName[0];
        let componentName = splitSystemNameComponentNameAndSubcomponentName[1];
        let subcomponentName = splitSystemNameComponentNameAndSubcomponentName[2];

        if (!registers.hasOwnProperty(systemName)) {
            registers[systemName] = {};
        }
        if (!registers[systemName].hasOwnProperty(componentName)) {
            registers[systemName][componentName] = [];
        }
        registers[systemName][componentName].push(subcomponentName);
    });


    // sort?

}

systemsRegister(['SULS | Main Site | Home Page ',
    'SULS | Main Site | Login Page ',
    'SULS | Main Site | Register Page ',
    'SULS | Judge Site | Login Page ',
    'SULS | Judge Site | Submittion Page ',
    'Lambda | CoreA | A23 ',
    'SULS | Digital Site | Login Page ',
    'Lambda | CoreB | B24 ',
    'Lambda | CoreA | A24 ',
    'Lam25 ',
    'Lambda | CoreC | Cbda | CoreA | A4 ',
    'Indice | Session | Default Storage ',
    'Indice | Session | Default Security'
]);
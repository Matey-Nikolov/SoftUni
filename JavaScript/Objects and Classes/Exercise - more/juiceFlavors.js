function solve(input){

    let juiceNameKeyValue = {};
    let count;

    for (const lineInput of input) {
        let [juiceName, juiceQuantity] = lineInput.split(" => ");
            
        if(!juiceNameKeyValue.hasOwnProperty(juiceName)){
            juiceNameKeyValue[juiceName] = Number(juiceQuantity);
        }
        else{
            juiceNameKeyValue[juiceName] += Number(juiceQuantity);
        }
    }

   // console.log(juiceNameKeyValue);
   /*
   let sorted = Object.entries(juiceNameKeyValue);
   sorted.sort((a, b) => a[0].localeCompare(b[0])); // key

    for (const iterator of sorted) {
        let juiceName = iterator[0];
        let juiceQuantity = iterator[1];
        let bottles = Math.floor(juiceQuantity / 1000);

        if(bottles >= 1){
            console.log(`${juiceName} => ${bottles}`);
        }
    }
*/
    
    for (const key in juiceNameKeyValue) {

        let bottles = Math.floor(juiceNameKeyValue[key] / 1000);
        //console.log(bottles);
        if(bottles >= 1){
            console.log(`${key} => ${bottles}`);
        }
    }
}

solve(['Orange => 2000',
'Peach => 1432',
'Banana => 450',
'Peach => 600',
'Strawberry => 549']);

solve(['Kiwi => 234',
'Pear => 2345',
'Watermelon => 3456',
'Kiwi => 4567',
'Pear => 5678',
'Watermelon => 6789']);
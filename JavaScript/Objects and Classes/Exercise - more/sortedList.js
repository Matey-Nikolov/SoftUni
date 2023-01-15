class List{
    constructor(){
        this.list = [];
    }

    add(element){
        this.list.push(element);
    }

    get(index){
        return this.list[index];
    }

    remove(index){
        this.list.splice(index, 1);
    }
}

let list = new List();
list.add(5);
//list.add(6);
//list.add(7);
console.log(list.get(0));
//list.remove(1);
//console.log(list.get(1));
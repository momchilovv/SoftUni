/**
 * Created by Cvetelin Momchilov on 11/7/2017.
 */
function sumByTown(arr) {
    let sum = {};
    for(let i = 0; i < arr.length; i++){
        var object =JSON.parse(arr[i]);
        if(sum.hasOwnProperty(object.town)){
            sum[object.town] += object.income;
        }
        else{
            sum[object.town] = object.income;
        }
    }
    let towns = Object.keys(sum).sort();

    for(let town of towns){
        console.log(`${town} -> ${sum[town]}`);
    }
}
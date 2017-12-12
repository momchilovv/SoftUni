/**
 * Created by Cvetelin Momchilov on 11/8/2017.
 */
function extractCapitalCaseWords(arr) {
    let capitalWords = [];
    for(let sentence of arr){
        let words = sentence.split(/\W+/).filter(word => word != "");

        for(let word of words){
            if(word == word.toUpperCase()){
                capitalWords.push(word);
            }
        }
    }
    console.log(capitalWords.join(", "));
}
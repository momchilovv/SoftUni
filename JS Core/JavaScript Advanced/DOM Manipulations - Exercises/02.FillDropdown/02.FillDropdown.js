function addItem(){
    let inputText = document.getElementById('newItemText').value;
    let inputValue = document.getElementById('newItemValue').value;

    let el = document.createElement('option');
    
    el.textContent = inputText;
    el.value = inputValue;

    document.getElementById('menu').appendChild(el);
    document.getElementById('newItemText').value = '';
    document.getElementById('newItemValue').value = '';
};
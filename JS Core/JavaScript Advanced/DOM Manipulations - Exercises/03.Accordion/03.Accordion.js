function toggle(){
    let more = document.getElementsByClassName('button')[0];
    if(more.textContent == "More"){
        more.textContent = "Less";
        document.getElementById('extra').style.display = 'block';
    }
    else{
        more.textContent = "More";
        document.getElementById('extra').style.display = 'none';
    }
};
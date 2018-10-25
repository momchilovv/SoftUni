function create(sentences){
    for (const sentence of sentences) {
        let div = document.createElement('div');
        let para = document.createElement('p');

        para.textContent = sentence;

        div.appendChild(para).style.display = "none";
        div.addEventListener('click', function (){
            //This if-case is not required
            if(para.style.display == "block"){
                para.style.display = "none";
            }
            else{
                para.style.display = "block";
            }
        });
        

        let content = document.getElementById('content');
        content.appendChild(div);
    }
};
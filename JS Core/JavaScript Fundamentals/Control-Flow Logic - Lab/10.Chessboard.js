function chessboard(n){
    let html = '<div class="chessboard">\n';
    let count = n;
    if(n % 2 !== 0){
        let color = 'black';
    }
    else {
        let color = 'white';
    }
    for(let i = 1; i <= n; i++){        
               
        html += '\t<div>\n';
        for(let j = 1; j <= n; j++){
        
            if(n % 2 !== 0){
            if(count % 2 == 0)
                color = 'white';
                else{ color = 'black'}
            }
            else if(n % 2 == 0){
                if(count % 2 == 0)
                color = 'white';
                else{ color = 'black'}
            }
            html += `\t\t<span class="${color}"></span> \n`;
            count++;
        }
        html += '\t</div>\n';
    }
    html += '</div>';
    console.log(html);
}
chessboard(2);
function circle(radius){
    let area = (radius * radius) * Math.PI;

    console.log(area);
    console.log(Math.round(area * 100) / 100);

}
circle(5);
function CalculateArea(w, h, W, H){
    let firstSide = w * h;
    let secondSide = W * H;
    let thirdSide = Math.min(w, W) * Math.min(h, H);

    console.log(firstSide + secondSide - thirdSide);
}
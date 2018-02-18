function calculateArea(w, h, W, H){
    let [s1, s2, s3] = [w * h, W * H, Math.min(w, W) * Math.min(h, H)]
    let result = s1 + s2 - s3
    return result
}

console.log(calculateArea(13, 2, 5, 8))
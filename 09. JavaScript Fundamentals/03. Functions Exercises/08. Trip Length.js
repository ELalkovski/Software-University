function calculate(input) {
    let x1 = Number(input[0]);
    let y1 = Number(input[1]);
    let x2 = Number(input[2]);
    let y2 = Number(input[3]);
    let x3 = Number(input[4]);
    let y3 = Number(input[5]);
 
    let distance12 = Math.sqrt(Math.pow((x2 - x1), 2) + Math.pow((y2 - y1), 2));
    let distance23 = Math.sqrt(Math.pow((x3 - x2), 2) + Math.pow((y3 - y2), 2));
    let distance13 = Math.sqrt(Math.pow((x3 - x1), 2) + Math.pow((y3 - y1), 2));
 
 
    if ((distance12 <= distance13) && (distance13 => distance23)) {
       let a = distance12 + distance23;
        console.log('1->2->3: ' + a);
    }
    else if ((distance12 <= distance23) && (distance13 < distance23)) {
        let b = distance13 + distance12;
        console.log('2->1->3: '+ b);
    }
    else {
        let c = distance23 + distance13;
        console.log('1->3->2: ' + c);
    }
 
}

calculate([-1, -2, 3.5, 0, 0, 2])
//NOTE:asd TODO: asd FIXME: asd DEBUG: asd HACK: asd REVIEW:css
function solve(args) {
    let bricks = [];
    bricks[0] = [args[0]];
    bricks[1] = [args[1], args[2]];
    let layersCount = args[3];


    // console.log(bricks);
    printer(bricks);

    function printer(obj) {
        for (let i = 0; i < obj.length; i++) {
            let print = obj[i].join(" ");
            console.log(print);
        }
    }

    function builder() {

    }
}

solve(
    [2, 1, 5, 3]
);
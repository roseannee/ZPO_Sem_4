var board;
var score = 0;
var rows = 4;
var columns = 4;

var isLeftEqual = false,
isRightEqual = false,
isUpEqual = false,
isDownEqual = false;

window.onload = function() {
    setGame();
}

function setGame() {
    board = [
        [0, 0, 0, 0],
        [0, 0, 0, 0],
        [0, 0, 0, 0],
        [0, 0, 0, 0]
    ]

    for (let r = 0; r < rows; r++) {
        for (let c = 0; c < columns; c++) {
            let tile = document.createElement("div");
            tile.id = r.toString() + "-" + c.toString();
            let num = board[r][c];
            updateTile(tile, num);
            document.getElementById("board").append(tile);
        }
    }

    randomTileValue();
    randomTileValue();
}

function updateTile(tile, num) {
    tile.innerText = "";
    tile.classList.value = "";
    tile.classList.add("tile");
    if (num > 0) {
        tile.innerText = num;
        if (num <= 4096) {
            tile.classList.add("x" + num.toString());
        } else {
            tile.classList.add("x8192");
        }
    }
}

document.addEventListener("keyup", (e) => {
    let copyBoard = new Array(board.length);
    for (let i = 0; i < board.length; i++) {
        copyBoard[i] = board[i].slice(0);
    }

    if (e.code == "ArrowLeft" || e.key == "a") {
        slideLeft();
        randomTileValue();

        isLeftEqual = areEqual(board, copyBoard);
    }
    else if (e.code == "ArrowRight" || e.key == "d") {
        slideRight();
        randomTileValue();

        isRightEqual = areEqual(board, copyBoard);
    }
    else if (e.code == "ArrowUp" || e.key == "w") {
        slideUp();
        randomTileValue();

        isUpEqual = areEqual(board, copyBoard);
    }
    else if (e.code == "ArrowDown" || e.key == "s") {
        slideDown();
        randomTileValue();

        isDownEqual = areEqual(board, copyBoard);
    }

    document.getElementById("score").innerText = score;

    gameOver();
})

function filterZero(row) {
    return row.filter(num => num != 0);
}

function slide(row) {
    row = filterZero(row);

    for (let i = 0; i < row.length - 1; i++) {
        if (row[i] == row[i + 1]) {
            row[i] *= 2;
            row[i + 1] = 0;
            score += row[i];
        }
    }

    row = filterZero(row);

    while (row.length < columns) {
        row.push(0);
    }

    return row;
}

function slideLeft() {
    for (let r = 0; r < rows; r++) {
        let row = board[r];
        row = slide(row);
        board[r] = row;

        for (let c = 0; c < columns; c++) {
            let tile = document.getElementById(r.toString() + "-" + c.toString());
            let num = board[r][c];
            updateTile(tile, num);
        }
    }
}

function slideRight() {
    for (let r = 0; r < rows; r++) {
        let row = board[r];
        row.reverse();
        row = slide(row);
        row.reverse();
        board[r] = row;

        for (let c = 0; c < columns; c++) {
            let tile = document.getElementById(r.toString() + "-" + c.toString());
            let num = board[r][c];
            updateTile(tile, num);
        }
    }
}

function slideUp() {
    for (let c = 0; c < columns; c++) {
        let row = [board[0][c], board[1][c], board[2][c], board[3][c]];
        row = slide(row);

        for (let r = 0; r < rows; r++) {
            board[r][c] = row[r];
            let tile = document.getElementById(r.toString() + "-" + c.toString());
            let num = board[r][c];
            updateTile(tile, num);
        }
    }
}

function slideDown() {
    for (let c = 0; c < columns; c++) {
        let row = [board[0][c], board[1][c], board[2][c], board[3][c]];
        row.reverse();
        row = slide(row);
        row.reverse();

        for (let r = 0; r < rows; r++) {
            board[r][c] = row[r];
            let tile = document.getElementById(r.toString() + "-" + c.toString());
            let num = board[r][c];
            updateTile(tile, num);
        }
    }
}

function randomTileValue() {
    let min = 1;
    let max = 4;
   
    if (Math.floor(Math.random() * (max - min + 1) + min) <= 2) {
        setTwo();
    }
    else {
        setFour();
    }
}

function setTwo() {
    if (!hasEmptyTile()) {
        return;
    }

    let found = false;
    while (!found) {
        let r = Math.floor(Math.random() * rows);
        let c = Math.floor(Math.random() * columns);

        if (board[r][c] == 0) {
            board[r][c] = 2;

            let tile = document.getElementById(r.toString() + "-" + c.toString());
            tile.innerText = "2";
            tile.classList.add("x2");

            found = true;
        }
    }
}

function setFour() {
    if (!hasEmptyTile()) {
        return;
    }

    let found = false;
    while (!found) {
        let r = Math.floor(Math.random() * rows);
        let c = Math.floor(Math.random() * columns);
        if (board[r][c] == 0) {
            board[r][c] = 4;

            let tile = document.getElementById(r.toString() + "-" + c.toString());
            tile.innerText = "4";
            tile.classList.add("x4");

            found = true;
        }
    }
}

function hasEmptyTile() {
    for (let r = 0; r < rows; r++) {
        for (let c = 0; c < columns; c++) {
            if (board[r][c] == 0) {
                return true;
            }
        }
    }

    return false;
}

function gameOver() {
    if (!hasEmptyTile() && isLeftEqual && isRightEqual && isUpEqual && isDownEqual) {
        alert("Game Over! Your score is " + score);
        location.reload();
    }
}

function areEqual(arr1, arr2) {
    if (JSON.stringify(arr1) == JSON.stringify(arr2)) {
        return true;
    }
    else {
        return false;
    }
}
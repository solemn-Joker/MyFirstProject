onload = function () {
    setInterval(go, 1000);
};
var x = 5;
function go() {
    x--;
    if (x > 0) {
        document.getElementById("time").innerHTML = x;
    } else {
        location.href = '../logins/login.html';
    }
}

function fun() {
    window.location.href = '../logins/login.html';
}
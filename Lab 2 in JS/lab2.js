function hello() {
    console.log("Hello World");
}

function userInput() {
    var l = prompt("Please input a length");
    var w = prompt("Please input a width");
    var h = prompt("Please enter a height");

    var a = getArea(l, w);
    console.log("Area: " + a);
    var p = document.getElementById("output");
    p.innerText = "Area: " + a;
    console.log(p);

    var peri = getPerimeter(l, w);
    var p2 = document.getElementById("output2");
    p2.innerText = "Perimeter: " + peri;

    var vol = getVolume(l, w, h);
    var p3 = document.getElementById("output3");
    p3.innerText = "Volume: " + vol;

}

function getArea(length, width) {
    var result = length * width;
    return result;
}

function getPerimeter(length, width) {
    var result = (length * 2) + (width * 2);

    return result;
}

function getVolume(length, width, height) {
    var result = length * width * height;
    return result;
}
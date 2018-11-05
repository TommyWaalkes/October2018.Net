function doMath() {
    console.log("Hello World");
    var num1 = document.getElementById("input1").value;
    var num2 = document.getElementById("input2").value;

    //var output = document.getElementById("output");
    var radios = document.getElementsByName("math");
    var op;
    for (i = 0; i < radios.length; i++) {

        if (radios[i].checked) {
            console.log(radios[i]);
            op = radios[i].value;
        }
    }

    if (op === "add") {
        document.getElementById("output").innerText = parseInt(num1) + parseInt(num2);
    }
    else if (op === "subtract") {
        document.getElementById("output").innerText = parseInt(num1) - parseInt(num2);
    }
    else if (op === "multiply") {
        document.getElementById("output").innerText = parseInt(num1) * parseInt(num2);
    }
    else if (op === "divide") {
        document.getElementById("output").innerText = parseInt(num1) / parseInt(num2);
    }
}
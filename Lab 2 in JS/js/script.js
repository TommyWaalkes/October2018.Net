
console.log("This is my statement");

var myVariable;

//myVariable = [value];    var myVariable = 25; // number

var myVariable = "word"; // string

var myVariable = "25"; // string

var myVariable = true; // boolean

var myVariable = null; // null -- no value

var myVariable; // undefined    var name = "";

var done = false;

function ask() { return prompt("Please enter your name"); }

function helloName() {

    while (!done) {

        userinput = ask();

        if (isTooShort(userinput)) { alert("Your name is short. Too short.\n Do it again!"); }

        else {
            alert("Hello " + userinput);

            done = true;
        }

    }

} function isTooShort(inputName) {

    return inputName.length < 2;

}
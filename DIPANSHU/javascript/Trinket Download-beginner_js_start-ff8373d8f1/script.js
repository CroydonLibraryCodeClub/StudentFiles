var buttons = document.getElementsByClassName('colourButton');
function setButtonColour(button, red, green, blue){
    button.setAttribute('style',
                        'background-color: rgb('+ red +','+ green +','+ blue +');'
                       );
}
buttons[0]
setButtonColour(buttons[0], 0, 0, 255);

function makeColourValue(){
    return Math.round(Math.random()*255);
}
var red = makeColourValue();
var green = makeColourValue();
var blue = makeColourValue();

setButtonColour(buttons[0], red, green, blue);
for (var i = 0; i < buttons.length; i++) {

  var red = makeColourValue();
  var green = makeColourValue();
  var blue = makeColourValue();

  setButtonColour(buttons[i], red, green, blue);

}

function validate(inputID) {
    var input = document.getElementById(inputID);
    var validityState_object = input.validity;
    if(validityState_object.valueMissing) {
       input.setCustomValidity('You gotta fill this out, yo!');
    } else if (input.rangeUnderflow) {
      input.setCustomValidity('We need a higher number!');
    } else if (input.rangeOverflow) {
      input.setCustomValidity('Thats too high!');
    } else {
      input.setCustomValidity('');
    }
  }
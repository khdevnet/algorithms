var str = "([{}])";

function validate(str){

var open = {"(":")","[":"]","{":"}"};
var close = {")": "(","]":"[","}":"{"};

var stack = [];

for(var i=0; i< str.length; i++)
{
  if(open[str[i]]) {
     stack.push(open[str[i]]);
  }

  if(close[str[i]] && stack.pop() !== str[i]) {
  	  break;
  }

}

return stack.length==0;

}

console.log(validate(str));
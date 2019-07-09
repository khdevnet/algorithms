/// f(4) 1*2*3*4; n*(n+1)

function factorial(n) {
  if (n == 1) {
    return n;
  }
  return n * factorial(n - 1)
}

var num = 3;
console.log(factorial(num));
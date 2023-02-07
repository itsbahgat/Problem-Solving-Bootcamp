// palindrome number 

function isPalindrome(num) {
  let str = num.toString();
  let len = str.length;
  let mid = Math.floor(len / 2);
  let i = 0;
  while (i < mid) {
    if (str[i] !== str[len - 1 - i]) {
      return false;
    }
    i++;
  }
  return true;
}
console.log(isPalindrome(121)); // true
console.log(isPalindrome(1211)); // false

console.log(" ".repeat(10))
console.log("*".repeat(10))
console.log(" ".repeat(10))

// with modulus
function isPalindrome2(num) {
  let rev = 0;
  let n = num;
  while (n > 0) {
    rev = rev * 10 + n % 10;
    n = Math.floor(n / 10);
  }
  return rev === num;
}

console.log(isPalindrome(121)); // true
console.log(isPalindrome(1211)); // false

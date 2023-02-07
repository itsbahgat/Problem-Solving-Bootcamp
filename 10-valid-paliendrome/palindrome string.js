//palindrome string

function isPalindrome(str) {
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

console.log(isPalindrome("racecar")); // true
console.log(isPalindrome("racecars")); // false

console.log(" ".repeat(10))
console.log("*".repeat(10))
console.log(" ".repeat(10))

// with modulus
function isPalindrome2(str) {
  let rev = "";
  let n = str.length - 1;
  while (n >= 0) {
    rev += str[n];
    n--;
  }
  return rev === str;
}

console.log(isPalindrome2("racecar")); // true
console.log(isPalindrome2("racecars")); // false

console.log(" ".repeat(10))
console.log("*".repeat(10))
console.log(" ".repeat(10))

// with recursion
function isPalindrome3(str) {
  if (str.length <= 1) {
    return true;
  }
  if (str[0] !== str[str.length - 1]) {
    return false;
  }
  return isPalindrome3(str.slice(1, str.length - 1));// slice is O(n) where n is the length of the string
  // return isPalindrome3(str.substring(1, str.length - 1));// substring is O(n) where n is the length of the string
  // return isPalindrome3(str.substr(1, str.length - 2));// substr is O(n) where n is the length of the string
  }

console.log(isPalindrome3("racecar")); // true
console.log(isPalindrome3("racecars")); // false

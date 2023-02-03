// encode then decode function but with a delimiter of ; in the encoded string using join and split
const encodeAndDecode = (arr) => {
  let str = arr.join(";");
  const decode = () => {
    return str.split(";");
  };
  let decoded = decode();
  return decoded;
};
// time complexity: O(n) where n is the length of the array

// console.log("doesn't consider separator")
// console.log(encodeAndDecode(["i", "a;m", "a", "string"])); // ["i", "am", "a", "string"]
// console.log("*".repeat(10))

// encode then decode function but with a delimiter of element length + # + array element in the encoded string
const encodeAndDecode2 = (arr) => {
  let str = "";
  for (let i = 0; i < arr.length; i++) {
    str += arr[i].length + "#" + arr[i];
  }
  const decode = () => {
    let decoded = [];
    let i = 0;
    while (i < str.length) {
      let j = i;
      while (str[j] !== "#") {
        j++;
      }
      console.log("j => " + j)
      let len = parseInt(str.slice(i, j));
      console.log("length => " + len)

      decoded.push(str.slice(j + 1, j + 1 + len));
      i = j + 1 + len;
      console.log("i => " + i)
    }
    return decoded;
  }
  let decoded = decode();
  return decoded;
}

// time complexity: O(n) where n is the length of the array

// console.log("considers separator")
// console.log(encodeAndDecode2(["i", "a;m", "a", "string"])); // ["i", "am", "a", "string"]
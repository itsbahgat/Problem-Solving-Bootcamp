/**
 * Time O(N) | Space O(N)
 * https://leetcode.com/problems/valid-parentheses/
 * @param {string} s
 * @return {boolean}
 */
var isValid = (s, stack = []) => {
    const map = {
        '}': '{',
        ']': '[',
        ')': '(',
    };
    //check string length if odd =>false
    if(s.length % 2 != 0){return false}

    for (const char of s) {/* Time O(N) */
        const isBracket = (char in map)
        if (!isBracket) { stack.push(char); continue; }/* Space O(N) */

        const isEqual = (stack[stack.length - 1] === map[char])
        if (isEqual) { stack.pop(); continue;}

        return false;
    }

    return (stack.length === 0);// "{["
};
//asci
//dictionary
//iterate directly on string
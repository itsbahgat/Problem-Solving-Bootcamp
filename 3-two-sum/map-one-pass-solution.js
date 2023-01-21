/**
 * Time O(N) | Space O(N)
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
var twoSum = function (nums, target, map = new Map()) {
  for (let i = 0; i < nums.length; i++) {
    let num = nums[i];
    let diff = (target - num);
    if (!map.has(diff)) {
      map.set(num, i);
    }
    else {
      let index = map.get(diff);
      return [index, i]
    }
  };
  return [-1, -1]
};
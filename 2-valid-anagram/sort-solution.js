/**
 * Sort - HeapSort Space O(1) | QuickSort Space O(log(N))
 * @param {string} s
 * @param {string} t
 * @return {boolean}
 */

var isAnagram = (s, t) => {
  if (s.length !== t.length) return false;

  return reorder(s) === reorder(t); /* Time O(N * logN) | Space O(N) */
};

const reorder = (str) => (str
  .split('')                         /* Time O(N)          | Space O(N) */
  .sort((a, b) => a.localeCompare(b))/* Time O(N * log(N)) | Space O(1 || log(N)) */
  .join('')                          /* Time O(N)          | Space O(N) */
)
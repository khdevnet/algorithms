Given a string s, find the length of the longest substring without repeating characters.

```
Example 1:

Input: s = "abcabcbb"
Output: 3
Explanation: The answer is "abc", with the length of 3.
```
```
Example 2:

Input: s = "bbbbb"
Output: 1
Explanation: The answer is "b", with the length of 1.
```
```
Example 3:

Input: s = "pwwkew"
Output: 3
Explanation: The answer is "wke", with the length of 3.
Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
```
### My
```javascript
/**
 * @param {string} s
 * @return {number}
 */
var lengthOfLongestSubstring = function(s, indxStart = 0, max = 0) {
    var indx = indxStart;
    var seq = '';
    while (indx < s.length) {
        var isIncludes = seq.includes(s[indx]);
        if (!isIncludes) {
            seq += s[indx];
            indx++;
        } else {
            break;
        }
    }

    if (indxStart < s.length) {
        return lengthOfLongestSubstring(s, indxStart + 1, Math.max(seq.length, max));
    }
    return max;
};
```
### Optimal
```
/**
 * @param {string} s
 * @return {number}
 */
var lengthOfLongestSubstring = function(s) {
    let maxLength = 0;
    let substringStart = 0;
    let substringEnd = 0;
    let charMap = new Map();

    for (let i = 0; i < s.length; i++) {
        if (charMap.has(s[i]) && charMap.get(s[i]) >= substringStart) {
        substringStart = charMap.get(s[i]) + 1;
        }
        charMap.set(s[i], i);
        substringEnd = i;
        maxLength = Math.max(maxLength, substringEnd - substringStart + 1);
    }

    return maxLength;
};
```

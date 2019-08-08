const arr = [6, 5, 3, 1, 8, 7];

console.log(insertSort(arr));

function insertSort(unsortedArr) {
  if (unsortedArr.length == 1) {
    return unsortedArr;
  }

  for (let i = 1; i < unsortedArr.length; i++) {
    console.log(unsortedArr);
    let cursor = unsortedArr[i];
    console.log("cursor: " + cursor)
    let pos = i;
    while (pos > 0 && unsortedArr[pos - 1] > cursor) {
      unsortedArr[pos] = unsortedArr[pos - 1];
      pos = pos - 1;
      console.log("pos: " + pos)
    }
    unsortedArr[pos] = cursor;
  }

  return unsortedArr;
}
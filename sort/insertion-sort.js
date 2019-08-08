const arr = [2, 22, 5, 66, 33, 77, 1, 99];

console.log(insertSort(arr));

function insertSort(unsortedArr) {
  if (unsortedArr.length == 1) {
    return unsortedArr;
  }

  for (let i = 1; i < unsortedArr.length; i++) {
    let cursor = unsortedArr[i];
    let pos = i;
    while (pos > 0 && unsortedArr[pos - 1] > cursor) {
      unsortedArr[pos] = unsortedArr[pos - 1];
      pos = pos - 1;
    }
    unsortedArr[pos] = cursor;
  }

  return unsortedArr;
}
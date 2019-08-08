const arr = [2, 22, 5, 66, 33, 77, 1, 99];

console.log(selectionSort(arr));

function selectionSort(unsortedArr) {
  const n = unsortedArr.length;
  if (n == 1) {
    return unsortedArr;
  }

  for (let i = 0; i < n; i++) {
    let minIndex = i;
    for (let j = i; j < n; j++) {
      if (unsortedArr[j] < unsortedArr[minIndex]) {
        minIndex = j;
      }
    }
    swap(unsortedArr, i, minIndex);
  }

  return unsortedArr;
}

function swap(arr, to, from) {
  const temp = arr[to];
  arr[to] = arr[from];
  arr[from] = temp;
}

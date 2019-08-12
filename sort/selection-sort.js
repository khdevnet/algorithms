const arr = [8, 5, 7, 1, 9, 3];

console.log(selectionSort(arr));

function selectionSort(unsortedArr) {
  const n = unsortedArr.length;
  if (n == 1) {
    return unsortedArr;
  }

  for (let i = 0; i < n; i++) {
    console.log(unsortedArr);
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

const arr = [2, 22, 5, 66, 33, 77, 1, 99];

function bubbleSort(unsortedArr) {
  for (let i = 0; i < unsortedArr.length; i++) {
    for (let j = 0; j < unsortedArr.length; j++) {
      if (unsortedArr[i] < unsortedArr[j]) {
        swap(unsortedArr, i, j);
      }
    }
  }
  return unsortedArr;
}

function swap(unsortedArr, first, second) {
  let buffer = unsortedArr[first];
  unsortedArr[first] = unsortedArr[second];
  unsortedArr[second] = buffer;
}

console.log(bubbleSort(arr));



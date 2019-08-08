const arr = [2, 22, 5, 66, 33, 77, 1, 99];

console.log(bubbleSort(arr.slice()));

console.log(bubbleSortv2(arr.slice()));

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

function swap(unsortedArr, to, from) {
  let buffer = unsortedArr[to];
  unsortedArr[to] = unsortedArr[from];
  unsortedArr[from] = buffer;
}

function bubbleSortv2(array) {
  let swapped;
  do {
    swapped = false;
    for(let i = 0; i < array.length; i++) {
      if(array[i] && array[i + 1] && array[i] > array[i + 1]) {
        [array[i], array[i + 1]] = [array[i + 1], array[i]];
        swapped = true;
      }
    }
  } while(swapped);
  return array;
}



const arr = [2, 22, 5, 66, 33, 77, 1, 99];

function mergeSort(unsortedArr) {
  if (unsortedArr.length <= 1) {
    return unsortedArr;
  }

  const middleIndex = Math.floor(unsortedArr.length / 2);

  var leftArr = mergeSort(unsortedArr.slice(0, middleIndex));
  var rightArr = mergeSort(unsortedArr.slice(middleIndex));

  return merge(leftArr, rightArr);
}

function merge(leftArr, rightArr) {
  let leftIndex = 0, rightIndex = 0, sortedArr = [];

  while (leftIndex < leftArr.length && rightIndex < rightArr.length) {
    if (leftArr[leftIndex] < rightArr[rightIndex]) {
      sortedArr.push(leftArr[leftIndex]);
      leftIndex++;
    } else {
      sortedArr.push(rightArr[rightIndex]);
      rightIndex++;
    }
  }

  return sortedArr
        .concat(leftArr.slice(leftIndex))
        .concat(rightArr.slice(rightIndex));
}

console.log(mergeSort(arr));



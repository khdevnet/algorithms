display(getNumbers(100));
display(getNumbers(1000));
display(getNumbers(10000));
display(getNumbers(100000));
display(getNumbers(1000000));
display(getNumbers(10000000));

function display(arr) {
  var searchEl = arr[getNumberBetweenRange(0, arr.length)];
  console.log(`Items count: ${arr.length}`);
  searchSimulation(arr, searchEl, linearSearch, 'Linear Search');
  console.log("--------------------------");
  searchSimulation(mergeSort(arr), searchEl, (ar, el) => binarySearch(ar, el, 0, ar.length - 1), 'Binary Search');
  console.log("##########################");
  console.log("");
}

function searchSimulation(arr, searchEl, alg, prefix) {
  console.log(`${prefix} an element: ${searchEl}`);
  let hrstart = process.hrtime();
  let r = alg(arr, searchEl);
  let hrend = process.hrtime(hrstart)
  console.info('Execution time (hr): %ds %dms %dns', hrend[0], hrend[1] / 1000000, hrend[1])
  console.log(`${prefix} result: ${r}`);
}

function linearSearch(arr, elToFind) {
  for (var i = 0; i < arr.length; i++) {
    if (arr[i] == elToFind) {
      return i;
    }
  }
  return -1;
}

function binarySearch(arr, target, left = 0, right = 0) {
  var mid = left + Math.floor((right - left) / 2);

  if (left == right) {
    return -1;
  }

  if (arr[mid] === target) {
    return mid;
  }

  if (target > arr[mid]) {
    return binarySearch(arr, target, mid + 1, right)
  } else {
    return binarySearch(arr, target, left, mid)
  }
}


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

function getNumbers(count) {
  const arr = [];
  for (let index = 0; index < count; index++) {
    arr.push(getNumberBetweenRange(1, 999999));
  }
  return arr;
}

function getNumberBetweenRange(min, max) {
  return Math.floor(Math.random() * (+max - +min) + +min);
}

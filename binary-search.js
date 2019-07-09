function binarySearch(arr, target, left = 0, right = 0) {

  if (arr.length == 1) {
    return arr[0];
  }

  if (!arr.length || left == right) {
    return -1;
  }

  var mid = left + Math.floor((right - left) / 2);
  if (arr[mid] === target) {
    return mid;
  }

  if (target > arr[mid]) {
    return binarySearch(arr, target, mid + 1, right)
  } else {
    return binarySearch(arr, target, left, mid - 1)
  }
}

var arr = [1, 2, 3, 4, 5, 7, 8, 33, 55, 66, 222];

console.log(binarySearch([], 3, 0, arr.length - 1));
console.log(binarySearch(arr, 3, 0, arr.length - 1));
console.log(binarySearch(arr, 333, 0, arr.length - 1));
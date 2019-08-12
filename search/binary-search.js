var app = app || {};
app.alg = app.alg || {};
(function (alg) {
  'use strict';

  alg.binarySearch = (arr, target, left = 0, right = 0) => {
    let operations = 0;
    let binarySearch = (arr, target, left = 0, right = 0) => {
      operations += 1;
      if (left > right) {
        return { result: -1, operations };
      }

      let mid = Math.floor((left + right) / 2);
      if (arr[mid] === target) return { result: mid, operations };
      if (arr[mid] > target) {
        return binarySearch(arr, target, left, mid - 1);
      }
      else {
        return binarySearch(arr, target, mid + 1, right);
      }
    }

    return binarySearch(arr, target, left, right);
  };
}(app.alg));
var arr = [1, 2, 3, 4, 5, 7, 8, 33, 55, 66, 222];

// console.log(app.alg.binarySearch([], 3, 0, arr.length - 1));
//console.log(app.alg.binarySearch(arr, 33, 0, arr.length - 1));
// console.log(app.alg.binarySearch(arr, 333, 0, arr.length - 1));
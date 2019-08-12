var app = app || {};
app.alg = app.alg || {};
(function (app) {
  'use strict';
  let elementCount = 100;
  let step = 10;
  let elements = mergeSort(getNumbers(elementCount));
  let getAvg = (runNumber, func) => {
    let operations = 0;
    for (let i = 0; i < runNumber; i++) {
      let r = func();
      operations += r.operations;
    }
    return operations / runNumber;
  }

  app.linearSearchData = () => {
    let chartResult = [];
    for (let index = 0; index < elementCount; index += step) {
      let arr = elements.slice(0, index + step);
      let avgOperations = getAvg(10, () => {
        let searchElement = elements[getNumberBetweenRange(0, index + step)];
        return app.alg.linearSearch(arr, searchElement);
      });

      chartResult.push({ elements: arr.length, operations: avgOperations });
    }
    return chartResult
  }


  app.binarySearchData = () => {
    let chartResult = [];
    for (let index = 0; index < elementCount; index += step) {
      let arr = elements.slice(0, index + step);
      let avgOperations = getAvg(10, () => {
        let searchElement = elements[getNumberBetweenRange(0, index + step)];
        return app.alg.binarySearch(arr, searchElement, 0, index + step);
      });

      chartResult.push({ elements: arr.length, operations: avgOperations });
    }
    console.log(chartResult);
    return chartResult;
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
}(app));
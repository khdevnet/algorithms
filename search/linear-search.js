var app = app || {};
app.alg = app.alg || {};
(function (alg) {
  'use strict';

  alg.linearSearch = (arr, elToFind) => {
    for (var i = 0; i < arr.length; i++) {
      if (arr[i] == elToFind) {
        return { result: i, operations: i + 1 };
      }
    }
    return { result: -1, operations: arr.length };
  }
}(app.alg));
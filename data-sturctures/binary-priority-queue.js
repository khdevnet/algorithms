(function () {
  'use strict';

  var BinaryHeap = require('./binary-heap');

  var PriorityQueue = function () {
    this.heap = new BinaryHeap();
  };

  PriorityQueue.prototype.enqueue = function (value) {
    this.heap.insert(value);
  };

  PriorityQueue.prototype.dequeue = function () {
    return this.heap.extractMinimum();
  };

  PriorityQueue.prototype.front = function () {
    return this.heap.findMinimum();
  };

  PriorityQueue.prototype.size = function () {
    return this.heap.size();
  };

  PriorityQueue.prototype.clear = function () {
    this.heap.clear();
  };

  PriorityQueue.prototype.print = function () {
    this.heap.print();
  };


  module.exports = PriorityQueue;

})();

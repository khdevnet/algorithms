'use strict';

var BinaryHeap = function () {
  this.list = [];
};

BinaryHeap.prototype.clear = function () {
  this.list.length = 0;
};

BinaryHeap.prototype.extractMinimum = function () {
  if (!this.list.length) {
    return undefined;
  }
  if (this.list.length === 1) {
    return this.list.shift();
  }
  var min = this.list[0];
  this.list[0] = this.list.pop();
  heapify(this, 0);
  return min;
};

BinaryHeap.prototype.insert = function (key) {
  var i = this.list.length;
  var node = key;
  this.list.push(node);
  var parent = getParent(i);
  while (typeof parent !== 'undefined' &&
      this.compare(this.list[i], this.list[parent]) < 0) {
    swap(this.list, i, parent);
    i = parent;
    parent = getParent(i);
  }
  return node;
};

BinaryHeap.prototype.findMinimum = function () {
  return this.isEmpty() ? undefined : this.list[0];
};

BinaryHeap.prototype.isEmpty = function () {
  return !this.list.length;
};

BinaryHeap.prototype.print = function () {
  for (let i = 0; i < this.list.length; i++) {
    console.log(this.list[i]);
  }
};

BinaryHeap.prototype.size = function () {
  return this.list.length;
};

BinaryHeap.prototype.compare = function (a, b) {
  if (a > b) {
    return 1;
  }
  if (a < b) {
    return -1;
  }
  return 0;
};

function heapify(heap, i) {
  var l = getLeft(i);
  var r = getRight(i);
  var smallest = i;
  if (l < heap.list.length &&
      heap.compare(heap.list[l], heap.list[i]) < 0) {
    smallest = l;
  }
  if (r < heap.list.length &&
      heap.compare(heap.list[r], heap.list[smallest]) < 0) {
    smallest = r;
  }
  if (smallest !== i) {
    swap(heap.list, i, smallest);
    heapify(heap, smallest);
  }
}

function swap(array, a, b) {
  var temp = array[a];
  array[a] = array[b];
  array[b] = temp;
}

function getParent(i) {
  if (i === 0) {
    return undefined;
  }
  return Math.floor((i - 1) / 2);
}

function getLeft(i) {
  return 2 * i + 1;
}

function getRight(i) {
  return 2 * i + 2;
}

module.exports = BinaryHeap;
var assert = require('assert');
var PriorityQueue = require('./binary-priority-queue');
describe('PriorityQueue', function () {

  describe('enqueue', function () {
    it('should add item to the queue', function () {
      var priorityQueue = new PriorityQueue();
      priorityQueue.enqueue(2);
      priorityQueue.enqueue(3);

      assert.equal(priorityQueue.front(), 2);
    });
  });

  describe('dequeue', function () {
    it('should remove the highest priority item', function () {
      var priorityQueue = new PriorityQueue();
      priorityQueue.enqueue(2);
      priorityQueue.enqueue(3);
      priorityQueue.enqueue(1);

      assert.equal(priorityQueue.dequeue(), 1);
    });
  });

  describe('front', function () {
    it('should return highest priority item', function () {
      var priorityQueue = new PriorityQueue();
      priorityQueue.enqueue(2);
      priorityQueue.enqueue(3);
      priorityQueue.enqueue(1);

      assert.equal(priorityQueue.front(), 1);
      assert.equal(priorityQueue.size(), 3);
    });
  });

});
'use strict'
class PriorityQueue {
  constructor() {
    this.queue = [];
  }

  enqueue(element) {
    this.queue.unshift(element);
    this.queue = this.queue.sort((a, b) => b - a)
  }

  dequeue() {
    return this.queue.pop();
  }

  front() {
    if (!this.isEmpty()) {
      return this.queue[this.queue.length - 1]
    }
    throw new Exception("PriorityQueue is empty.");
  }

  rear() {
    if (!this.isEmpty()) {
      return this.queue[0]
    }
    throw new Exception("PriorityQueue is empty.");
  }

  isEmpty() {
    return this.queue.length === 0
  }
  print() {
    console.log(this.queue);
  }
}

var pq = new PriorityQueue();
pq.enqueue(10);
pq.enqueue(11);
pq.enqueue(12);
pq.enqueue(5);
console.log('all');
pq.print();

console.log('front: ' + pq.front());
console.log('rear: ' + pq.rear());
console.log('dequeue: ' + pq.dequeue());

console.log('all');
pq.print();

console.log('enqueue: 7');
pq.enqueue(7);
console.log('enqueue: 11');
pq.enqueue(11);
console.log('all');

console.log('front: ' + pq.front());
console.log('rear: ' + pq.rear());
pq.print();

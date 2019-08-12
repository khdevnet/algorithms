'use strict'
class PriorityQueue {
  constructor() {
    this.queue = [];
  }

  enqueue(element, priority = 0) {
    this.queue.unshift({ element, priority });
    this.queue = this.queue.sort((a, b) => b.priority - a.priority)
  }

  dequeue() {
    return this.queue.pop().element;
  }

  front() {
    if (!this.isEmpty()) {
      return this.queue[this.queue.length - 1].element
    }
    throw new Exception("PriorityQueue is empty.");
  }

  rear() {
    if (!this.isEmpty()) {
      return this.queue[0].element
    }
    throw new Exception("PriorityQueue is empty.");
  }

  isEmpty() {
    return this.queue.length === 0
  }
  print() {
    console.log(this.queue.map(el => el.element));
  }
}

var pq = new PriorityQueue();
pq.enqueue(10, 5);
pq.enqueue(11, 2);
pq.enqueue(12, 3);
pq.enqueue(5, 1);
console.log('all');
pq.print();

console.log('front: ' + pq.front());
console.log('rear: ' + pq.rear());
console.log('dequeue: ' + pq.dequeue());

console.log('all');
pq.print();

console.log('enqueue: 7, 0');
pq.enqueue(7, 0);

console.log('all');

console.log('front: ' + pq.front());
console.log('rear: ' + pq.rear());
pq.print();

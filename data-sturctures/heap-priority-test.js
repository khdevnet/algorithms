var PriorityQueue = require('./binary-priority-queue');

var pq = new PriorityQueue();
pq.enqueue(10);
pq.enqueue(11);
pq.enqueue(12);
pq.enqueue(5);

console.log('all');
pq.print();

console.log('front: ' + pq.front());
console.log('dequeue: ' + pq.dequeue());

console.log('all');
pq.print();

console.log('enqueue: 7');
pq.enqueue(7);
console.log('enqueue: 11');
pq.enqueue(11);
console.log('all');

console.log('front: ' + pq.front());
pq.print();
# Priority queue
## The Basics
A priority queue is a collection in which items can be added at any time, but the only item that can be removed is the one with the highest priority.

## Operations

```
engueue(x): add item x
dequeue: remove the highest priority item
front: return the highest priority item (without removing it)
size: return the number of items in the priority queue
isEmpty: return whether the priority queue has no items
```
## Examples
* Patients in an emergency room
* Operating system scheduler
* Routing A* search

## Representations

### Sorted Array
* engueue is Θ(n log n) — you can find where to insert in log time, but you have to make room in the array, which is linear.
* front is Θ(1) — return the highest priority item (without removing it)
* dequeue is Θ(1) — remove the highest priority item.

### Heap
* engueue is  Θ(log n) — you can find where to insert in log time, but you have to make room in the array, which is linear.
* front is Θ(1) — return the highest priority item (without removing it)
* dequeue is Θ(log n) — remove the highest priority item.

### Resources
* [pqueues representations](https://cs.lmu.edu/~ray/notes/pqueues/)
* [priority-queue sample](https://github.com/adamhooper/js-priority-queue)
* [min heap](https://medium.com/@randerson112358/lets-build-a-min-heap-4d863cac6521)

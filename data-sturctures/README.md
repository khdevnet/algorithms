# Priority queue
## The Basics
A priority queue is a collection in which items can be added at any time, but the only item that can be removed is the one with the highest priority.

## Operations

```add(x): add item x
remove: remove the highest priority item
peek: return the highest priority item (without removing it)
size: return the number of items in the priority queue
isEmpty: return whether the priority queue has no items
```
## Examples
* Patients in an emergency room
* Operating system scheduler
* Routing A* search

## Representations
### Unsorted Array
* add is Θ(1) — just add the item at the end.
* peek is Θ(n) — must do linear scan to find.
* remove is Θ(n) — must find the element and compress the array.

### Unsorted Linked List
* add is Θ(1) — just add the item at the end.
* peek is Θ(n) — must do linear scan to find.
* remove is Θ(n) — because the item must be found first.

### Sorted Array
* add is Θ(n) — you can find where to insert in log time, but you have to make room in the array, which is linear.
* peek is Θ(1) — the value is at the end of the array.
* remove is Θ(1) — we can just whack the item off the end.

### Sorted Linked List
* add is Θ(n) — you have to step through the chain to find the place to insert.
* peek is Θ(1) — the value is at the end of the array.
* remove is Θ(1) — we can just whack the item off the end.

### Heap
* add is Θ(logn)
* peek is Θ(1)
* remove is Θ(logn)

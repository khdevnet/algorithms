# Doubly Linked List
## The Basics

In simple terms, a doubly linked list consists of one or more 'nodes'.  Each node has a data field (which can contain any data--a primitive value or complex object) and a pointer to the next 'node' and the previous 'node'. This additional pointer to the previous node is what distinguishes a doubly linked list from a singly linked list--a singly linked list only contains a pointer, or reference, to the next node.  The major advantage to having pointers to both the next and previous node is that the list can be traversed in both
directions, as well as making operations that operate on the 'middle' of the list a bit more efficient since each node has a reference the one before it and the one after it.  The idea of having a links to the previous and next nodes is where this data structure got its descriptive name.

## Operations

```
getHeadNode(): returns the first node in the list
getTailNode(): returns the last node in the list
clear(): clears the list of all nodes/data
insert(data): inserts a node (with the provided `data`) to the end of the list
insertFirst(data): inserts a node (with the provided `data`) to the front of the list
insertBefore(nodeData, dataToInsert): inserts a node (with the `dataToInsert`) _before_ the first node containing `nodeData`
insertAfter(nodeData, dataToInsert): inserts a node (with the `dataToInsert`) _after_ the first node containing `nodeData`
remove(): removes the tail node from the list
removeFirst(): removes the head node from the list
removeNode(nodeData): removes the first node that contains the `nodeData` provided
find(nodeData): returns the fist node containing the provided `nodeData`.  If a node cannot be found containing the provided data, -1 is returned.
toArray(): returns an array of all the data contained in the list
printList(): prints to the console the data property of each node in the list
```

## Examples
* you need constant-time insertions/deletions from the list (such as in real-time computing where time predictability is absolutely critical)
* you don't know how many items will be in the list. With arrays, you may need to re-declare and copy memory if the array grows too big
* you don't need random access to any elements
* you want to be able to insert items in the middle of the list (such as a priority queue)

## Representation
* find is Θ(n) — you should go through all items in worst case.
* insertFront is Θ(1) — insert to the head of Linked List
* insert is Θ(1) — insert to the tail of Linked List
* insertBefore, insertAfter, removeNode is Θ(n) - you should find a node where to insert/remove

### Advantages

- List will grow dynamically with each node added; no requirement to
  'resize' list when it reaches a certain size, saving considerable overhead
  in 'house-keeping' operations.
- Flexibility to add or remove nodes at the beginning or end of the list in
  O(1) time.  This is a significant improvement over its
  [singly linked list](https://github.com/jasonsjones/singly-linked-list)
  counterpart.

### Disadvantages

- All 'find' operations take O(n) time to iterate over the list to find the
  requested node.  This is the case for both the singly and doubly linked
  list.

*For specific examples and documentation, see the below sections*


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
* [binary heap](https://en.wikipedia.org/wiki/Binary_heap)
* [min heap](https://medium.com/@randerson112358/lets-build-a-min-heap-4d863cac6521)


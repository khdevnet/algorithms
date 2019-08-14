### Bubble Sort
* **O(n)** is the best-case running time for bubble sort. It is possible to modify bubble sort to keep track of the number of swaps it performs. If an array is already in sorted order, and bubble sort makes no swaps, the algorithm can terminate after one pass. With this modification, if bubble sort encounters a list that is already sorted, it will finish in O(n)O(n) time.
* **O(n^2)** is average and worst-case running time of O(n^2), and can only run in its best-case running time of O(n) when the input list is already sorted.    
![Bubble-sort](https://github.com/khdevnet/algorithms/blob/master/sort/bubble-sort.png)

### Selection Sort
* **Best Case Analysis** - same as insertion sort
* **Worst and Average Case Analysis** - same as insertion sort    
![Selection Sort](https://github.com/khdevnet/algorithms/blob/master/sort/selection-sort.jpg)

### Insertion Sort
* **Best Case Analysis** 
Insertion sort performs two operations: it scans through the list, comparing each pair of elements, and it swaps elements if they are out of order. Each operation contributes to the running time of the algorithm. If the input array is already in sorted order, insertion sort compares O(n) elements and performs no swaps (in the Python code above, the inner loop is never triggered). Therefore, in the best case, insertion sort runs in O(n) time.
* **Worst and Average Case Analysis** The worst case for insertion sort will occur when the input list is in decreasing order. To insert the last element, we need at most n-1n−1 comparisons and at most n-1n−1 swaps. To insert the second to last element, we need at most n-2n−2 comparisons and at most n-2n−2 swaps, and so on.[3] The number of operations needed to perform insertion sort is therefore: 2 \times (1+2+ \dots +n-2+n-1)2×(1+2+⋯+n−2+n−1). To calculate the recurrence relation for this algorithm, use the following summation:
![Insertion Sort](https://github.com/khdevnet/algorithms/blob/master/sort/insertion-sort.gif)

### Quick Sort
![Quick Sort](https://github.com/khdevnet/algorithms/blob/master/sort/quicksort.png)

### Merge Sort
![Merge Sort](https://github.com/khdevnet/algorithms/blob/master/sort/merge-sort.png)

# Resources
* [sorting algorithms](https://brilliant.org/wiki/sorting-algorithms/)
* [merge-sort](https://medium.com/javascript-in-plain-english/javascript-merge-sort-3205891ac060)
* [quick-sort.js](https://www.nczonline.net/blog/2012/11/27/computer-science-in-javascript-quicksort/)
* [javascript sort method implementations](https://stackoverflow.com/questions/234683/javascript-array-sort-implementation)

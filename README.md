# Algorithms

* **Asymptotic Analysis** is the big idea that handles above issues in analyzing algorithms. In Asymptotic Analysis, we evaluate the performance of an algorithm in terms of input size (we don’t measure the actual running time). We calculate, how does the time (or space) taken by an algorithm increases with the input size. [analysis-of-algorithms-set-1-asymptotic-analysis](https://www.geeksforgeeks.org/analysis-of-algorithms-set-1-asymptotic-analysis/)
* **Big O (Big O)**: notation defines an upper bound of an algorithm, it bounds a function only from above or worst value.
* **Θ (The theta)**: notation bounds a functions from above and below, so it defines exact asymptotic behavior or average value.
* **Ω (Omega)** notation defines a lower bound on time complexity of an algorithm or best value. 
### The following list explains some of the most common big Oh notations:
* **O(1) constant**: the operation doesn't depend on the size of its input, e.g. adding a node to the tail of a linked list where we always maintain a pointer to the tail node.
* **O(n) linear**: the run time complexity is proportionate to the size of n.
* **O(log n) logarithmic**: normally associated with algorithms that break the problem into smaller chunks per each invocation, e.g. searching a binary search tree.
* **O(n log n) just n log n**: usually associated with an algorithm that breaks the problem into smaller chunks per each invocation, and then takes the results of these smaller chunks and stitches them back together, e.g. quick sort.
* **O(n2) quadratic**: e.g. bubble sort.
* **O(n3) cubic**: very rare.
* **O(2n) exponential**: incredibly rare.

![sorting and searching](https://github.com/khdevnet/algorithms/blob/master/docs/sorting-and-searching.png)
![sorting and searching](https://github.com/khdevnet/algorithms/blob/master/docs/sorting-and-searching-big-o-complexity.png)
### Graph traversal
### Brute force Greedy algorithms
### Divide and conquer
* [Divide and conquer](https://www.geeksforgeeks.org/divide-and-conquer-algorithm-introduction/)
* [Quick-sort](https://www.nczonline.net/blog/2012/11/27/computer-science-in-javascript-quicksort/) 
* [Merge Sort](https://hackernoon.com/programming-with-js-merge-sort-deb677b777c0)
* [Binary Search](https://medium.com/@jeffrey.allen.lewis/javascript-algorithms-explained-binary-search-25064b896470)
#### Samples
* [quick-sort.js](https://github.com/khdevnet/algorithms/blob/master/sort/quick-sort.js)
### Dynamic programming
### Branch and bound


# Data structures
![Data structures](https://github.com/khdevnet/algorithms/blob/master/docs/data-structures.png)

# Data compression algorithms
### RLE
Run-length encoding is a data compression algorithm that is supported by most bitmap file formats, such as TIFF, BMP, and PCX. RLE is suited for compressing any type of data regardless of its information content, but the content of the data will affect the compression ratio achieved by RLE. Although most RLE algorithms cannot achieve the high compression ratios of the more advanced compression methods, RLE is both easy to implement and quick to execute, making it a good alternative to either using a complex compression algorithm or leaving your image data uncompressed.

RLE works by reducing the physical size of a repeating string of characters. This repeating string, called a run, is typically encoded into two bytes. The first byte represents the number of characters in the run and is called the run count. In practice, an encoded run may contain 1 to 128 or 256 characters; the run count usually contains as the number of characters minus one (a value in the range of 0 to 127 or 255). The second byte is the value of the character in the run, which is in the range of 0 to 255, and is called the run value.

```
before compresion:
AAAAAAbbbXXXXXt
after compresion:
6A3b5X1t
```

### Huffman
The Huffman encoding algorithm is an optimal compression algorithm when only the frequency of individual letters are used to compress the data. (There are better algorithms that can use more structure of the file than just letter frequencies.) The idea behind the algorithm is that if you have some letters that are more frequent than others, it makes sense to use fewer bits to encode those letters than to encode the less frequent letters. 
#### Example
 "ADA ATE APPLE". There are 4 As, 1 D, 1 T, 2 Es, 2 Ps, 1 L, and 2 spaces.
 ```
char  encoding
A     0
E     10
P     110
space 1110
D     11110
T     111110
L     111111
 ```
 
### LZ77

# Resources
* [sorting-and-searching-algorithms-time-complexities-cheat-sheet](https://www.hackerearth.com/practice/notes/sorting-and-searching-algorithms-time-complexities-cheat-sheet/)
* [data-structures-a-quick-comparison](https://medium.com/omarelgabrys-blog/data-structures-a-quick-comparison-6689d725b3b0)
* [What does ‘Space Complexity’ mean?](https://www.geeksforgeeks.org/g-fact-86/)

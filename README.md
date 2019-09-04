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
* **Lossy compression** refers to compression in which some of the data from the original file (JPEG) is lost. The process is irreversible, once you convert to lossy, you can’t go back. And the more you compress it, the more degradation occurs. JPEGs and GIFs are both lossy image formats. By default WordPress uses a lossy compression rate of 90 percent to optimize JPEG images when creating preview images. You can change this using the filter jpeg_quality in your functions.php file.
* **Lossless data compression** make use of data compression algorithms that allows the exact original data to be reconstructed from the compressed data. This can be contrasted to lossy data compression, which does not allow the exact original data to be reconstructed from the compressed data. Lossless data compression is used in many applications. For example, it is used in the popular ZIP file format and in the Unix tool gzip. It is also often used as a component within lossy data compression technologies. 

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
 
### LZ77, LZ78
* **LZ77** algorithms achieve compression by replacing repeated occurrences of data with references to a single copy of that data existing earlier in the uncompressed data stream. A match is encoded by a pair of numbers called a length-distance pair, which is equivalent to the statement "each of the next length characters is equal to the characters exactly distance characters behind it in the uncompressed stream". (The distance is sometimes called the offset instead.)

* **LZ78** algorithms achieve compression by replacing repeated occurrences of data with references to a dictionary that is built based on the input data stream. Each dictionary entry is of the form dictionary[...] = {index, character}, where index is the index to a previous dictionary entry, and character is appended to the string represented by dictionary[index]. For example, "abc" would be stored (in reverse order) as follows: dictionary[k] = {j, 'c'}, dictionary[j] = {i, 'b'}, dictionary[i] = {0, 'a'}, where an index of 0 specifies the first character of a string.

#### Use in modern algorithms
* DEFLATE: Used by PNG, ZIP and GZIP
* LZMA: (Very high compression ration) Used by: 7Zip and xz
* LZSS: Used by WinRar with Huffman coding

# Parsing algorithms
![](https://github.com/khdevnet/algorithms/blob/master/docs/lexer-parser-center.png)
* **Scannerless Parsers** - Scannerless parsers operate differently because they process directly the original text instead of processing a list of tokens produced by a lexer. That is to say, a scannerless parser works as a lexer and a parser combined.
* **Grammar** - a formal grammar is a set of rules that describes syntactically a language.
* **Lexer(scanners,tokenizers)** - A lexer transforms a sequence of characters in a sequence of tokens.
* **Parser** - In any sense, the parser's output is an organized structure of the code — usually, a tree. The tree can be a parse tree or an abstract syntax tree.
* **Syntactic vs. Semantic Correctness** - Let's see an example of code that is syntactically correct, but semantically incorrect.
```
int x = 10
int sum = x + y // incorect because y not defined;
```
* **Parse tree** is a representation of the code closer to the concrete syntax. It shows many details of the implementations of the parser.
* **Abstract Syntax Tree** is a representation of the code closer to the concrete syntax. It shows many details of the implementations of the parser.
* **Parsing Tree(PT) and Abstract Syntax Tree(AST)** - **PT** contains all tokens after parsing, after processing some nodes of **PT** can be removed and from left nodes builds **AST**
![](https://github.com/khdevnet/algorithms/blob/master/docs/parse-trees.png)
## Lookahead and Backtracking
The terms lookahead and backtracking do not have a different meaning in parsing than the ones they have in the larger computer science field. 
* **Lookahead** indicates the number of elements, following the current one, that are taken into consideration to decide which current action to take.

A simple example: A parser might check the next token to decide which rule to apply now. When the proper rule is matched, the current token is consumed, but the next one remains in the queue.

* **Backtracking** is a technique of an algorithm. It consists of finding a solution to complex problems by trying partial solutions and then continuously checking the most promising one. If the one that is currently being tested fails, then the parser backtracks (i.e. it goes back to the last position that was successfully parsed) and tries another one.

* **Chart parsers** are a family of parsers that can be bottom-up (i.e. CYK) or top-down (i.e. Earley). Chart parsers essentially try to avoid backtracking, which can be expensive, by using dynamic programming. Dynamic programming, or dynamic optimization, is a general method to break down a larger problem in smaller subproblems.

## Top-down parsing
**top-down** parser tries to identify the root of the parse tree first, then moves down the subtrees until it finds the leaves of the tree.
### LL parser
The key idea behind LL( * ) parsers is to use regular-expressions rather than a fixed constant or backtracking with a full parser to do lookahead. The analysis constructs a deterministic finite automata (DFA) for each nonterminal in the grammar to distinguish between alternative productions. If the analysis cannot find a suitable DFA for a nonterminal, it fails over to backtracking. As a result, LL( * ) parsers gracefully throttle up from conventional fixed k ≥ 1 lookahead to arbitrary lookahead and, finally, fail over to backtracking depending on the complexity of the parsing decision. Even within the same parsing decision, the parser decides on a strategy dynamically according to the input sequence. Just because a decision might have to scan arbitrarily far ahead or backtrack does not mean that it will at parse-time for every input sequence. [[LL-ANTLR](https://www.antlr.org/papers/LL-star-PLDI11.pdf)]

### Recursive Descent Parser
A recursive descent parser is a parser that works with a set of (mutually) recursive procedures, usually one for each rule of the grammars. Thus, the structure of the parser mirrors the structure of the grammar.

The termpredictive parser is used in a few different ways: some people mean it as a synonym for a top-down parser, some as a recursive descent parser that never backtracks.

The opposite of this second meaning is a recursive descent parser, which does backtracks. That is to say, one that finds the rule that matches the input by trying each one of the rules in sequence and then goes back each time it fails.

Typically, recursive descent parsers have problems parsing left-recursive rules because the algorithm would end up calling the same function again and again. A possible solution to this problem is using tail recursion. Parsers that use this method are called tail recursive parsers.

Tail recursion **per se** is simply recursion that happens at the end of the function. However, tail recursion is employed in conjunction with transformations of grammar rules. The combination of transforming the grammar rules and putting recursion at the end of the process allows dealing with left-recursive rules.

## Bottom-up parser
A **bottom-up** parser instead starts from the lowest part of the tree, the leaves, and rises up until it determines the root of the tree.

### CYK Parser
The Cocke-Younger-Kasami (CYK) algorithm was formulated independently by three authors. Its notability is due to a great worst-case performance (O(n3)), although it is hampered by comparatively bad performance in most common scenarios.

However, the real disadvantage of the algorithm is that it requires grammars to be expressed in Chomsky normal form.

That is because the algorithm relies on the properties of this particular form to be able to split the input in half to try to match all the possibilities. In theory, any context-free grammar can be transformed into a corresponding CNF, but this is seldom practical to do by hand. Imagine being annoyed by the fact that you can't use left-recursive rules and then being asked to learn a special kind of form.

The CYK algorithm is used mostly for specific problems; for instance, the membership problem: to determine if a string is compatible with a certain grammar. It can also be used in natural language processing to find the most probable parsing between many options.

For all practical purposes, if you need to parse all context-free grammar with great worst-case performance, you want to use an Earley parser.

### LR Parser
LR (Left-to-right read of the input; Rightmost derivation) parsers are bottom-up parsers that can handle deterministic context-free languages in linear time with lookahead and without backtracking. The invention of LR parsers is credited to the renowned Donald Knuth.

Traditionally, they have been compared to and have competed with LL parsers. There's a similar analysis related to the number of lookahead tokens necessary to parse a language. An LR(k) parser can parse grammars that need k tokens of lookahead to be parsed. However, LR grammars are less restrictive, and thus more powerful, than the corresponding LL grammars. For example, there is no need to exclude left-recursive rules.

Technically, LR grammars are a superset of LL grammars. One consequence of this is that you need only LR(1) grammars, so usually, the (k) is omitted.

They are also table-based, just like LL-parsers, but they need two complicated tables. In very simple terms:

One table tells the parser what to do depending on the current token, the state it's in, and the tokens that could possibly follow the current one (lookahead sets).
The other one tells the parser to which state move next.
LR parsers are powerful and have great performance — so where is the catch? The tables they need are hard to build by hand and can grow very large for normal computer languages, so usually, they are used through parser generators. If you need to build a parser by hand, you would probably prefer a top-down parser.

Simple LR and Lookahead LR
Parser generators avoid the problem of creating such tables, but they do not solve the issue of the cost of generating and navigating such large tables. There are simpler alternatives to the canonical LR(1) parser described by Knuth. These alternatives are less powerful than the original. They are the simple LR parser (SLR) and lookahead LR parser (LALR). So, in order of power we have:

* LR(1)

* LALR(1)

* SLR(1)

* LR(0)

The names of the two parsers, both invented by Frank DeRemer, are somewhat misleading: one is not really that simple and the other is not the only one that uses lookahead. We can say that one is simpler and the other relies more heavily on lookahead to make decisions.  

Basically, they differ in the tables they employ. Mostly, they change the “what to do” part and the lookahead sets, which in turn pose different restrictions on the grammars that they can parse. In other words, they use different algorithms to derive parsing tables from the grammar.  

An SLR parser is quite restrictive in practical terms and it is not often used. A LALR parser instead works for most practical grammars and is widely employed. In fact, the popular tools yacc and bisonwork with LALR parser tables.  

Contrary to LR grammars, LALR and SLR grammars are not supersets of LL grammars. They are not easily comparable; some grammars can be covered by one class and not the other, or vice versa.  

* Generalized LR Parser
Generalized LR parsers (GLR) are more powerful variants of LR parsers. They were described by Bernard Land in 1974 and implemented for the first time by Masaru Tomita in 1984. The reason for GLR's existence is the need to parse nondeterministic and ambiguous grammars.  

The power of a GLR parser is not found on its tables, which are equivalent to the table of a traditional LR parser. Instead, it can move to different states. In practice, when there is ambiguity, it forks a new parser (or parsers) that handle(s) that particular case. These parsers might fail at a later stage and be discarded.  

The worst-case complexity of a GLR parser is the same as Earley (O(n3)), though it may have better performance with the best case of deterministic grammars. A GLR parser is also harder to build than an Earley one.  

# Resources
* [parsing-algorithms-and-technology](https://dzone.com/articles/a-guide-to-parsing-algorithms-and-technology-part-3)
* [sorting-and-searching-algorithms-time-complexities-cheat-sheet](https://www.hackerearth.com/practice/notes/sorting-and-searching-algorithms-time-complexities-cheat-sheet/)
* [data-structures-a-quick-comparison](https://medium.com/omarelgabrys-blog/data-structures-a-quick-comparison-6689d725b3b0)
* [What does ‘Space Complexity’ mean?](https://www.geeksforgeeks.org/g-fact-86/)
* [Data compression](https://www.slideshare.net/MustafaGokce/lz77-and-lz78-compression-algorithms)

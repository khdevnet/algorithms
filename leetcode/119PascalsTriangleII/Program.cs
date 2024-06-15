// Example 1:

// Input: rowIndex = 3
// Output: [1,3,3,1]

// Pascal's triangle are a series of numbers arranged in the shape of triangle. 
// In Pascal's triangle, the leftmost and the rightmost numbers of each row are always 1. 
// For the rest, each number is the sum of the two numbers directly above it in the previous row.

//        1
//       1 1
//      1 2 1
//     1 3 3 1      rowIndex = 3 , colIndex = 0, 1, 2, 3  
//    1 4 6 4 1
//
// f(rowIndex 3, colIndex 0) = 1
// f(rowIndex 3, colIndex 1) = f(2, 0) + f(2, 1)  = 3
// f(rowIndex 3, colIndex 2) = f(2, 1) + f(2, 2)  = 3
// f(rowIndex 3, colIndex 3) = f(2, 2)  = 1
//
// f(rowIndex 2, colIndex 0) = f(2, 0)  = 1
// f(rowIndex 2, colIndex 1) = f(1, 0) + f(1, 1)  = 2
// f(rowIndex 2, colIndex 2) = f(2, 2) = 1
//
// f(rowIndex 1, colIndex 0) = f(1, 0) = 1
// f(rowIndex 1, colIndex 1) = f(1, 1) = 1
//
// f(rowIndex 0, colIndex 0) = f(0, 0) = 1

var output = GetRow(3);
Console.ReadLine();

IList<int> GetRow(int rowIndex)
{
    return new List<int>();
}

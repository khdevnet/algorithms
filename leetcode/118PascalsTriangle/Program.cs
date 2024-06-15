// Example 1:

// Input: numRows = 5
// Output: [[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]

// Pascal's triangle are a series of numbers arranged in the shape of triangle. 
// In Pascal's triangle, the leftmost and the rightmost numbers of each row are always 1. 
// For the rest, each number is the sum of the two numbers directly above it in the previous row.

//        1         rowIndex = 0
//       1 1        rowIndex = 1
//      1 2 1       rowIndex = 2   2, 1
//     1 3 3 1      rowIndex = 3 , colIndex = 0, 1, 2, 3  
//    1 4 6 4 1
//
// f(rowIndex 3, colIndex 0) = 1
// f(rowIndex 3, colIndex 1) = f(2, 0) + f(2, 1)  = 3  f(rowIndex 3, colIndex 1) = f(rowIndex - 1, colIndex -1)+f(rowIndex - 1, colIndex)
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

//var t = F(4, 2);
var arr = GenerateDP(5);
var arr2 = Generate(5);
Console.ReadLine();

//
//
IList<IList<int>> GenerateDP(int numRows)
{
    IList<IList<int>> triangle = new List<IList<int>>();
    triangle.Add(new List<int>());
    triangle[0].Add(1);
    for (int i = 1; i < numRows; i++)
    {
        triangle.Add(new List<int>());
        triangle[i].Add(1);
        for (int j = 1; j < i; j++)
        {
            ((List<int>)triangle[i]).Add(triangle[i - 1][j - 1] + triangle[i - 1][j]);
        }
        triangle[i].Add(1);
    }
    return triangle;
}

IList<IList<int>> Generate(int numRows)
{
    IList<IList<int>> arr = new List<IList<int>>();
    var mem = new Dictionary<string, int>();
    for (int i = 0; i < numRows; i++)
    {
        arr.Add(new List<int>());
        for (int j = 0; j <= i; j++)
        {
            arr[i].Add(F(i, j, mem));
        }
    }
    return arr;
}

int F(int rowIndex, int colIndex, Dictionary<string, int> mem)
{
    if (colIndex == 0) return 1;
    if (rowIndex == colIndex) return 1;
    if (!mem.ContainsKey($"{rowIndex}_{colIndex}"))
    {
        var val = F(rowIndex - 1, colIndex - 1, mem) + F(rowIndex - 1, colIndex, mem);
        mem.Add($"{rowIndex}_{colIndex}", val);
    }

    return mem[$"{rowIndex}_{colIndex}"];
}

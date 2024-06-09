// See https://aka.ms/new-console-template for more information
var houses = new int[] { 1, 2, 3, 1 };
var mem = new Dictionary<int, int>();
var money = Rob(houses, houses.Length - 1, mem);
var m2 = RobBU(houses);

Console.ReadLine();

// top down+memoize
static int Rob(int[] houses, int houseNumber, Dictionary<int, int> mem)
{
    if (houseNumber == 1) return houses[0];
    if (houseNumber == 2) return Math.Max(houses[0], houses[1]);
    if (!mem.ContainsKey(houseNumber))
    {
        var money = Math.Max(Rob(houses, houseNumber - 1, mem), Rob(houses, houseNumber - 2, mem) + houses[houseNumber]);
        mem.Add(houseNumber, money);
        return money;
    }
    return mem[houseNumber];
}

// Bottom up
static int RobBU(int[] houses)
{
    if (houses.Length == 1) return houses[0];
    if (houses.Length == 2) return Math.Max(houses[0], houses[1]);
    var robbedHouses = new int[houses.Length];
    robbedHouses[0] = houses[0];
    robbedHouses[1] = Math.Max(houses[0], houses[1]);
    for (int houseNumber = 2; houseNumber < houses.Length; houseNumber++)
    {
        robbedHouses[houseNumber] = Math.Max(robbedHouses[houseNumber - 1], robbedHouses[houseNumber - 2] + houses[houseNumber]);
    }

    return robbedHouses[houses.Length - 1];
}

// Example 1:
// Input: nums = [1,2,3,1]
// Output: 4
// Explanation: Rob house 1 (money = 1) and then rob house 3 (money = 3).
// Total amount you can rob = 1 + 3 = 4.

// Example 2:
// Input: nums = [2,7,9,3,1]
// Output: 12
// Explanation: Rob house 1 (money = 2), rob house 3 (money = 9) and rob house 5 (money = 1).
// Total amount you can rob = 2 + 9 + 1 = 12.

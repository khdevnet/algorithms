internal class Program
{
    private static void Main(string[] args)
    {
        // var digits = new int[] { 1, 2, 3 };
        var digits = new int[] { 4, 3, 9, 9 };
        var r = PlusOne(digits);
        Console.ReadLine();
    }

    private static int[] PlusOne(int[] digits)
    {
        var newDigits = new int[10];
        var add = 1;
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            var lastD = digits[i] + add;
            if (lastD == 10)
            {
                newDigits[i] = 0;
                add = 1;
            }
            else
            {
                add = 0;
                newDigits[i] = lastD;
            }
        }
        return newDigits;
    }
}
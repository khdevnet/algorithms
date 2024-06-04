internal class Program
{
    private static void Main(string[] args)
    {
        // var digits = new int[] { 1, 2, 3 };
        var digits = new int[] { 1, 9, 9 };
        var r = PlusOne(digits);
        Console.ReadLine();
    }

    private static int[] PlusOne(int[] digits)
    {
        if (digits.Length == 0) return digits;
        var add = 1;
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            var lastD = digits[i] + add;
            if (lastD == 10)
            {
                digits[i] = 0;
                add = 1;
            }
            else
            {
                add = 0;
                digits[i] = lastD;
            }
        }

        if (add == 1)
        {
            var newDigits = new int[digits.Length + 1];
            newDigits[0] = 1;
            for (int i = 0; i < digits.Length; i++)
            {
                newDigits[i + 1] = digits[i];
            }
            return newDigits;
        }

        return digits;
    }
}
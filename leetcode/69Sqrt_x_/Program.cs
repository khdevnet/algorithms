internal class Program
{
    private static void Main(string[] args)
    {
        var r = MySqrt(3);
        Console.ReadLine();
    }

    // calculate using formula, sqrt x = e^1/2*logx
    // e = Math.Exp(0.5*Math.log(x));
    private static int MySqrt(int x)
    {
        if (x < 2) return x;
        var left = (long)Math.Exp(0.5 * Math.Log(x));
        var right = left + 1;
        return (int)(right * right > x ? left : right);
    }
}
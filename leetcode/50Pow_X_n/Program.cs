
var r = MyPow(2, -2);
Console.ReadLine();

double MyPow(double x, int n)
{
    return n > 0 ? Pow(x, n) : 1 / Pow(x, (n * -1));
}

double Pow(double x, int n)
{
    if (n == 0) return 1;
    return x * Pow(x, n - 1);
}
MovingAverage obj = new MovingAverage(3);
double param_1 = obj.Next(2);
Console.ReadLine();

public class MovingAverage
{
    private double sum;
    private int size;
    private readonly Queue<int> queue = new Queue<int>();
    public MovingAverage(int size)
    {
        this.size = size;
    }

    public double Next(int val)
    {
        int first = queue.Count == size ? queue.Dequeue() : 0;
        sum = sum - first + val;
        queue.Enqueue(val);
        return sum / queue.Count;
    }
}

/**
 * Your MovingAverage object will be instantiated and called as such:
 * MovingAverage obj = new MovingAverage(size);
 * double param_1 = obj.Next(val);
 */

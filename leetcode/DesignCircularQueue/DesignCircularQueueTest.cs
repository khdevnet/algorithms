namespace DesignCircularQueue;

public class DesignCircularQueueTest
{
    [Fact]
    public void MyCircularQueueTest()
    {
        var myCircularQueue = new MyCircularQueue(3);
        Assert.True(myCircularQueue.EnQueue(1)); // return True
        Assert.True(myCircularQueue.EnQueue(2)); // return True
        Assert.True(myCircularQueue.EnQueue(3)); // return True
        Assert.False(myCircularQueue.EnQueue(4)); // return False
        Assert.Equal(3, myCircularQueue.Rear());     // return 3
        Assert.True(myCircularQueue.IsFull());   // return True
        Assert.True(myCircularQueue.DeQueue());  // return True
        Assert.True(myCircularQueue.EnQueue(4)); // return True
        Assert.Equal(4, myCircularQueue.Rear());     // return 4
    }

    [Fact]
    public void MyQueueTest()
    {
        var myQueue = new MyQueue();
        Assert.True(myQueue.EnQueue(1)); // return True
        Assert.True(myQueue.EnQueue(2)); // return True
        Assert.True(myQueue.EnQueue(3)); // return True
        Assert.Equal(3, myQueue.Rear());     // return 3
        Assert.True(myQueue.DeQueue());  // return True
        Assert.True(myQueue.EnQueue(4)); // return True
        Assert.Equal(4, myQueue.Rear());     // return 4
    }

    public class MyQueue
    {
        private readonly List<int> queue;
        private int headIndex;
        public MyQueue()
        {
            queue = new List<int>();
            headIndex = 0;
        }

        public bool EnQueue(int value)
        {
            queue.Add(value);
            return true;
        }

        public bool DeQueue()
        {
            if (queue.Count == 0) return false;
            headIndex += 1;
            return true;
        }

        public int Front()
        {
            if (queue.Count - 1 == headIndex)
            {
                return -1;
            }

            return queue[headIndex];
        }

        public int Rear()
        {
            if (queue.Count == headIndex)
            {
                return -1;
            }
            return queue[queue.Count - 1];
        }

        public bool IsEmpty()
        {
            return queue.Count - 1 == headIndex;
        }
    }

    public class MyCircularQueue
    {
        private readonly int[] queue;
        private int headIndex;
        private int capacity;
        private int count;
        public MyCircularQueue(int k)
        {
            queue = new int[k];
            capacity = k;
            headIndex = 0;
            count = 0;
        }

        public bool EnQueue(int value)
        {
            if (count == capacity) return false;
            var tail = (headIndex + count) % capacity;
            queue[tail] = value;
            count += 1;
            return true;
        }

        public bool DeQueue()
        {
            if (count == 0) return false;
            headIndex = (headIndex + 1) % capacity;
            count -= 1;
            return true;
        }

        public int Front()
        {
            if (count == 0)
            {
                return -1;
            }

            return queue[headIndex];
        }

        public int Rear()
        {
            if (count == 0)
            {
                return -1;
            }
            return queue[(headIndex + count - 1) % capacity];
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public bool IsFull()
        {
            return count == capacity;
        }
    }
}
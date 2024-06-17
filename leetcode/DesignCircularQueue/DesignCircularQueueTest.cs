namespace DesignCircularQueue;

public class DesignCircularQueueTest
{
    [Fact]
    public void Test1()
    {
        MyCircularQueue myCircularQueue = new MyCircularQueue(3);
        Assert.True(myCircularQueue.EnQueue(1)); // return True
        Assert.True(myCircularQueue.EnQueue(2)); // return True
        Assert.True(myCircularQueue.EnQueue(3)); // return True
        Assert.True(myCircularQueue.EnQueue(4)); // return False
        Assert.Equal(3, myCircularQueue.Rear());     // return 3
        Assert.True(myCircularQueue.IsFull());   // return True
        Assert.True(myCircularQueue.DeQueue());  // return True
        Assert.True(myCircularQueue.EnQueue(4)); // return True
        Assert.Equal(3, myCircularQueue.Rear());     // return 4
    }

    public class MyCircularQueue
    {
        private readonly int[] _queue;
        private int _head = 0;
        private int _tail;
        private int _endIndex;
        private int _startIndex;
        public MyCircularQueue(int k)
        {
            _queue = new int[k];
            _endIndex = k - 1;
            _tail = 0;
            _startIndex = 0;
        }

        public bool EnQueue(int value)
        {
            _queue[_tail] = value;
            if (IsFull())
            {
                return false;
            }

            if (_tail == _endIndex)
            {
                if (_startIndex < _head && _head > 0)
                {
                    _tail = _startIndex;
                }
            }

            _tail++;

            return true;
        }

        public bool DeQueue()
        {
            if (IsEmpty())
            {
                return false;
            }
            if (_head == _endIndex)
            {

                _head = _startIndex;
            }
            _head++;
            return true;
        }

        public int Front()
        {
            if (IsEmpty())
            {
                return -1;
            }

            return _queue[_head];
        }

        public int Rear()
        {
            return IsEmpty() ? -1 : _queue[_tail];
        }

        public bool IsEmpty()
        {
            return _head == _tail;
        }

        public bool IsFull()
        {
            if (IsEmpty()) return false;
            return (_head == _startIndex && _tail == _endIndex) || !(_head < _tail);
        }
    }
}
    public class MyQueue
    {
        private int[] _repository = new int[1000];
        private int head = -1;
        private int tail = 0;
        public MyQueue()
        {}

        public void Enqueue(int input)
        {
            if (tail >= _repository.Length - 1)
            {
                throw new Exception("Queue is full");
            }
            _repository[tail] = input;
            tail++;
            if(head == -1)
            {
                head = 0;
            }
        }

        public int Dequeue()
        {
            if (head == -1 || head > tail)
            {
                throw new Exception("Queue is empty");
            }
            var result = _repository[head];
            head++;
            return result;
        }

        public int Size()
        {
            return tail - head;
        }
    }

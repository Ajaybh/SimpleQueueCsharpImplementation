using System;

namespace SimpleQueue
{
    public class MyQueue
    {
        private int[] _repository = new int[1000];
        private int _head = -1;
        private int _tail = 0;
        public MyQueue()
        { }

        public void Enqueue(int input)
        {
            if (_tail >= _repository.Length - 1)
            {
                throw new Exception("Queue is full");
            }
            _repository[_tail] = input;
            _tail++;
            if (_head == -1)
            {
                _head = 0;
            }
        }

        public int Dequeue()
        {
            if (_head == -1)
            {
                throw new Exception("Queue is empty");
            }
            var result = _repository[_head];
            _head++;
            if (_head > _tail)
            {
                _head = -1;
                _tail = 0;
            }
            return result;
        }

        public int Size()
        {
            if(_head == -1)
            {
                throw new Exception("Queue is empty");
            }
            return _tail - _head;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue myQueue = new MyQueue();
            myQueue.Enqueue(10);
            myQueue.Enqueue(15);
            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine(myQueue.Dequeue());
            myQueue.Enqueue(20);
            Console.WriteLine(myQueue.Dequeue());
            myQueue.Enqueue(30);
            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine(myQueue.Dequeue());
            try
            {
                Console.WriteLine(myQueue.Dequeue());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            try { 
            Console.WriteLine(myQueue.Size());
            }
            catch(Exception emptyEx)
            {
                Console.WriteLine(emptyEx);
            }
            myQueue.Enqueue(40);
            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine(myQueue.Size());
            Console.ReadLine();
        }
    }
}

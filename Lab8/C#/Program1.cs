using System;

namespace Events
{

    class Event
    {
        public delegate void MyEventHandler();

        public event MyEventHandler StackOwerflow;

        public void ifStackOwerflow()
        {
            Console.WriteLine("Stack owerflow");
        }
    }
    class Stack<T>: Event
    {
        private readonly int _Size;
        private readonly T[] _Array;
        private int _Top;

        public Stack(int Size)
        {
            _Size = Size;
            _Top = 0;
            _Array = new T[_Size];
        }

        public int Top
        {
            get => _Top;
        }
        
        public int Size
        {
            get => _Size;
        }

        public int Count()
        {
            return _Top;
        }

        public bool IsFull()
        {
            return _Top == _Size;
        }

        public bool IsEmpty()
        {
            return _Top == 0;
        }
        public void Push(T Element)
        {
            if (IsFull())
            {
                StackOwerflow += new MyEventHandler(ifStackOwerflow);
                ifStackOwerflow();
            }
            else _Array[_Top++] = Element;
        }
        public T Pop()
        {
            if (IsEmpty())
                throw new Exception("No more element");
            return _Array[--_Top];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> s = new Stack<int>(2);

            try
            {
                s.Push(1);
                s.Push(2);
                s.Push(3);
                Console.WriteLine(s.Pop());
                Console.WriteLine(s.Pop());
                Console.WriteLine(s.Pop());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

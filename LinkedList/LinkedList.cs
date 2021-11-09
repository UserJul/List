using System;

namespace LinkedList
{
    public class LinkedList
    {
        private Node _root;
        private Node _tail;

        public LinkedList()
        {
            _root = null;
            _tail = null;
        }

        public LinkedList(int value)
        {
            _root = new Node(value);
            _tail = _root;
        }

        public LinkedList(int[] array)
        {
            if (array.Length != 0)
            {
                _root = new Node(array[0]);
                _tail = _root;

                for (int i = 1; i < array.Length; i++)
                {
                    _tail.Next = new Node(array[i]);
                    _tail = _tail.Next;
                }
            }
            else
            {
                _root = null;
                _tail = null;
            }
        }
        public int GetLength()
        {
            int Length = 0;
            Node current = _root;
            while (current != null)
            {
                Length++;
                current = current.Next;
            }
            return Length;
        }
        public int[] ToArray()
        {
            int[] array = new int[GetLength()];
            Node current = _root;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = current.Value;
                current = current.Next;
            }
            return array;
        }
        public void AddLast(int value)
        {
            int length = GetLength();
            Node current = new Node(value);
            if (length == 0)
            {
                _root = current;
            }
            else
            {
                _tail.Next = current;
                _tail = _tail.Next;
            }
        }
        public void AddFirst(int value)
        {
            int length = GetLength();
            Node current = new Node(value);
            if (length == 0)
            {
                _root = current;
            }
            else
            {
                current.Next = _root;
                _root = current;
            }
        }
        public void AddAt(int index, int value)
        {
            int length = GetLength();
            Node current = _root;
            Node tmp = new Node(value);
            if (length == 0)
            {
                throw new IndexOutOfRangeException("");
            }

            for (int i = 0; i < index; i++)
            {
                tmp.Next = current.Next;
                current.Next = tmp;
            }
        }


        public void RemoveFirst()
        {
            _root = _root.Next;
        }

        public int RemoveFirst(int val)
        {
            
            Node tmp = new Node(0);
            tmp.Next = _root;
            Node current = tmp;

            int index = -1;
            if(current == null)
            {
                throw new Exception();
            }
            while(current.Next != null)
            {
                index++;
                if(current.Next.Value == val)
                {
                    current.Next = current.Next.Next;
                    _root = tmp.Next;
                    return index;
                }
                else
                {
                    current = current.Next;
                }
            }
            return index;
        }
        public void RemoveAt(int index)
        {
            Node current = _root;
            if(_root == null)
            {
                throw new Exception();
            }
            if(index == 0)
            {
                current = current.Next;
                _root = current;
            }
            else
            {
                for (int i = 1; i < index; i++)
                {
                    current = current.Next;
                }
                current.Next = current.Next.Next;
            }
           
        }
        public void RemoveLast()
        {
            if (_root == null)
            {
                throw new IndexOutOfRangeException();
            }

            Node current = _root;

            if (current.Next == null)
            {
                RemoveFirst();
                return;
            }

            while (current.Next.Next != null)
            {
                current = current.Next;
            }

            current.Next = null;

        }
        public void  RemoveLastMultiple(int n)
        {
            if (_root == null)
            {
                throw new IndexOutOfRangeException();
            }
            int length = GetLength(); 
            Node current = _root;
            for (int i = 0; i < length-1 - n; i++)
            {
                current = current.Next;

            }
            current.Next = null;
        }
        public void RemoveAtMultiple(int index, int n)
        {
            if (_root == null)
            {
                throw new IndexOutOfRangeException();
            }
            if(index == 0)
            {
                RemoveFirstMultiple(n);
            }
            else
            {
                Node current = _root;

                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }

                Node tmp = current;
                for (int i = 0; i < n + 1; i++)
                {
                    tmp = tmp.Next;
                }
                current.Next = tmp;
            }

        }
        public void RemoveFirstMultiple(int n)
        {
            if (_root == null)
            {
                throw new IndexOutOfRangeException();
            }
            Node current = _root;
            for (int i = 0; i < n; i++)
            {
                current = current.Next;
            }
            _root = current;
        }
            public void Set(int index, int value)
        {
            Node current = _root;

            for (int i = 1; i <= index; i++)
            {
                current = current.Next;
            }

            current.Value = value;
        }
        public override string ToString()
        {
            return string.Join(";", ToArray());
        }

    }
}

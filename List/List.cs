using System;

namespace ArrayList
{
    public class List
    {
        private int[] _array;
        private int _minLength = 10;
        public int Length { get; private set; }
        public List()
        {

            _array = new int[_minLength];
        }
        public List(int value)
        {
            _array = new int[_minLength];
            _array[0] = value;

        }
        public List(int[] array)
        {
            Length = array.Length;
            int length;


            if (array.Length > _minLength)
            {
                length = array.Length;
            }
            else
            {
                length = _minLength;
            }
            int[] array1 = new int[length];
            for (int i = 0; i < Length; i++)
            {

                array1[i] = array[i];
            }
            _array = array1;


        }
        public int this[int index]
        {
            get
            {
                return _array[index];
            }
            set
            {
                _array[index] = value;
            }
        }

        public int[] ToArray()
        {
            int[] array = new int[Length];
            for (int i = 0; i < Length; i++)
            {
                array[i] = _array[i];
            }
            return array;
        }

        public void AddLast(int value)
        {
            if (Length == _array.Length)
            {
                UpSize();
            }
            _array[Length] = value;
            Length++;
        }
        public void AddLast(List list)
        {
            if (list.Length > _array.Length)
            {
                UpSize();
            }
            int newLength = Length + list.Length;
            int[] tmpArray = new int[newLength];
            for (int i = 0; i < Length; i++)
            {
                tmpArray[i] = _array[i];
            }
            for (int i = 0; i < list.Length; i++)
            {
                tmpArray[Length + i] = list._array[i];
            }
            _array = tmpArray;
            Length = newLength;
        }
        public void AddAt(int index, int value)
        {
            if (Length == _array.Length)
            {
                UpSize();
            }
            for (int i = Length - 1; i >= index; i--)
            {
                _array[i + 1] = _array[i];
            }
            Length++;
            _array[index] = value;

        }
        public void AddAt(int index, List list)
        {
            if (Length == 0)
            {
                throw new IndexOutOfRangeException("массив пуст");

            }
            UpSize(list.Length);
            ShiftToRight(index, list.Length);
            for (int i = 0; i < list.Length; i++)
            {
                _array[i + index] = list[i];
            }
        }
        public int GetLength()
        {
            return Length;
        }
        public void AddFirst(int value)
        {
            if (Length == _array.Length)
            {
                UpSize();
            }
            ShiftToRight(0, 1);
            _array[0] = value;
        }

        public void AddFirst(List list)
        {
            if (_array.Length - list.Length <= 0 )
            {
                UpSize(list.Length);
            }
            ShiftToRight(0, list.Length);
            for (int i = 0; i < list.Length; i++)
            {
                _array[i] = list[i];
            }

        }
        public void RemoveFirst()
        {

            for (int i = 0; i < Length - 1; i++)
            {
                _array[i] = _array[i + 1];
            }
            Length--;


        }
        public void RemoveLast()
        {
            if (Length == _array.Length)
            {
                UpSize();
            }
            for (int i = Length; i < Length; i++)
            {
                _array[Length] = _array[Length + 1];
            }
            Length--;
        }
        public void RemoveAt(int index)
        {
            if (Length == _array.Length)
            {
                UpSize();
            }
            if(Length == 0)
            {
                throw new IndexOutOfRangeException("массив пуст");
            }
            if(index > Length - 1 || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            if((index >=0 ) && index < Length)
            {
                for (int i = index; i < Length-1; i++)
                {
                    _array[index] = _array[index + 1];
                }
                Length--;
            }
            
        }
        public void RemoveFirstMultiple(int n)
        {
            if (Length == _array.Length)
            {
                UpSize();
            }
            if (n > Length)
            {
                throw new DivideByZeroException();
            }
            for (int i = 0; i < Length - n; i++)
            {
                _array[i] = _array[i + n];
            }
            Length -= n;
        }
        public void RemoveLastMultiple(int n)
        {
            if (Length == _array.Length)
            {
                UpSize();
            }
            if (n > Length)
            {
                throw new DivideByZeroException();
            }
            Length -= n;
        }
        public void RemoveAtMultiple(int index, int n)
        {
            if (Length == _array.Length)
            {
                UpSize();
            }
            if (n > Length)
            {
                throw new DivideByZeroException();
            }
            for (int i = index; i < Length - n; i++)
            {
                _array[i] = _array[i + n];
            }
            Length -= n;
        }
        public int RemoveFirst(int val)
        {
            if (Length == 0)
            {
                throw new IndexOutOfRangeException();
            }
            int index = IndexOf(val);
            if (index != -1)
            { 
                RemoveAt(index);
            }
            return index;
        }
        public void RemoveAll(int value)
        {
            for (int i = 0; i < Length + 1; i++)
            {
                if (_array[i] == value)
                {
                    _array[i] = _array[i + 1];
                    Length--;
                }
            }
        }
        public bool Contains(int value)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] == value)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        public int IndexOf(int val)
        {
            int index = -1;

            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] == val )
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        public int GetFirst()
        {
            int result = _array[0];
            return result;
        }
        public int GetLast()
        {
            int result = _array[Length - 1];
            return result;
        }
        public int Get(int index)
        {
            return _array[index];
        }
        public void Reverse()
        {
            int tmp = 0;

            for (int i = 0; i < Length / 2; i++)
            {
                tmp = _array[i];
                _array[i] = _array[Length - i - 1];
                _array[Length - i - 1] = tmp;
            }
        }
        public int Max()
        {
            return _array[IndexOfMax()];
        }
        public int Min()
        {
            return _array[IndexOfMin()];
        }
        public int IndexOfMax()
        {
            int max = _array[0];
            int indexMax = 0;
            for (int i = 0; i < Length; i++)
            {
                if (max <= _array[i])
                {
                    max = _array[i];
                    indexMax = i;
                }
            }
            return indexMax;
        }
        public int IndexOfMin()
        {
            int min = _array[0];
            int indexMin = 0;
            for (int i = 0; i < Length; i++)
            {
                if (min > _array[i])
                {
                    min = _array[i];
                    indexMin = i;
                }
            }
            return indexMin;
        }
        public int[] Sort()
        {
            int tmp;

            for (int i = 0; i < Length; i++)
            {
                for (int j = Length - 1; j > i; j--)
                {
                    if (_array[j - 1] > _array[j])
                    {
                        tmp = _array[j - 1];
                        _array[j - 1] = _array[j];
                        _array[j] = tmp;
                    }
                }
            }

            return _array;
        }

        public int[] SortDes()
        {
            int tmp;

            for (int i = 0; i < Length - 1; i++)
            {
                int indexOfMax = i;

                for (int j = i; j < Length; j++)
                {
                    if (_array[indexOfMax] < _array[j])
                    {
                        indexOfMax = j;
                    }
                }

                tmp = _array[i];
                _array[i] = _array[indexOfMax];
                _array[indexOfMax] = tmp;
            }

            return _array;
        }
        public void ShiftToRight(int index, int n)
        {
            if (Length + n > _array.Length)
            {

                UpSize(n);

            }
            Length += n;
            for (int i = Length - 1; i > index + n - 1; i--)
            {
                _array[i] = _array[i - n];

            }

        }

        public override bool Equals(object obj)
        {
            List arrayList = (List)obj;

            if (Length != _array.Length)
            {
                return false;
            }
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] != arrayList._array[i])
                {
                    return false;
                }
            }
            return true;
        }

        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < Length; i++)
            {
                str += _array[i] + " ";
            }
            return str;
        }
        private void UpSize()
        {
            int newLenght = (Length * 3) / 2 + 1;
            int[] tmpArray = new int[newLenght];
            for (int i = 0; i < _array.Length; i++)
            {
                tmpArray[i] = _array[i];
            }
            _array = tmpArray;
        }
        public void UpSize(int newLength)
        {
            int length = (_array.Length + newLength) * 3 / 2;
            int[] tmpArray = new int[length];


            for (int i = 0; i < _array.Length; i++)
            {
                tmpArray[i] = _array[i];

            }
            _array = tmpArray;

        }
        private void DownSize()
        {
            int newLength = _array.Length * 2 / 3;
            int[] tmpArray = new int[newLength];

            for (int i = 0; i < _array.Length; i++)
            {
                tmpArray[i] = _array[i];
            }

            _array = tmpArray;
        }
    }
}

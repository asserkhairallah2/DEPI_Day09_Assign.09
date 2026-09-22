using System;

namespace TaskApp
{
    #region ArrayHelper and Generic Methods
    public static class ArrayHelper
    {
        // Reverse Array
        public static T[] ReverseArray<T>(T[] array)
        {
            T[] reversed = new T[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                reversed[i] = array[array.Length - 1 - i];
            }
            return reversed;
        }

        // Swap Elements by Index
        public static void SwapElements<T>(T[] array, int index1, int index2)
        {
            if (index1 >= 0 && index1 < array.Length && index2 >= 0 && index2 < array.Length)
            {
                T temp = array[index1];
                array[index1] = array[index2];
                array[index2] = temp;
            }
        }

        // Get Maximum Element
        public static T GetMaximum<T>(T[] array) where T : IComparable<T>
        {
            if (array == null || array.Length == 0) throw new ArgumentException("Array is empty");
            T max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i].CompareTo(max) > 0)
                {
                    max = array[i];
                }
            }
            return max;
        }

        // Generic Max Method taking two arguments
        public static T Max<T>(T val1, T val2) where T : IComparable<T>
        {
            return val1.CompareTo(val2) > 0 ? val1 : val2;
        }
    }
    #endregion

    #region Generic Stack Class
    public class MyStack<T>
    {
        private T[] _items;
        private int _top;

        public MyStack(int capacity)
        {
            _items = new T[capacity];
            _top = 0;
        }

        public void Push(T item)
        {
            if (_top == _items.Length) throw new InvalidOperationException("Stack Overflow");
            _items[_top++] = item;
        }

        public T Pop()
        {
            if (_top == 0) throw new InvalidOperationException("Stack Underflow");
            return _items[--_top];
        }

        public T Peek()
        {
            if (_top == 0) throw new InvalidOperationException("Stack is Empty");
            return _items[_top - 1];
        }
    }
    #endregion

    #region Helper2<T> for Search and Replace
    public class Helper2<T>
    {
        public static int SearchArray(T[] array, T value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(value)) return i;
            }
            return -1;
        }

        public static void ReplaceArray(T[] array, T oldValue, T newValue)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(oldValue))
                {
                    array[i] = newValue;
                }
            }
        }
    }
    #endregion
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LironGenericReview
{
    class myList<T> : IList<T>
    {
        T[] data;
        int minimumCapacity;
        public myList(int minimumCapacity)
        {
            this.minimumCapacity = minimumCapacity;
            data = new T[minimumCapacity];
            Count = 0;
        }


        public T this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Count { get; set; }

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            if (!(data.Length == Count))
            {
                data[Count] = item;
            }

            else
            {
                //cerate a temporary array for loop it
            }

        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

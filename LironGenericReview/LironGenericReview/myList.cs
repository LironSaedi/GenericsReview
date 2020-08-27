using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
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


        public T this[int index]
        {
            get
            {
                //check if index is valid
                //return that index value if it is valid

                // throw many errors.
            }
            set
            {
                //check if index is valid
                //set that index's value if it is valid
                data[index] = value;
                // throw many errors.
            }
        }

        public int Count { get; set; }

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            if (!(data.Length == Count))
            {
                data[Count] = item;

                Count++;
            }

            else
            {
                T[] temp = new T[data.Length * 2];
                for (int i = 0; i < data.Length; i++)
                {
                    temp[i] = data[i];
                }

                data = temp;

                data[Count] = item;
                Count++;

            }

        }

        public void Clear()
        {
            Count = 0;
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (item.Equals(data[i]))
                {
                    return true;
                }
            }
            return false;
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
            for (int i = 0; i < Count; i++)
            {
                if (item.Equals(data[i]))
                {
                    for (int j = i; j < Count - 1; j++)
                    {
                        data[j] = data[j + 1];
                    }
                    Count--;
                    return true;

                }

            }
            return false;
        }

        public void RemoveAt(int index)
        {
            if (index < Count && index >= 0)
            {
                for (int i = index; i < Count; i++)
                {
                    data[i] = data[i + 1];
                }
                Count--;
            }
            else
            {
                throw new Exception("You Did not enter a valid numero. ");
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

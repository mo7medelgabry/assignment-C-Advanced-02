using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_C__Advanced_02
{
    internal class FixedSizeList<T>
    {
        public T[] Items;
        public int Count;

        public FixedSizeList(int Capacity)
        {
           Items = new T[Capacity];
            Count = 0;
        }

        public void Add(T item)
        {
            if (Count >= Items.Length)
            {
                throw new InvalidOperationException("List capacity is Full.");
            }
            Items[Count++] = item;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index out of range.");
            }
            return Items[index];
        }

        public int count => Count;
        public int Capacity => Items.Length;





    }
}

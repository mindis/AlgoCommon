using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiDriven.AlgoCommon.Heap
{
    /// <summary>
    /// Thread unsafe data structure for a min-heap
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MinHeap<T> where T : IComparable
    {
        private List<T> data = new List<T>();
        public int Count
        {
            get { return data.Count; }
        }

        public void Insert(T value)
        {
            data.Add(value);
            this.UpHeapify();
        }

        public T RemoveMin()
        {
            if (data.Count == 0)
            {
                throw new Exception("no data");
            }

            T root = data[0];
            if (data.Count == 0)
            {
                data.Clear();
            }
            else
            {
                this.DownHeapify();
            }
            return root;
        }

        private void UpHeapify()
        {
            int currentIndex = data.Count - 1;

            while (currentIndex > 0)
            {
                int parentIndex = (currentIndex - 1) / 2;
                if (data[currentIndex].CompareTo(data[parentIndex]) < 0)
                {
                    T tmp = data[currentIndex];
                    data[currentIndex] = data[parentIndex];
                    data[parentIndex] = tmp;

                    currentIndex = parentIndex;
                }
                else
                {
                    break;
                }
            }

        }

        private void DownHeapify()
        {
            data[0] = data[data.Count - 1];
            data.RemoveAt(data.Count-1);
            int currentIndex = 0;
            int leftChildIndex = (currentIndex + 1) * 2 - 1;
            while (leftChildIndex < data.Count && data[currentIndex].CompareTo(data[leftChildIndex]) > 0)
            {
                T tmp = data[leftChildIndex];
                data[leftChildIndex] = data[currentIndex];
                data[currentIndex] = tmp;

                currentIndex = leftChildIndex;
            }
        }

    }
}

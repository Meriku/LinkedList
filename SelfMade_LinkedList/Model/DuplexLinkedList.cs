using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfMade_LinkedList.Model
{
    public class DuplexLinkedList<T> : IEnumerable
    {
        public DuplexItem<T> Head { get; set; }
        public DuplexItem<T> Tail { get; set; }
        public int Count { get; set; }

        public DuplexLinkedList() { }

        public DuplexLinkedList(T data)
        {
            var item = new DuplexItem<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }
        public void Add(T data)
        {

            var item = new DuplexItem<T>(data);

            if (Count == 0)
            {
                Head = item;
                Tail = item;
                Count = 1;
                return;
            }


            Tail.Next = item;
            item.Previous = Tail;
            Tail = item;
            Count++;
        }

        public void Delete(T data)
        {
            var current = Head;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    if (current.Next != null && current.Previous != null)       // Если есть элементы и справа и слева
                    {
                        current.Previous.Next = current.Next;
                        current.Next.Previous = current.Previous;
                    }
                    
                    else if (current.Next == null && current.Previous != null)  // Если следующий элемент отсутствует
                    {
                        current.Previous.Next = null;
                    }

                    else if (current.Previous == null && current.Next != null)  // Если предыдущий элемент отсутствует
                    {
                        current.Next.Previous = null;
                    }

                    Count--;
                    return;
                }

                current = current.Next;
            }
        }

        public IEnumerator GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}

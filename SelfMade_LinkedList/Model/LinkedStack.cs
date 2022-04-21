using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfMade_LinkedList.Model
{
    public class LinkedStack<T>
    {
        private ItemStack<T> Top;

        public int count { get; private set; }

        public LinkedStack()
        {
            count = 0;
        }

        public void Push(T data) // Добавить элемент 
        {
            if (count == 0)
            {
                Top = new ItemStack<T> (data);
            }
            else
            {
                var item = new ItemStack<T>(data) { Previous = Top };
                Top = item;
            }
            count++;
        }

        public T Pop()          // Убрать верхний элемент
        {
            if (count > 0)
            {
                var item = Top;
                Top = item.Previous;
                count--;
                return item.Data;
            }
            else
            {
                return default(T);
            }
        }

        public T Peek()         // Посмотреть верхний элемент 
        {
            if (count > 0)
            {
                return Top.Data;
            }
            else
            {
                return default(T);
            }
        }
    }
}

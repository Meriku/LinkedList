using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfMade_LinkedList.Model
{
    public class ItemStack<T>
    {
        public T Data { get; set; }
        public ItemStack<T> Previous { get; set; }

        public ItemStack(T data)
        {
            // Проверка
            Data = data;
        }

    }
}

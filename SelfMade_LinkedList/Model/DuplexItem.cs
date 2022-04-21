using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfMade_LinkedList.Model
{
    public class DuplexItem<T>
    {
        public T Data { get; set; }

        public DuplexItem<T> Previous { get; set; }

        public DuplexItem<T> Next { get; set; }

        public DuplexItem(T data)
        {
            // Проверки
            Data = data;
        }







    }
}

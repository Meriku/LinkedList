using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfMade_LinkedList.Model
{
    public class ItemList<T>
    {
        private T data = default(T); // Данный

        public T Data
        {
            get { return data; }
            set
            {
                if (value != null)
                    data = value;
                else
                    throw new ArgumentNullException(nameof(value));
            }
        }

        public ItemList<T> Next { get; set; } // Ссылка на следующий элемент

        public ItemList(T data)
        {
            Data = data;
        }

    }
}

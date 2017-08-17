using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    public class GenericList<T>
    {
        T[] items = new T[0];
        public void Add(T value)
        {
            //logic to add value to list (internal array)
        }
        public void Remove(T value)
        {

        }

        public T this [int index]
        {
            get { throw new NotImplementedException();}
        }
        public void 
    }

}

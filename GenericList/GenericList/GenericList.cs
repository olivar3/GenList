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
            //logic to remove value to list (internal array)
        }

        public T this [int index]
        {
            get { throw new NotImplementedException();}
        }
        public override string ToString()
        {
            
            return GenericList<T>;// see what return path this should have.
        }

        public void ToString(string v)
        {
            throw new NotImplementedException();
        }
        public static GenericList<T> operator +(GenericList<T> GenericList, GenericList<T> GenericList2)
        {
            //can use the add method in order to add lists.
            return GenericList;
        }
        public static GenericList<T> operator -(GenericList<T> GenericList, GenericList<T> GenericList2)
        {
            // might be able to use the remove method to subtract indexes.
            return GenericList;
        }
    }
}

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
            GenericList<int> listA = new GenericList<int>();
            GenericList<int> listB = new GenericList<int>();
            GenericList<int> listC = new GenericList<int>();
            listA.Add(1, 2, 3);
            listB.Add(4, 5, 6);
            listC.Add(listA, listB);
            //logic to add value to list (internal array)
        }
        public void Remove(T value)
        {
            GenericList<int> listA = new GenericList<int>();
            GenericList<int> listB = new GenericList<int>();
            GenericList<int> listC = new GenericList<int>();
            listA.Add(1, 2, 3);
            listB.Add(4, 5, 6);
            listC.Remove(2, 4, 6);//logic to remove value to list (internal array)
        }

        private void Remove(int v1, int v2, int v3)
        {
            throw new NotImplementedException();
        }

        public T this [int index]
        {
            get { throw new NotImplementedException();}
        }
        public override string ToString()
        {
            
            return GenericList<T>;// see what return path this should have.
        }
        public void zipTogether()
        {

        }

        public void ToString(string v)
        {
            throw new NotImplementedException();
        }
        public static GenericList<T> operator +(GenericList<T> GenericList, GenericList<T> GenericList2)
        {
            GenericList.Add(GenericList, GenericList2);
            //GenericList a plus GenericList b = Generic List C
            //can use the add method in order to add lists.
            return GenericList;
        }

        private void Add(GenericList<T> genericList1, GenericList<T> genericList2)
        {
            throw new NotImplementedException();
        }

        public static GenericList<T> operator -(GenericList<T> GenericList, GenericList<T> GenericList2)
        {
            //GenericList a minus GenericList b = Generic List C
            // might be able to use the remove method to subtract indexes.
            return GenericList;
        }

        public static implicit operator int(GenericList<int> v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator char(GenericList<char> v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator GenericList<T>(double v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator double(GenericList<double> v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator string(GenericList<string> v)
        {
            throw new NotImplementedException();
        }

        public void Remove(GenericList<int> lista, GenericList<int> listb)
        {
            throw new NotImplementedException();
        }

        public void Add(GenericList<int> lista, GenericList<int> listb)
        {
            throw new NotImplementedException();
        }

        public void Add(int v1, int v2, int v3)
        {
            throw new NotImplementedException();
        }

        public void Add(GenericList<char> lista, GenericList<char> listb)
        {
            throw new NotImplementedException();
        }

        public void Add(object d, object e, object f)
        {
            throw new NotImplementedException();
        }

        public void Add(object a, object b, object c)
        {
            throw new NotImplementedException();
        }

        public void Add(GenericList<double> lista, GenericList<double> listb)
        {
            throw new NotImplementedException();
        }

        public void Add(GenericList<string> lista, GenericList<string> listb)
        {
            throw new NotImplementedException();
        }

        public object Zip(GenericList<int> list2, Func<object, object, object> p)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03_GenericList
{
    [Version(0,1)]
    public class GenericList<T>
        where T : IComparable<T>
    {
        private const int startCapacity=16;
        private int capacity;
        private T[] array;
        private int GenericIndex;

        public GenericList(int capacity = startCapacity)
        {
            this.Capacity = capacity;
            array=new T[capacity];
            GenericIndex = 0;
        }

        private int Capacity 
        {
            get { return capacity; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Capacity of GenericList must be positive number");
                }
                this.capacity = value;
            }
        }

        // adding an element
        public void Add(T item)
        {
            CheckCapacity();

            array[GenericIndex] = item;
            GenericIndex++;
        }

        private void CheckIndex(int index)
        {
            if (index < 0)
            {
                throw new IndexOutOfRangeException("Index cannot be neggative");
            }
            if (index >= GenericIndex)
            {
                throw new IndexOutOfRangeException("Index is out of the boundries of the GenericList");
            }
        }

        // Auto - growing
        private void CheckCapacity()
        {
            if (GenericIndex == this.Capacity)
            {
                int newSize = this.Capacity*2;
                T[] newArray = new T[newSize];

                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = array[i];
                }

                this.Capacity = newSize;
                array = newArray;
            }
        }

        private void IsEmpty()
        {
            if (GenericIndex == 0)
            {
                throw new InvalidOperationException("List is empty");
            }
        }

        // accessing element by index
        public T ElementAt(int index)
        {
            IsEmpty();
            CheckIndex(index);
            return array[index];
        }

        // removing element by index
        public void RemoveElementAt(int index)
        {
            IsEmpty();
            CheckIndex(index);

            T[]newArray=new T[this.Capacity];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i == index)
                {
                    continue;
                }
                
                newArray[j] = array[i];
                j++;
            }

            array = newArray;
            GenericIndex--;
        }

        // inserting element at given position
        public void Insert(T element,int index)
        {
            CheckIndex(index);
            CheckCapacity();

            T[] newArray = new T[this.Capacity];
            int j = 0;
            for (int i = 0; i < array.Length-1; i++)
            {
                if (i == index)
                {
                    newArray[j] = element;
                    j++;
                }

                newArray[j] = array[i];
                j++;
            }

            array = newArray;
            GenericIndex++;
        }

        // clearing the list
        public void Clear()
        {
            array=new T[startCapacity];
            this.Capacity = startCapacity;
            GenericIndex = 0;
        }

        // finding element index by given value
        public int IndexAt(T element)
        {
            IsEmpty();

            for (int i = 0; i < GenericIndex; i++)
            {
                if (array[i].CompareTo(element) == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        // checking if the list contains a value
        public bool Contains(T element)
        {
            IsEmpty();

            for (int i = 0; i < GenericIndex; i++)
            {
                if (array[i].CompareTo(element) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        //finding the maximal element in the  GenericList<T>
        public T Max()
        {
            IsEmpty();

            T max = array[0];

            for (int i = 0; i < GenericIndex; i++)
            {
                if (array[i].CompareTo(max) > 0)
                {
                    max = array[i];
                }
            }
            return max;
        }

        //finding the minimal element in the  GenericList<T>
        public T Min()
        {
            IsEmpty();

            T min = array[0];

            for (int i = 0; i < GenericIndex; i++)
            {
                if (array[i].CompareTo(min) < 0)
                {
                    min = array[i];
                }
            }
            return min;
        }

        public override string ToString()
        {
            StringBuilder output=new StringBuilder();
            output.Append("{");

            for (int i = 0; i < GenericIndex; i++)
            {
                if (i == GenericIndex - 1)
                {
                    output.Append(" "+array[i]);
                }
                else
                {
                    output.Append(" " + array[i] + ",");
                }
            }
            return output.ToString()+" }";
        }

        public void Version()
        {
            Type type = typeof(GenericList<T>);
            object[] allAttributes = type.GetCustomAttributes(false);
            foreach (var ver in allAttributes)
            {
                if (ver is VersionAttribute)
                {
                    VersionAttribute temp = ver as VersionAttribute;
                    Console.WriteLine("GenericList Version {0}.{1}", temp.MajorVersion, temp.MinorVersion.ToString("X2"));
                }
            }
        }
    }
}

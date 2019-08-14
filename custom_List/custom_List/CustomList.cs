using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace custom_List
{
    //Steps for the project:
    //Make capacity a property
    //Need to start with the test method creation for the remove method
    //after approval, start to develop the method for the remove method
    //before this, generate the steps necessary to create this method

    public class CustomList<T>
    {
        //member variables
        public T[] data;
        private int count;
        private int capacity;
        public T this [int index]
        {
            get
            {
                if (index < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else if (index >= Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    return data[index];
                }
            }
            set
            {
                if (index < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else if (index >= Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    data[index] = value;
                }
            }
        }
        //throw the outofrange exceptions within the indexer
        public int Count
        {
            get
            {
                return count;
            }
        }

        public int Capacity
        {
            get
            {
                return capacity;
            }
        }

        //constructor
        public CustomList()
        {
            count = 0;
            capacity = 4;
            data = new T[capacity];
        }
        //member methods


        public void Add(T itemToAdd)
        {
            if (count == capacity)
            {
                T[] newData = new T[capacity * 2];
                for (int i = 0; i < count; i++)
                {
                    newData[i] = data[i];
                }
                capacity *= 2;
                data = newData;
            }
            data[count] = itemToAdd;
            count++;
        }
        public bool Remove(T itemToRemove)
        {
            for (int i = 0; i < count; i++)
            {
                bool equivalencyTest = CustomList<T>.Equals(data[i], itemToRemove);
                Console.WriteLine(equivalencyTest);
                Console.ReadLine();

            }
            return false;
        }
    }
}

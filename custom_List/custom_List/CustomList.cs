using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace custom_List
{

    public class CustomList<T> : IEnumerable<T>
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

        public IEnumerator<T> GetEnumerator()
        {
            for(int i = 0; i < Count; i++)
            {
                yield return data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

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
        public void Remove(T itemToRemove)
        {
            for (int i = 0; i < count; i++)
            {
                bool equivalencyTest = CustomList<T>.Equals(data[i], itemToRemove);
                if (equivalencyTest)
                {
                    for (int j = i; j < count; j++)
                    {
                        if (j == count - 1)
                        {
                            data[j] = default(T);
                            break;
                        }
                        data[j] = data[j + 1];
                    }
                    count--;
                    break;
                }
            }
        }

        public override string ToString()
        {
            string stringHolder = "";
            for (int i = 0; i < count; i++)
            {
                stringHolder += data[i].ToString();
            }
            return stringHolder;
        }
        
        public static CustomList<T> operator +(CustomList<T> list1, CustomList<T> list2)
        {
            for(int i = 0; i < list2.count; i++)
            {
                list1.Add(list2[i]);
            }
            return list1;
        }

        public static CustomList<T> operator -(CustomList<T> list1, CustomList<T> list2)
        {
            for(int i = 0; i < list1.count; i++)
            {
                for(int j = 0; j < list2.count; j++)
                {
                    if(CustomList<T>.Equals(list1[i], list2[j]))
                    {
                        list1.Remove(list2[j]);
                        break;
                    }
                }
            }
            return list1;
        }

        public static CustomList<T> Zip(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> resultList = new CustomList<T>();
            if (list1.Count >= list2.Count)
            {
                for (int i = 0; i < list1.Count; i++)
                {
                    resultList.Add(list1[i]);
                    for (int j = i; j < list2.Count; j++)
                    {
                        resultList.Add(list2[j]);
                        break;
                    }
                }
                return resultList;
            }
            else
            {
                for (int i = 0; i < list2.Count; i++)
                {
                    resultList.Add(list2[i]);
                    for (int j = i; j < list1.Count; j++)
                    {
                        resultList.Add(list1[j]);
                        break;
                    }
                }
                return resultList;
            }
        }

       
    }
}


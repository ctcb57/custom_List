using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace custom_List
{
    //Steps for the project:
    //Make sure all of the unit tests are created
    //Create an indexer within the class
    //Generate the logic within the add method 
    //Logic Steps:
    //need to have item[0] = item that is passed as a parameter
    //this needs to be a for loop though where it is item[i] and predicated on the capacity of the array
    //when the capacity has been reached, there needs to be logic which will double the size of the array
    //for this, it will reinstantiate an array which is the same size as the previous array size
    //need to combine these two arrays while also keeping the numbers at the correct index locations
    //Test the logic when it is complete to ensure the method works
    //move onto the remove method
    public class CustomList<T>
    {
        //member variables
        private T[] customList;
        private T count;
        private T capacity;

        public T Count
        {
            get
            {
                return count;
            }
        }


        //constructor


        //member methods
        public void Add(T itemToAdd)
        {

        }
    }
}

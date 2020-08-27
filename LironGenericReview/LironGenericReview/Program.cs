using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;

namespace LironGenericReview
{

    class Program
    {

        //Make a generic list
        //Generic array inside the list. 
        //Array has a minimum capacity  
        //Add, Remove, RemoveAt, count, indexing
        //You need the List to have the following interfaces:
        //IList<T>

        static void Main(string[] args)
        {
            //Create your list
            //add items to it
            //remove items from it
            myList<int> list = new myList<int>(3);
            //add items
            //remove items
            list.Add(5);
            list.Add(3);
            list.Add(4);
            list.Add(7);
            list.Add(8);

            Console.WriteLine(list.Remove(5));
            Console.WriteLine(list.Remove(10));


            list.RemoveAt(2);

            //list.RemoveAt(8);
            

            //loop through the mylist and print out everything

            ;







            Console.WriteLine("Hello World!");
        }
    }
}

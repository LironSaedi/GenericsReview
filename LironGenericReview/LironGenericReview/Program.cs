using Microsoft.VisualBasic.CompilerServices;
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
            MyList<int> list = new MyList<int>(3);

            int[] array = new int[3];


            //add items
            //remove items
            list.Add(5);
            list.Add(3);
            list.Add(4);
            list.Add(7);
            list.Add(8);
           

            //  Console.WriteLine(list.Remove(5));
            // Console.WriteLine(list.Remove(10));


            //list.CopyTo(array, 0);

            list.Insert(3, 10);
            ;
            list.RemoveAt(2);

            //list.RemoveAt(8);


            //loop through the mylist and print out everything

            ;


            //int MyList<int>[2];
            //MyList<int> list = new MyList<int>();

            Console.WriteLine(list[2]);

            Console.WriteLine("Hello World!");
        }
    }
}

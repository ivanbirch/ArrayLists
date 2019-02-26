using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare arraylist with undefined amount of object
            ArrayList myArrayList = new ArrayList();
            //declare arraylist with defined amount of object
            ArrayList myArrayList2 = new ArrayList();

            myArrayList.Add(25);
            myArrayList.Add("Hello");
            myArrayList.Add(13.37);
            myArrayList.Add(13);
            myArrayList.Add(128);
            myArrayList.Add(25.3 );
            myArrayList.Add(13);

            //delete element with specific value from the arraylist
            myArrayList.Remove(13);

            //delete element at specific position
            myArrayList.RemoveAt(0);

            Console.WriteLine("There are {0} elements in the arraylist.", myArrayList.Count);

            double sum = 0;

            foreach (object  obj in myArrayList)
            {
                if (obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if (obj is double)
                {
                    sum += (double)obj;
                }
                else if (obj is string)
                {
                    Console.WriteLine(obj+ " is not an int or double");
                }

            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}

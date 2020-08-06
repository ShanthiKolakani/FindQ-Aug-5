using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Collections;

namespace ConCollectionsApp
{
    class ListDic
    {
        public static void Main()
        {

            // Creating a ListDictionary named myDict 
            ListDictionary myDict = new ListDictionary();

            // Adding key/value pairs in myDict 
            myDict.Add("Australia", "Canberra");
            myDict.Add("Belgium", "Brussels");
            myDict.Add("Netherlands", "Amsterdam");
            myDict.Add("China", "Beijing");
            myDict.Add("Russia", "Moscow");
            myDict.Add("India", "New Delhi");

            // To get count of key/value pairs in myDict 
            Console.WriteLine("Total key/value pairs in myDict are : " + myDict.Count);

            // Displaying the key/value pairs in myDict 
            Console.WriteLine("The key/value pairs in myDict are : ");

            foreach (DictionaryEntry de in myDict)
            {
                Console.WriteLine(de.Key + " " + de.Value);
            }

            // Displaying the number of key/value 
            // pairs contained in the ListDictionary 
            Console.WriteLine(myDict.Count);

            // Checking if ListDictionary is read-only 
            Console.WriteLine(myDict.IsReadOnly);


            // Displaying the total number of elements in myDict 
            Console.WriteLine("Total number of elements in myDict are : "
                                                          + myDict.Count);

            // Displaying the elements in ListDictionary myDict 
            foreach (DictionaryEntry de in myDict)
            {
                Console.WriteLine(de.Key + " " + de.Value);
            }

        }
    }
}

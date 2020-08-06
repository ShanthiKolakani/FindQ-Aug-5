using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Collections;

namespace ConCollectionsApp
{
    class HybridDic

    {
        public static void Main()
        {

            // Creating a HybridDictionary with the 
            // specified initial size and case sensitivity. 
            HybridDictionary myDict = new HybridDictionary(10, false);

            // Adding key/value pairs in myDict 
            myDict.Add("I", "first");

            // This will not raise exception as the 
            // Collection is not case-insensitive 
            myDict.Add("i", "first");
            myDict.Add("II", "second");
            myDict.Add("III", "third");
            myDict.Add("IV", "fourth");
            myDict.Add("V", "fifth");

            // Displaying the key/value pairs in myDict 
            foreach (DictionaryEntry de in myDict)
                Console.WriteLine(de.Key + " " + de.Value);

            // To get count of key/value pairs in myDict 
            Console.WriteLine("Total key/value pairs in myDict are : "
                                                      + myDict.Count);


            // To check whether the HybridDictionary 
            // is read-only. 
            Console.WriteLine(myDict.IsReadOnly);


            // Creating a one-dimensional Array named myArr 
            DictionaryEntry[] myArr = new DictionaryEntry[myDict.Count];

            // copying the HybridDictionary entries 
            // to a one-dimensional Array instance 
            // at the specified index 
            myDict.CopyTo(myArr, 0);

            for (int i = 0; i < myArr.Length; i++)
                Console.WriteLine(myArr[i].Key + " --> " + myArr[i].Value);




            // Displaying the number of key/value 
            // pairs in HybridDictionary myDict 
            Console.WriteLine("Number of key/value pairs in myDict are : "
                                                           + myDict.Count);

            // Removing the entry with the 
            // specified key from the HybridDictionary. 
            myDict.Remove("i");

            // Displaying the number of key/value 
            // pairs in HybridDictionary myDict 
            Console.WriteLine("Number of key/value pairs in myDict are : "
                                                           + myDict.Count);
        }

    }
}

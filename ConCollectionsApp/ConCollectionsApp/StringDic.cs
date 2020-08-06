using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Collections;

namespace ConCollectionsApp
{
    class StringDic
    {
        public static void Main()
        {

            // Creating a StringDictionary named myDict 
            StringDictionary myDict = new StringDictionary();

            // Adding key and value into the StringDictionary 
            myDict.Add("A", "Apple");
            myDict.Add("B", "Banana");
            myDict.Add("C", "Cat");
            myDict.Add("D", "Dog");
            myDict.Add("E", "Elephant");

            // Displaying the keys and values in StringDictionary 
            foreach (DictionaryEntry dic in myDict)
            {
                Console.WriteLine(dic.Key + " " + dic.Value);
            }
            // -------- Values Property -------- 

            // Getting a collection of values  
            // in the StringDictionary  
            foreach (string val in myDict.Values)
            {
                Console.WriteLine(val);
            }


            // -------- IsSynchronized Property -------- 

            // Checking if StringDictionary  
            // is synchronized (thread safe)  
            Console.WriteLine(myDict.IsSynchronized);


            // Displaying the keys and values in StringDictionary 
            Console.WriteLine("The number of key/value pairs are : " + myDict.Count);

            // Removing the entry with the specified 
            // key from the StringDictionary 
            myDict.Remove("D");

            // Displaying the keys and values in StringDictionary 
            Console.WriteLine("The number of key/value pairs are : " + myDict.Count);



            // Creating an Array named myArr 
            DictionaryEntry[] myArr = { new DictionaryEntry(),
                                    new DictionaryEntry(),
                                    new DictionaryEntry(),
                                    new DictionaryEntry(),
                                    new DictionaryEntry() };

            // Copying StringDictionary to 
            // Array at the specified index 
            myDict.CopyTo(myArr, 0);

            // Displaying key and value pairs in Array myArr 
            for (int i = 0; i < myArr.Length; i++)
            {
                Console.WriteLine(myArr[i].Key + " " + myArr[i].Value);
            }
        }
    }
}

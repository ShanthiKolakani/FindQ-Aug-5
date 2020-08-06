using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Collections;

namespace ConCollectionsApp
{
    class StringEnu
    {
        public static void Main()
        {

            // creating a StringCollection named myCol 
            StringCollection myCol = new StringCollection();

            // Adding elements in StringCollection 
            myCol.Add("A");
            myCol.Add("B");
            myCol.Add("C");
            myCol.Add("D");
            myCol.Add("E");

            // taking an emumerator &  
            // using GetEnumerator method 
            StringEnumerator myenum = myCol.GetEnumerator();

            // If MoveNext passes the end of the 
            StringEnumerator myenum = myCol.GetEnumerator();

            // If MoveNext passes the end of the 
            // collection, the enumerator is positioned 
            // after the last element in the collection 
            // and MoveNext returns false. 
            while (myenum.MoveNext())
                Console.WriteLine(myenum.Current);
            // collection, the enumerator is positioned 
            // after the last element in the collection 
            // and MoveNext returns false. 
            while (myenum.MoveNext())
                Console.WriteLine(myenum.Current);

            StringEnumerator myenum = myCol.GetEnumerator();

            // If MoveNext passes the end of the 
            // collection, the enumerator is positioned 
            // after the last element in the collection 
            // and MoveNext returns false. 
            while (myenum.MoveNext())
                Console.WriteLine(myenum.Current);

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Task4
{
    internal class MyStringCollection
    {
        private List<string> myList;

        public MyStringCollection()
        {
           
             myList = new List<string>();

        }
        public void Add(string item)
        {
            
            myList.Add(item);
        }
        public bool Remove(string item)
        {
           return  myList.Remove(item);
        }
        public bool Contains(string item)
        {
           return myList.Contains(item);
        }
        public void PrintAll()
        {
            foreach(string item in myList)
            {
                Console.Write($"{item}  ");
            }
            Console.WriteLine();
        }
    }
}

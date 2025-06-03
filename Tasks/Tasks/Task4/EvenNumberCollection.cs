using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Task4
{
    internal class EvenNumberCollection : IEnumerable<int>
    {
        private List<int> numberList;
        public EvenNumberCollection(List<int> list)
        {
            numberList = list;
        }
        public IEnumerator<int> GetEnumerator()
        {
            foreach (int number in numberList)
            {
                if (number % 2 == 0)
                {
                    yield return number;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {

            return new Iterator(this);
        }

        class Iterator : IEnumerator
        {
            EvenNumberCollection myCollection;
            int index;
            public Iterator(EvenNumberCollection numbers)
            {
                myCollection = numbers;
                index = -1;

            }

            public object Current
            {
                get
                {
                    
                        return myCollection.numberList.ElementAt(index);
                    
                }
            }

            public bool MoveNext()
            {
                while (++index < myCollection.numberList.Count)
                {
                    if (myCollection.numberList.ElementAt(index) % 2 == 0) 
                        return true;
                }
                return false;

              
            }

            public void Reset()
            {
                index = -1;
            }
        }
    }
}

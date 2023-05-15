using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1Practise
{
    internal class Collection
    {
        ArrayList arrList = new ArrayList();
        public void AddData(object T)
        {
            arrList.Add(T);
        }
        public void RemoveData(object T)
        {
            arrList.Remove(T);
        }
        public void SearchData(object T)
        {
            arrList.Contains(T);
        }
        public void fetchAll()
        {
            foreach (object T in arrList)
            {
                Console.WriteLine(T);
            }
        }

    }
    class Calling
    {
        public static void Main(string[] args)
        {
            Collection c = new Collection();
            c.AddData(4);
            c.fetchAll();
            Console.ReadLine();
        }
        
    }
}

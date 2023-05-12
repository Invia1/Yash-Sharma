using System;
using System.CodeDom.Compiler;
using System.Collections;


namespace Day7Collection
{
    class DataEntryContact
    {
        ArrayList obj = new ArrayList();
        public void AddData()
        {
            obj.Add("Deepa");
            obj.Add("Deepak");

            foreach (var temp in obj) {
                Console.WriteLine(temp);
            }
        }
        public void deleteData()
        {
            //obj.Remove
        }
        public static void Main(string[] args)
        {
            DataEntryContact obj=new DataEntryContact();
            obj.AddData();
            Console.ReadLine();
        }

    }
}

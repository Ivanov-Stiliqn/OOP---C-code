using System;

namespace Problem_03_GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int>genericList=new GenericList<int>(2);
            genericList.Add(3);
            genericList.Add(2);
            genericList.Add(5);
            genericList.Add(8);

            Console.WriteLine(genericList);
            genericList.Version();
            Console.WriteLine("Element: "+genericList.ElementAt(2));

            genericList.RemoveElementAt(1);
            Console.WriteLine("Äfter removing: "+genericList);
            genericList.Add(7);
            Console.WriteLine(genericList);

            genericList.Insert(0,0);
            Console.WriteLine("Äfter inserting: "+genericList);
            

            Console.WriteLine("Index: "+genericList.IndexAt(5));
            Console.WriteLine("Does the list contains: "+genericList.Contains(5));

            Console.WriteLine("MAx: "+genericList.Max());
            Console.WriteLine("Min: "+genericList.Min());

            genericList.Clear();
            Console.WriteLine(genericList);
        }
    }
}

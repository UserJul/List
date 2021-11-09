using System;
using ArrayList;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List arrayList = new List(new int[] { 3, 5, 6, 1, 4 });
            arrayList.RemoveFirst();
            arrayList.ToArray();
        }
    }
}

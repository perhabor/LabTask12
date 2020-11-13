using System;

namespace DelegateApp
{
    public delegate string SpaceDel(string str);
    public delegate string ReverseDel(string str);

    class Program
    {
        static void Main(string[] args)
        {
            var testDel = new TestDelegate();
            SpaceDel spaceDel = testDel.Space;
            ReverseDel reverseDel = testDel.Reverse;
            Console.WriteLine(spaceDel("James"));
            Console.WriteLine(reverseDel("Banky"));
        }
    }
}
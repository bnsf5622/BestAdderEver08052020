using System;

namespace BestAdderEver08052020
{
    class Program
    {
        static void Main(string[] args)
        {

            int tapes, cds, collection;

            double number;

            tapes = 56;
            cds = 126;

            collection = cds + tapes;

            cds--;
            tapes--;
            Console.WriteLine(" tapes + cds ");
            Console.WriteLine("I have tapes + cds in my collection");
            Console.WriteLine(collection);
        }
    }
}
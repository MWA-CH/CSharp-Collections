using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArayList Expariment
            //*************************************************************************//
            /*ArrayList AL = new ArrayList();
            AL.Add(45);
            AL.Add(5);
            AL.Add(4);
            AL.Add(50);
            AL.Add(42);
            AL.Add(2);
            AL.Add(1);
            AL.Add(36);
            Console.WriteLine("Count : {0}", AL.Count);
            Console.Write("Content : ");
            foreach (int i in AL)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.Write("Sorted Content : ");
            AL.Sort();
            foreach (int i in AL)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();*/

            //HashTable Expariment
            //*********************************************************************************//
            /*Hashtable HT = new Hashtable();
            HT.Add("1", "Ali");
            HT.Add("2", "Aarib");
            HT.Add("3", "Abeha");
            HT.Add("4", "Abrisha");
            HT.Add("5", "Aisha");

            //Get a Collection of keys
            ICollection key = HT.Keys;

            foreach (var k in key)
            {
                Console.WriteLine(k + ":" + HT[k]);
            }*/

            //Stack Expariment
            //**********************************************************************************//

            /*Stack S = new Stack();
            S.Push('A');
            S.Push('G');
            S.Push('K');
            S.Push('P');
            Console.WriteLine("Current Stack");
            foreach (char c in S)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
            S.Push('Z');
            S.Push('Y');
            Console.WriteLine("After Push More Stack");
            foreach (char c in S)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
            S.Pop();
            S.Pop();
            S.Pop();
            Console.WriteLine("Now after pop");
            foreach (char c in S)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();*/

            //Queue Expariment
            //***************************************************************************//

            /*Queue Q = new Queue();
            Q.Enqueue('A');
            Q.Enqueue('D');
            Q.Enqueue('C');
            Q.Enqueue('B');
            Console.WriteLine("Current Queue");
            foreach (char c in Q)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
            Q.Enqueue('V');
            Q.Enqueue('Z');
            Console.WriteLine("Adding more items in Queue");
            foreach (char c in Q)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Removing some values");
            Q.Dequeue();
            Q.Dequeue();
            foreach (char c in Q)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();*/
        }
    }
}

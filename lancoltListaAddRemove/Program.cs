using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lancoltListaAddRemove
{
    public class OneChainList
    {
        // Add metódus (hozzáad egy elemet a listához)
        public void Add(List<int> list, int elem)
        {
            list.Add(elem);
        }

        // Remove metódus (eltávolítja a paraméterként átadott elemet a listából)
        public void Remove(List<int> list, int elem)
        {
            list.Remove(elem);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> myChainList = new List<int>();
            OneChainList oneChain = new OneChainList();

            // Elemek hozzáadása a listához
            oneChain.Add(myChainList, 10);
            oneChain.Add(myChainList, 20);
            oneChain.Add(myChainList, 15);

            // Elem eltávolítása a listából
            oneChain.Remove(myChainList, 20);

            // Kiíratás
            foreach (var item in myChainList)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}

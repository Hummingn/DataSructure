using DataStructure.DS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {

            
            SinglyLinkedList singlyLinkedList = new SinglyLinkedList();
            
            singlyLinkedList.Add(10);
            singlyLinkedList.Add(20);
            singlyLinkedList.Add(30);
            singlyLinkedList.Add(40);
            singlyLinkedList.Add(50);
            singlyLinkedList.Add(60);
            singlyLinkedList.Add(70);
            singlyLinkedList.Add(80);
            singlyLinkedList.Add(90);

            var length = singlyLinkedList.Length;
            var count = singlyLinkedList.Count();

            singlyLinkedList.Print();
            Console.WriteLine("\n");
            singlyLinkedList.Delete(8);
            

            Console.ReadLine();
        }
    }
}

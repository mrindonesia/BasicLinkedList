using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            HelperSLL SSLHELPER = new HelperSLL();
            SingleLinkedList MyLinkedList = new SingleLinkedList();

            SSLHELPER.InsertFirst(MyLinkedList, 20);
            SSLHELPER.InsertLast(MyLinkedList, 40);
            SSLHELPER.InsertLast(MyLinkedList, 60);
            SSLHELPER.InsertAfter(MyLinkedList.Head, 30);
            SSLHELPER.PrintLinkedList(MyLinkedList);
            Console.WriteLine();
            Console.WriteLine("Single Link List After Delete By Key [30] ");
            SSLHELPER.DeleteNodeByKey(MyLinkedList, 30);
            SSLHELPER.PrintLinkedList(MyLinkedList);
            Console.WriteLine();
            Console.WriteLine("Single Link List After Delete By Position [1] ");
            SSLHELPER.DeleteNodeByPosition(MyLinkedList, 1);
            SSLHELPER.PrintLinkedList(MyLinkedList);
            Console.WriteLine();
            SSLHELPER.FindMiddle(MyLinkedList);
            Console.WriteLine();
            SSLHELPER.SearchLinkList(MyLinkedList, 20);
            Console.WriteLine();
            SSLHELPER.ReverseLinkList(MyLinkedList);
            SSLHELPER.PrintLinkedList(MyLinkedList);

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLinkedList
{
    public class SingleLinkedList
    {
        internal Node Head;
    }

    internal class Node
    {
        internal int Data;
        internal Node Next;

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }

    internal class HelperSLL
    {
       internal SingleLinkedList CreateLinkList()
        {
            SingleLinkedList llist = new SingleLinkedList();
            llist.Head = new Node(1);
            Node Secon = new Node(2);
            Node Third = new Node(3);

            llist.Head.Next = Secon;
            Secon.Next = Third;

            return llist;
        }

       internal void InsertFirst(SingleLinkedList SinglyList, int NewData)
       {
           Node NewNode = new Node(NewData);
           NewNode.Next = SinglyList.Head;
           SinglyList.Head = NewNode;
       }

       internal void InsertAfter(Node PrevNode, int NewData)
       {
           if(PrevNode == null)
           {
               Console.WriteLine("The given previous node cannot be null");
               return;
           }

           Node NewNode = new Node(NewData);
           NewNode.Next = PrevNode.Next;
           PrevNode.Next = NewNode;
       }

       internal void InsertLast(SingleLinkedList SinglyList, int NewData)
       {
           Node NewNode = new Node(NewData);
           if(SinglyList.Head == null)
           {
               SinglyList.Head = NewNode;
               return;
           }

           Node LastNode = GetLastNode(SinglyList);
           LastNode.Next = NewNode;
       }

       internal Node GetLastNode(SingleLinkedList SinglyList)
       {
           Node temp = SinglyList.Head;
           while(temp.Next != null)
           {
               temp = temp.Next;
           }
           return temp;
       }

       internal void PrintLinkedList(SingleLinkedList SinglyList)
       {
           Node n = SinglyList.Head;
           while(n != null)
           {
               Console.Write(n.Data + " ");
               n = n.Next;
           }
       }

       internal void DeleteNodeByKey(SingleLinkedList SinglyList, int Key)
       {
           Node Temp = SinglyList.Head;
           Node Prev = null;

           if(Temp != null && Temp.Data == Key)
           {
               SinglyList.Head = Temp.Next;
               return;
           }

           if(Temp != null && Temp.Data != Key)
           {
               Prev = Temp;
               Temp = Temp.Next;
           }

           if(Temp == null)
           {
               return;
           }

           Prev.Next = Temp.Next;
       }

       internal void DeleteNodeByPosition(SingleLinkedList SinglyList, int Position)
       {
           if(SinglyList.Head == null)
           {
               return;
           }

           Node Temp = SinglyList.Head;

           if(Position == 0)
           {
               SinglyList.Head = Temp.Next;
               return;
           }

           for (int i = 0; Temp != null && i < Position - 1; i++)
           {
               Temp = Temp.Next;
           }

           if(Temp == null || Temp.Next == null)
           {
               return;
           }

           Node NextNode = Temp.Next.Next;
           Temp.Next = NextNode;
       }

       internal void FindMiddle(SingleLinkedList SinglyList)
       {
           Node SlowPtr = SinglyList.Head;
           Node FastPtr = SinglyList.Head;

           if(SinglyList.Head != null)
           {
               while(FastPtr != null && FastPtr.Next != null)
               {
                   FastPtr = FastPtr.Next.Next;
                   SlowPtr = SlowPtr.Next;
               }
               Console.WriteLine("The middle element is {0} " + SlowPtr.Data);
           }
       }

       internal void SearchLinkList(SingleLinkedList SinglyList, int value)
       {
           Node Temp = SinglyList.Head;
           while(Temp != null)
           {
               if(Temp.Data == value)
               {
                   Console.WriteLine("The element {0} is present in linked list", value);
                   return;
               }
               Temp = Temp.Next;
           }
           Console.WriteLine("The element {0} is not present in linked list", value);
       }

       internal void ReverseLinkList(SingleLinkedList SinglyList)
       {
           Node Prev = null;
           Node Current = SinglyList.Head;
           Node Temp = null;

           while(Current != null)
           {
               Temp = Current.Next;
               Current.Next = Prev;
               Prev = Current;
               Current = Temp;
           }

           SinglyList.Head = Prev;
       }
    }
}

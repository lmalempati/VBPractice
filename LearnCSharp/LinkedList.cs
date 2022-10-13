using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    using System;
    public class Node
    {
        public int data;
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }

    }
    public class Solution
    {
        public static Node insert(Node head, int data)
        {
            //Complete this method
            Node newNode = null;
            if (head == null)
            {
                head = new Node(data);
                // Console.WriteLine("head is null");
                return head;
            }
            else
            {
                newNode = new Node(data);
                
                Node nextNode = head.next;
                while (nextNode != null)
                {
                    if (nextNode.next != null)
                        nextNode = nextNode.next;
                    else
                        break;
                }
                if (nextNode != null)
                    nextNode.next = newNode;
                else
                    head.next = newNode;

                return head;
                // Console.WriteLine("head is not null");
            }
        }

        public static void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                Console.ReadLine();
                start = start.next;
            }
        }
        public static void ReadInput()
        {

            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            display(head);
        }
    }

}

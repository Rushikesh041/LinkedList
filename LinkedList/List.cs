using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class List
    {
        internal Node head;
        public void Add(int data)
        {
            Node node = new Node(data);

            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine($"{node.data} is Inserted in Linked List");
        }
        internal Node InsertAtParticularPosition(int position, int data)
        {
            Node temp = head;
            if (position < 1)
            {
                Console.WriteLine("Invalid Position");
            }
            if (position == 1)
            {
                Node newNode = new Node(data);
                newNode.next = temp;
                temp = newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        var node = new Node(data);
                        node.next = temp.next;
                        temp.next = node;
                        break;
                    }
                    temp = temp.next;
                }
                if (position != 1)
                    Console.WriteLine("Position out of range");
            }
            Console.WriteLine();
            Console.WriteLine("Inserted value is : " + data);
            return temp;
        }
        internal Node RemoveFirstNode()
        {
            if (head == null)
            {
                return null;
            }
            head = head.next;
            return head;
        }
        internal Node RemoveLastNode()
        {
            if (head == null)
            {
                return null;
            }
            if (head.next == null)
            {
                return null;
            }
            Node newNode = head;
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            newNode.next = null;
            return head;
        }
        internal Node Search(int value)
        {
            int Count = 1;
            Node temp = head;
            while (temp != null)
            {
                if (temp.data == value)
                {

                    Console.WriteLine($"\nThe {value} is at Node : " + Count);

                    return temp;
                }
                temp = temp.next;
                Count++;
            }
            return null;
        }
        public void Display()
        {

            int i = 1;
            Node temp = head;

            Console.WriteLine();
            if (temp == null)
            {
                Console.WriteLine("LinkedList is Empty");
            }
            while (temp != null)
            {
                Console.WriteLine($"Element {i} in Linked List is : " + temp.data);
                temp = temp.next;
                i++;

            }
        }
        
    }
}

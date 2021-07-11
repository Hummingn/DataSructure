using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.DS
{
    public class SinglyLinkedList
    {
        private Node _head { get; set; }
        private int _length { get; set; }

        public int Length { get { return _length; } }


        public SinglyLinkedList()
        {
            _head = null;
            _length = 0;
        }

        public SinglyLinkedList(int data)
        {
            _head = new Node(data);
            _length = 1;
        }



        public void Add(int data)
        {
            if (_head == null)
            {
                _head = new Node(data);
                _length = 1;
            }
            else
            {
                Node temp = _head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                Node newNode = new Node(data);
                temp.Next = newNode;

                _length++;
            }
        }

        public void Delete(int position)
        {
            if (_head == null)
            {
                throw new Exception("List is empty");
            }
            else if (position >= _length)
            {
                throw new Exception("Delete index is greater than length");
            }
            else
            {
                if (position == 0)
                {
                    _head = _head.Next;                    
                }
                else
                {
                    int i = 0;
                    Node temp = _head;
                    while (i < position - 1)
                    {
                        temp = temp.Next;
                        i++;
                    }

                    if(temp.Next.Next==null)
                    {
                        temp.Next = null;
                    }
                    else
                    {
                        temp.Next = temp.Next.Next;
                    }
                }
            }
            _length--;
        }

        public void Print()
        {
            if (_head == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                Node temp = _head;
                int index = 0;
                while (temp != null)
                {
                    Console.WriteLine(index + " : " + temp.Data);
                    temp = temp.Next;
                    index++;
                }
            }
        }

        public int Count()
        {
            return _length;
        }
    }

    internal class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }
}

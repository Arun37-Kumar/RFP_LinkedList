﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    class Queue
    {
       Node head = null;

        //Add element
        public void Enqueue(int data)
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
                Console.WriteLine("{0} inserted into Queue.", node.data);
            }
        }

            //Display the queue
            public void Display()
            {
                Node temp = this.head;
                if(temp == null)
                {
                    Console.WriteLine("Queue is empty");
                    return;
                }
                while(temp != null){
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
            }

        public void Dequeu()
        {
            Node temp = this.head;
            if(temp == null)
            {
                Console.WriteLine("Queue is empty!");
            }
            else
            {
                head = head.next;
                temp = this.head; ;
            }
                Console.WriteLine("{0} is deleted.",temp);
        }

        }
    }


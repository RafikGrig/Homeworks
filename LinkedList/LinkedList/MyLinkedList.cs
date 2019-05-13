using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class MyLinkedList<T>
    {

        Node<T> head;

        public void Add(T data)
        {
            Node<T> node = new Node<T>();
            node.data = data;
            if (head == null)
            {
                head = node;

            }
            else
            {
                Node<T> tmp = head;
                while (tmp.next != null)
                {
                    tmp = tmp.next;
                }
                tmp.next = node;
            }
            
        }

        public IEnumeratorMy<T> GetEnumerator()
        {
            return new IteratorList<T>(head);
        }

        public void ShowNods()
        {
            Node<T> tmp = head;
            while (tmp != null)
            {
                Console.WriteLine(tmp.data);
                tmp = tmp.next;
            }


        }

    
    }
}

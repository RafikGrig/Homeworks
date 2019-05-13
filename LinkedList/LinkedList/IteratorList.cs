using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
     public class IteratorList<T>: IEnumeratorMy<T>
    {
        Node<T> nd;
        Node<T> tmpres;
        public IteratorList(Node<T> node)
        {
            nd = node;
        }
        public T Current
        {
            get
            {
                if (nd != null)
                    return nd.data;
                else return default(T);
            }
        }

       



        public bool MoveNext()
        {
            if (nd != null)
            {
                nd = nd.next;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            nd = tmpres;
        }
    }
}

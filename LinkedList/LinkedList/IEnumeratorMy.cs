using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public interface IEnumeratorMy<T>
    {
        T Current { get; }
        bool MoveNext();
        void Reset();
    }
}

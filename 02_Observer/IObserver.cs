using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Observer
{
    internal interface IObserver
    {
        string Update(decimal price);
    }
}

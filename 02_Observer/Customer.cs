using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Observer
{
    internal class Customer : IObserver
    {
        public string Name { get; set; }
        public string Update(decimal price)
        {
            return $"Ürün artık {price} fiyatından satılıyor. Müşteri adı : {Name}";
        }
    }
}

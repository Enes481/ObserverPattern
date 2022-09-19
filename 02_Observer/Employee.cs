using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Observer
{
    internal class Employee : IObserver
    {
        public string Name { get; set; }

        public string Update(decimal price)
        {
            return $"Çalışan ürünü artık {price} fiyatından teklif edecek. Çalışan adı : {Name}";
        }
    }
}

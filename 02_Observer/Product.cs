using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Observer
{
    internal class Product
    {
        List<IObserver> observers;
        decimal price;

        public Product()
        {
            observers = new List<IObserver>();
        }

        public string Name { get; set; }
        public string Info { get; set; }
        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                if (price == 0)
                {
                    price = value;
                }
                else
                {
                    price = value;
                    Info = Notify();
                }
            }
        }

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        private string Notify()
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (IObserver item in observers)
            {
                stringBuilder.AppendLine(item.Update(price));
            }

            return stringBuilder.ToString();
        }
    }
}

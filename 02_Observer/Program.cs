using System;

namespace _02_Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product() { Price = 20 };

            Employee employee1 = new Employee() { Name="Fermat" };
            Employee employee2 = new Employee() { Name="Marty" };

            Customer customer1 = new Customer() { Name = "Stanley" };
            Customer customer2 = new Customer() { Name = "Sergen" };

            product.AddObserver(employee1);
            product.AddObserver(employee2);
            product.AddObserver(customer1);
            product.AddObserver(customer2);

            product.Price = 30;
            Console.WriteLine(product.Info);

            Console.WriteLine("---------------------");

            product.RemoveObserver(customer1);

            product.Price = 25;
            Console.WriteLine(product.Info);


            // .NET Observer Pattern
            //IObserver<>
            //IObservable<>

            Console.ReadKey();
        }
    }
}

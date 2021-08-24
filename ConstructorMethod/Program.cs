using System;

namespace ConstructorMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstName = "İsa", LastName = "Demir", City = "Ordu" };

            Customer customer2 = new Customer(2, "Züleyha", "Demir", "Ordu");

            Console.WriteLine(customer1.FirstName);
            Console.WriteLine(customer2.FirstName);
        }
    }

    class Customer
    {
        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        //ctor -> yazıp tab tab yaparsak otomatik yazar
        public Customer() //Default Constructor
        {
            Console.WriteLine("Constructor Çalıştı");
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }


}

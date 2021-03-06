using System;

namespace DegerReferans
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };

            sayilar1 = sayilar2;
            sayilar2[0] = 1000;
            Console.WriteLine(sayilar1[0]);

            Person person1 = new Person();
            Person person2 = new Person();

            person1.FirstName = "İsa";
            person2 = person1; //Değer eşitlemesi değil, adres eşitlemesi yapılır.
            person1.FirstName = "Halil";
            
            Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();
            Employee employee = new Employee();
            employee.EmployeeNumber = 123;

            customer.FirstName = "Salih";
            Person person3 = customer; //Person3 customerın adresini tutar.
            Console.WriteLine(person3.FirstName);
            customer.CreditCardNumber = "9999999999";

           // Console.WriteLine(((Customer)person3).CreditCardNumber);
            PersonManager personManager = new PersonManager();
            personManager.Add(employee);
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    //base class : Person
    class Customer : Person
    {
        public string CreditCardNumber { get; set; }

    }

    class Employee : Person
    {
        public int EmployeeNumber { get; set; }

    }

    class PersonManager
    {
        public void Add(Person person)
        {

            Console.WriteLine(person.CreditCardNumber);

            if (person is Customer)
            {
                Console.WriteLine(person.CreditCardNumber);
            }
            else if (person is Employee)
            {
                Console.WriteLine(person.EmployeeNumber);
            }
            else
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }

}

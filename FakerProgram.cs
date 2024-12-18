using System;
using Bogus;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a Faker instance for a Person

            var personFaker = new Faker<Person>()
                .RuleFor(p => p.Id, f => f.Random.Int(1, 1000))
                .RuleFor(p => p.Email, f => f.Internet.Email())
                .RuleFor(p => p.FirstName, f => f.Name.FirstName())
                .RuleFor(p => p.PhoneNumber, f => f.Phone.PhoneNumber())
                .RuleFor(p=> p.Address , f => f.Address.FullAddress())
                .RuleFor(p => p.CreditCard, f => f.Finance.CreditCardNumber());


            // Generate and display a fake person object
            var fakePerson = personFaker.Generate();
            Console.WriteLine($"ID: {fakePerson.Id}");
            Console.WriteLine($"FirstName: {fakePerson.FirstName}");
            Console.WriteLine($"Email: {fakePerson.Email}");
            Console.WriteLine($"Address: {fakePerson.Address}");            
            Console.WriteLine($"Phone: {fakePerson.PhoneNumber}");
            Console.WriteLine($"Credit Card: {fakePerson.CreditCard}");
        }
    }
    // Define the Person class
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set;}     
        public string Email { get; set;}
        public string Address { get; set;}
        public string PhoneNumber { get; set;}
        public string CreditCard { get; set;}
    }
}

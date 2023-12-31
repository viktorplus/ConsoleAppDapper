using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDapper
{
    public class Customers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateOnly BirthDate { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string City { get; set; }

        public Customers() { }

        public Customers (int iD, string name, DateOnly birthDate, string gender, string email, string country, string city)
        {
            Id = iD;
            Name = name;
            BirthDate = birthDate;
            Gender = gender;
            Email = email;
            Country = country;
            City = city;
        }
        public override string ToString()
        {
            return $"Id: {Id}\nName: {Name}, Gender: {Gender}\nEmail: {Email}\nCountry: {Country}, City: {City}\n";
        }
    }

}

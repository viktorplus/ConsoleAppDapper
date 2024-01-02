using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDapper
{
    public class PromoGoods
    {
        public int Id { get; set; }
        public string Section { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }

        public PromoGoods() { }

        public PromoGoods(int id, string section, string name, string country, DateOnly startDate, DateOnly endDate)
        {
            Id = id;
            Section = section;
            Name = name;
            Country = country;
            StartDate = startDate;
            EndDate = endDate;
        }
        public override string ToString()
        {
            return $"Id: {Id}\nSection: {Section}\nName: {Name}\nCountry: {Country}\nStartDate: {StartDate}\nEndDate: {EndDate}\n";
        }
    }
}

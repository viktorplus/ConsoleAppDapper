using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDapper
{
    public class Subsribe
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int SectionId { get; set; }
        public Subsribe() { }

        public Subsribe(int id, int customerId, int SectionId)
        {
            Id = id;
            CustomerId = customerId;
            SectionId = SectionId;
        }
        public override string ToString()
        {
            return $"Id: {Id}\nCustomerId: {CustomerId}\nSectionId: {SectionId}\n";
        }
    }
}

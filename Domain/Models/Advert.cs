using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Advert
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Place { get; set; }
        public string Salary { get; set; }
        public string Description { get; set; }
        public Subcategory Subcategory { get; set; }
        public List<Characteristic> Characteristics { get; set; }
        public List<Contact> Contacts { get; set; }
        public string Video { get; set; }
        public string Photo { get; set; }
    }
}

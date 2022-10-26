 using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Subcategory
    {
        public int Id { get; set; }
        public Category Category { get; set; }
        public string Name { get; set; }
        public List<string> Chars { get; set; }
    }
}

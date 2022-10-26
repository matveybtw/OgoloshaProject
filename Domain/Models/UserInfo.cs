using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class UserInfo
    {
        public int Id { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Place { get; set; }
        public string Photo { get; set; }
        public string Description { get; set; }
    }
}

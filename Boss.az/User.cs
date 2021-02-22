using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss.az
{
    abstract class User
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string Username { get; set; }
        public string Password { get; set; }        
        public string Name { get; set; }    
        public string Surname { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public short Age { get; set; }

    }
}

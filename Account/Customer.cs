using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Customer
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }


        public Customer()
        {

        }
        public Customer(int id, string fname, string lname, string email)
        {
            this.Id = id;
            this.Fname = fname;
            this.Lname = lname;
            this.Email = email;
        }
    }
}

    


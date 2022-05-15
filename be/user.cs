using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace be
{
    public class user : IdentityUser
    {
        public string name { get; set; }
        public string pass { get; set; }
        public string family { get; set; }
        public string mobile { get; set; }
        public string address { get; set; }
        public string post { get; set; }
    }
}

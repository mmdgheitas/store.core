using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace be
{
    public class human
    {
        public int id { get; set; }
        public string name { get; set; }
        public string family { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string mobile { get; set; }
        public string address { get; set; }
        public string post { get; set; }
        public List<Items> items { get; set; }
    }

}
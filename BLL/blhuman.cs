using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using be;
using DAL;
namespace BLL
{
    public class blhuman
    {
        public string create(user h)
        {
            dahuman dah = new dahuman();
            string r = dah.create(h).ToString();
            return r;
        }
        public string update(user h)
        {
            dahuman dah = new dahuman();
            string r = dah.update(h);
            return r;
        }
        public user login(string username, string password)
        {
            dahuman dah = new dahuman();
            user h = dah.login(username, password);
            return h;
        }
        public user find_by_id(string id)
        {
            dahuman dah = new dahuman();
            user h = dah.find_by_id(id);
            return h;
        }
    }
}

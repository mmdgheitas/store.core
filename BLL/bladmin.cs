using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using be;
using DAL;

namespace BLL
{
    public class bladmin
    {
        
        public bool add( Items item)
        {
            daadmin daa = new daadmin();
            return daa.add(item);
        }
        public List<be.Items> readall()
        {
            daadmin daa = new daadmin();
            return daa.readall();
        }
        public be.Items read_by_id(int id)
        {
            daadmin daa = new daadmin();
            return daa.read_by_id(id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using be;


namespace DAL
{
    public class daadmin
    {
        database db = new database();
        public bool add(Items item)
        {
            db.items.Add(item);
            db.SaveChanges();
            return true;
        }
        public List<be.Items> readall()
        {
            var q = from i in db.items select i;
            return q.ToList();
        }
        public be.Items read_by_id(int id)
        {
            var q = from i in db.items where i.id == id select i;
            return q.Single();
        }
    }
}

using myCRM_BL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCRM_BL.Control
{
   public class ControlDataBase <T> where T:class
    {
        myCRMContext context;
        // Product product_;
     //   DbSet<T> set_ ;

      


        public void addProduct( T p )
        
        {
            
            context = new myCRMContext();
            var dbSet = context.Set(typeof(T));
           // context.Set(typeof(T));

            var entity = dbSet.Create();
            dbSet.Add(entity);
            DbEntityEntry entry = context.Entry(entity);
            entry.CurrentValues.SetValues(p);
// context.add(p) ;

            context.SaveChanges();                           

        }



    }
}

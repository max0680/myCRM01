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
    
      


        public void AddToCatalog( T p )
        {            
            context = new myCRMContext();
            var dbSet = context.Set(typeof(T));
          

            var entity = dbSet.Create();
            dbSet.Add(entity);
            DbEntityEntry entry = context.Entry(entity);
            entry.CurrentValues.SetValues(p);
            context.SaveChanges();                           
        }

        public void DeleteFromCatalog(T entity ) 
        {
        myCRMContext context1;
            context1 = new myCRMContext();            
           // var dbSet = context.Set(typeof(T));
            // var entity = dbSet.Create();
            //dbSet.Remove(entity);
            //DbEntityEntry entry = context.Entry(entity);
            //entry.CurrentValues.SetValues(p);
           // var i = dbSet. Find(1);
            context1.Entry<T>(entity).State=EntityState.Deleted;
            
            context1.SaveChanges();                               
        }

        public T FindSelectedItem(int id)
        {
            myCRMContext context2 = new myCRMContext();
            var dbSet = context2.Set<T>().Find(id);
            // //var entity = dbSet.Create();
          // T i =dbSet.Find(id);
            // ////var o=context.Checks.
             return dbSet; 
        }



    }
}

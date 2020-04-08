using myCRM_BL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCRM_BL.Control
{
   public class ControlDataBase <T> where T:class
    {
        myCRMContext context;
        // Product product_;
        DbSet<T> set_ ;

      


        public void addProduct( T p )
        
        {
          
            context = new myCRMContext();
           
            
            context.Products.Add(p) ;

            context.SaveChanges();                           

        }



    }
}

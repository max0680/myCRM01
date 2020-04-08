using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using myCRM_BL.Model;

namespace myCRM
{
    public partial class Catalog<T> : Form where T : class
    {

        myCRMContext db= new myCRMContext();
        DbSet<T> set;

        public Catalog(DbSet<T> set )
        {



            InitializeComponent();
          
          //  this.db = db;
           this.set = set;
           
            set.Load();
            dataGridView1.DataSource = set.Local.ToBindingList();
        }

        private void Catalog_Load(object sender, EventArgs e)
        {

        }

        private void btAdd_Click(object sender, EventArgs e)
        {

            if (typeof(T)==typeof(Customer))
            {
                var frCustomer = new CustomerForms();
                frCustomer.Show();

            } else
                if (typeof(T) == typeof(Seller))
            {
                var frSeller = new SellerForms();
                frSeller.Show();
            } else

             if (typeof(T) == typeof(Product))
            {
                var frProduct = new ProductsForms();

                frProduct.AddProduct += LoadDataBase;
                frProduct.Show();
            }
        }

        private void LoadDataBase()
        {
            //this.set = set;
            
            set.Load();
            dataGridView1.DataSource = set.Local.ToBindingList();
        }



    }
}

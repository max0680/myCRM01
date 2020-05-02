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
using myCRM_BL.Control;

namespace myCRM
{
    public partial class Catalog<T> : Form where T : class
    {

        myCRMContext db= new myCRMContext();
        DbSet<T> set;
        

        public Catalog(DbSet<T> set )
        {
                    
            InitializeComponent();
                 
           this.set = set;
            LoadDataBase();
        }

        private void Catalog_Load(object sender, EventArgs e)
        {

        }

        private void btAdd_Click(object sender, EventArgs e)
        {

            if (typeof(T)==typeof(Customer))
            {
                var frCustomer = new CustomerForms();
                frCustomer.UpdateTable += LoadDataBase;
                frCustomer.Show();

            } else
                if (typeof(T) == typeof(Seller))
            {
                var frSeller = new SellerForms();
                frSeller.AddCustomer += LoadDataBase;

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
            
            set.Load();
            dataGridView1.DataSource = set.Local.ToBindingList();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {


        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {

                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                var clDB = new ControlDataBase<T>();
                clDB.DeleteFromCatalog(id);
                LoadDataBase();
            } else
            {
                MessageBox.Show("НЕ ВЫБРАНЫ СТРОКИ");
            }
            


           
        }
    }
}

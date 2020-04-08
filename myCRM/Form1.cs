using myCRM_BL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myCRM
{
    public partial class Form1 : Form
    {
        myCRMContext db;

        public Form1()
        {
            InitializeComponent();
            db = new myCRMContext();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {


        }

       

        private void ProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Catalog<Product>(db.Products);
            frm.ShowDialog();
        }

        private void SellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Catalog<Seller>(db.Sellers);
            frm.ShowDialog();
        }

        private void CustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Catalog<Customer>(db.Customers);
            frm.ShowDialog();
        }



    }
}

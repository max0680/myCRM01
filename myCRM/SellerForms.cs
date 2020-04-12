using myCRM_BL.Control;
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
    public partial class SellerForms : Form
    {
        public event Action AddCustomer;
        public SellerForms()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var c = new Seller();
            c.Name = textBox1.Text;

            var Control = new ControlDataBase<Seller>();
            Control.addProduct(c);



            AddCustomer();

            Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using myCRM_BL.Model;

namespace myCRM
{
    public partial class CustomerForms : Form
    {
       public Customer Customer { get; set; }
        public CustomerForms()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var c = new Customer();
            c.Name = textBox1.Text;
            Close();

        }
    }
}

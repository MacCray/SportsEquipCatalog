using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsEquipCatalog
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        CatalogForm parent;
        private void OrderForm_Load(object sender, EventArgs e)
        {
            parent = Owner as CatalogForm;
            listBox1.DataSource = parent.eqForOrder;
            listBox1.DisplayMember = "Name";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            parent.orders.Add(new Order(parent.eqForOrder, (int)numericUpDown1.Value, new Client(textBox1.Text, textBox2.Text, checkBox1.Checked)));
            foreach(var eq in parent.eqForOrder)
            {
                parent.catalog.Find(e => e.Name == eq.Name).Available = false;
            }
            parent.eqForOrder.Clear();
            if(MessageBox.Show("Заказ оформлен","Инфо", MessageBoxButtons.OK) == DialogResult.OK) Close();
        }                       
    }
}

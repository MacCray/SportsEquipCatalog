namespace SportsEquipCatalog
{
    public partial class CatalogForm : Form
    {
        public List<Equipment> catalog = new()
        {
            new Equipment("����", 1100, true),
            new Equipment("��������", 1200, true),
            new Equipment("������", 150, true),
            new Equipment("���������", 900, true),
            new Equipment("�����������", 450, true)
        };
        public List<Order> orders = new();
        public List<Equipment> eqForOrder = new();
        public CatalogForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = catalog;
            dataGridView1.Columns[0].HeaderText = "������������";
            dataGridView1.Columns[1].HeaderText = "���� ������";
            dataGridView1.Columns[2].HeaderText = "�����������";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Selected)
            {
                AddToOrderBtn.Visible = (bool)dataGridView1.CurrentRow.Cells[2].Value;
            }
        }

        private void AddToOrderBtn_Click(object sender, EventArgs e)
        {
            if(!eqForOrder.Contains(catalog[dataGridView1.CurrentRow.Index])) eqForOrder.Add(catalog[dataGridView1.CurrentRow.Index]);
        }

        private void Checkout_Click(object sender, EventArgs e)
        {
            AddToOrderBtn.Visible = false;
            OrderForm orderForm = new ();
            orderForm.Owner = this;
            orderForm.ShowDialog();
        }

        private void CatalogForm_Enter(object sender, EventArgs e)
        {

        }
    }
}
namespace SportsEquipCatalog
{
    partial class CatalogForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddToOrderBtn = new System.Windows.Forms.Button();
            this.Checkout = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddToOrderBtn
            // 
            this.AddToOrderBtn.Location = new System.Drawing.Point(485, 12);
            this.AddToOrderBtn.Name = "AddToOrderBtn";
            this.AddToOrderBtn.Size = new System.Drawing.Size(303, 119);
            this.AddToOrderBtn.TabIndex = 0;
            this.AddToOrderBtn.Text = "Добавить в корзину";
            this.AddToOrderBtn.UseVisualStyleBackColor = true;
            this.AddToOrderBtn.Visible = false;
            this.AddToOrderBtn.Click += new System.EventHandler(this.AddToOrderBtn_Click);
            // 
            // Checkout
            // 
            this.Checkout.Location = new System.Drawing.Point(485, 320);
            this.Checkout.Name = "Checkout";
            this.Checkout.Size = new System.Drawing.Size(303, 118);
            this.Checkout.TabIndex = 1;
            this.Checkout.Text = "Оформить заказ";
            this.Checkout.UseVisualStyleBackColor = true;
            this.Checkout.Click += new System.EventHandler(this.Checkout_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(467, 426);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // CatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Checkout);
            this.Controls.Add(this.AddToOrderBtn);
            this.Name = "CatalogForm";
            this.Text = "Form1";
            this.Enter += new System.EventHandler(this.CatalogForm_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button AddToOrderBtn;
        private Button Checkout;
        private DataGridView dataGridView1;
    }
}
namespace Shop_Management_System
{
    partial class Items
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Items));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.ItemsPanel = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.ItemText = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BillingPanel = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.BillingText = new System.Windows.Forms.Label();
            this.CustomerPanel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Customer = new System.Windows.Forms.Label();
            this.CategoriesPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CategoriesText = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.CloseBtn = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ItemTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.PriceTb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.StockTb = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ManufacturerTb = new System.Windows.Forms.TextBox();
            this.CategoryTb = new System.Windows.Forms.ComboBox();
            this.categoryTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hardwareDbDataSet = new Shop_Management_System.HardwareDbDataSet();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.AddItemBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.ItemList = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.categoryTblTableAdapter = new Shop_Management_System.HardwareDbDataSetTableAdapters.CategoryTblTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.ItemsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.BillingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.CustomerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.CategoriesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardwareDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.ItemsPanel);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.BillingPanel);
            this.panel1.Controls.Add(this.CustomerPanel);
            this.panel1.Controls.Add(this.CategoriesPanel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 674);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(19, 12);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(160, 99);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 8;
            this.pictureBox7.TabStop = false;
            // 
            // ItemsPanel
            // 
            this.ItemsPanel.BackColor = System.Drawing.Color.DarkCyan;
            this.ItemsPanel.Controls.Add(this.pictureBox6);
            this.ItemsPanel.Controls.Add(this.ItemText);
            this.ItemsPanel.Location = new System.Drawing.Point(6, 187);
            this.ItemsPanel.Name = "ItemsPanel";
            this.ItemsPanel.Size = new System.Drawing.Size(192, 45);
            this.ItemsPanel.TabIndex = 9;
            this.ItemsPanel.Click += new System.EventHandler(this.ItemsPanel_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(16, 8);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(48, 34);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            // 
            // ItemText
            // 
            this.ItemText.AutoSize = true;
            this.ItemText.ForeColor = System.Drawing.Color.White;
            this.ItemText.Location = new System.Drawing.Point(70, 11);
            this.ItemText.Name = "ItemText";
            this.ItemText.Size = new System.Drawing.Size(69, 25);
            this.ItemText.TabIndex = 4;
            this.ItemText.Text = "Items";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkCyan;
            this.panel6.Controls.Add(this.pictureBox5);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(3, 438);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(195, 45);
            this.panel6.TabIndex = 8;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(16, 8);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(48, 34);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(70, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dashboard";
            // 
            // BillingPanel
            // 
            this.BillingPanel.BackColor = System.Drawing.Color.DarkCyan;
            this.BillingPanel.Controls.Add(this.pictureBox4);
            this.BillingPanel.Controls.Add(this.BillingText);
            this.BillingPanel.Location = new System.Drawing.Point(3, 376);
            this.BillingPanel.Name = "BillingPanel";
            this.BillingPanel.Size = new System.Drawing.Size(195, 45);
            this.BillingPanel.TabIndex = 8;
            this.BillingPanel.Click += new System.EventHandler(this.BillingPanel_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(16, 8);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 34);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // BillingText
            // 
            this.BillingText.AutoSize = true;
            this.BillingText.ForeColor = System.Drawing.Color.White;
            this.BillingText.Location = new System.Drawing.Point(70, 11);
            this.BillingText.Name = "BillingText";
            this.BillingText.Size = new System.Drawing.Size(75, 25);
            this.BillingText.TabIndex = 4;
            this.BillingText.Text = "Billing";
            this.BillingText.Click += new System.EventHandler(this.BillingPanel_Click);
            // 
            // CustomerPanel
            // 
            this.CustomerPanel.BackColor = System.Drawing.Color.DarkCyan;
            this.CustomerPanel.Controls.Add(this.pictureBox3);
            this.CustomerPanel.Controls.Add(this.Customer);
            this.CustomerPanel.Location = new System.Drawing.Point(3, 313);
            this.CustomerPanel.Name = "CustomerPanel";
            this.CustomerPanel.Size = new System.Drawing.Size(195, 45);
            this.CustomerPanel.TabIndex = 8;
            this.CustomerPanel.Click += new System.EventHandler(this.CustomerPanel_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(16, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // Customer
            // 
            this.Customer.AutoSize = true;
            this.Customer.ForeColor = System.Drawing.Color.White;
            this.Customer.Location = new System.Drawing.Point(70, 11);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(109, 25);
            this.Customer.TabIndex = 4;
            this.Customer.Text = "Customer";
            // 
            // CategoriesPanel
            // 
            this.CategoriesPanel.BackColor = System.Drawing.Color.DarkCyan;
            this.CategoriesPanel.Controls.Add(this.pictureBox2);
            this.CategoriesPanel.Controls.Add(this.CategoriesText);
            this.CategoriesPanel.Location = new System.Drawing.Point(6, 249);
            this.CategoriesPanel.Name = "CategoriesPanel";
            this.CategoriesPanel.Size = new System.Drawing.Size(192, 45);
            this.CategoriesPanel.TabIndex = 8;
            this.CategoriesPanel.Click += new System.EventHandler(this.CategoriesPanel_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // CategoriesText
            // 
            this.CategoriesText.AutoSize = true;
            this.CategoriesText.ForeColor = System.Drawing.Color.White;
            this.CategoriesText.Location = new System.Drawing.Point(70, 11);
            this.CategoriesText.Name = "CategoriesText";
            this.CategoriesText.Size = new System.Drawing.Size(119, 25);
            this.CategoriesText.TabIndex = 4;
            this.CategoriesText.Text = "Categories";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 626);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 45);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(70, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Logout";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DarkCyan;
            this.panel8.Controls.Add(this.CloseBtn);
            this.panel8.Controls.Add(this.pictureBox8);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(198, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(975, 45);
            this.panel8.TabIndex = 3;
            // 
            // CloseBtn
            // 
            this.CloseBtn.AutoSize = true;
            this.CloseBtn.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseBtn.Location = new System.Drawing.Point(929, 8);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(34, 34);
            this.CloseBtn.TabIndex = 22;
            this.CloseBtn.Text = "X";
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(16, 8);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(48, 34);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 7;
            this.pictureBox8.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(70, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(426, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Hardware Shop Management System 2.0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(235, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "Item";
            // 
            // ItemTb
            // 
            this.ItemTb.Location = new System.Drawing.Point(240, 145);
            this.ItemTb.Name = "ItemTb";
            this.ItemTb.Size = new System.Drawing.Size(188, 32);
            this.ItemTb.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(460, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "Category";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(684, 100);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(61, 25);
            this.Price.TabIndex = 9;
            this.Price.Text = "Price";
            // 
            // PriceTb
            // 
            this.PriceTb.Location = new System.Drawing.Point(689, 145);
            this.PriceTb.Name = "PriceTb";
            this.PriceTb.Size = new System.Drawing.Size(188, 32);
            this.PriceTb.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(909, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 25);
            this.label11.TabIndex = 11;
            this.label11.Text = "Stock";
            // 
            // StockTb
            // 
            this.StockTb.Location = new System.Drawing.Point(914, 145);
            this.StockTb.Name = "StockTb";
            this.StockTb.Size = new System.Drawing.Size(188, 32);
            this.StockTb.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(552, 217);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(147, 25);
            this.label12.TabIndex = 13;
            this.label12.Text = "Manufacturer";
            // 
            // ManufacturerTb
            // 
            this.ManufacturerTb.Location = new System.Drawing.Point(557, 262);
            this.ManufacturerTb.Name = "ManufacturerTb";
            this.ManufacturerTb.Size = new System.Drawing.Size(188, 32);
            this.ManufacturerTb.TabIndex = 12;
            // 
            // CategoryTb
            // 
            this.CategoryTb.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.categoryTblBindingSource, "Name", true));
            this.CategoryTb.FormattingEnabled = true;
            this.CategoryTb.Items.AddRange(new object[] {
            "Power Supply",
            "Graphic Adapter",
            "Mainboard"});
            this.CategoryTb.Location = new System.Drawing.Point(465, 144);
            this.CategoryTb.Name = "CategoryTb";
            this.CategoryTb.Size = new System.Drawing.Size(190, 33);
            this.CategoryTb.TabIndex = 14;
            // 
            // categoryTblBindingSource
            // 
            this.categoryTblBindingSource.DataMember = "CategoryTbl";
            this.categoryTblBindingSource.DataSource = this.hardwareDbDataSet;
            // 
            // hardwareDbDataSet
            // 
            this.hardwareDbDataSet.DataSetName = "HardwareDbDataSet";
            this.hardwareDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Crimson;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(722, 333);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(139, 37);
            this.DeleteBtn.TabIndex = 17;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // AddItemBtn
            // 
            this.AddItemBtn.BackColor = System.Drawing.Color.Teal;
            this.AddItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddItemBtn.ForeColor = System.Drawing.Color.White;
            this.AddItemBtn.Location = new System.Drawing.Point(555, 333);
            this.AddItemBtn.Name = "AddItemBtn";
            this.AddItemBtn.Size = new System.Drawing.Size(139, 37);
            this.AddItemBtn.TabIndex = 18;
            this.AddItemBtn.Text = "Add Item";
            this.AddItemBtn.UseVisualStyleBackColor = false;
            this.AddItemBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.ForeColor = System.Drawing.Color.White;
            this.EditBtn.Location = new System.Drawing.Point(389, 333);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(139, 37);
            this.EditBtn.TabIndex = 19;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // ItemList
            // 
            this.ItemList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ItemList.BackgroundColor = System.Drawing.Color.White;
            this.ItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemList.Location = new System.Drawing.Point(240, 439);
            this.ItemList.Name = "ItemList";
            this.ItemList.RowHeadersWidth = 51;
            this.ItemList.RowTemplate.Height = 24;
            this.ItemList.Size = new System.Drawing.Size(891, 223);
            this.ItemList.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(552, 387);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 25);
            this.label13.TabIndex = 21;
            this.label13.Text = "Items List";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Crimson;
            this.label15.Location = new System.Drawing.Point(235, 58);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(206, 25);
            this.label15.TabIndex = 40;
            this.label15.Text = "Items Management";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // categoryTblTableAdapter
            // 
            this.categoryTblTableAdapter.ClearBeforeFill = true;
            // 
            // Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1173, 674);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ItemList);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddItemBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.CategoryTb);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ManufacturerTb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.StockTb);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.PriceTb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ItemTb);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Items";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ItemsPanel.ResumeLayout(false);
            this.ItemsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.BillingPanel.ResumeLayout(false);
            this.BillingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.CustomerPanel.ResumeLayout(false);
            this.CustomerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.CategoriesPanel.ResumeLayout(false);
            this.CategoriesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardwareDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel BillingPanel;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label BillingText;
        private System.Windows.Forms.Panel CustomerPanel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label Customer;
        private System.Windows.Forms.Panel CategoriesPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label CategoriesText;
        private System.Windows.Forms.Panel ItemsPanel;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label ItemText;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ItemTb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.TextBox PriceTb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox StockTb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ManufacturerTb;
        private System.Windows.Forms.ComboBox CategoryTb;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button AddItemBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.DataGridView ItemList;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label CloseBtn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private HardwareDbDataSet hardwareDbDataSet;
        private System.Windows.Forms.BindingSource categoryTblBindingSource;
        private HardwareDbDataSetTableAdapters.CategoryTblTableAdapter categoryTblTableAdapter;
    }
}
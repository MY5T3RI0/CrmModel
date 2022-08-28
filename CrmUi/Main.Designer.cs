namespace CrmUi
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.EntityStrip = new System.Windows.Forms.MenuStrip();
            this.EntityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SellersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddSellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.СheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EntityStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // EntityStrip
            // 
            this.EntityStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EntityToolStripMenuItem,
            this.ModelToolStripMenuItem});
            this.EntityStrip.Location = new System.Drawing.Point(0, 0);
            this.EntityStrip.Name = "EntityStrip";
            this.EntityStrip.Size = new System.Drawing.Size(500, 24);
            this.EntityStrip.TabIndex = 1;
            this.EntityStrip.Text = "EntityStrip";
            // 
            // EntityToolStripMenuItem
            // 
            this.EntityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CustomersToolStripMenuItem,
            this.SellersToolStripMenuItem,
            this.ProductsToolStripMenuItem,
            this.СheckToolStripMenuItem});
            this.EntityToolStripMenuItem.Name = "EntityToolStripMenuItem";
            this.EntityToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.EntityToolStripMenuItem.Text = "Сущности";
            // 
            // CustomersToolStripMenuItem
            // 
            this.CustomersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddCustomerToolStripMenuItem});
            this.CustomersToolStripMenuItem.Name = "CustomersToolStripMenuItem";
            this.CustomersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CustomersToolStripMenuItem.Text = "Покупатели";
            this.CustomersToolStripMenuItem.Click += new System.EventHandler(this.CustomersToolStripMenuItem_Click);
            // 
            // AddCustomerToolStripMenuItem
            // 
            this.AddCustomerToolStripMenuItem.Name = "AddCustomerToolStripMenuItem";
            this.AddCustomerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AddCustomerToolStripMenuItem.Text = "Добавить";
            this.AddCustomerToolStripMenuItem.Click += new System.EventHandler(this.AddCustomerToolStripMenuItem_Click);
            // 
            // SellersToolStripMenuItem
            // 
            this.SellersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddSellerToolStripMenuItem});
            this.SellersToolStripMenuItem.Name = "SellersToolStripMenuItem";
            this.SellersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SellersToolStripMenuItem.Text = "Продавцы";
            this.SellersToolStripMenuItem.Click += new System.EventHandler(this.SellersToolStripMenuItem_Click);
            // 
            // AddSellerToolStripMenuItem
            // 
            this.AddSellerToolStripMenuItem.Name = "AddSellerToolStripMenuItem";
            this.AddSellerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AddSellerToolStripMenuItem.Text = "Добавить";
            this.AddSellerToolStripMenuItem.Click += new System.EventHandler(this.AddSellerToolStripMenuItem_Click);
            // 
            // ProductsToolStripMenuItem
            // 
            this.ProductsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddProductToolStripMenuItem});
            this.ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem";
            this.ProductsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ProductsToolStripMenuItem.Text = "Товары";
            this.ProductsToolStripMenuItem.Click += new System.EventHandler(this.ProductsToolStripMenuItem_Click);
            // 
            // AddProductToolStripMenuItem
            // 
            this.AddProductToolStripMenuItem.Name = "AddProductToolStripMenuItem";
            this.AddProductToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AddProductToolStripMenuItem.Text = "Добавить";
            this.AddProductToolStripMenuItem.Click += new System.EventHandler(this.AddProductToolStripMenuItem_Click);
            // 
            // ModelToolStripMenuItem
            // 
            this.ModelToolStripMenuItem.Name = "ModelToolStripMenuItem";
            this.ModelToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.ModelToolStripMenuItem.Text = "Модель";
            this.ModelToolStripMenuItem.Click += new System.EventHandler(this.ModelToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(13, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(215, 412);
            this.listBox1.TabIndex = 2;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 24;
            this.listBox2.Location = new System.Drawing.Point(271, 54);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(215, 364);
            this.listBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Оплатить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(268, 28);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(37, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Войти";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // СheckToolStripMenuItem
            // 
            this.СheckToolStripMenuItem.Name = "СheckToolStripMenuItem";
            this.СheckToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.СheckToolStripMenuItem.Text = "Чеки";
            this.СheckToolStripMenuItem.Click += new System.EventHandler(this.CheksToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 466);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.EntityStrip);
            this.MainMenuStrip = this.EntityStrip;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.EntityStrip.ResumeLayout(false);
            this.EntityStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip EntityStrip;
        private System.Windows.Forms.ToolStripMenuItem EntityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SellersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddSellerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModelToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ToolStripMenuItem СheckToolStripMenuItem;
    }
}


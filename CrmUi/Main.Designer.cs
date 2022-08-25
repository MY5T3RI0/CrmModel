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
            this.SellersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CheksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddSellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddCheckToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.EntityStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // EntityStrip
            // 
            this.EntityStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EntityToolStripMenuItem});
            this.EntityStrip.Location = new System.Drawing.Point(0, 0);
            this.EntityStrip.Name = "EntityStrip";
            this.EntityStrip.Size = new System.Drawing.Size(800, 24);
            this.EntityStrip.TabIndex = 1;
            this.EntityStrip.Text = "EntityStrip";
            // 
            // EntityToolStripMenuItem
            // 
            this.EntityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CustomersToolStripMenuItem,
            this.SellersToolStripMenuItem,
            this.ProductsToolStripMenuItem,
            this.CheksToolStripMenuItem});
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
            // SellersToolStripMenuItem
            // 
            this.SellersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddSellerToolStripMenuItem});
            this.SellersToolStripMenuItem.Name = "SellersToolStripMenuItem";
            this.SellersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SellersToolStripMenuItem.Text = "Продавцы";
            this.SellersToolStripMenuItem.Click += new System.EventHandler(this.SellersToolStripMenuItem_Click);
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
            // CheksToolStripMenuItem
            // 
            this.CheksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddCheckToolStripMenuItem1});
            this.CheksToolStripMenuItem.Name = "CheksToolStripMenuItem";
            this.CheksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CheksToolStripMenuItem.Text = "Чеки";
            this.CheksToolStripMenuItem.Click += new System.EventHandler(this.CheksToolStripMenuItem_Click);
            // 
            // AddSellerToolStripMenuItem
            // 
            this.AddSellerToolStripMenuItem.Name = "AddSellerToolStripMenuItem";
            this.AddSellerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AddSellerToolStripMenuItem.Text = "Добавить";
            this.AddSellerToolStripMenuItem.Click += new System.EventHandler(this.AddSellerToolStripMenuItem_Click);
            // 
            // AddCustomerToolStripMenuItem
            // 
            this.AddCustomerToolStripMenuItem.Name = "AddCustomerToolStripMenuItem";
            this.AddCustomerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AddCustomerToolStripMenuItem.Text = "Добавить";
            // 
            // AddProductToolStripMenuItem
            // 
            this.AddProductToolStripMenuItem.Name = "AddProductToolStripMenuItem";
            this.AddProductToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AddProductToolStripMenuItem.Text = "Добавить";
            // 
            // AddCheckToolStripMenuItem1
            // 
            this.AddCheckToolStripMenuItem1.Name = "AddCheckToolStripMenuItem1";
            this.AddCheckToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.AddCheckToolStripMenuItem1.Text = "Добавить";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EntityStrip);
            this.MainMenuStrip = this.EntityStrip;
            this.Name = "Main";
            this.Text = "Main";
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
        private System.Windows.Forms.ToolStripMenuItem CheksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddSellerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddCheckToolStripMenuItem1;
    }
}


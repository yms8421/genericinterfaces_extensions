namespace BilgeAdam.GenericsAndInterfaces.GenericForms
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yönlendirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msbClients = new System.Windows.Forms.ToolStripMenuItem();
            this.msbPeople = new System.Windows.Forms.ToolStripMenuItem();
            this.msbProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.msbStudents = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yönlendirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // yönlendirToolStripMenuItem
            // 
            this.yönlendirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msbClients,
            this.msbPeople,
            this.msbProducts,
            this.msbStudents});
            this.yönlendirToolStripMenuItem.Name = "yönlendirToolStripMenuItem";
            this.yönlendirToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.yönlendirToolStripMenuItem.Text = "Yönlendir";
            // 
            // msbClients
            // 
            this.msbClients.Name = "msbClients";
            this.msbClients.Size = new System.Drawing.Size(180, 22);
            this.msbClients.Text = "Müşteriler";
            this.msbClients.Click += new System.EventHandler(this.msbClients_Click);
            // 
            // msbPeople
            // 
            this.msbPeople.Name = "msbPeople";
            this.msbPeople.Size = new System.Drawing.Size(180, 22);
            this.msbPeople.Text = "Rehber";
            this.msbPeople.Click += new System.EventHandler(this.msbPeople_Click);
            // 
            // msbProducts
            // 
            this.msbProducts.Name = "msbProducts";
            this.msbProducts.Size = new System.Drawing.Size(180, 22);
            this.msbProducts.Text = "Ürünler";
            this.msbProducts.Click += new System.EventHandler(this.msbProducts_Click);
            // 
            // msbStudents
            // 
            this.msbStudents.Name = "msbStudents";
            this.msbStudents.Size = new System.Drawing.Size(180, 22);
            this.msbStudents.Text = "Öğrenciler";
            this.msbStudents.Click += new System.EventHandler(this.msbStudents_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yönlendirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msbClients;
        private System.Windows.Forms.ToolStripMenuItem msbPeople;
        private System.Windows.Forms.ToolStripMenuItem msbProducts;
        private System.Windows.Forms.ToolStripMenuItem msbStudents;
    }
}
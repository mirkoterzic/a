namespace Menu
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.bojaPozadineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crvenaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zelenaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.žutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smeđaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crvenaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.plavaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox1.BackColor = System.Drawing.Color.Yellow;
            this.textBox1.Location = new System.Drawing.Point(12, 59);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 104);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Neki tekst u TextBox-u";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Poruka:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(268, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bojaPozadineToolStripMenuItem,
            this.bToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(268, 24);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // bojaPozadineToolStripMenuItem
            // 
            this.bojaPozadineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crvenaToolStripMenuItem,
            this.zelenaToolStripMenuItem,
            this.plavaToolStripMenuItem,
            this.žutaToolStripMenuItem});
            this.bojaPozadineToolStripMenuItem.Name = "bojaPozadineToolStripMenuItem";
            this.bojaPozadineToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.bojaPozadineToolStripMenuItem.Text = "Boja pozadine";
            // 
            // crvenaToolStripMenuItem
            // 
            this.crvenaToolStripMenuItem.Name = "crvenaToolStripMenuItem";
            this.crvenaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.crvenaToolStripMenuItem.Text = "Crvena";
            this.crvenaToolStripMenuItem.Click += new System.EventHandler(this.crvenaToolStripMenuItem_Click);
            // 
            // zelenaToolStripMenuItem
            // 
            this.zelenaToolStripMenuItem.Name = "zelenaToolStripMenuItem";
            this.zelenaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zelenaToolStripMenuItem.Text = "Zelena";
            this.zelenaToolStripMenuItem.Click += new System.EventHandler(this.zelenaToolStripMenuItem_Click);
            // 
            // plavaToolStripMenuItem
            // 
            this.plavaToolStripMenuItem.Name = "plavaToolStripMenuItem";
            this.plavaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.plavaToolStripMenuItem.Text = "Plava";
            this.plavaToolStripMenuItem.Click += new System.EventHandler(this.plavaToolStripMenuItem_Click);
            // 
            // žutaToolStripMenuItem
            // 
            this.žutaToolStripMenuItem.Name = "žutaToolStripMenuItem";
            this.žutaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.žutaToolStripMenuItem.Text = "Žuta";
            this.žutaToolStripMenuItem.Click += new System.EventHandler(this.žutaToolStripMenuItem_Click);
            // 
            // bToolStripMenuItem
            // 
            this.bToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crnaToolStripMenuItem,
            this.smeđaToolStripMenuItem,
            this.crvenaToolStripMenuItem1,
            this.plavaToolStripMenuItem1});
            this.bToolStripMenuItem.Name = "bToolStripMenuItem";
            this.bToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.bToolStripMenuItem.Text = "Boja teksta";
            // 
            // crnaToolStripMenuItem
            // 
            this.crnaToolStripMenuItem.Name = "crnaToolStripMenuItem";
            this.crnaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.crnaToolStripMenuItem.Text = "Crna";
            this.crnaToolStripMenuItem.Click += new System.EventHandler(this.crnaToolStripMenuItem_Click);
            // 
            // smeđaToolStripMenuItem
            // 
            this.smeđaToolStripMenuItem.Name = "smeđaToolStripMenuItem";
            this.smeđaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.smeđaToolStripMenuItem.Text = "Smeđa";
            this.smeđaToolStripMenuItem.Click += new System.EventHandler(this.smeđaToolStripMenuItem_Click);
            // 
            // crvenaToolStripMenuItem1
            // 
            this.crvenaToolStripMenuItem1.Name = "crvenaToolStripMenuItem1";
            this.crvenaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.crvenaToolStripMenuItem1.Text = "Crvena";
            this.crvenaToolStripMenuItem1.Click += new System.EventHandler(this.crvenaToolStripMenuItem1_Click);
            // 
            // plavaToolStripMenuItem1
            // 
            this.plavaToolStripMenuItem1.Name = "plavaToolStripMenuItem1";
            this.plavaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.plavaToolStripMenuItem1.Text = "Plava";
            this.plavaToolStripMenuItem1.Click += new System.EventHandler(this.plavaToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 241);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem bojaPozadineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crvenaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zelenaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plavaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem žutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crnaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smeđaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crvenaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem plavaToolStripMenuItem1;
    }
}


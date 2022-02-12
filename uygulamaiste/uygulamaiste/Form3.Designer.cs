namespace uygulamaiste
{
    partial class Form3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arkaPlanRengiDeğişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seçenekşerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öncekiSayfayaDönToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uygulamayıKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1038, 371);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Önceki Sayfaya Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arkaPlanRengiDeğişToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(190, 48);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ContextMenuStrip = this.contextMenuStrip1;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seçenekşerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1056, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arkaPlanRengiDeğişToolStripMenuItem
            // 
            this.arkaPlanRengiDeğişToolStripMenuItem.Name = "arkaPlanRengiDeğişToolStripMenuItem";
            this.arkaPlanRengiDeğişToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.arkaPlanRengiDeğişToolStripMenuItem.Text = "Arka Plan Rengi Değiş";
            this.arkaPlanRengiDeğişToolStripMenuItem.Click += new System.EventHandler(this.arkaPlanRengiDeğişToolStripMenuItem_Click);
            // 
            // seçenekşerToolStripMenuItem
            // 
            this.seçenekşerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öncekiSayfayaDönToolStripMenuItem,
            this.uygulamayıKapatToolStripMenuItem});
            this.seçenekşerToolStripMenuItem.Name = "seçenekşerToolStripMenuItem";
            this.seçenekşerToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.seçenekşerToolStripMenuItem.Text = "Seçenekler";
            // 
            // öncekiSayfayaDönToolStripMenuItem
            // 
            this.öncekiSayfayaDönToolStripMenuItem.Name = "öncekiSayfayaDönToolStripMenuItem";
            this.öncekiSayfayaDönToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.öncekiSayfayaDönToolStripMenuItem.Text = "Önceki Sayfaya Dön";
            this.öncekiSayfayaDönToolStripMenuItem.Click += new System.EventHandler(this.öncekiSayfayaDönToolStripMenuItem_Click);
            // 
            // uygulamayıKapatToolStripMenuItem
            // 
            this.uygulamayıKapatToolStripMenuItem.Name = "uygulamayıKapatToolStripMenuItem";
            this.uygulamayıKapatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.uygulamayıKapatToolStripMenuItem.Text = "Uygulamayı Kapat";
            this.uygulamayıKapatToolStripMenuItem.Click += new System.EventHandler(this.uygulamayıKapatToolStripMenuItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 446);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arkaPlanRengiDeğişToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seçenekşerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öncekiSayfayaDönToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uygulamayıKapatToolStripMenuItem;
    }
}
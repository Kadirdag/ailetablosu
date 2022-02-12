namespace uygulamaiste
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aYARLARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uYGULAMAYIKAPATToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hAKKIMIZDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iLETİŞİMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rEDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(95, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(550, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(75, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "AİLEYE KİŞİ EKLE/GÜNCELLE/SİL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(400, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(218, 57);
            this.button2.TabIndex = 2;
            this.button2.Text = "KİŞİ ARA";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(75, 264);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(218, 53);
            this.button3.TabIndex = 3;
            this.button3.Text = "AİLEYİ LİSTELE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(400, 262);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(218, 57);
            this.button6.TabIndex = 6;
            this.button6.Text = "TARİHE GÖRE SORGULA";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aYARLARToolStripMenuItem,
            this.hAKKIMIZDAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aYARLARToolStripMenuItem
            // 
            this.aYARLARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uYGULAMAYIKAPATToolStripMenuItem});
            this.aYARLARToolStripMenuItem.Name = "aYARLARToolStripMenuItem";
            this.aYARLARToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.aYARLARToolStripMenuItem.Text = "AYARLAR";
            // 
            // uYGULAMAYIKAPATToolStripMenuItem
            // 
            this.uYGULAMAYIKAPATToolStripMenuItem.Name = "uYGULAMAYIKAPATToolStripMenuItem";
            this.uYGULAMAYIKAPATToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.uYGULAMAYIKAPATToolStripMenuItem.Text = "UYGULAMAYI KAPAT";
            this.uYGULAMAYIKAPATToolStripMenuItem.Click += new System.EventHandler(this.uYGULAMAYIKAPATToolStripMenuItem_Click);
            // 
            // hAKKIMIZDAToolStripMenuItem
            // 
            this.hAKKIMIZDAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iLETİŞİMToolStripMenuItem});
            this.hAKKIMIZDAToolStripMenuItem.Name = "hAKKIMIZDAToolStripMenuItem";
            this.hAKKIMIZDAToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.hAKKIMIZDAToolStripMenuItem.Text = "HAKKIMIZDA";
            // 
            // iLETİŞİMToolStripMenuItem
            // 
            this.iLETİŞİMToolStripMenuItem.Name = "iLETİŞİMToolStripMenuItem";
            this.iLETİŞİMToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.iLETİŞİMToolStripMenuItem.Text = "Neden Böyle Bir Fikir";
            this.iLETİŞİMToolStripMenuItem.Click += new System.EventHandler(this.iLETİŞİMToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEDToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(217, 26);
            // 
            // rEDToolStripMenuItem
            // 
            this.rEDToolStripMenuItem.Name = "rEDToolStripMenuItem";
            this.rEDToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.rEDToolStripMenuItem.Text = "Buton Yazılarını Kırmızı Yap";
            this.rEDToolStripMenuItem.Click += new System.EventHandler(this.rEDToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "ASADS";
            this.notifyIcon1.BalloonTipTitle = "DAĞ FAMİLY ";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "DAĞ FAMİLY";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(734, 376);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aYARLARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hAKKIMIZDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uYGULAMAYIKAPATToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iLETİŞİMToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rEDToolStripMenuItem;
        protected System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}


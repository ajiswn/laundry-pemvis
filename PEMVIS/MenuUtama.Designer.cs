namespace PEMVIS
{
    partial class MenuUtama
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuUtama));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            aKUNToolStripMenuItem = new ToolStripMenuItem();
            lOGOUTToolStripMenuItem = new ToolStripMenuItem();
            eXITToolStripMenuItem = new ToolStripMenuItem();
            mASTERToolStripMenuItem = new ToolStripMenuItem();
            tRANSAKSIToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 497);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(633, 390);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Javanese Text", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(607, 146);
            label1.Name = "label1";
            label1.Size = new Size(719, 69);
            label1.TabIndex = 1;
            label1.Text = "SELAMAT DATANG DI APLIKASI E-LAUNDRY\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1144, 399);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(557, 446);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(982, 370);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(334, 142);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.LightSkyBlue;
            menuStrip1.BackgroundImageLayout = ImageLayout.None;
            menuStrip1.Font = new Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mASTERToolStripMenuItem, tRANSAKSIToolStripMenuItem, aKUNToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 2, 0, 2);
            menuStrip1.Size = new Size(1924, 53);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "MenuStrip1";
            // 
            // aKUNToolStripMenuItem
            // 
            aKUNToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lOGOUTToolStripMenuItem, eXITToolStripMenuItem });
            aKUNToolStripMenuItem.Name = "aKUNToolStripMenuItem";
            aKUNToolStripMenuItem.Size = new Size(85, 49);
            aKUNToolStripMenuItem.Text = "EXIT";
            aKUNToolStripMenuItem.Click += aKUNToolStripMenuItem_Click;
            // 
            // lOGOUTToolStripMenuItem
            // 
            lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            lOGOUTToolStripMenuItem.Size = new Size(293, 50);
            lOGOUTToolStripMenuItem.Text = "LOG OUT";
            lOGOUTToolStripMenuItem.Click += lOGOUTToolStripMenuItem_Click;
            // 
            // eXITToolStripMenuItem
            // 
            eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            eXITToolStripMenuItem.Size = new Size(293, 50);
            eXITToolStripMenuItem.Text = "TUTUP APLIKASI";
            eXITToolStripMenuItem.Click += eXITToolStripMenuItem_Click;
            // 
            // mASTERToolStripMenuItem
            // 
            mASTERToolStripMenuItem.Name = "mASTERToolStripMenuItem";
            mASTERToolStripMenuItem.Size = new Size(97, 49);
            mASTERToolStripMenuItem.Text = "AKUN";
            mASTERToolStripMenuItem.Click += mASTERToolStripMenuItem_Click;
            // 
            // tRANSAKSIToolStripMenuItem
            // 
            tRANSAKSIToolStripMenuItem.Name = "tRANSAKSIToolStripMenuItem";
            tRANSAKSIToolStripMenuItem.Size = new Size(156, 49);
            tRANSAKSIToolStripMenuItem.Text = "TRANSAKSI";
            tRANSAKSIToolStripMenuItem.Click += tRANSAKSIToolStripMenuItem_Click;
            // 
            // MenuUtama
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1924, 898);
            Controls.Add(menuStrip1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Microsoft Sans Serif", 7.8F);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuUtama";
            Text = "MENU UTAMA";
            WindowState = FormWindowState.Maximized;
            Load += MenuUtama_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private ContextMenuStrip contextMenuStrip1;
        public MenuStrip menuStrip1;
        private ToolStripMenuItem aKUNToolStripMenuItem;
        private ToolStripMenuItem lOGOUTToolStripMenuItem;
        private ToolStripMenuItem eXITToolStripMenuItem;
        private ToolStripMenuItem mASTERToolStripMenuItem;
        private ToolStripMenuItem tRANSAKSIToolStripMenuItem;
    }
}
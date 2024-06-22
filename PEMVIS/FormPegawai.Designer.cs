namespace PEMVIS
{
    partial class FormPegawai
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button4 = new Button();
            textBox4 = new TextBox();
            label4 = new Label();
            button5 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView2 = new DataGridView();
            textBox3 = new TextBox();
            label3 = new Label();
            id = new DataGridViewTextBoxColumn();
            nama = new DataGridViewTextBoxColumn();
            username = new DataGridViewTextBoxColumn();
            password = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            textBox1.Location = new Point(178, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(376, 34);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            textBox2.Location = new Point(178, 111);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(376, 34);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Javanese Text", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 58);
            label1.Name = "label1";
            label1.Size = new Size(87, 54);
            label1.TabIndex = 3;
            label1.Text = "Nama";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Javanese Text", 14.25F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 111);
            label2.Name = "label2";
            label2.Size = new Size(136, 54);
            label2.TabIndex = 4;
            label2.Text = "Username";
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.Font = new Font("Javanese Text", 14.25F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(835, 91);
            button1.Name = "button1";
            button1.Size = new Size(145, 54);
            button1.TabIndex = 7;
            button1.Text = "SIMPAN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.Font = new Font("Javanese Text", 14.25F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(835, 474);
            button4.Name = "button4";
            button4.Size = new Size(145, 54);
            button4.TabIndex = 10;
            button4.Text = "TUTUP";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            textBox4.Location = new Point(178, 8);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(376, 34);
            textBox4.TabIndex = 11;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Javanese Text", 14.25F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 4);
            label4.Name = "label4";
            label4.Size = new Size(52, 54);
            label4.TabIndex = 12;
            label4.Text = "ID";
            label4.Click += label4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.DeepSkyBlue;
            button5.Font = new Font("Javanese Text", 14.25F, FontStyle.Bold);
            button5.ForeColor = Color.White;
            button5.Location = new Point(835, 12);
            button5.Name = "button5";
            button5.Size = new Size(145, 54);
            button5.TabIndex = 13;
            button5.Text = "BARU";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.Font = new Font("Javanese Text", 14.25F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(632, 12);
            button2.Name = "button2";
            button2.Size = new Size(145, 54);
            button2.TabIndex = 14;
            button2.Text = "HAPUS";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkOliveGreen;
            button3.Font = new Font("Javanese Text", 14.25F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(632, 91);
            button3.Name = "button3";
            button3.Size = new Size(145, 54);
            button3.TabIndex = 15;
            button3.Text = "EDIT";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { id, nama, username, password });
            dataGridView2.Location = new Point(178, 226);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(802, 227);
            dataGridView2.TabIndex = 16;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            textBox3.Location = new Point(178, 165);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(376, 34);
            textBox3.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Javanese Text", 14.25F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 161);
            label3.Name = "label3";
            label3.Size = new Size(128, 54);
            label3.TabIndex = 18;
            label3.Text = "Password";
            // 
            // id
            // 
            id.DataPropertyName = "ID";
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Width = 50;
            // 
            // nama
            // 
            nama.DataPropertyName = "nama";
            nama.HeaderText = "Nama";
            nama.MinimumWidth = 6;
            nama.Name = "nama";
            nama.Width = 300;
            // 
            // username
            // 
            username.DataPropertyName = "username";
            username.HeaderText = "Username";
            username.MinimumWidth = 6;
            username.Name = "username";
            username.Width = 210;
            // 
            // password
            // 
            password.DataPropertyName = "password";
            password.HeaderText = "Password";
            password.MinimumWidth = 6;
            password.Name = "password";
            password.Width = 210;
            // 
            // FormPegawai
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1052, 540);
            Controls.Add(dataGridView2);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button5);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Font = new Font("Microsoft Sans Serif", 7.8F);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormPegawai";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPegawai";
            Load += FormPegawai_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button4;
        private TextBox textBox4;
        private Label label4;
        private Button button5;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView2;
        private TextBox textBox3;
        private Label label3;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nama;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn password;
    }
}
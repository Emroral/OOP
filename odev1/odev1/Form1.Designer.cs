namespace odev1
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            comboBox1 = new ComboBox();
            listBox1 = new ListBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            textBox4 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(42, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(258, 324);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Öğrenci Kayıt Ekranı";
            // 
            // button1
            // 
            button1.Location = new Point(106, 210);
            button1.Name = "button1";
            button1.Size = new Size(125, 29);
            button1.TabIndex = 6;
            button1.Text = "Öğrenci Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(106, 134);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(106, 92);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(106, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 134);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 2;
            label3.Text = "Bölüm Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 95);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 1;
            label2.Text = "Öğrenci No";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 55);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(listBox1);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Location = new Point(355, 69);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(307, 324);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Öğrenci Bilgileri";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(18, 176);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(266, 28);
            comboBox1.TabIndex = 11;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(18, 68);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(266, 104);
            listBox1.TabIndex = 10;
            // 
            // button4
            // 
            button4.Location = new Point(159, 259);
            button4.Name = "button4";
            button4.Size = new Size(125, 29);
            button4.TabIndex = 9;
            button4.Text = "Ara";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(159, 210);
            button3.Name = "button3";
            button3.Size = new Size(125, 29);
            button3.TabIndex = 8;
            button3.Text = "Temizle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(91, 26);
            button2.Name = "button2";
            button2.Size = new Size(125, 29);
            button2.TabIndex = 7;
            button2.Text = "Aktar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(18, 261);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(674, 454);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private ComboBox comboBox1;
        private ListBox listBox1;
        private Button button4;
        private Button button3;
        private Button button2;
        private TextBox textBox4;
    }
}
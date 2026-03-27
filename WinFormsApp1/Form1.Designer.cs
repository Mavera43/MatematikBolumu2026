namespace WinFormsApp1
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
            label1 = new Label();
            label2 = new Label();
            s1 = new TextBox();
            s2 = new TextBox();
            button1 = new Button();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            ekle = new Button();
            cikar = new Button();
            sp = new Label();
            spt = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 30);
            label1.Name = "label1";
            label1.Size = new Size(83, 36);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 117);
            label2.Name = "label2";
            label2.Size = new Size(83, 36);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // s1
            // 
            s1.Location = new Point(154, 35);
            s1.Multiline = true;
            s1.Name = "s1";
            s1.Size = new Size(285, 64);
            s1.TabIndex = 2;
            // 
            // s2
            // 
            s2.Location = new Point(154, 117);
            s2.Multiline = true;
            s2.Name = "s2";
            s2.Size = new Size(285, 57);
            s2.TabIndex = 3;
            s2.TextChanged += s2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(195, 225);
            button1.Name = "button1";
            button1.Size = new Size(194, 90);
            button1.TabIndex = 4;
            button1.Text = "Hesapla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 36;
            listBox1.Items.AddRange(new object[] { "Pizza (100 TL)", "Hamburger (75 TL)", "Patates Kızartması (40 TL)", "İçecek (20 TL)" });
            listBox1.Location = new Point(535, 117);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(354, 184);
            listBox1.TabIndex = 5;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 36;
            listBox2.Location = new Point(1065, 117);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(360, 184);
            listBox2.TabIndex = 6;
            // 
            // ekle
            // 
            ekle.Location = new Point(909, 117);
            ekle.Name = "ekle";
            ekle.Size = new Size(133, 70);
            ekle.TabIndex = 7;
            ekle.Text = "ekle";
            ekle.UseVisualStyleBackColor = true;
            ekle.Click += ekle_Click;
            // 
            // cikar
            // 
            cikar.Location = new Point(909, 235);
            cikar.Name = "cikar";
            cikar.Size = new Size(133, 70);
            cikar.TabIndex = 8;
            cikar.Text = "çıkar";
            cikar.UseVisualStyleBackColor = true;
            cikar.Click += cikar_Click;
            // 
            // sp
            // 
            sp.AutoSize = true;
            sp.Location = new Point(868, 366);
            sp.Name = "sp";
            sp.Size = new Size(197, 36);
            sp.TabIndex = 9;
            sp.Text = "Sipariş Toplamı :";
            // 
            // spt
            // 
            spt.AutoSize = true;
            spt.Location = new Point(1092, 366);
            spt.Name = "spt";
            spt.Size = new Size(29, 36);
            spt.TabIndex = 10;
            spt.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1437, 735);
            Controls.Add(spt);
            Controls.Add(sp);
            Controls.Add(cikar);
            Controls.Add(ekle);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(s2);
            Controls.Add(s1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox s1;
        private TextBox s2;
        private Button button1;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button ekle;
        private Button cikar;
        private Label sp;
        private Label spt;
    }
}

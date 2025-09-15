namespace B241210088_Proje
{
    partial class aktivite_alanlari
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
            cmbAktivite = new ComboBox();
            txtDaireNo = new TextBox();
            txtAdSoyad = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnOnayla = new Button();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // cmbAktivite
            // 
            cmbAktivite.FormattingEnabled = true;
            cmbAktivite.Location = new Point(213, 101);
            cmbAktivite.Name = "cmbAktivite";
            cmbAktivite.Size = new Size(125, 28);
            cmbAktivite.TabIndex = 0;
            // 
            // txtDaireNo
            // 
            txtDaireNo.Location = new Point(213, 33);
            txtDaireNo.Name = "txtDaireNo";
            txtDaireNo.Size = new Size(125, 27);
            txtDaireNo.TabIndex = 1;
            txtDaireNo.TextChanged += txtDaireNo_TextChanged;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(213, 66);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(125, 27);
            txtAdSoyad.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 36);
            label1.Name = "label1";
            label1.Size = new Size(169, 20);
            label1.TabIndex = 3;
            label1.Text = "Daire numarasını giriniz:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(194, 20);
            label2.TabIndex = 4;
            label2.Text = "Kullanacak kişinin ad-soyad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 101);
            label3.Name = "label3";
            label3.Size = new Size(185, 20);
            label3.TabIndex = 5;
            label3.Text = "Kullanmak istediğiniz alan:";
            // 
            // btnOnayla
            // 
            btnOnayla.Location = new Point(244, 148);
            btnOnayla.Name = "btnOnayla";
            btnOnayla.Size = new Size(94, 29);
            btnOnayla.TabIndex = 6;
            btnOnayla.Text = "ONAYLA";
            btnOnayla.UseVisualStyleBackColor = true;
            btnOnayla.Click += btnOnayla_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(360, 32);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(231, 144);
            listBox1.TabIndex = 7;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(597, 33);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(250, 144);
            listBox2.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(360, 9);
            label4.Name = "label4";
            label4.Size = new Size(170, 20);
            label4.TabIndex = 9;
            label4.Text = "Son HAVUZ kullanımları:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(597, 9);
            label5.Name = "label5";
            label5.Size = new Size(176, 20);
            label5.TabIndex = 10;
            label5.Text = "Son FİTNESS kullanımları:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(101, 20);
            label6.TabIndex = 11;
            label6.Text = "Kullanım ekle:";
            // 
            // aktivite_alanlari
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 191);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(btnOnayla);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAdSoyad);
            Controls.Add(txtDaireNo);
            Controls.Add(cmbAktivite);
            Name = "aktivite_alanlari";
            Text = "Aktivite Alanı İşlemleri";
            Load += aktivite_alanlari_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbAktivite;
        private TextBox txtDaireNo;
        private TextBox txtAdSoyad;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnOnayla;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
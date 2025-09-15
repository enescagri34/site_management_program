namespace B241210088_Proje
{
    partial class Odeme
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
            label1 = new Label();
            txtDaireNo = new TextBox();
            lblBorc = new Label();
            txtBorc = new TextBox();
            btnAra = new Button();
            btnKaydet = new Button();
            label3 = new Label();
            txtOdeme = new TextBox();
            listBox1 = new ListBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 28);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 0;
            label1.Text = "Daire No:";
            // 
            // txtDaireNo
            // 
            txtDaireNo.Location = new Point(99, 25);
            txtDaireNo.Name = "txtDaireNo";
            txtDaireNo.Size = new Size(132, 27);
            txtDaireNo.TabIndex = 1;
            // 
            // lblBorc
            // 
            lblBorc.AutoSize = true;
            lblBorc.Location = new Point(9, 61);
            lblBorc.Name = "lblBorc";
            lblBorc.Size = new Size(84, 20);
            lblBorc.TabIndex = 2;
            lblBorc.Text = "Borç Tutarı:";
            // 
            // txtBorc
            // 
            txtBorc.Location = new Point(99, 58);
            txtBorc.Name = "txtBorc";
            txtBorc.Size = new Size(129, 27);
            txtBorc.TabIndex = 3;
            // 
            // btnAra
            // 
            btnAra.Location = new Point(237, 25);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(56, 27);
            btnAra.TabIndex = 4;
            btnAra.Text = "ARA";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(237, 120);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(69, 27);
            btnKaydet.TabIndex = 5;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 120);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 6;
            label3.Text = "Ödenecek Tutar:";
            // 
            // txtOdeme
            // 
            txtOdeme.Location = new Point(131, 120);
            txtOdeme.Name = "txtOdeme";
            txtOdeme.Size = new Size(100, 27);
            txtOdeme.TabIndex = 7;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(330, 36);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(258, 104);
            listBox1.TabIndex = 8;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(330, 9);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 9;
            label2.Text = "Son defter kayıtları:";
            // 
            // Odeme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 159);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(txtOdeme);
            Controls.Add(label3);
            Controls.Add(btnKaydet);
            Controls.Add(btnAra);
            Controls.Add(txtBorc);
            Controls.Add(lblBorc);
            Controls.Add(txtDaireNo);
            Controls.Add(label1);
            Name = "Odeme";
            Text = "Ödeme İşlemleri";
            Load += Odeme_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDaireNo;
        private Label lblBorc;
        private TextBox txtBorc;
        private Button btnAra;
        private Button btnKaydet;
        private Label label3;
        private TextBox txtOdeme;
        private ListBox listBox1;
        private Label label2;
    }
}
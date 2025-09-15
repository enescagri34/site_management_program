namespace B241210088_Proje
{
    partial class Misafir_İslemleri
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
            listBox1 = new ListBox();
            btnKaydet = new Button();
            btnPrgKapat = new Button();
            label2 = new Label();
            label3 = new Label();
            txtMisafirAd = new TextBox();
            btnAra = new Button();
            btnEkle = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 18);
            label1.Name = "label1";
            label1.Size = new Size(325, 20);
            label1.TabIndex = 0;
            label1.Text = "Düzenlemek istediğiniz daire numarasını giriniz:";
            // 
            // txtDaireNo
            // 
            txtDaireNo.Location = new Point(336, 18);
            txtDaireNo.Name = "txtDaireNo";
            txtDaireNo.Size = new Size(65, 27);
            txtDaireNo.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 114);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(482, 344);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(251, 464);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(94, 29);
            btnKaydet.TabIndex = 3;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnPrgKapat
            // 
            btnPrgKapat.Location = new Point(349, 464);
            btnPrgKapat.Name = "btnPrgKapat";
            btnPrgKapat.Size = new Size(143, 29);
            btnPrgKapat.TabIndex = 4;
            btnPrgKapat.Text = "PROGRAMI KAPAT";
            btnPrgKapat.UseVisualStyleBackColor = true;
            btnPrgKapat.Click += btnPrgKapat_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 91);
            label2.Name = "label2";
            label2.Size = new Size(162, 20);
            label2.TabIndex = 5;
            label2.Text = "Dairede Konaklayanlar:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 56);
            label3.Name = "label3";
            label3.Size = new Size(241, 20);
            label3.TabIndex = 6;
            label3.Text = "Misafirin ismini ve soyismini giriniz:";
            // 
            // txtMisafirAd
            // 
            txtMisafirAd.Location = new Point(257, 53);
            txtMisafirAd.Name = "txtMisafirAd";
            txtMisafirAd.Size = new Size(144, 27);
            txtMisafirAd.TabIndex = 7;
            // 
            // btnAra
            // 
            btnAra.Location = new Point(407, 18);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(87, 27);
            btnAra.TabIndex = 8;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(407, 51);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(87, 29);
            btnEkle.TabIndex = 9;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // Misafir_İslemleri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 504);
            Controls.Add(btnEkle);
            Controls.Add(btnAra);
            Controls.Add(txtMisafirAd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnPrgKapat);
            Controls.Add(btnKaydet);
            Controls.Add(listBox1);
            Controls.Add(txtDaireNo);
            Controls.Add(label1);
            Name = "Misafir_İslemleri";
            Text = "Misafir_İslemleri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDaireNo;
        private ListBox listBox1;
        private Button btnKaydet;
        private Button btnPrgKapat;
        private Label label2;
        private Label label3;
        private TextBox txtMisafirAd;
        private Button btnAra;
        private Button btnEkle;
    }
}
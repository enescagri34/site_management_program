namespace B241210088_Proje
{
    partial class Mekan_menu
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
            lblDaireNum = new Label();
            lblDaireSahibi = new Label();
            txtDaireNo = new TextBox();
            txtDaireSahibi = new TextBox();
            lblDaireBorcu = new Label();
            txtDaireBorcu = new TextBox();
            label2 = new Label();
            listBox1 = new ListBox();
            lblArama = new Label();
            txtDaireArama = new TextBox();
            label1 = new Label();
            listBox2 = new ListBox();
            button1 = new Button();
            btnAra = new Button();
            lblDaireList = new Label();
            txtBlokNo = new TextBox();
            label3 = new Label();
            btnSil = new Button();
            btnPrgKapat = new Button();
            btnListele = new Button();
            btnEkle = new Button();
            label4 = new Label();
            label5 = new Label();
            txtAdSoyad = new TextBox();
            SuspendLayout();
            // 
            // lblDaireNum
            // 
            lblDaireNum.AutoSize = true;
            lblDaireNum.Location = new Point(4, 96);
            lblDaireNum.Name = "lblDaireNum";
            lblDaireNum.Size = new Size(115, 20);
            lblDaireNum.TabIndex = 0;
            lblDaireNum.Text = "Daire Numarası:";
            // 
            // lblDaireSahibi
            // 
            lblDaireSahibi.AutoSize = true;
            lblDaireSahibi.Location = new Point(26, 198);
            lblDaireSahibi.Name = "lblDaireSahibi";
            lblDaireSahibi.Size = new Size(93, 20);
            lblDaireSahibi.TabIndex = 1;
            lblDaireSahibi.Text = "Daire Sahibi:";
            // 
            // txtDaireNo
            // 
            txtDaireNo.Location = new Point(129, 96);
            txtDaireNo.Name = "txtDaireNo";
            txtDaireNo.Size = new Size(229, 27);
            txtDaireNo.TabIndex = 3;
            // 
            // txtDaireSahibi
            // 
            txtDaireSahibi.Location = new Point(129, 195);
            txtDaireSahibi.Name = "txtDaireSahibi";
            txtDaireSahibi.Size = new Size(229, 27);
            txtDaireSahibi.TabIndex = 4;
            // 
            // lblDaireBorcu
            // 
            lblDaireBorcu.AutoSize = true;
            lblDaireBorcu.Location = new Point(29, 169);
            lblDaireBorcu.Name = "lblDaireBorcu";
            lblDaireBorcu.Size = new Size(90, 20);
            lblDaireBorcu.TabIndex = 6;
            lblDaireBorcu.Text = "Daire Borcu:";
            // 
            // txtDaireBorcu
            // 
            txtDaireBorcu.Location = new Point(129, 162);
            txtDaireBorcu.Name = "txtDaireBorcu";
            txtDaireBorcu.Size = new Size(229, 27);
            txtDaireBorcu.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 281);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 8;
            label2.Text = "Üye Listesi:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ImeMode = ImeMode.On;
            listBox1.Location = new Point(129, 281);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(229, 104);
            listBox1.TabIndex = 9;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // lblArama
            // 
            lblArama.AutoSize = true;
            lblArama.Location = new Point(12, 30);
            lblArama.Name = "lblArama";
            lblArama.Size = new Size(169, 20);
            lblArama.TabIndex = 11;
            lblArama.Text = "Daire numarasını giriniz:";
            // 
            // txtDaireArama
            // 
            txtDaireArama.Location = new Point(187, 30);
            txtDaireArama.Name = "txtDaireArama";
            txtDaireArama.Size = new Size(65, 27);
            txtDaireArama.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 66);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 13;
            label1.Text = "EKLE-DÜZENLE";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(394, 53);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(262, 284);
            listBox2.TabIndex = 14;
            // 
            // button1
            // 
            button1.Location = new Point(268, 395);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 15;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnAra
            // 
            btnAra.Location = new Point(268, 30);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(74, 29);
            btnAra.TabIndex = 16;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // lblDaireList
            // 
            lblDaireList.AutoSize = true;
            lblDaireList.Location = new Point(394, 30);
            lblDaireList.Name = "lblDaireList";
            lblDaireList.Size = new Size(92, 20);
            lblDaireList.TabIndex = 17;
            lblDaireList.Text = "Daire Listesi:";
            // 
            // txtBlokNo
            // 
            txtBlokNo.Location = new Point(129, 129);
            txtBlokNo.Name = "txtBlokNo";
            txtBlokNo.Size = new Size(229, 27);
            txtBlokNo.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 129);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 19;
            label3.Text = "Blok No:";
            // 
            // btnSil
            // 
            btnSil.Location = new Point(163, 395);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(99, 29);
            btnSil.TabIndex = 20;
            btnSil.Text = "Daireyi Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnPrgKapat
            // 
            btnPrgKapat.Location = new Point(502, 395);
            btnPrgKapat.Name = "btnPrgKapat";
            btnPrgKapat.Size = new Size(154, 29);
            btnPrgKapat.TabIndex = 21;
            btnPrgKapat.Text = "PROGRAMI KAPAT";
            btnPrgKapat.UseVisualStyleBackColor = true;
            btnPrgKapat.Click += btnPrgKapat_Click;
            // 
            // btnListele
            // 
            btnListele.Location = new Point(562, 343);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(94, 29);
            btnListele.TabIndex = 22;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = true;
            btnListele.Click += btnListele_Click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(296, 247);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(62, 29);
            btnEkle.TabIndex = 23;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 225);
            label4.Name = "label4";
            label4.Size = new Size(243, 20);
            label4.TabIndex = 24;
            label4.Text = "Aile Üyeleri (Her birini tek tek girin)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 254);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 25;
            label5.Text = "Ad-Soyad:";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(129, 248);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(161, 27);
            txtAdSoyad.TabIndex = 26;
            // 
            // Mekan_menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 436);
            Controls.Add(txtAdSoyad);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnEkle);
            Controls.Add(btnListele);
            Controls.Add(btnPrgKapat);
            Controls.Add(btnSil);
            Controls.Add(label3);
            Controls.Add(txtBlokNo);
            Controls.Add(lblDaireList);
            Controls.Add(btnAra);
            Controls.Add(button1);
            Controls.Add(listBox2);
            Controls.Add(label1);
            Controls.Add(txtDaireArama);
            Controls.Add(lblArama);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(txtDaireBorcu);
            Controls.Add(lblDaireBorcu);
            Controls.Add(txtDaireSahibi);
            Controls.Add(txtDaireNo);
            Controls.Add(lblDaireSahibi);
            Controls.Add(lblDaireNum);
            Name = "Mekan_menu";
            Text = "Daire İşlemleri";
            Load += Mekan_menu_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDaireNum;
        private Label lblDaireSahibi;
        private TextBox txtDaireNo;
        private TextBox txtDaireSahibi;
        private Label lblDaireBorcu;
        private TextBox txtDaireBorcu;
        private Label label2;
        private ListBox listBox1;
        private Label lblArama;
        private TextBox txtDaireArama;
        private Label label1;
        private ListBox listBox2;
        private Button button1;
        private Button btnAra;
        private Label lblDaireList;
        private TextBox txtBlokNo;
        private Label label3;
        private Button btnSil;
        private Button btnPrgKapat;
        private Button btnListele;
        private Button btnEkle;
        private Label label4;
        private Label label5;
        private TextBox txtAdSoyad;
    }
}
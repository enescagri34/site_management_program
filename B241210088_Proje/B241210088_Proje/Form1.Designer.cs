namespace B241210088_Proje
{
    partial class Giris
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
            islem_secim = new Label();
            mekan_gecis = new Button();
            odeme_gecis = new Button();
            cikis = new Button();
            label1 = new Label();
            aktiveAlanlari = new Button();
            btnMisafir = new Button();
            SuspendLayout();
            // 
            // islem_secim
            // 
            islem_secim.AutoSize = true;
            islem_secim.Location = new Point(25, 59);
            islem_secim.Name = "islem_secim";
            islem_secim.Size = new Size(216, 20);
            islem_secim.TabIndex = 0;
            islem_secim.Text = "Yapmak istediğiniz işlemi seçin:";
            // 
            // mekan_gecis
            // 
            mekan_gecis.Location = new Point(44, 92);
            mekan_gecis.Name = "mekan_gecis";
            mekan_gecis.Size = new Size(197, 29);
            mekan_gecis.TabIndex = 1;
            mekan_gecis.Text = "Daire İşlemleri";
            mekan_gecis.UseVisualStyleBackColor = true;
            mekan_gecis.Click += mekan_gecis_Click;
            // 
            // odeme_gecis
            // 
            odeme_gecis.Location = new Point(44, 199);
            odeme_gecis.Name = "odeme_gecis";
            odeme_gecis.Size = new Size(197, 31);
            odeme_gecis.TabIndex = 5;
            odeme_gecis.Text = "Ödeme İşlemleri";
            odeme_gecis.UseVisualStyleBackColor = true;
            odeme_gecis.Click += odeme_gecis_Click;
            // 
            // cikis
            // 
            cikis.Location = new Point(182, 250);
            cikis.Name = "cikis";
            cikis.Size = new Size(94, 29);
            cikis.TabIndex = 6;
            cikis.Text = "ÇIKIŞ";
            cikis.UseVisualStyleBackColor = true;
            cikis.Click += cikis_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 29);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 7;
            label1.Text = "HOŞGELDİNİZ";
            // 
            // aktiveAlanlari
            // 
            aktiveAlanlari.Location = new Point(44, 164);
            aktiveAlanlari.Name = "aktiveAlanlari";
            aktiveAlanlari.Size = new Size(197, 29);
            aktiveAlanlari.TabIndex = 9;
            aktiveAlanlari.Text = "Aktivite Alanları İşlemleri";
            aktiveAlanlari.UseVisualStyleBackColor = true;
            aktiveAlanlari.Click += aktiveAlanlari_Click;
            // 
            // btnMisafir
            // 
            btnMisafir.Location = new Point(44, 129);
            btnMisafir.Name = "btnMisafir";
            btnMisafir.Size = new Size(197, 29);
            btnMisafir.TabIndex = 10;
            btnMisafir.Text = "Misafir İşlemleri";
            btnMisafir.UseVisualStyleBackColor = true;
            btnMisafir.Click += btnMisafir_Click;
            // 
            // Giris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 286);
            Controls.Add(btnMisafir);
            Controls.Add(aktiveAlanlari);
            Controls.Add(label1);
            Controls.Add(cikis);
            Controls.Add(odeme_gecis);
            Controls.Add(mekan_gecis);
            Controls.Add(islem_secim);
            Name = "Giris";
            Text = "Giriş";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label islem_secim;
        private Button mekan_gecis;
        private Button odeme_gecis;
        private Button cikis;
        private Label label1;
        private Button aktiveAlanlari;
        private Button btnMisafir;
    }
}

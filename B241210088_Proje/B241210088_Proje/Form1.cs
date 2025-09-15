/****************************************************************************
**					SAKARYA ÜNÝVERSÝTESÝ
**				BÝLGÝSAYAR VE BÝLÝÞÝM BÝLÝMLERÝ FAKÜLTESÝ
**				    BÝLGÝSAYAR MÜHENDÝSLÝÐÝ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSÝ
**					2014-2015 BAHAR DÖNEMÝ
**	
**				ÖDEV NUMARASI..........:Bahar Dönemi Proje
**				ÖÐRENCÝ ADI............:Enes Çaðrý ÇALIÞKAN 
**				ÖÐRENCÝ NUMARASI.......:b241210088
**                         DERSÝN ALINDIÐI GRUP...:B grubu
****************************************************************************/
namespace B241210088_Proje
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] dosyaAdlari = { "mekan.txt", "data.txt", "fitness.txt", "havuz.txt", "odeme.txt" };
            List<string> eksikDosyalar = new List<string>();

            foreach (string dosya in dosyaAdlari)
            {
                string yol = Path.Combine(Application.StartupPath, dosya);
                if (!File.Exists(yol))
                {
                    eksikDosyalar.Add(dosya);
                }
            }

            if (eksikDosyalar.Count > 0)
            {
                string mesaj = "Eksik dosyalar bulundu:\n\n" + string.Join("\n", eksikDosyalar) +
                               "\n\nBu dosyalarý oluþturmak ister misiniz?";
                DialogResult sonuc = MessageBox.Show(mesaj, "Eksik Dosyalar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (sonuc == DialogResult.Yes)
                {
                    foreach (string eksik in eksikDosyalar)
                    {
                        string yol = Path.Combine(Application.StartupPath, eksik);
                        File.Create(yol).Close(); // Dosya oluþtur
                    }

                    MessageBox.Show("Eksik dosyalar oluþturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Bazý iþlemler eksik dosyalar nedeniyle çalýþmayabilir.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }



        private void mekan_gecis_Click(object sender, EventArgs e)
        {
            Mekan_menu daireForm = new Mekan_menu(); // Form nesnesini oluþtur
            daireForm.Show(); // Yeni pencere olarak aç

        }

        private void aktiveAlanlari_Click(object sender, EventArgs e)
        {
            aktivite_alanlari aktiviteform = new aktivite_alanlari();
            aktiviteform.Show();
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMisafir_Click(object sender, EventArgs e)
        {
            Misafir_Ýslemleri misafirForm = new Misafir_Ýslemleri();
            misafirForm.Show();
        }

        private void odeme_gecis_Click(object sender, EventArgs e)
        {
            Odeme formOdeme = new Odeme();
            formOdeme.Show();
        }
    }
}

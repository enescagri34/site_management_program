using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B241210088_Proje
{
    public partial class aktivite_alanlari : Form
    {
        public aktivite_alanlari()
        {
            InitializeComponent();
        }

        private void aktivite_alanlari_Load(object sender, EventArgs e)
        {
            cmbAktivite.Items.Add("Havuz");
            cmbAktivite.Items.Add("Fitness");
            ListeleKullanimlar(); // liste ilk açıldığında yüklensin
        }

        private void ListeleKullanimlar()
        {
            string havuzDosya = Path.Combine(Application.StartupPath, "Havuz.txt");
            string fitnessDosya = Path.Combine(Application.StartupPath, "Fitness.txt");

            listBox1.Items.Clear();
            listBox2.Items.Clear();

            // HAVUZ
            if (File.Exists(havuzDosya))
            {
                var havuzSatirlar = File.ReadAllLines(havuzDosya)
                                         .Reverse() // son kayıtlar en üstte
                                         .Take(10); // son 10 kayıt
                foreach (string satir in havuzSatirlar)
                {
                    listBox1.Items.Add(satir);
                }
            }

            // FITNESS
            if (File.Exists(fitnessDosya))
            {
                var fitnessSatirlar = File.ReadAllLines(fitnessDosya)
                                          .Reverse()
                                          .Take(10);
                foreach (string satir in fitnessSatirlar)
                {
                    listBox2.Items.Add(satir);
                }
            }
        }


        private void txtDaireNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            string daireNo = txtDaireNo.Text.Trim();
            string ad = txtAdSoyad.Text.Trim();
            string aktivite = cmbAktivite.Text.Trim();
            string tarih = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            string durum = "";
            string hedefDosya = "";

            if (string.IsNullOrEmpty(daireNo) || string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(aktivite))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            // 1. Oturan doğrulaması (Oturan.txt)
            string oturanYolu = Path.Combine(Application.StartupPath, "Oturan.txt");
            bool kisiBulundu = false;

            if (File.Exists(oturanYolu))
            {
                string[] oturanlar = File.ReadAllLines(oturanYolu);
                foreach (string satir in oturanlar)
                {
                    string[] parca = satir.Split(',');
                    if (parca.Length >= 3 && parca[0] == daireNo && parca[1].Trim().Equals(ad, StringComparison.OrdinalIgnoreCase))
                    {
                        kisiBulundu = true;
                        break;
                    }
                }
            }

            if (!kisiBulundu)
            {
                MessageBox.Show("Bu kişi bu dairede kayıtlı değil.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Mekan.txt → Borç kontrolü
            bool borcuVar = false;
            string mekanYolu = Path.Combine(Application.StartupPath, "Mekan.txt");

            if (File.Exists(mekanYolu))
            {
                string[] satirlar = File.ReadAllLines(mekanYolu);
                foreach (string satir in satirlar)
                {
                    string[] parcalar = satir.Split(',');
                    if (parcalar.Length >= 3 && parcalar[0] == daireNo)
                    {
                        if (decimal.TryParse(parcalar[2], out decimal borc))
                        {
                            if (borc > 0)
                                borcuVar = true;
                        }
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Mekan.txt dosyası bulunamadı.");
                return;
            }

            // 3. Dosya seçimi
            if (aktivite == "Fitness")
                hedefDosya = Path.Combine(Application.StartupPath, "Fitness.txt");
            else if (aktivite == "Havuz")
                hedefDosya = Path.Combine(Application.StartupPath, "Havuz.txt");
            else
            {
                MessageBox.Show("Lütfen geçerli bir alan seçin (Havuz veya Fitness).");
                return;
            }

            // 4. Giriş durumu
            if (borcuVar)
            {
                durum = "Kullandırılmadı - Borç Var";
                MessageBox.Show("Giriş reddedildi. Daireye ait borç var.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                durum = "Kullandırıldı";
                MessageBox.Show("Giriş başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // 5. Dosyaya yaz
            string kayit = $"{daireNo},{ad},{tarih},{durum}";
            File.AppendAllText(hedefDosya, kayit + Environment.NewLine);
            ListeleKullanimlar();
        }
    }
}
        

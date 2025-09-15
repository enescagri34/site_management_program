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
    public partial class Odeme : Form
    {
        public Odeme()
        {
            InitializeComponent();
        }

        private void Odeme_Load(object sender, EventArgs e)
        {
            ListeleOdeme();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string daireNo = txtDaireNo.Text.Trim();
            string mekanYolu = Path.Combine(Application.StartupPath, "Mekan.txt");

            if (File.Exists(mekanYolu))
            {
                string[] satirlar = File.ReadAllLines(mekanYolu);
                foreach (string satir in satirlar)
                {
                    string[] bilgiler = satir.Split(',');
                    if (bilgiler.Length >= 3 && bilgiler[0] == daireNo)
                    {
                        txtBorc.Text = bilgiler[2]; // Borç göster
                        return;
                    }
                }

                MessageBox.Show("Bu daire numarasına ait kayıt bulunamadı.");
            }
            else
            {
                MessageBox.Show("Mekan.txt dosyası bulunamadı.");
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string daireNo = txtDaireNo.Text.Trim();
            string odemeMetin = txtOdeme.Text.Trim();
            string mekanYolu = Path.Combine(Application.StartupPath, "Mekan.txt");
            string odemeYolu = Path.Combine(Application.StartupPath, "Odeme.txt");

            if (!decimal.TryParse(odemeMetin, out decimal odemeMiktari))
            {
                MessageBox.Show("Lütfen geçerli bir ödeme tutarı girin.");
                return;
            }

            string[] satirlar = File.ReadAllLines(mekanYolu);
            bool guncellendi = false;

            for (int i = 0; i < satirlar.Length; i++)
            {
                string[] bilgiler = satirlar[i].Split(',');
                if (bilgiler[0] == daireNo && bilgiler.Length >= 3)
                {
                    if (decimal.TryParse(bilgiler[2], out decimal mevcutBorc))
                    {
                        decimal yeniBorc = Math.Max(0, mevcutBorc - odemeMiktari);
                        bilgiler[2] = yeniBorc.ToString();
                        satirlar[i] = string.Join(",", bilgiler);

                        File.WriteAllLines(mekanYolu, satirlar);

                        // Odeme.txt'ye kaydet
                        string tarih = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                        string kayit = $"{daireNo},{odemeMiktari},{tarih}";
                        File.AppendAllText(odemeYolu, kayit + Environment.NewLine);

                        MessageBox.Show("Ödeme kaydedildi.");
                        guncellendi = true;
                        ListeleOdeme();
                        txtBorc.Text = yeniBorc.ToString();
                        txtOdeme.Clear();
                        break;
                    }
                }
            }

            if (!guncellendi)
            {
                MessageBox.Show("Daire bulunamadı veya borç bilgisi hatalı.");
            }
        }
        private void ListeleOdeme()
        {
            listBox1.Items.Clear();
            string odemeYolu = Path.Combine(Application.StartupPath, "Odeme.txt");

            if (File.Exists(odemeYolu))
            {
                var sonKayitlar = File.ReadAllLines(odemeYolu).Reverse().Take(10);
                foreach (var satir in sonKayitlar)
                {
                    listBox1.Items.Add(satir);
                }
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string odemeYolu = Path.Combine(Application.StartupPath, "Odeme.txt");

            if (File.Exists(odemeYolu))
            {
                var sonKayitlar = File.ReadAllLines(odemeYolu).Reverse().Take(10);
                foreach (var satir in sonKayitlar)
                {
                    listBox1.Items.Add(satir);
                }
            }
        }
    }
}

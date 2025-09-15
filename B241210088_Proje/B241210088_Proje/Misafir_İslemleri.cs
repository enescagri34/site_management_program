using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace B241210088_Proje
{
    public partial class Misafir_İslemleri : Form
    {
        public Misafir_İslemleri()
        {
            InitializeComponent();
        }

        private void Misafir_İslemleri_Load(object sender, EventArgs e)
        {
            // Gerekli dosyalar yoksa oluştur
            string[] gerekliDosyalar = { "Data.txt", "Mekan.txt" };
            foreach (var dosya in gerekliDosyalar)
            {
                string yol = Path.Combine(Application.StartupPath, dosya);
                if (!File.Exists(yol))
                {
                    File.Create(yol).Close();
                }
            }
        }

        private void btnPrgKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            string daireNo = txtDaireNo.Text.Trim();
            if (string.IsNullOrEmpty(daireNo))
            {
                MessageBox.Show("Lütfen daire numarası girin.");
                return;
            }

            string mekanDosya = Path.Combine(Application.StartupPath, "Mekan.txt");
            string dataDosya = Path.Combine(Application.StartupPath, "Data.txt");

            HashSet<string> mekanAileReisleri = new HashSet<string>();
            HashSet<string> dataAileReisleri = new HashSet<string>();
            List<string> dataMisafirleri = new List<string>();

            // --- Mekan.txt → Aile Reislerini Bul
            if (File.Exists(mekanDosya))
            {
                string[] satirlar = File.ReadAllLines(mekanDosya);
                foreach (string satir in satirlar)
                {
                    string[] bilgiler = satir.Split(',');

                    if (bilgiler.Length >= 3 && bilgiler[0] == daireNo)
                    {
                        string daireSahibi = bilgiler[1].Trim();
                        mekanAileReisleri.Add(daireSahibi);

                        if (bilgiler.Length >= 4)
                        {
                            string[] oturanlar = bilgiler[3].Split('|');
                            foreach (string oturan in oturanlar)
                            {
                                if (oturan.Contains("(Aile Reisi)"))
                                {
                                    string ad = oturan.Replace("(Aile Reisi)", "").Trim();
                                    mekanAileReisleri.Add(ad);
                                }
                            }
                        }
                        break;
                    }
                }
            }

            // --- Data.txt → Aile Reisleri ve Misafirler
            if (File.Exists(dataDosya))
            {
                string[] dataSatirlar = File.ReadAllLines(dataDosya);
                foreach (string satir in dataSatirlar)
                {
                    string[] parcalar = satir.Split(',');
                    if (parcalar.Length == 3 && parcalar[0] == daireNo)
                    {
                        string ad = parcalar[1].Trim();
                        string tip = parcalar[2].Trim();

                        if (tip == "AileReisi")
                            dataAileReisleri.Add(ad);
                        else if (tip == "Misafir")
                            dataMisafirleri.Add(ad);
                    }
                }
            }

            // --- Eksik aile reislerini data.txt'ye yaz
            List<string> eksikReisler = mekanAileReisleri.Except(dataAileReisleri).ToList();
            if (eksikReisler.Count > 0)
            {
                foreach (string eksik in eksikReisler)
                {
                    string yeniSatir = $"{daireNo},{eksik},AileReisi";
                    File.AppendAllText(dataDosya, yeniSatir + Environment.NewLine);
                }

                MessageBox.Show($"{eksikReisler.Count} eksik aile reisi data.txt'ye eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // --- Listeyi oluştur
            foreach (var kisi in mekanAileReisleri)
            {
                listBox1.Items.Add($"{kisi} (Aile Reisi)");
            }

            foreach (var kisi in dataMisafirleri)
            {
                listBox1.Items.Add($"{kisi} (Misafir)");
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ad = txtMisafirAd.Text.Trim();
            if (string.IsNullOrEmpty(ad))
            {
                MessageBox.Show("Misafir adı boş olamaz.");
                return;
            }

            listBox1.Items.Add($"{ad} (Misafir)");
            txtMisafirAd.Clear();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string daireNo = txtDaireNo.Text.Trim();
            if (string.IsNullOrEmpty(daireNo)) return;

            string oturanDosya = Path.Combine(Application.StartupPath, "Data.txt");

            // Eski kayıtları çıkar
            var tumSatirlar = File.Exists(oturanDosya) ? File.ReadAllLines(oturanDosya).ToList() : new List<string>();
            tumSatirlar.RemoveAll(s => s.StartsWith(daireNo + ","));

            foreach (var item in listBox1.Items)
            {
                string satir = item.ToString(); // Örn: "Ali Yılmaz (Misafir)"
                string[] parcalar = satir.Split(new string[] { " (" }, StringSplitOptions.None);
                if (parcalar.Length == 2)
                {
                    string ad = parcalar[0].Trim();
                    string tip = parcalar[1].Replace(")", "").Trim();
                    tumSatirlar.Add($"{daireNo},{ad},{tip}");
                }
            }

            File.WriteAllLines(oturanDosya, tumSatirlar);
            MessageBox.Show("Misafir listesi kaydedildi.");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string secilen = listBox1.SelectedItem.ToString();
                if (secilen.Contains("(Aile Reisi)"))
                {
                    MessageBox.Show("Aile Reisi silinemez.");
                }
                else
                {
                    listBox1.Items.Remove(secilen);
                }
            }
        }
    }
}

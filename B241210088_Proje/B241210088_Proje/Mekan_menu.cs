using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace B241210088_Proje
{
    public partial class Mekan_menu : Form
    {
        public Mekan_menu()
        {
            InitializeComponent();

        }
        private void Mekan_menu_Load(object sender, EventArgs e)
        {

        }
        private void Listele()
        {
            listBox2.Items.Clear();

            if (File.Exists("Mekan.txt"))
            {
                string[] satirlar = File.ReadAllLines("Mekan.txt");
                foreach (string satir in satirlar)
                {
                    listBox2.Items.Add(satir);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string daireNo = txtDaireNo.Text.Trim();
            string blokNo = txtBlokNo.Text.Trim();
            string daireBorcu = txtDaireBorcu.Text.Trim();
            string daireSahibi = txtDaireSahibi.Text.Trim();

            List<string> oturanlar = new List<string>();
            foreach (var item in listBox1.Items)
                oturanlar.Add(item.ToString());

            string yeniSatir = $"{daireNo},{daireSahibi},{daireBorcu},{string.Join("|", oturanlar)}";

            string dosyaYolu = Path.Combine(Application.StartupPath, "Mekan.txt");
            string dataDosyaYolu = Path.Combine(Application.StartupPath, "Data.txt");
            string oturanDosyaYolu = Path.Combine(Application.StartupPath, "Oturan.txt");

            string[] satirlar = File.Exists(dosyaYolu) ? File.ReadAllLines(dosyaYolu) : new string[0];
            bool guncellendi = false;

            for (int i = 0; i < satirlar.Length; i++)
            {
                string[] bilgiler = satirlar[i].Split(',');
                if (bilgiler[0] == daireNo)
                {
                    satirlar[i] = yeniSatir;
                    guncellendi = true;
                    break;
                }
            }

            if (!guncellendi)
            {
                var satirlarList = satirlar.ToList();
                satirlarList.Add(yeniSatir);
                satirlar = satirlarList.ToArray();
            }

            try
            {
                File.WriteAllLines(dosyaYolu, satirlar);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mekan.txt dosyasına yazılamadı: " + ex.Message);
                return;
            }

            // Aile Reislerini Data.txt'ye yaz
            foreach (var item in listBox1.Items)
            {
                string satir = item.ToString();
                if (satir.Contains("(Aile Reisi)"))
                {
                    string ad = satir.Replace("(Aile Reisi)", "").Trim();
                    string veri = $"{daireNo},{ad},AileReisi";
                    File.AppendAllText(dataDosyaYolu, veri + Environment.NewLine);
                }
            }

            // Oturan.txt'ye daire sahibi + oturanlar yaz
            if (!string.IsNullOrEmpty(daireSahibi))
            {
                File.AppendAllText(oturanDosyaYolu, $"{daireNo},{daireSahibi},AileReisi" + Environment.NewLine);
            }

            foreach (var item in listBox1.Items)
            {
                string satir = item.ToString();
                string[] parcalar = satir.Split(new string[] { " (" }, StringSplitOptions.None);
                if (parcalar.Length == 2)
                {
                    string ad = parcalar[0].Trim();
                    string tip = parcalar[1].Replace(")", "").Trim();
                    File.AppendAllText(oturanDosyaYolu, $"{daireNo},{ad},{tip}" + Environment.NewLine);
                }
            }

            MessageBox.Show(guncellendi ? "Daire güncellendi." : "Yeni daire eklendi.");
            Listele();

        }



        private void btnAra_Click(object sender, EventArgs e)
        {
            string arananNo = txtDaireArama.Text.Trim();
            bool bulundu = false;

            // 📌 Aranan daire numarasını alt kutuya yaz (her durumda)
            txtDaireNo.Text = arananNo;

            if (File.Exists("Mekan.txt"))
            {
                string[] satirlar = File.ReadAllLines("Mekan.txt");

                foreach (string satir in satirlar)
                {
                    string[] bilgiler = satir.Split(',');

                    if (bilgiler.Length >= 3 && bilgiler[0] == arananNo)
                    {
                        txtDaireSahibi.Text = bilgiler[1];
                        txtDaireBorcu.Text = bilgiler[2];

                        listBox1.Items.Clear();
                        if (bilgiler.Length >= 4)
                        {
                            string[] oturanlar = bilgiler[3].Split('|');
                            listBox1.Items.AddRange(oturanlar);
                        }

                        bulundu = true;
                        break;
                    }
                }

                if (!bulundu)
                {
                    MessageBox.Show("Aradığınız daire bulunamadı,isterseniz aşağıdan ekleyebilirsiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDaireSahibi.Clear();
                    txtDaireBorcu.Clear();
                    listBox1.Items.Clear();
                }
            }
            else
            {
                MessageBox.Show("Mekan.txt dosyası bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }


        private void btnSil_Click(object sender, EventArgs e)
        {
            string daireNo = txtDaireNo.Text.Trim();
            if (string.IsNullOrEmpty(daireNo)) return;

            if (!File.Exists("Mekan.txt")) return;

            var satirlar = File.ReadAllLines("Mekan.txt").ToList();
            int silinen = satirlar.RemoveAll(s => s.StartsWith(daireNo + ","));

            if (silinen > 0)
            {
                File.WriteAllLines("Mekan.txt", satirlar);
                MessageBox.Show("Daire silindi.");
                Listele();
            }
            else
            {
                MessageBox.Show("Daire bulunamadı.");
            }
        }

        private void btnPrgKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Mekan_menu_Load_1(object sender, EventArgs e)
        {

        }
        private void OturanListele()
        {
            listBox2.Items.Clear();
            string yol = Path.Combine(Application.StartupPath, "Mekan.txt");

            if (File.Exists(yol))
            {
                var satirlar = File.ReadAllLines(yol);
                foreach (var satir in satirlar)
                {
                    listBox2.Items.Add(satir);
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ad = txtAdSoyad.Text.Trim();

            if (string.IsNullOrEmpty(ad))
            {
                MessageBox.Show("Lütfen ad girin.");
                return;
            }

            listBox1.Items.Add($"{ad} (Aile Reisi)");
            txtAdSoyad.Clear();
            OturanListele();
        }
    }
}

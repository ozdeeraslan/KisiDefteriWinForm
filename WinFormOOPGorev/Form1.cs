using System.Data;
using System.Security.Cryptography;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Windows.Forms;

namespace WinFormOOPGorev
{
    public partial class Form1 : Form
    {
        List<Kisi> kisiler;


        public Form1()
        {
            InitializeComponent();
            VerileriYukle();
            KisileriListele();

        }

        private void VerileriYukle()
        {
            try
            {
                string json = File.ReadAllText("veri.json");
                kisiler = JsonSerializer.Deserialize<List<Kisi>>(json)!; // seralization tersi(deserialize). String listeyi objeye ceviriyor.
            }
            catch (Exception)
            {

                kisiler = OrnekVeriler();
            }
        }

        private void KisileriListele()
        {
            lstKisiler.Items.Clear();

            foreach (Kisi kisi in kisiler)
            {
                lstKisiler.Items.Add(kisi);
            }
        }

        private List<Kisi> OrnekVeriler()
        {
            return new List<Kisi>()
            {
                new Kisi() { Ad = "Ali", Soyad = "Yılmaz" },
                new Kisi() { Ad = "Can", Soyad = "Öztürk" },
                new Kisi() { Ad = "Cem", Soyad = "Şahin" },
                new Kisi() { Ad = "Ece", Soyad = "Doğan" }
            };
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text.Trim();
            string soyad = txtSoyad.Text.Trim();

            if (ad == "" || soyad == "")
            {
                MessageBox.Show("Ad ve soyad zorunlu!");
                return;
            }

            Kisi k = new Kisi() { Ad = ad, Soyad = soyad };
            kisiler.Add(k);
            KisileriListele();
            lstKisiler.SelectedItem = k;
            txtAd.Clear();
            txtSoyad.Clear();
            txtAd.Focus();

        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            int sid = lstKisiler.SelectedIndex;

            if (lstKisiler.SelectedItem == null)
            {
                MessageBox.Show("Silinmesi istediginiz kisiyi seciniz.");
                return;
            }

            DialogResult dr = MessageBox.Show("Seçili kişiyi silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Kisi k = (Kisi)lstKisiler.SelectedItem;
                kisiler.Remove(k);
                KisileriListele();
                lstKisiler.SelectedIndex = Math.Min(sid, lstKisiler.Items.Count - 1);
            }

        }


        private void btnYukari_Click(object sender, EventArgs e)
        {
            int sid = lstKisiler.SelectedIndex;

            if (sid < 1)
                return;

            SeciliyiTasi(sid - 1); // yeniIndeks = sid - 1
        }

        private void btnAsagi_Click(object sender, EventArgs e)
        {
            int sid = lstKisiler.SelectedIndex;

            if (sid == -1 || sid == lstKisiler.Items.Count - 1)
                return;

            SeciliyiTasi(sid + 1); // yeniIndeks = sid + 1


        }

        private void SeciliyiTasi(int yeniIndeks)
        {
            Kisi k = (Kisi)lstKisiler.SelectedItem!; // !: null'i affeden operatör
            kisiler.Remove(k);
            kisiler.Insert(yeniIndeks, k);
            KisileriListele();
            lstKisiler.SelectedItem = k;
        }



        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedItem == null)
            {
                MessageBox.Show("Düzenlenmesini istediginiz kisiyi seciniz.");
                return;
            }

            Kisi k = (Kisi)lstKisiler.SelectedItem;
            Form2 frmDuzenle = new Form2(k);

            if (frmDuzenle.ShowDialog() == DialogResult.OK)
            {
                KisileriListele();
                lstKisiler.SelectedItem = k;
            }
        }

        private void lstKisiler_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                btnSil.PerformClick();
            }


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var options = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(kisiler, options);
            File.WriteAllText("veri.json", json);
        }
    }
}
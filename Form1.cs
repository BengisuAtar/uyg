namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // Personel sýnýfý
        public class Personel
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public string Pozisyon { get; set; }
            public decimal Ucret { get; set; }
            public int Kidem { get; set; }
            public string Subesi { get; set; }
            public bool Izinli { get; set; }

            public Personel(string ad, string soyad, string pozisyon, decimal ucret, int kidem, string subesi)
            {
                Ad = ad;
                Soyad = soyad;
                Pozisyon = pozisyon;
                Ucret = ucret;
                Kidem = kidem;
                Subesi = subesi;
                Izinli = false;
            }

            public override string ToString()
            {
                return Ad+ Soyad+ "- Pozisyon:" +Pozisyon+" Ücret:" +Ucret+" Kýdem:" +Kidem+ "Þube:" +Subesi +"Ýzinli:" +Izinli;
            }
        }

        // Personel listesini tutan liste
        private List<Personel> personelListesi = new List<Personel>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            // Kullanýcýdan bilgileri al
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string pozisyon = txtPozisyon.Text;
            decimal ucret = Convert.ToDecimal(txtUcret.Text);
            int kidem = Convert.ToInt32(txtKidem.Text);
            string subesi = txtSubesi.Text;

            // Yeni personel oluþtur ve listeye ekle
            Personel yeniPersonel = new Personel(ad, soyad, pozisyon, ucret, kidem, subesi);
            personelListesi.Add(yeniPersonel);
            MessageBox.Show(ad+ soyad+" baþarýyla eklendi.");
            txtAd.Clear();
            txtSoyad.Clear();
            txtPozisyon.Clear();
            txtUcret.Clear();
            txtKidem.Clear();
            txtSubesi.Clear();
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            // Kullanýcýdan çýkarýlacak personelin ad ve soyadýný al
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;

            // Personeli bul ve çýkar
            var personel = personelListesi.Find(p => p.Ad == ad && p.Soyad == soyad);
            if (personel != null)
            {
                personelListesi.Remove(personel);
                MessageBox.Show(ad+ soyad+" baþarýyla çýkarýldý.");
            }
            else
            {
                MessageBox.Show(ad+ soyad+" bulunamadý.");
            }
            txtAd.Clear();
            txtSoyad.Clear();
        }

        private void btnIzinVer_Click(object sender, EventArgs e)
        {
            // Kullanýcýdan izin verilecek personelin ad ve soyadýný al
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;

            // Personeli bul ve izni ver
            var personel = personelListesi.Find(p => p.Ad == ad && p.Soyad == soyad);
            if (personel != null)
            {
                personel.Izinli = true; // Ýzinli durumu true olarak ayarlanýr
                MessageBox.Show(ad+ soyad+" izne ayrýldý."); // Ýzin verildiði mesajý
            }
            else
            {
                MessageBox.Show(ad+ soyad+" bulunamadý."); // Personel bulunamazsa mesaj
            }
            txtAd.Clear();
            txtSoyad.Clear();
        }

        private void btnIzinKaldir_Click(object sender, EventArgs e)
        {
            // Kullanýcýdan izni kaldýrýlacak personelin ad ve soyadýný al
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;

            // Personeli bul ve izni kaldýr
            var personel = personelListesi.Find(p => p.Ad == ad && p.Soyad == soyad);
            if (personel != null)
            {
                personel.Izinli = false; // Ýzinli durumu false olarak ayarlanýr
                MessageBox.Show(ad+ soyad+" izni kaldýrýldý."); // Ýzin kaldýrýldýðý mesajý
            }
            else
            {
                MessageBox.Show(ad+ soyad+" bulunamadý."); // Personel bulunamazsa mesaj
            }
            txtAd.Clear();
            txtSoyad.Clear();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            lstboxPersonel.Items.Clear(); // ListBox'ý temizle
            foreach (var personel in personelListesi) // Her bir personel için
            {
                lstboxPersonel.Items.Add(personel); // Personel bilgilerini ekle
            }
        }

       

       
    }
}


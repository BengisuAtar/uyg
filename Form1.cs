namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // Personel s�n�f�
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
                return Ad+ Soyad+ "- Pozisyon:" +Pozisyon+" �cret:" +Ucret+" K�dem:" +Kidem+ "�ube:" +Subesi +"�zinli:" +Izinli;
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
            // Kullan�c�dan bilgileri al
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string pozisyon = txtPozisyon.Text;
            decimal ucret = Convert.ToDecimal(txtUcret.Text);
            int kidem = Convert.ToInt32(txtKidem.Text);
            string subesi = txtSubesi.Text;

            // Yeni personel olu�tur ve listeye ekle
            Personel yeniPersonel = new Personel(ad, soyad, pozisyon, ucret, kidem, subesi);
            personelListesi.Add(yeniPersonel);
            MessageBox.Show(ad+ soyad+" ba�ar�yla eklendi.");
            txtAd.Clear();
            txtSoyad.Clear();
            txtPozisyon.Clear();
            txtUcret.Clear();
            txtKidem.Clear();
            txtSubesi.Clear();
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            // Kullan�c�dan ��kar�lacak personelin ad ve soyad�n� al
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;

            // Personeli bul ve ��kar
            var personel = personelListesi.Find(p => p.Ad == ad && p.Soyad == soyad);
            if (personel != null)
            {
                personelListesi.Remove(personel);
                MessageBox.Show(ad+ soyad+" ba�ar�yla ��kar�ld�.");
            }
            else
            {
                MessageBox.Show(ad+ soyad+" bulunamad�.");
            }
            txtAd.Clear();
            txtSoyad.Clear();
        }

        private void btnIzinVer_Click(object sender, EventArgs e)
        {
            // Kullan�c�dan izin verilecek personelin ad ve soyad�n� al
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;

            // Personeli bul ve izni ver
            var personel = personelListesi.Find(p => p.Ad == ad && p.Soyad == soyad);
            if (personel != null)
            {
                personel.Izinli = true; // �zinli durumu true olarak ayarlan�r
                MessageBox.Show(ad+ soyad+" izne ayr�ld�."); // �zin verildi�i mesaj�
            }
            else
            {
                MessageBox.Show(ad+ soyad+" bulunamad�."); // Personel bulunamazsa mesaj
            }
            txtAd.Clear();
            txtSoyad.Clear();
        }

        private void btnIzinKaldir_Click(object sender, EventArgs e)
        {
            // Kullan�c�dan izni kald�r�lacak personelin ad ve soyad�n� al
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;

            // Personeli bul ve izni kald�r
            var personel = personelListesi.Find(p => p.Ad == ad && p.Soyad == soyad);
            if (personel != null)
            {
                personel.Izinli = false; // �zinli durumu false olarak ayarlan�r
                MessageBox.Show(ad+ soyad+" izni kald�r�ld�."); // �zin kald�r�ld��� mesaj�
            }
            else
            {
                MessageBox.Show(ad+ soyad+" bulunamad�."); // Personel bulunamazsa mesaj
            }
            txtAd.Clear();
            txtSoyad.Clear();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            lstboxPersonel.Items.Clear(); // ListBox'� temizle
            foreach (var personel in personelListesi) // Her bir personel i�in
            {
                lstboxPersonel.Items.Add(personel); // Personel bilgilerini ekle
            }
        }

       

       
    }
}


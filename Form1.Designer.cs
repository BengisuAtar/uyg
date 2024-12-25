namespace WinFormsApp1
{
    partial class Form1
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
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtPozisyon = new TextBox();
            txtUcret = new TextBox();
            txtSubesi = new TextBox();
            txtKidem = new TextBox();
            btnEkle = new Button();
            btnCikar = new Button();
            btnIzinVer = new Button();
            btnIzinKaldir = new Button();
            btnListele = new Button();
            lstboxPersonel = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // txtAd
            // 
            txtAd.Location = new Point(31, 30);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(31, 99);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(125, 27);
            txtSoyad.TabIndex = 1;
            // 
            // txtPozisyon
            // 
            txtPozisyon.Location = new Point(31, 173);
            txtPozisyon.Name = "txtPozisyon";
            txtPozisyon.Size = new Size(125, 27);
            txtPozisyon.TabIndex = 2;
            // 
            // txtUcret
            // 
            txtUcret.Location = new Point(31, 244);
            txtUcret.Name = "txtUcret";
            txtUcret.Size = new Size(125, 27);
            txtUcret.TabIndex = 3;
            // 
            // txtSubesi
            // 
            txtSubesi.Location = new Point(31, 389);
            txtSubesi.Name = "txtSubesi";
            txtSubesi.Size = new Size(125, 27);
            txtSubesi.TabIndex = 4;
            // 
            // txtKidem
            // 
            txtKidem.Location = new Point(31, 318);
            txtKidem.Name = "txtKidem";
            txtKidem.Size = new Size(125, 27);
            txtKidem.TabIndex = 5;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(206, 54);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 6;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnCikar
            // 
            btnCikar.Location = new Point(206, 112);
            btnCikar.Name = "btnCikar";
            btnCikar.Size = new Size(94, 29);
            btnCikar.TabIndex = 7;
            btnCikar.Text = "Çıkar";
            btnCikar.UseVisualStyleBackColor = true;
            btnCikar.Click += btnCikar_Click;
            // 
            // btnIzinVer
            // 
            btnIzinVer.Location = new Point(206, 171);
            btnIzinVer.Name = "btnIzinVer";
            btnIzinVer.Size = new Size(94, 29);
            btnIzinVer.TabIndex = 8;
            btnIzinVer.Text = "İzin ver";
            btnIzinVer.UseVisualStyleBackColor = true;
            btnIzinVer.Click += btnIzinVer_Click;
            // 
            // btnIzinKaldir
            // 
            btnIzinKaldir.Location = new Point(206, 232);
            btnIzinKaldir.Name = "btnIzinKaldir";
            btnIzinKaldir.Size = new Size(94, 29);
            btnIzinKaldir.TabIndex = 9;
            btnIzinKaldir.Text = "izin kaldır";
            btnIzinKaldir.UseVisualStyleBackColor = true;
            btnIzinKaldir.Click += btnIzinKaldir_Click;
            // 
            // btnListele
            // 
            btnListele.Location = new Point(206, 295);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(94, 29);
            btnListele.TabIndex = 10;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = true;
            btnListele.Click += btnListele_Click;
            // 
            // lstboxPersonel
            // 
            lstboxPersonel.Enabled = false;
            lstboxPersonel.FormattingEnabled = true;
            lstboxPersonel.Location = new Point(332, 42);
            lstboxPersonel.Name = "lstboxPersonel";
            lstboxPersonel.Size = new Size(440, 84);
            lstboxPersonel.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 10);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 12;
            label1.Text = "Ad Giriniz:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 76);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 13;
            label2.Text = "Soyad Giriniz:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 147);
            label3.Name = "label3";
            label3.Size = new Size(154, 20);
            label3.TabIndex = 14;
            label3.Text = "Pozisyonunuzu Giriniz:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 221);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 15;
            label4.Text = "Ücret Giriniz:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 295);
            label5.Name = "label5";
            label5.Size = new Size(101, 20);
            label5.TabIndex = 16;
            label5.Text = "Kıdem Giriniz:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 366);
            label6.Name = "label6";
            label6.Size = new Size(91, 20);
            label6.TabIndex = 17;
            label6.Text = "Şube Giriniz:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstboxPersonel);
            Controls.Add(btnListele);
            Controls.Add(btnIzinKaldir);
            Controls.Add(btnIzinVer);
            Controls.Add(btnCikar);
            Controls.Add(btnEkle);
            Controls.Add(txtKidem);
            Controls.Add(txtSubesi);
            Controls.Add(txtUcret);
            Controls.Add(txtPozisyon);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtPozisyon;
        private TextBox txtUcret;
        private TextBox txtSubesi;
        private TextBox txtKidem;
        private Button btnEkle;
        private Button btnCikar;
        private Button btnIzinVer;
        private Button btnIzinKaldir;
        private Button btnListele;
        private ListBox lstboxPersonel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}

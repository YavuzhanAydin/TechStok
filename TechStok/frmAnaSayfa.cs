using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechStok
{
    public partial class frmAnaSayfa : Form
    {
        public tbl_Kullanicilar personel;

        public frmAnaSayfa(tbl_Kullanicilar user)
        {
            InitializeComponent();

            personel = user;
            AdminMenuStrip.Visible = false;
            UserMenuStrip.Visible = false;
        
            switch (user.YetkiSeviyesi)
            {
                case 1: AdminMenuStrip.Visible = true; break;
                case 2: UserMenuStrip.Visible = true; break;
               
            }

        }

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {
            

        }

        private void frmAnaSayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void kullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKullaniciRolAta frmKullaniciRolAta = new frmKullaniciRolAta();
            frmKullaniciRolAta.MdiParent = this;
            frmKullaniciRolAta.Show();
        }

        private void kullanıcıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmKullaniciListele frmKullaniciListele = new frmKullaniciListele();
            frmKullaniciListele.MdiParent = this;
            frmKullaniciListele.Show();
        }

        private void kategoriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKategori frmKategori =new frmKategori();
            frmKategori.MdiParent = this;
            frmKategori.Show();

        }

        private void profilBilgileriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmProfilBilgileri frmProfilBilgileri = new frmProfilBilgileri();
            frmProfilBilgileri.MdiParent = this;
            frmProfilBilgileri.Show();
        }

        private void profilBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProfilBilgileri frmProfilBilgileri = new frmProfilBilgileri();
            frmProfilBilgileri.MdiParent = this;
            frmProfilBilgileri.Show();
        }

        private void kategoriİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUrunEkle frmUrunEkle = new frmUrunEkle();
            frmUrunEkle.MdiParent = this;
            frmUrunEkle.Show();
        }

        private void ürünListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUrunListele frmUrunListele = new frmUrunListele();
            frmUrunListele.MdiParent = this;
            frmUrunListele.Show();
        }

        private void urunGuncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUrunGuncelle frmUrunGuncelle = new frmUrunGuncelle();
            frmUrunGuncelle.MdiParent = this;
            frmUrunGuncelle.Show();
        }

        private void ürünSatınAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUrunSatinAl frmUrunSatinAl = new frmUrunSatinAl();
            frmUrunSatinAl.MdiParent = this;
            frmUrunSatinAl.Show();
        }

        private void rAPORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSiparislerim frmSiparislerim = new frmSiparislerim();
            frmSiparislerim.MdiParent = this;
            frmSiparislerim.Show();
        }

        private void raporlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void stokRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStokReport frmStokReport = new frmStokReport();
            frmStokReport.MdiParent = this;
            frmStokReport.Show();
        }

        private void popülerÜrünlerRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPopulerUrunlerReport frmPopuler = new frmPopulerUrunlerReport();
            frmPopuler.MdiParent = this;
            frmPopuler.Show();
        }
    }
}

using BLL;
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
    public partial class frmKullaniciListele : Form
    {
        public frmKullaniciListele()
        {
            InitializeComponent(); 
        }

        private void frmKullaniciListele_Load(object sender, EventArgs e)
        {

            dgv_1.AutoGenerateColumns = false;
            
            var sonuc = UserManager.UserList();

            dgv_1.DataSource = sonuc;  

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QLBONGDAEURO
{
    public partial class QuanLyDoiBong : Form
    {
        public QuanLyDoiBong()
        {
            InitializeComponent();
        }
        private Form activeChildForm = null;

        private void OpenChildForm(Form childForm)
        {
            if (activeChildForm != null)
            {
                activeChildForm.Close();
            }
            activeChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void lbChiTietDSDB_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Chitietdanhsachdoibong());
        }

        private void lbChiTietDSCT_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Chitietdanhsachcauthu());
        }
    }

}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace DoAn_QLBONGDAEURO
{
    public partial class TrangChu : Form
    {
        Label selectedLabel = null;
        Button selectedButton = null;
        bool hienpanel = false;
        ToolTip tooltip;
        string tenPhanMem = "Quản Lý Giải Vô Địch Bóng Đá EURO 2024";
        public TrangChu()
        {
            InitializeComponent();
            _instance = this;
            tooltip = new ToolTip();
            this.Text = tenPhanMem;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void panel_body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btQuanLy_Click(object sender, EventArgs e)
        {
            if (panel3.Visible)
            {
                panel3.Visible = false;
            }
            else
            {
                panel3.Visible=true;
            }
            panel_body.Visible = true;
            hienpanel = true;
            btQuanLy.Font = new Font(btQuanLy.Font, FontStyle.Regular);
            btQuanLy.ForeColor = Color.Black;
            if (selectedButton != null)
            {
                selectedButton.Font = new Font(selectedButton.Font, FontStyle.Regular);
                btQuanLy.ForeColor = Color.Black;
            }
            selectedButton = (sender as Button);
            this.Text = btQuanLy.Text + " - " + tenPhanMem;
        }
          private static TrangChu _instance;

        private void lbQuanLyDoiBong_Click(object sender, EventArgs e)
        {
            lbQuanLyDoiBong.Font = new Font(lbQuanLyDoiBong.Font, FontStyle.Bold);
            OpenChildForm(new QuanLyDoiBong());


        }
        private void MouseEnter(object sender, EventArgs e)
        {
            (sender as Label).Font = new Font((sender as Label).Font, FontStyle.Italic);
        }
        private void lbQuanLyDoiBong_MouseLeave(object sender, EventArgs e)
        {
            if (selectedLabel != (sender as Label))
                (sender as Label).Font = new Font((sender as Label).Font, FontStyle.Italic);
        }



        private Form currentformchild;
        private void OpenChildForm( Form childForm )
        {
            if (currentformchild != null)
            {
                currentformchild.Close();

            }
            currentformchild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if (currentformchild != null)
            {
                currentformchild.Close();
            }

        }

        private void lbQuanLyTrongTai_Click(object sender, EventArgs e)

        {
            lbQuanLyTrongTai.Font = new Font(lbQuanLyTrongTai.Font, FontStyle.Italic);
            OpenChildForm(new QuanLyTrongTai());
        }

        private void lbQuanLyThiDau_Click(object sender, EventArgs e)
        {
            lbQuanLyThiDau.Font = new Font(lbQuanLyThiDau.Font, FontStyle.Italic);
            OpenChildForm(new QuanLyThiDau());

        }

        private void lbQuanLyKetQuaTD_Click(object sender, EventArgs e)
        {
            lbQuanLyKetQuaTD.Font = new Font(lbQuanLyKetQuaTD.Font, FontStyle.Italic);
            OpenChildForm(new QuanLyKetQua());
        }

        private void btTraCuu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TraCuu());
        }

        

    }



}


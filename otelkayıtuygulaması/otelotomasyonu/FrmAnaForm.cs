﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otelotomasyonu
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdminGiris fr = new FrmAdminGiris();
            fr.Show();
            this.Hide();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmYeniMusteri fr = new FrmYeniMusteri();
            fr.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmMusteriler fr = new FrmMusteriler();
            fr.Show();


        }

        private void button7_Click(object sender, EventArgs e)
        {
            Odalar2 fr = new Odalar2();
            fr.Show();



        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmOdalar fr = new FrmOdalar();
            fr.Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Odalar3 fr = new Odalar3();
            fr.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmMesajlar fr = new FrmMesajlar();
            fr.Show();


        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmSifreGuncelle fr = new FrmSifreGuncelle();
            fr.Show();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            FrmHizmetler fr = new FrmHizmetler();
            fr.Show();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            FrmGelirGider frm = new FrmGelirGider();
            frm.Show();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            FrmStoklar frm = new FrmStoklar();
            frm.Show();
        }
    }
}

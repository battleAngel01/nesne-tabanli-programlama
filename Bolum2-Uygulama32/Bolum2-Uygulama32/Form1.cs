﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bolum2_Uygulama32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayinin_karesi;
            try
            {
                sayi1 = Convert.ToInt16(textBox1.Text);
                sayinin_karesi = sayi1 * sayi1;
                MessageBox.Show(sayinin_karesi.ToString());
            }
            catch
            {
                MessageBox.Show("Hatalı giriş yaptınız!");
            }
            finally
            {
                // Hata olsa da olmasa da çalışacak kodlar
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int progress = Convert.ToInt32(textBox2.Text);
            progressBar1.Value = progress;
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {

        double bil1, bil2, hasil;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_bil1.Text) || string.IsNullOrEmpty(txt_bil2.Text))
            {
                MessageBox.Show("Angka 1 dan Angka 2 Harus Diisi Terlebih Dahulu !");
            }
            else
            {
                //int bil1, bil2, hasil;
                bil1 = double.Parse(txt_bil1.Text);
                bil2 = double.Parse(txt_bil2.Text);
                hasil = bil1 + bil2;

                //untuk menampilkan hasil
                txt_hasil.Text = hasil.ToString();
            }
        }

        private void btn_kurang_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_bil1.Text) || string.IsNullOrEmpty(txt_bil2.Text))
            {
                MessageBox.Show("Angka 1 dan Angka 2 Harus Diisi Terlebih Dahulu !");
            }
            else
            {
                //int bil1, bil2, hasil;
                bil1 = double.Parse(txt_bil1.Text);
                bil2 = double.Parse(txt_bil2.Text);
                hasil = bil1 - bil2;

                //untuk menampilkan hasil
                txt_hasil.Text = hasil.ToString();
            }
        }

        private void btn_kali_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_bil1.Text) || string.IsNullOrEmpty(txt_bil2.Text))
            {
                MessageBox.Show("Angka 1 dan Angka 2 Harus Diisi Terlebih Dahulu !");
            }
            else
            {
                //int bil1, bil2, hasil;
                bil1 = double.Parse(txt_bil1.Text);
                bil2 = double.Parse(txt_bil2.Text);
                hasil = bil1 * bil2;

                //untuk menampilkan hasil
                txt_hasil.Text = hasil.ToString();
            } 
        }

        private void btn_bagi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_bil1.Text) || string.IsNullOrEmpty(txt_bil2.Text))
            {
                MessageBox.Show("Angka 1 dan Angka 2 Harus Diisi Terlebih Dahulu !");
            }
            else
            {
                double bil1;
                double bil2, hasil;
                bil1 = double.Parse(txt_bil1.Text);
                bil2 = double.Parse(txt_bil2.Text);
                hasil = bil1 / bil2;

                //untuk menampilkan hasil
                txt_hasil.Text = hasil.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_bil1.Clear();
            txt_bil2.Clear();
            txt_hasil.Clear();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_bil1.Clear();
            txt_bil2.Clear();
            txt_hasil.Clear();
        }
    }
}

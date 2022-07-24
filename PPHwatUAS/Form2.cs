using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPHwatUAS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(masukanGaji.Text=="")
            {
                MessageBox.Show("Isian harus diisi tidak boleh kosong");
                return;
            }
            else if (bebanTanggung.Text == "" && menikahh.Checked)
            {
                MessageBox.Show("Isian harus diisi tidak boleh kosong");
                return;
            }
            else if (JumlahAnak.Text == ""&&menikahh.Checked)//(masukanGaji.Text.Trim() == string.Empty&& bebanTanggung.Text.Trim() == string.Empty&& ptkp.Text.Trim() == string.Empty&& pkp.Text.Trim() == string.Empty&& textBox4.Text.Trim() == string.Empty&& textBox5.Text.Trim() == string.Empty&& JumlahAnak.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Isian harus diisi tidak boleh kosong");
                return;
            }


            else
            {
                long gajiBulanan, bebanTanggungan, pb, saya = 54000000, istri = 4500000, anak, totalptkp, totalpkp, totalpph;
                gajiBulanan = Convert.ToInt32(masukanGaji.Text);
                
                if (lajangg.Checked)
                {
                    //penghasilan bersih
                    pb = gajiBulanan * 12;

                    //ptkp lajang
                    totalptkp = saya;
                    this.ptkp.Text = totalptkp.ToString();

                    //pkp lanjang
                    totalpkp = pb - totalptkp;
                    this.pkp.Text = totalpkp.ToString();

                    //pph
                    if (totalpkp < 50000000)
                    {
                        totalpph = totalpkp * 5 / 100;
                        this.pph.Text = totalpph.ToString();
                    }
                    else if (totalpkp < 250000000)
                    {
                        totalpph = totalpkp * 15 / 100;
                        this.pph.Text = totalpph.ToString();
                    }
                    else if (totalpkp < 500000000)
                    {
                        totalpph = totalpkp * 25 / 100;
                        this.pph.Text = totalpph.ToString();
                    }
                    else if (totalpkp > 500000000)
                    {
                        totalpph = totalpkp * 30 / 100;
                        this.pph.Text = totalpph.ToString();
                    }
                }
                if (menikahh.Checked)
                {
                    bebanTanggungan = Convert.ToInt32(bebanTanggung.Text);
                    //penghasilan bersih
                    pb = gajiBulanan - bebanTanggungan;

                    //ptkp
                    int n = Convert.ToInt32(JumlahAnak.Text);
                    anak = n * 4500000;
                    totalptkp = saya + istri + anak;
                    this.ptkp.Text = totalptkp.ToString();

                    //pkp
                    totalpkp = pb - totalptkp;
                    this.pkp.Text = totalpkp.ToString();

                    //pph
                    if(totalpkp<50000000)
                    {
                        totalpph = totalpkp * 5 / 100;
                        this.pph.Text = totalpph.ToString();
                    }
                    else if(totalpkp<250000000)
                    {
                        totalpph = totalpkp * 15 / 100;
                        this.pph.Text = totalpph.ToString();
                    }
                    else if (totalpkp < 500000000)
                    {
                        totalpph = totalpkp * 25 / 100;
                        this.pph.Text = totalpph.ToString();
                    }
                    else if (totalpkp > 500000000)
                    {
                        totalpph = totalpkp * 30 / 100;
                        this.pph.Text = totalpph.ToString();
                    }
                }
            }
        }

        void masukanGaji_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 about = new Form3();
            about.Show();
        }

        private void menikahh_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

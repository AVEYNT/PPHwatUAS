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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string uname = Convert.ToString(username.Text);
            string pw = Convert.ToString(password.Text);
            if(uname == "Username" && pw == "Password")
            {
                Form2 form2 = new Form2();
                this.Hide();
                form2.Show();
                MessageBox.Show("Anda berhasil login.\n\nSilahkan baca panduan penggunaan terlebih dahulu.");
            }
            else
            {
                string message = "Nama akun dan sandi mungkin salah, Silahkan masukan ulang.\n\nTekan Bantuan untuk membantu anda.";
                
                MessageBox.Show(message);

            }
        }
    }
}

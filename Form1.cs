using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kuis10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        decimal angka1;
        decimal angka2;
        decimal hasil;


        private void bersih()
        {
            texthasil.Text = "0";
            textinput1.Text = "";
            textinput2.Text = "";
            
         
        }
        private void fokus()
        {
            texthasil.Focus();
            texthasil.Select(texthasil.Text.Length, 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Focus();
            bersih();

        }

        private void textinput1_TextChanged(object sender, EventArgs e)
        {
            Button btnAng = (Button)sender;
         
        }

        private void texthasil_TextChanged(object sender, EventArgs e)
        {
      
        }
    }
}

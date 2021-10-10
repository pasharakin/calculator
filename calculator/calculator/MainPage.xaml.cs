using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace calculator
{
    public partial class MainPage : ContentPage
    {
        public string D;
        public string N1;
        public bool N2;
        public MainPage()
        {
            N2 = false;
            InitializeComponent();
        }

        private void k0_Clicked(object sender, EventArgs e)
        {
            if(N2)
            {
                N2 = false;
                rez.Text = "0";
            }
            Button k1 = (Button)sender;
            if (rez.Text == "0")
            {
                rez.Text = k1.Text;
            }
            else
            {
                rez.Text = rez.Text + k1.Text;
            }
        }

        private void kac_Clicked(object sender, EventArgs e)
        {
            rez.Text = "0";
        }

        private void kc_Clicked(object sender, EventArgs e)
        {
            if (Convert.ToInt32(rez.Text.Length) != 1)
            {
                rez.Text = rez.Text.Remove((Convert.ToInt32(rez.Text.Length)) - 1);
            }
            else
            {
                rez.Text = "0";
            }
        }

        private void kplus_Clicked(object sender, EventArgs e)
        {
            Button kplus = (Button)sender;
            D = kplus.Text;
            N1 = rez.Text;
            N2 = true;
        }

        private void kravno_Clicked(object sender, EventArgs e)
        {
            double dn1, dn2, res;
            res = 0;
            dn1 = Convert.ToDouble(N1);
            dn2 = Convert.ToDouble(rez.Text);
            if (D == "+")
            {
                res = dn1 + dn2;
            }
            if (D == "-")
            {
                res = dn1 - dn2;
            }
            if (D == "*")
            {
                res = dn1 * dn2;
            }
            if (D == "/")
            {
                res = dn1 / dn2;
            }
            D = "=";
            N2 = true;
            rez.Text = res.ToString();
        }

        private void kcomma_Clicked(object sender, EventArgs e)
        {
            if (!rez.Text.Contains("."))
            {
                rez.Text = rez.Text + ".";
            }
        }

        private void pm_Clicked(object sender, EventArgs e)
        {
            double dn, res;
            dn = Convert.ToDouble(rez.Text);
            res = -dn;
            rez.Text = res.ToString();
        }
    }
}
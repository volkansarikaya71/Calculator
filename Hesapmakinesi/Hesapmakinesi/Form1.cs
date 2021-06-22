using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesapmakinesi
{
    public partial class Hesap : Form
    {
        public Hesap()
        {
            InitializeComponent();
        }
        Islemler islemler = new Islemler();
        public double islem, sondeger;
        public char? dortislemtutucu;
        public void controltext()
        {
            if (islem >= 0)
            {
                sayiekrani.Clear();
                islem = -1;
            }
        }
        public void operatorcontrol()
        {
            islem++;
            switch (dortislemtutucu)
            {
                case '+':
                    sondeger = islemler.Topla(Convert.ToDouble(sayiekrani.Text));
                    break;
                case '-':
                    sondeger = islemler.Cıkar(Convert.ToDouble(sayiekrani.Text));
                    break;
                case '*':
                    sondeger = islemler.Carp(Convert.ToDouble(sayiekrani.Text));
                    break;
                case '/':
                    sondeger = islemler.Bol(Convert.ToDouble(sayiekrani.Text));
                    break;
                case '%':
                    sondeger = islemler.Mod(Convert.ToDouble(sayiekrani.Text));
                    break;
            }
            sayiekrani.Text = sondeger.ToString();
        }
        private void sayilar(object sender, EventArgs e)
        {
            controltext();
            Button btn = (Button)sender;
            sayiekrani.Text += btn.Text;
        }
        private void esittir_Click(object sender, EventArgs e)
        {
            operatorcontrol();
            dortislemtutucu =null;
        }
        private void delete(object sender, EventArgs e)
        {
            Button delete = (Button)sender;
            string deletetutucu = delete.Text.ToString();
            switch (deletetutucu)
            {
                case "C":
                    {
                        sayiekrani.Clear();
                        islemler.Sifirla();
                        dortislemtutucu = null;
                        islem = -1;
                    }
                    break;
                case "CE":sayiekrani.Clear();
                    break;
                case "<-":
                    {
                        if (sayiekrani.Text != "")
                        { 
                        sayiekrani.Text = sayiekrani.Text.Substring(0, sayiekrani.Text.Length - 1);
                        islem = -1;
                        }
                    }
                    break;
            }
        }
        private void operatorler(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (dortislemtutucu == null)
            {
                dortislemtutucu = Convert.ToChar(btn.Text);
                operatorcontrol();
            }
            else
            {
                operatorcontrol();
                dortislemtutucu = Convert.ToChar(btn.Text);
            }
        }
        private void Numbernokta_Click(object sender, EventArgs e)
        {
            controltext();
            if (!sayiekrani.Text.Contains(","))
            {
                if (sayiekrani.Text == "")
                {
                    sayiekrani.Text += "0,";
                }
                else
                sayiekrani.Text += ",";
            }
        }
    }
}

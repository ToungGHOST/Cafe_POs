using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee
{
    public partial class Form1 : Form
    {
        string POS = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public Form1()
        {
            InitializeComponent();
        }
        public void C(string Menu, string Bath)
        {
            string[] C = { Menu, Bath };
            var L = new ListViewItem(C);
            listView1.Items.Add(L);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            C("Esspresso(Hot)", "35");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            C("Esspresso(Ice)", "45");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            C("Esspresso(Frappe)", "50");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            C("Americano(Hot)", "35");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            C("Americano(Ice)", "45");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            C("Latte(Hot)", "35");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            C("Latte(Ice)", "45");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            C("Latte(Frappe)", "50");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            C("Mocha(Hot)", "35");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            C("Mocha(Ice)", "45");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            C("Mocha(Frappe)", "50");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            C("Cappuccino(Hot)", "35");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            C("Cappuccino(Ice)", "45");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            C("Cappuccino(Frappe)", "50");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            C("Greentea(Hot)", "20");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            C("Greentea(Ice)", "25");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            C("Greentea(Frappe)", "30");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            C("Thaitea(Hot)", "20");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            C("Thaitea(Ice)", "25");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            C("Thaitea(Frappe)", "30");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            C("Cocoa(Hot)", "20");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            C("Cocoa(Ice)", "25");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            C("Cocoa(Frappe)", "30");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            C("Milk(Hot)", "20");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            C("Milk(Ice)", "25");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            C("Milk(Frappe)", "30");
        }

        private void button35_Click(object sender, EventArgs e)
        {
            C("Milktea(Ice)", "25");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            C("Milktea(Frappe)", "30");
        }

        private void button32_Click(object sender, EventArgs e)
        {

            C("Lemontea(Ice)", "25");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            C("Lemontea(Frappe)", "30");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            C("Milo(Hot)", "20");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            C("Milo(Ice)", "25");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            C("Milo(Frappe)", "30");
        }

        private void button39_Click(object sender, EventArgs e)
        {
            C("Nescafe(Hot)", "20");
        }

        private void button38_Click(object sender, EventArgs e)
        {
            C("Nescafe(Ice)", "25");

        }

        private void button37_Click(object sender, EventArgs e)
        {
            C("Nescafe(Frappe)", "30");
        }

        private void button42_Click(object sender, EventArgs e)
        {
            C("NesteaTea(Hot)", "20");
        }

        private void button41_Click(object sender, EventArgs e)
        {
            C("NesteaTea(Ice)", "25");
        }

        private void button40_Click(object sender, EventArgs e)
        {
            C("NesteaTea(Frappe)", "30");
        }

        private void button44_Click(object sender, EventArgs e)
        {

            C("Cantalupe", "25");
        }

        private void button43_Click(object sender, EventArgs e)
        {
            C("Strawberry", "25");
        }

        private void button46_Click(object sender, EventArgs e)
        {
            C("Apple", "25");
        }

        private void button45_Click(object sender, EventArgs e)
        {
            C("Bluehawai", "25");
        }

        private void button48_Click(object sender, EventArgs e)
        {
            C("Red lime Soda", "25");
        }

        private void button47_Click(object sender, EventArgs e)
        {
            C("Honey lime Soda", "25");
        }
        double P;
        public string[] K()
        {
            P = 0;
            string[] G = new string[listView1.Items.Count];
            int item = listView1.Items.Count;
            for (int i=0;i< item; i++)
            {
                P += double.Parse(listView1.Items[i].SubItems[1].Text);
                G[i] = listView1.Items[i].SubItems[0].Text.ToString();
            }
            Pice.Text = P.ToString();
            return G;

        }
        public string[] M()
        {
            string[] G = new string[listView1.Items.Count];
            int item = listView1.Items.Count;
            for (int i = 0; i < item; i++)
            {
                G[i] = listView1.Items[i].SubItems[1].Text.ToString();
            }
            return G;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabcontal1.Controls.Remove(Payment);
        }
        public void HA()
        {
            string[] J = K();
            string[] b = M();
            string mu = "Coffee Pos" + DateTime.Now.ToString("hhmmss_dd_mm_yyyy");
            string LOL = "Coffee Pos";
            LOL += "\r\n" + DateTime.Now.ToString("hh:mm:ss") + "\r\n" + DateTime.Now.ToString("dd/mm/yyyy") + "\r\n" + "\r\n";
            LOL += "Menu" + "\r\n";
            for(int i = 0; i < listView1.Items.Count; i++)
            {
                LOL += J[i] + new String(' ', 20) + b[i] + "Bath" + "\r\n";
               
            }
            LOL += "\r\n";
            LOL += "Totle Price :" + Pice.Text;
            System.IO.File.WriteAllText(POS + @"\" + mu + ".txt", LOL);
            label28.Text += LOL + "\r\n" + "\r\n" + "\r\n" + "\r\n" + "Save File at" + POS + @"\" + mu + ".txt";

        }
        bool oh = false;

        private void button49_Click(object sender, EventArgs e)
        {
            Pice.Text = "";
            if (oh == false)
            {
                tabcontal1.TabPages.Insert(1, Payment);
                oh = true;
                tabcontal1.SelectedTab = Payment;
            }
            else tabcontal1.SelectedTab = Payment;
            if (listView1.Items.Count > 0)
                HA();
        }

        private void button50_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            oh = false;
            tabcontal1.Controls.Remove(Payment);
            label28.Text = "";
            Pice.Text = "";
        }
    }
}

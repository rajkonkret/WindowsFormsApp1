using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<string> l = new List<string>();
        public Form1()
        {
            InitializeComponent();
            
            tekst.Text = "TEST";
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            tekst.Text = "klik";
        }
        

        private void Button1_MouseClick(object sender, MouseEventArgs e)
        {
			
			
			tekst.Text = "klik_button1";
        }

		private void Button1_KeyDown(object sender, KeyEventArgs e)
		{
			tekst.Text = "klik_key";
		}

		private void Button7_Click(object sender, EventArgs e)
		{
			tekst.Text = "";
            tekst.Text = (sender as Button).Name.ToString();
            l.Add(tekst.Text);
            
               
		}

        private void Form1_Load(object sender, EventArgs e)
        {
            ListViewItem lv1 = new ListViewItem("a                                   ", 0);
            listView1.Items.Add(lv1);
            ListViewItem lv2 = new ListViewItem("aA                                  ", 0);
            listView1.Items.Add(lv2);
            ListViewItem lv3 = new ListViewItem("aAa                                 ", 0);
            listView1.Items.Add(lv3);
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListView1_Click(object sender, EventArgs e)
        {
            tekst.Text = listView1.SelectedItems[0].Text;
        }

        private void ListView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
             
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string filename = "";

        private void Create_Click(object sender, EventArgs e)
        {
            filename = "D:\\university\\3 CS\\second term\\File Organization\\project\\" + filetextbox.Text + ".txt";
            if (!File.Exists(filename))
            {
                File.Create(filename).Close();
                MessageBox.Show("");
            }
            else
            {
                label.Visible = true;
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            filename = "D:\\university\\3 CS\\second term\\File Organization\\project\\" + filetextbox.Text + ".txt";
            if (File.Exists(filename))
            {
                File.Delete(filename);
                MessageBox.Show("File is Deleted");
                filetextbox.Clear();
                label.Visible = false;
            }
            else
            {
                MessageBox.Show("File isn't Founded, Please try again");
            }
        }
 
        private void Save_Click(object sender, EventArgs e)
        {
            BinaryWriter bw = new BinaryWriter(File.Open(filename, FileMode.Open, FileAccess.Write));
            int length = (int)bw.BaseStream.Length;
            if (length != 0)
            {
                bw.Seek(length, SeekOrigin.Begin);
            }
            bw.Write(Int32.Parse(isbntb.Text)); //ISBN
            
            typetb.Text= typetb.Text.PadRight(9); //Type
            bw.Write(typetb.Text.Substring(0,9));

            titletb.Text = titletb.Text.PadRight(11); //title
            bw.Write(titletb.Text.Substring(0, 11));

            bw.Write(Int32.Parse(pagecounttb.Text)); //page count

            bw.Write(double.Parse(pricetb.Text).ToString()); //price

            isbntb.Text = typetb.Text = titletb.Text = pagecounttb.Text = pricetb.Text = "";

            MessageBox.Show("Data is saved successfully");
            bw.Close();
        }

        

        

        
    }
}

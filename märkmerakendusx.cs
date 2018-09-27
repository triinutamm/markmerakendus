using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace markmerakendus
{
    public partial class Form1 : Form
    {
        string pealkiri;

        private void refreshlist()
        {
            notelist.Items.Clear();
            string[] failinimed = Directory.GetFiles(@"C:\Users\triinu\Desktop\kool\proge\markmerakendus\markmerakendus\markmerakendus\notes\");
            int length = failinimed.Length;
            for (int i = 0; i < length; i++)
            {
                string failinimi = Path.GetFileNameWithoutExtension(failinimed[i]);
                notelist.Items.Add(failinimi);
            }
        }

        private void leftsidevis()
        {
            tekstiaken.Visible = !tekstiaken.Visible;
            lisa_btn.Visible = !lisa_btn.Visible;
            tekstipealkiri.Visible = !tekstipealkiri.Visible;
            labelpealkiri.Visible = !labelpealkiri.Visible;
            labeltekst.Visible = !labeltekst.Visible;
        }
        private void salvesta()
        {
            pealkiri = tekstipealkiri.Text;
            if (pealkiri == "")
            {
            }
            else
            {
                TextWriter sisu = new StreamWriter(@"C:\Users\triinu\Desktop\kool\proge\markmerakendus\markmerakendus\markmerakendus\notes\" + pealkiri + ".txt");
                sisu.Write(tekstiaken.Text);
                sisu.Close();
            }
        }

        public Form1()
        {
            InitializeComponent();
            refreshlist();           
        }

        private void addnote_btn_Click(object sender, EventArgs e)
        {
            notelist.SelectedItems.Clear();
            ava_btn.Enabled = false;
            kustuta_btn.Enabled = false;
            addnote_btn.Enabled = false;
            leftsidevis();
        }

        private void lisa_btn_Click(object sender, EventArgs e)
        {
            salvesta();
            if (tekstiaken.Text == "")
            {
                leftsidevis();
                ava_btn.Enabled = true;
                kustuta_btn.Enabled = true;
            }
            else
            {
                if (pealkiri.ToString() == "")
                {
                    MessageBox.Show("Sisesta pealkiri!");
                }
                else
                {
                    refreshlist();
                    leftsidevis();
                    ava_btn.Enabled = true;
                    kustuta_btn.Enabled = true;
                }
                
            }
            addnote_btn.Enabled = true;
            tekstiaken.Clear();
            tekstipealkiri.Clear();
        }

        private void ava_btn_Click(object sender, EventArgs e)
        {
            addnote_btn.Enabled = false;
            kustuta_btn.Enabled = false;
            ava_btn.Enabled = false;
            if (notelist.SelectedItem == null)
            {
                MessageBox.Show("Valikut pole tehtud!");
                kustuta_btn.Enabled = true;
                addnote_btn.Enabled = true;
                ava_btn.Enabled = true;

            }
            else
            {
                leftsidevis();
                pealkiri = notelist.SelectedItem.ToString();
                string tekst = File.ReadAllText(@"C:\Users\triinu\Desktop\kool\proge\markmerakendus\markmerakendus\markmerakendus\notes\" + pealkiri + ".txt");

                tekstipealkiri.Text = pealkiri;
                tekstiaken.Text = tekst;
                File.Delete(@"C:\Users\triinu\Desktop\kool\proge\markmerakendus\markmerakendus\markmerakendus\notes\" + pealkiri + ".txt");
                salvesta();
                refreshlist();
            }
        }

        private void kustuta_btn_Click(object sender, EventArgs e)
        {
            if (notelist.SelectedItem == null)
            {
                MessageBox.Show("Valikut pole tehtud!");
            }
            else
            {
                pealkiri = notelist.SelectedItem.ToString();
                File.Delete(@"C:\Users\triinu\Desktop\kool\proge\markmerakendus\markmerakendus\markmerakendus\notes\" + pealkiri + ".txt");
                refreshlist();
            }
        }
    }
}

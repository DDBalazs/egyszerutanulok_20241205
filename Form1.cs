using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace egyszerutanulok_20241205
{
    public partial class Form : System.Windows.Forms.Form
    {
        List<Tanulok> lista = new List<Tanulok>();
        string elsosor;
        string igazolvanyszam;
        int index;
        public Form()
        {
            InitializeComponent();
        }

        void betoltes()
        {
            FileStream fs = new FileStream("..\\..\\src\\tanulo.csv", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            elsosor = sr.ReadLine();
            while (!sr.EndOfStream)
            {
                Tanulok t = new Tanulok(sr.ReadLine());
                lista.Add(t);
                dgadatok.Rows.Add(t.Nev,t.Igszam);
            }
            sr.Close();
            fs.Close();

            for(int i = 0; i < lista.Count; i++)
            {
                if (!cbtelepules.Items.Contains(lista[i].Varos))
                {
                    cbtelepules.Items.Add(lista[i].Varos);
                }
            }
            
        }

        private void Form_Load(object sender, EventArgs e)
        {
            betoltes();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txigszam_TextChanged(object sender, EventArgs e)
        {
            if (txigszam.Text.Length > 0)
            {
                for(int i = 0; i < lista.Count; i++)
                {
                    if(txigszam.Text == lista[i].Igszam && index != i)
                    {
                        MessageBox.Show("Ilyen igazolványszám már másnál szerepel!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txigszam.Text = igazolvanyszam;
                    }
                }
            }

        }

        private void txnev_TextChanged(object sender, EventArgs e)
        {
            //if(txnev.Text.Length > 0)
            //{
            //    try
            //    {
            //        Convert.ToString(txnev.Text);
            //    }
            //    catch
            //    {
            //        MessageBox.Show("Nem betűt adtál meg!","Hiba",MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        txnev.Clear();
            //        txnev.Focus();
            //    }
            //}
        }

        private void cbtelepules_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgadatok.Rows.Clear();
            for (int i = 0; i<lista.Count; i++)
            {
                if (lista[i].Varos == cbtelepules.Text)
                {
                    dgadatok.Rows.Add(lista[i].Nev, lista[i].Igszam);
                }
            }
        }

        private void dgadatok_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewRow sor = dgadatok.Rows[e.RowIndex];
            //igazolvanyszam=sor.Cells["igazolvany"].Value.ToString();
            //txigszam.Text = igazolvanyszam;

        }

        private void dgadatok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow sor = dgadatok.Rows[e.RowIndex];
            igazolvanyszam=sor.Cells["igazolvany"].Value.ToString();
            index = 0;
            while(lista[index].Igszam != igazolvanyszam)
            {
                index++;
            }
            txnev.Text = lista[index].Nev;
            txosztaly.Text = lista[index].Osztaly;
            txigszam.Text = lista[index].Igszam;
            txutca.Text = lista[index].Utca;
            txirszam.Text = lista[index].Irszam;
            txvaros.Text = lista[index].Varos;
            dtszuletett.Value = lista[index].Szulido;
        }

        private void btmod_Click(object sender, EventArgs e)
        {
            if(txigszam.TextLength == 0)
            {
                MessageBox.Show("Adja meg az igazolványszámot!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txigszam.Clear();
                txigszam.Focus();
            }
            else if(txosztaly.Text.Length == 0)
            {
                MessageBox.Show("Adja meg az osztályát!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txosztaly.Clear();
                txosztaly.Focus();
            }
            else if (txnev.Text.Length == 0)
            {
                MessageBox.Show("Adja meg a nevét!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txnev.Clear();
                txnev.Focus();
            }
            else if (txirszam.Text.Length == 0)
            {
                MessageBox.Show("Adja meg az irányítószámát!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txirszam.Clear();
                txirszam.Focus();
            }
            else if (txvaros.Text.Length == 0)
            {
                MessageBox.Show("Adja meg a városát!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txvaros.Clear();
                txvaros.Focus();
            }
            else if (txutca.Text.Length == 0)
            {
                MessageBox.Show("Adja meg az utcáját!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txutca.Clear();
                txutca.Focus();
            }
            else
            {
                lista[index].Osztaly = txosztaly.Text;
                lista[index].Igszam = txigszam.Text;
                lista[index].Varos = txvaros.Text;
                lista[index].Irszam = txirszam.Text;
                lista[index].Nev = txnev.Text;
                lista[index].Utca = txutca.Text;
                lista[index].Szulido = dtszuletett.Value;

                FileStream fs = new FileStream("..\\..\\src\\tanulo.csv", FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(elsosor);

                for(int i = 0; i < lista.Count; i++)
                {
                    sw.Write("\n" + lista[i].Igszam + ";" + lista[i].Nev + ";" + lista[i].Szulido.ToString() + ";" + lista[i].Osztaly + ";" + lista[i].Irszam + ";" + lista[i].Varos + ";" + lista[i].Utca);
                }
                sw.Close();
                fs.Close();
                lbuzenet.Text = "Sikeres módotsítás!";
                txigszam.Clear();
                txnev.Clear();
                txosztaly.Clear();
                txirszam.Clear();
                txutca.Clear();
                txvaros.Clear();
            }
        }

        private void cxigaz_CheckedChanged(object sender, EventArgs e)
        {
            if (cxigaz.Checked)
            {
                txigszam.Enabled = true;
            }
            else
            {
                txigszam.Enabled = false;
            }
        }
    }
}

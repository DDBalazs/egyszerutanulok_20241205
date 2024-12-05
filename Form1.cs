using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace egyszerutanulok_20241205
{
    public partial class Form : System.Windows.Forms.Form
    {
        List<Tanulok> lista = new List<Tanulok>();
        string elsosor;
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
                if (cbtelepules.Items.Contains(lista[i]))
                {
                    return;
                }
                else
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
            if (rbigszam.Checked)
            {
                txigszam.Enabled = true;
            }
        }
    }
}

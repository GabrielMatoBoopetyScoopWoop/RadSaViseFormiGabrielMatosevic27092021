using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadSaViseFormiGabrielMatosevic27092021
{
    public partial class Studenti : Form
    {
        public Studenti()
        {
            InitializeComponent();
        }

        private string ime { get; set; }
        private string prezime { get; set; }
        private string brojIndeksa { get; set; }
        private DateTime datumRodjenja { get; set; }
        private string smjer { get; set; }

        public Studenti(string Ime, string Prezime, string BrojIndeksa, DateTime DatumRodjenja, string Smjer)
        {
            this.ime = Ime;
            this.prezime = Prezime;
            this.brojIndeksa = BrojIndeksa;
            this.datumRodjenja = DatumRodjenja;
            this.smjer = Smjer;
        }

        public override string ToString() 
        {
            return "Ime = " + this.ime + "\n Prezime = " + this.prezime + "\n Broj indeksa = " + this.brojIndeksa + "\n Datum rodjenja = " + this.datumRodjenja + "\n smjer = " + this.smjer;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void DodajNovogStudentaButton_Click(object sender, EventArgs e)
        {
            UnosNovogStudenta NoviStudent = new UnosNovogStudenta();
            NoviStudent.Show();
        }
    }
}

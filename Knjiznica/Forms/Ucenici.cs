using Knjiznica.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Knjiznica.Forms
{
    public partial class Ucenici : Form
    {
        public Ucenici()
        {
            InitializeComponent();
        }

        private void Ucenici_Load(object sender, EventArgs e)
        {
            List<Ucenik> spremljeniUcenici = new List<Ucenik>();

            if (File.Exists("Ucenici.txt"))
            {

                StreamReader streamReader = new StreamReader("Ucenici.txt");

                while (streamReader.EndOfStream == false)
                {

                    string linija = streamReader.ReadLine();
                    string[] elementi = linija.Split('|');

                    Ucenik trenutniUcenik = new Ucenik();
                    trenutniUcenik.OIB = elementi[0];
                    trenutniUcenik.Ime = elementi[1];
                    trenutniUcenik.Prezime = elementi[2];
                    trenutniUcenik.Adresa = elementi[3];
                    trenutniUcenik.Telefon = elementi[4];
                    trenutniUcenik.Razred = int.Parse(elementi[5]);


                    spremljeniUcenici.Add(trenutniUcenik);

                }

            }

            spremljeniUcenici.Sort();
            foreach (Ucenik ucenik in spremljeniUcenici)
            {
                lbUcenici.Items.Add(ucenik);
            }

        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
            DetaljiUcenika formaDodaj = new DetaljiUcenika();
            formaDodaj.ShowDialog();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strzelnica
{
    public partial class Strzelnica : Form
    {

        public Strzelnica()
        {
            InitializeComponent();
        }

        private void Strzelnica_Load_1(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'strzelnicaDS.WYPOZYCZENIA' . Możesz go przenieść lub usunąć.
            this.wYPOZYCZENIATableAdapter.Fill(this.strzelnicaDS.WYPOZYCZENIA);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'strzelnicaDS.BRONIE' . Możesz go przenieść lub usunąć.
            this.bRONIETableAdapter.Fill(this.strzelnicaDS.BRONIE);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'strzelnicaDS.STANOWISKA' . Możesz go przenieść lub usunąć.
            this.sTANOWISKATableAdapter.Fill(this.strzelnicaDS.STANOWISKA);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'strzelnicaDS.KARNETY' . Możesz go przenieść lub usunąć.
            this.kARNETYTableAdapter.Fill(this.strzelnicaDS.KARNETY);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'strzelnicaDS.TRENERZY' . Możesz go przenieść lub usunąć.
            this.tRENERZYTableAdapter.Fill(this.strzelnicaDS.TRENERZY);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'strzelnicaDS.KLIENCI' . Możesz go przenieść lub usunąć.
            this.kLIENCITableAdapter.Fill(this.strzelnicaDS.KLIENCI);

        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void KlDodaj_Click(object sender, EventArgs e)
        {
            NewKlient NKlie = new NewKlient();
            NKlie.Show();
        }

        private void TrDodaj_Click(object sender, EventArgs e)
        {
            NewTrainer NTrainer = new NewTrainer();
            NTrainer.Show();
        }

        private void KaDodaj_Click(object sender, EventArgs e)
        {
            NewKarnet NKarnet = new NewKarnet();
            NKarnet.Show();
        }

        private void StDodaj_Click(object sender, EventArgs e)
        {
            NewStan NStano = new NewStan();
            NStano.Show();
        }

        private void WypDodaj_Click(object sender, EventArgs e)
        {
            NewWypo nWypo = new NewWypo();
            nWypo.Show();
        }

        private void BrDodaj_Click(object sender, EventArgs e)
        {
            NewBron NBron = new NewBron();
            NBron.Show();
        }

        private void KlEdytuj_Click(object sender, EventArgs e)
        {
            EdytKlient EKlie = new EdytKlient();
            EKlie.Show();
        }

        private void TrEdytuj_Click(object sender, EventArgs e)
        {
            EdytTrener ETren = new EdytTrener();
            ETren.Show();
        }

        private void KaEdytuj_Click(object sender, EventArgs e)
        {
            EdytKarnet EKar = new EdytKarnet();
            EKar.Show();
        }

        private void StEdytuj_Click(object sender, EventArgs e)
        {
            EdytStanowisko EStan = new EdytStanowisko();
            EStan.Show();
        }

        private void BrEdytuj_Click(object sender, EventArgs e)
        {
            EdytBron EBron = new EdytBron();
            EBron.Show();
        }

        private void WypEdytuj_Click(object sender, EventArgs e)
        {
            EdytWypo EWyp = new EdytWypo();
            EWyp.Show();
        }

    }
    }
    


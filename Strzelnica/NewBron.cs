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
    public partial class NewBron : Form
    {
        public NewBron()
        {
            InitializeComponent();
        }

        private void NewBron_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'strzelnicaDS.AMUNICJA' . Możesz go przenieść lub usunąć.
            this.aMUNICJATableAdapter.Fill(this.strzelnicaDS.AMUNICJA);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'strzelnicaDS.BRONIE_TYP' . Możesz go przenieść lub usunąć.
            this.bRONIE_TYPTableAdapter.Fill(this.strzelnicaDS.BRONIE_TYP);

        }

        public void insertNewBron(object sender, EventArgs e)
        {
            using (StrzelnicaEntities strzelnicaEntities = new StrzelnicaEntities())
            {
                BRONIE bron = new BRONIE
                {
                    PRODUCENT = NBProdText.Text.ToUpper(),
                    MODEL = NBModText.Text.ToUpper(),
                    TYP = NBTypGrid.SelectedCells[0].RowIndex,
                    AMUNICJA = NBAmuGrid.SelectedCells[0].RowIndex,
                    CENA_WYPOZYCZENIA = NBCenaNum.Value 

                };

                strzelnicaEntities.BRONIE.Add(bron);
                strzelnicaEntities.SaveChanges();
            }

        }
    }
}

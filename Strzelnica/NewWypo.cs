using System;
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
    public partial class NewWypo : Form
    {
        public NewWypo()
        {
            InitializeComponent();
        }

        public void insertNewWypo(object sender, EventArgs e)
        {
            using (StrzelnicaEntities strzelnicaEntities = new StrzelnicaEntities())
            {
                WYPOZYCZENIA wypo = new WYPOZYCZENIA()
                {
                    ID_KLIENTA = NWKlieGrid.SelectedCells[0].RowIndex,
                    ID_TRENERA = NWTreGrid.SelectedCells[0].RowIndex,
                    ID_STANOWISKA = NWStaGrid.SelectedCells[0].RowIndex,
                    ID_BRONI = NWBroGrid.SelectedCells[0].RowIndex,
                    ILOSC_PAKIETOW_AMUNICJI = (int)NWAmoNum.Value,
                    DATA_POCZATEK = NWDatPoczPick.Value,
                    DATA_KONIEC = NWDatKonPick.Value
                };

                strzelnicaEntities.WYPOZYCZENIA.Add(wypo);
                strzelnicaEntities.SaveChanges();
            }

        }
    }
}

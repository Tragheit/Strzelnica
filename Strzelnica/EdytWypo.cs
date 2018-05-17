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
    public partial class EdytWypo : Form
    {
        public EdytWypo()
        {
            InitializeComponent();
        }

        private void EdytWypo_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'strzelnicaDS.BRONIE' . Możesz go przenieść lub usunąć.
            this.bRONIETableAdapter.Fill(this.strzelnicaDS.BRONIE);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'strzelnicaDS.STANOWISKA' . Możesz go przenieść lub usunąć.
            this.sTANOWISKATableAdapter.Fill(this.strzelnicaDS.STANOWISKA);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'strzelnicaDS.TRENERZY' . Możesz go przenieść lub usunąć.
            this.tRENERZYTableAdapter.Fill(this.strzelnicaDS.TRENERZY);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'strzelnicaDS.KLIENCI' . Możesz go przenieść lub usunąć.
            this.kLIENCITableAdapter.Fill(this.strzelnicaDS.KLIENCI);

        }

        private void editKlient(object sender, EventArgs e)
        {
            using (StrzelnicaEntities strz = new StrzelnicaEntities())
            {
                int id = (int)EWWybNum.Value;
                WYPOZYCZENIA wypozyczenia = strz.WYPOZYCZENIA.Find(id);

                if (!EWKlieGrid.SelectedCells[0].RowIndex.Equals(null))
                {
                    wypozyczenia.ID_KLIENTA = EWKlieGrid.SelectedCells[0].RowIndex;
                }

                if (!EWTrenGrid.SelectedCells[0].RowIndex.Equals(null))
                {
                    wypozyczenia.ID_TRENERA = EWTrenGrid.SelectedCells[0].RowIndex;
                }

                if (!EWStanGrid.SelectedCells[0].RowIndex.Equals(null))
                {
                    wypozyczenia.ID_STANOWISKA = EWStanGrid.SelectedCells[0].RowIndex;
                }

                if (EWBronGrid.SelectedCells[0].RowIndex.Equals(null))
                {
                    wypozyczenia.ID_BRONI = EWBronGrid.SelectedCells[0].RowIndex;
                }

                if (!EWIloscNum.Value.Equals(null))
                {
                    wypozyczenia.ILOSC_PAKIETOW_AMUNICJI = (int)EWIloscNum.Value;
                }

                strz.SaveChanges();
                this.Close();
            }
        }

    }

    }


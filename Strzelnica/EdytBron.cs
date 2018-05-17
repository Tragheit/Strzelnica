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
    public partial class EdytBron : Form
    {
        public EdytBron()
        {
            InitializeComponent();
        }

        private void EdytBron_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'strzelnicaDS.BRONIE_TYP' . Możesz go przenieść lub usunąć.
            this.bRONIE_TYPTableAdapter.Fill(this.strzelnicaDS.BRONIE_TYP);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'strzelnicaDS.AMUNICJA' . Możesz go przenieść lub usunąć.
            this.aMUNICJATableAdapter.Fill(this.strzelnicaDS.AMUNICJA);

        }

        public void editBron(object sender, EventArgs e)
        {
            using (StrzelnicaEntities strz = new StrzelnicaEntities())
            {
                int id = (int)EBWybNum.Value;
                BRONIE bronie = strz.BRONIE.Find(id);

                if (EBAmuGrid.SelectedCells[0].RowIndex.Equals(null))
                {
                    bronie.AMUNICJA = EBAmuGrid.SelectedCells[0].RowIndex;
                }

                if (EBProdText.Text != "")
                {
                    bronie.PRODUCENT = EBProdText.Text;

                }

                if (EBModText.Text != "")
                {
                    bronie.MODEL = EBModText.Text;
                }

                if (!EBTypGrid.SelectedCells[0].RowIndex.Equals(null))
                {
                    bronie.TYP = EBTypGrid.SelectedCells[0].RowIndex;
                }

                if (!EBCenaNum.Value.Equals(null))
                {
                    bronie.CENA_WYPOZYCZENIA = EBCenaNum.Value;
                }

                strz.SaveChanges();
                this.Close();
            }
        }
    }
}


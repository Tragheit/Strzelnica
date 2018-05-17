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
    public partial class EdytKlient : Form
    {
        public EdytKlient()
        {
            InitializeComponent();
        }

        private void EdytKlient_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'strzelnicaDS.KARNETY' . Możesz go przenieść lub usunąć.
            this.kARNETYTableAdapter.Fill(this.strzelnicaDS.KARNETY);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'strzelnicaDS.KLIENCI' . Możesz go przenieść lub usunąć.
            this.kLIENCITableAdapter.Fill(this.strzelnicaDS.KLIENCI);

        }

        public void editKlient(object sender, EventArgs e)
        {
            using (StrzelnicaEntities strz = new StrzelnicaEntities())
            {
                int id = (int)EKKlieNum.Value;
                KLIENCI klient = strz.KLIENCI.Find(id);

                if (EKImieBox.Text != "")
                {
                    klient.IMIE = EKImieBox.Text.ToUpper();
                }

                if (EKNazwiskoBox.Text != "")
                {
                    klient.NAZWISKO = EKNazwiskoBox.Text.ToUpper();
                }

                if (!EKKarnetGrid.SelectedCells[0].RowIndex.Equals(null))
                { 
                klient.ID_KARNETU = EKKarnetGrid.SelectedCells[0].RowIndex;
                }

                if (!EKWiekNum.Value.Equals(null)) { 
                    klient.WIEK = (int)EKWiekNum.Value;
                }

                strz.SaveChanges();
                this.Close();
            }
        }
    }
}

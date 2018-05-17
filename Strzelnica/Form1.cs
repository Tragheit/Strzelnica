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

        private void refreshGridKl(object sender, EventArgs e)
        {

            using (StrzelnicaEntities strz = new StrzelnicaEntities())
            {
                List<KLIENCI> Klienci = strz.KLIENCI.ToList();

                kLIENCIBindingSource.DataSource = Klienci;
                dataGridView1.DataSource = kLIENCIBindingSource;
            }
        }

        private void refreshGridTr(object sender, EventArgs e)
        {

            using (StrzelnicaEntities strz = new StrzelnicaEntities())
            {
                List<TRENERZY> trenerzy = strz.TRENERZY.ToList();

                tRENERZYBindingSource.DataSource = trenerzy;
                dataGridView1.DataSource = tRENERZYBindingSource;
            }
        }

        private void refreshGridKa(object sender, EventArgs e)
        {

            using (StrzelnicaEntities strz = new StrzelnicaEntities())
            {
                List<KARNETY> karnety = strz.KARNETY.ToList();

                kARNETYBindingSource.DataSource = Karnety;
                dataGridView1.DataSource = kARNETYBindingSource;
            }
        }

        private void refreshGridSt(object sender, EventArgs e)
        {

            using (StrzelnicaEntities strz = new StrzelnicaEntities())
            {
                List<STANOWISKA> stanowiska = strz.STANOWISKA.ToList();

                sTANOWISKABindingSource.DataSource = stanowiska;
                dataGridView1.DataSource = sTANOWISKABindingSource;
            }
        }

        private void refreshGridBr(object sender, EventArgs e)
        {

            using (StrzelnicaEntities strz = new StrzelnicaEntities())
            {
                List<BRONIE> bronie = strz.BRONIE.ToList();

                bRONIEBindingSource.DataSource = bronie;
                dataGridView1.DataSource = bRONIEBindingSource;
            }
        }

        private void refreshGridWyp(object sender, EventArgs e)
        {

            using (StrzelnicaEntities strz = new StrzelnicaEntities())
            {
                List<WYPOZYCZENIA> wypożyczenia = strz.WYPOZYCZENIA.ToList();

               wYPOZYCZENIABindingSource.DataSource = wypożyczenia;
                dataGridView1.DataSource = wYPOZYCZENIABindingSource;
            }
        }

        public void RemoveKlient(object sender, EventArgs e)
        {
            using (StrzelnicaEntities strzelnicaEntities = new StrzelnicaEntities())
            {
                int id = dataGridView1.SelectedCells[0].RowIndex;
                strzelnicaEntities.KLIENCI.Remove(strzelnicaEntities.KLIENCI.Find(id));
                strzelnicaEntities.SaveChanges();
            }
        }

        public void RemoveTrener(object sender, EventArgs e)
        {
            using (StrzelnicaEntities strzelnicaEntities = new StrzelnicaEntities())
            {
                int id = dataGridView2.SelectedCells[0].RowIndex;
                strzelnicaEntities.TRENERZY.Remove(strzelnicaEntities.TRENERZY.Find(id));
                strzelnicaEntities.SaveChanges();
            }
        }

        public void RemoveKarner(object sender, EventArgs e)
        {
            using (StrzelnicaEntities strzelnicaEntities = new StrzelnicaEntities())
            {
                int id = dataGridView3.SelectedCells[0].RowIndex;
                strzelnicaEntities.KARNETY.Remove(strzelnicaEntities.KARNETY.Find(id));
                strzelnicaEntities.SaveChanges();
            }
        }

        public void RemoveStanowisko(object sender, EventArgs e)
        {
            using (StrzelnicaEntities strzelnicaEntities = new StrzelnicaEntities())
            {
                int id = dataGridView4.SelectedCells[0].RowIndex;
                strzelnicaEntities.STANOWISKA.Remove(strzelnicaEntities.STANOWISKA.Find(id));
                strzelnicaEntities.SaveChanges();
            }
        }

        public void RemoveBron(object sender, EventArgs e)
        {
            using (StrzelnicaEntities strzelnicaEntities = new StrzelnicaEntities())
            {
                int id = dataGridView5.SelectedCells[0].RowIndex;
                strzelnicaEntities.BRONIE.Remove(strzelnicaEntities.BRONIE.Find(id));
                strzelnicaEntities.SaveChanges();
            }
        }

        public void RemoveWypozyczenie(object sender, EventArgs e)
        {
            using (StrzelnicaEntities strzelnicaEntities = new StrzelnicaEntities())
            {
                int id = dataGridView1.SelectedCells[0].RowIndex;
                strzelnicaEntities.WYPOZYCZENIA.Remove(strzelnicaEntities.WYPOZYCZENIA.Find(id));
                strzelnicaEntities.SaveChanges();
            }
        }
    }
}

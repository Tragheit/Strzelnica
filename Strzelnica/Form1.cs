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

        private void Strzelnica_Load(object sender, EventArgs e)
        { }

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
    }
    }


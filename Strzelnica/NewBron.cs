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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NBAmuGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void EBAmuGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EdytBron_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'strzelnicaDS.BRONIE_TYP' . Możesz go przenieść lub usunąć.
            this.bRONIE_TYPTableAdapter.Fill(this.strzelnicaDS.BRONIE_TYP);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'strzelnicaDS.AMUNICJA' . Możesz go przenieść lub usunąć.
            this.aMUNICJATableAdapter.Fill(this.strzelnicaDS.AMUNICJA);

        }
    }
}

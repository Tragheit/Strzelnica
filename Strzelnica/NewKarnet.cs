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
    public partial class NewKarnet : Form
    {
        public NewKarnet()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void loadList()
        {
            


        }

        private void NewKarnet_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'strzelnicaDS.KLIENCI' . Możesz go przenieść lub usunąć.
            this.kLIENCITableAdapter.Fill(this.strzelnicaDS.KLIENCI);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

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

        public void insertNewkARNET(object sender, EventArgs e)
        {
            using (StrzelnicaEntities strzelnicaEntities = new StrzelnicaEntities())
            {
                KARNETY karnet = new KARNETY()
                {
                 RODZAJ_KARNETU = NKGrid.SelectedCells[0].RowIndex,
                 DATA_WAZNOSCI = NKDate.Value,
                };

                strzelnicaEntities.KARNETY.Add(karnet);
                strzelnicaEntities.SaveChanges();
            }

        }
    }
}

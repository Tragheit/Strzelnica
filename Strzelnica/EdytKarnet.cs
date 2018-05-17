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
    public partial class EdytKarnet : Form
    {
        public EdytKarnet()
        {
            InitializeComponent();
        }

        public void editKarnet(object sender, EventArgs e)
        {
            using (StrzelnicaEntities strz = new StrzelnicaEntities())
            {
                int id = (int)EKWybNum.Value;
                KARNETY karnet = strz.KARNETY.Find(id);

                if (!EKRodzajGrid.SelectedCells[0].RowIndex.Equals(null))
                {
                    karnet.RODZAJ_KARNETU = EKRodzajGrid.SelectedCells[0].RowIndex;
                }

                if (EKDataPick.Value != null)
                {
                    karnet.DATA_WAZNOSCI = EKDataPick.Value;
                }

                strz.SaveChanges();
                this.Close();
            }
        }

    }
}

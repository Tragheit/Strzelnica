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
    public partial class EdytStanowisko : Form
    {
        public EdytStanowisko()
        {
            InitializeComponent();
        }

        public void editStanowisko(object sender, EventArgs e)
        {
            using (StrzelnicaEntities strz = new StrzelnicaEntities())
            {
                int id = (int)ESStanNum.Value;
                STANOWISKA stanowisko = strz.STANOWISKA.Find(id);

                if (!ESKuloGrid.SelectedCells[0].RowIndex.Equals(null))
                {
                    stanowisko.KULOCHWYT = ESKuloGrid.SelectedCells[0].RowIndex;
                }

                if (!ESOdleNum.Value.Equals(null))
                {
                    stanowisko.ODLEGLOSC_OD_CELU = (int)ESOdleNum.Value;
                }

                if (!ESCenaNum.Value.Equals(null))
                {
                    stanowisko.CENA_WYNAJMU = ESCenaNum.Value;
                }

                strz.SaveChanges();
                this.Close();
            }
        }
    }
}

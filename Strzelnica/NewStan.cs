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
    public partial class NewStan : Form
    {
        public NewStan()
        {
            InitializeComponent();
        }

        public void insertNewStanowisko(object sender, EventArgs e)
        {
            using (StrzelnicaEntities strzelnicaEntities = new StrzelnicaEntities())
            {
                STANOWISKA stanowisko = new STANOWISKA()
                {
                    KULOCHWYT = NSKuloGrid.SelectedCells[0].RowIndex,
                    ODLEGLOSC_OD_CELU = (int)NSOdlegNum.Value,
                    CENA_WYNAJMU = NSCenaNum.Value
                    
                };

                strzelnicaEntities.STANOWISKA.Add(stanowisko);
                strzelnicaEntities.SaveChanges();
            }

        }
    }
}

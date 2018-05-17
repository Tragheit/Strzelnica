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
    public partial class NewTrainer : Form
    {
        public NewTrainer()
        {
            InitializeComponent();
        }

        public void insertNewTrener(object sender, EventArgs e)
        {
            using (StrzelnicaEntities strzelnicaEntities = new StrzelnicaEntities())
            {
                TRENERZY trener = new TRENERZY()
                {
                    IMIE = NTImieText.Text.ToUpper(),
                    NAZWISKO = NTNazwiskoText.Text.ToUpper(),

                };

                strzelnicaEntities.TRENERZY.Add(trener);
                strzelnicaEntities.SaveChanges();
            }

        }
    }
}

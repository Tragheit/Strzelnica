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
    public partial class EdytTrener : Form
    {
        public EdytTrener()
        {
            InitializeComponent();
        }

        public void editTrener(object sender, EventArgs e)
        {
            using (StrzelnicaEntities strz = new StrzelnicaEntities())
            {
                int id = (int)ETWybNum.Value;
                TRENERZY trener = strz.TRENERZY.Find(id);

                if (ETImieText.Text != "")
                {
                    trener.IMIE = ETImieText.Text.ToUpper();
                }

                if (ETNazwiskoText.Text != "")
                {
                    trener.NAZWISKO = ETNazwiskoText.Text.ToUpper();
                }


                strz.SaveChanges();
                this.Close();
            }
        }

    }
}

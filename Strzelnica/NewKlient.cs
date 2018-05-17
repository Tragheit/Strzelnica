using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strzelnica
{
    public partial class NewKlient : Form
    {
        public NewKlient()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void insertNewKlient(object sender, EventArgs e)
        {
            using (StrzelnicaEntities strzelnicaEntities = new StrzelnicaEntities())
            {
                KLIENCI Klient = new KLIENCI()
                {
                    IMIE = NKImieText.Text.ToUpper(),
                    NAZWISKO = NKNazwiskoText.Text.ToUpper(),
                    WIEK = (int)NKWiekNum.Value

                };

                strzelnicaEntities.KLIENCI.Add(Klient);
                strzelnicaEntities.SaveChanges();
            }

        }
                                        
            }
 
        }
   

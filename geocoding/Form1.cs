using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geocoding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            var geo = new Address();

            if (txtLine1.Text == "")
            {
                MessageBox.Show("Você Deve Digitar Pelo Menos A Rua.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else {

                //geo.Line1 = "30 Frank Lloyd Wright Drive";
                geo.Line1 = txtLine1.Text;
                geo.Line2 = txtLine2.Text;
                geo.City = txtCidade.Text;
                geo.State = cBoxUf.Text.ToUpper();
                geo.Country = "Brasil";

                geo.GeoCode();

                int posicao = geo.Latitude.IndexOf("<location>");
                string posi = geo.Latitude.Substring(posicao, 31);
                //txtLat.Text = posi;

                string posi2 = posi.Substring(20, 11).Replace("<", "");
                txtLat.Text = posi2;


                //txtLat.Text = geo.Latitude;
                //txtLong.Text = geo.Longitude;

                string posi3 = geo.Latitude.Substring(posicao, 59);
                string posi4 = posi3.Substring(46, 12).Replace(">", "").Replace("<", "");
                txtLong.Text = posi4;


                string mapskey2 = ConfigurationManager.AppSettings["GoogleMapsAPIKey2"];
                //setup a streamreader for retrieving data from Google.
                //--------------StreamReader sr = null;

                //Check to see if our maps key exists
                if (string.IsNullOrEmpty(mapskey2))
                {
                    throw new Exception("No valid google maps api key to use for geocoding.  Please add an app key named \"GoogleMapsAPIKey2\" to the web.config file.");
                }


                try
                {
                    StringBuilder queryaddress = new StringBuilder();
                    queryaddress.Append("http://mygeoposition.com/loc/");
                    //queryaddress.Append("https://maps.googleapis.com/maps/api/staticmap?center=");
                    /*queryaddress.Append(@"
                    <iframe width='630' height='520' frameborder='0' style='border: 0'
        src = 'https://www.google.com/maps/embed/v1/place?q=");

                    queryaddress.Append(posi2 + "%2C" + posi4 + "&key=" + mapskey2 + @"' allowfullscreen>
                    </iframe>
                    ");*/

                     if (posi2 != string.Empty)
                    {
                        queryaddress.Append(posi2 + ",");
                     }
                     if (posi4 != string.Empty)
                     {
                    //    queryaddress.Append(posi4 + "&zoom=15&size=630x520&markers=color:red%7Clabel:%E2%80%A2%7C");
                    //    queryaddress.Append(posi2 + "," + posi4 + "&path=weight:3%7Ccolor:blue%7Cenc:aofcFz_bhVJ[n@ZpAp@t@b@uA`FuAzEoCdJiDpLs@VM@y@s@oBcBkAw@cCoAuBu@eEaAiAa@iAi@w@a@o@g@g@k@e@u@uAaCc@i@w@y@eAo@i@UaBc@kAGo@@]JyKA}EC{G?q@?IGKCeGA{CAyCAyEAwEBaFAkJ?yGEyAIiLAiB?{@BcBJ}@@aBGwBEo@A@j@BjBFTHjEl@fOD`C?|@RARAJERWPL@FE^S`AI`A&key=AIzaSyDMFgRANsAB8BwMB1o3OBCElvoV2Zw_OkQ");
                    queryaddress.Append(posi4+ "/?zoomLevel=undefined&mapType=undefined");
                    }

                    //wbBrow.Navigate(queryaddress.ToString());



                    //wbBrow.DocumentText = queryaddress.ToString();
                    wbBrow.ScriptErrorsSuppressed = true;
                    wbBrow.Navigate(queryaddress.ToString());

                    // Hides script errors without hiding other dialog boxes.
                    


    }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Error");

                }
            }
        }

        private void txtLat_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (txtLat.Text == "")
            {
                MessageBox.Show("Ainda Não Foi Gerada a Latitude");
            }
            else
            {
                string copilat = txtLat.Text;
                Clipboard.SetText(copilat);
            }
        }

        private void btnCopiLong_Click(object sender, EventArgs e)
        {
            if (txtLong.Text == "")
            {
                MessageBox.Show("Ainda Não Foi Gerada a Longitude");
            }
            else
            {
                string copilong = txtLong.Text;
                Clipboard.SetText(copilong);
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AM Comercial - Geo Localização - Versão 1.1", "Help", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}

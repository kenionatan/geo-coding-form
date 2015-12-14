using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            //geo.Line1 = "30 Frank Lloyd Wright Drive";
            geo.Line1 = txtLine1.Text;
            geo.Line2 = txtLine2.Text;
            geo.City = txtCidade.Text;
            geo.State = cBoxUf.Text;
            geo.Country = "Brasil";

            geo.GeoCode();

            int posicao = geo.Latitude.IndexOf("<location>");
            string posi = geo.Latitude.Substring(posicao,31);
            //txtLat.Text = posi;
            
            string posi2 = posi.Substring(20, 11).Replace("<","");
            txtLat.Text = posi2;
            

            //txtLat.Text = geo.Latitude;
            //txtLong.Text = geo.Longitude;

            string posi3 = geo.Latitude.Substring(posicao,59);
            string posi4 = posi3.Substring(46, 12).Replace(">","").Replace("<","");
            txtLong.Text = posi4;





            try
            {
                StringBuilder queryaddress = new StringBuilder();
                queryaddress.Append("http://mygeoposition.com/loc/");

                if(posi2 != string.Empty)
                {
                    queryaddress.Append(posi2+",");
                }
                if (posi4 != string.Empty)
                {
                    queryaddress.Append(posi4 + "/?zoomLevel=undefined&mapType=earth");
                }

                wbBrow.Navigate(queryaddress.ToString());

                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");

            }
        }

        private void txtLat_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Googlemaps_Display
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void find_data_Click(object sender, EventArgs e)
        {
            string street = txt_street.Text;
            string city = txt_city.Text;
           
            try
            {
                // A queryadress must be properly
                StringBuilder queryadress = new StringBuilder();
                queryadress.Append("http://maps.google.com/maps?q=");

                if (street != string.Empty)
                {
                    queryadress.Append(street + "," + "+");
                }

                if (city != string.Empty)
                {
                    queryadress.Append(city + "," + "+");
                }
                              
                
                webBrowser1.Navigate(queryadress.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

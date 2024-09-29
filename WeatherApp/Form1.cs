using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WeatherApp.Class;

namespace WeatherApp
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        Entity entity = new Entity();


        private void Form1_Load(object sender, EventArgs e)
        {
            List list = new List(countryCombobox, cityCombobox);
            Load load = new Load(countryCombobox, cityCombobox, countryLabel, cityLabel, degeerLabel, cloudsLabel, dateLabel, hourLabel, highestLabel, lowestLabel, windSpeedLabel, windDirectionLabel, humidityLabel, pressureLabel);

            savedChangesBtn.Enabled = false;
        }

        private void cityCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            savedChangesBtn.Enabled = true;
        }

        private void savedChangesBtn_Click(object sender, EventArgs e)
        {
            savedChangesBtn.Enabled = false;

            entity.country = countryCombobox.SelectedItem.ToString();
            entity.city = cityCombobox.SelectedItem.ToString();

            Load load = new Load(countryCombobox, cityCombobox, countryLabel, cityLabel, degeerLabel, cloudsLabel, dateLabel, hourLabel, highestLabel, lowestLabel, windSpeedLabel, windDirectionLabel, humidityLabel, pressureLabel);
        }
    }
}

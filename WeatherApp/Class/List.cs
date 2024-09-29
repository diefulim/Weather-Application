using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WeatherApp.Class
{
    public class List
    {
        public List(KryptonComboBox countryCombobox, KryptonComboBox cityCombobox)
        {
            XDocument XCountry = XDocument.Load(@"./countrys.xml");
            XElement XCountryName = XCountry.Root;


            foreach (XElement item in XCountryName.Elements())
            {
                if (item.Value == "Turkey")
                {
                    countryCombobox.Items.Add(item.Value);
                }
            }

            countryCombobox.SelectedIndex = 0;

            XDocument XCities = XDocument.Load(@"./cities.xml");
            XElement XCityName = XCities.Root;
            var cities = XCities.Descendants("CITY").Attributes("cityname");

            foreach (var item in cities)
            {
                cityCombobox.Items.Add(item.Value);
            }

            cityCombobox.SelectedIndex = 0;
        }
    }
}

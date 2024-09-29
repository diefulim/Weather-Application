using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WeatherApp.Class
{
    public class Load
    {
        Entity entity = new Entity();

        public Load(KryptonComboBox countrycb, KryptonComboBox citycb, Label countryLabel, Label cityLabel, Label degeerLabel, Label cloudsLabel, Label dateLabel, Label hourLabel, Label max, Label min, Label windSpeed, Label windDirection, Label humidity, Label pressure)
        {
            entity.country = countrycb.SelectedItem.ToString(); 
            entity.city = citycb.SelectedItem.ToString(); 

            string host = "https://api.openweathermap.org/data/2.5/weather?q=" + entity.city.ToLower() + "&mode=xml&units=metric&lang=tr&apikey=" + entity.api;

            XDocument xml = XDocument.Load(host);
            var clouds = xml.Descendants("clouds").Attributes("name").ElementAt(0).Value;

            countryLabel.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(entity.country);
            cityLabel.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(entity.city);
            cloudsLabel.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(clouds);

            degeerLabel.Text = xml.Descendants("temperature").Attributes("value").ElementAt(0).Value;
            min.Text = xml.Descendants("temperature").Attributes("min").ElementAt(0).Value;
            max.Text = xml.Descendants("temperature").Attributes("max").ElementAt(0).Value;
            windSpeed.Text = xml.Descendants("speed").Attributes("value").ElementAt(0).Value;
            pressure.Text = xml.Descendants("pressure").Attributes("value").ElementAt(0).Value;
            humidity.Text = xml.Descendants("humidity").Attributes("value").ElementAt(0).Value;

            string direction = xml.Descendants("direction").Attributes("name").ElementAt(0).Value;

            if (direction == "South" || direction == "North") windDirection.Location = new System.Drawing.Point(47, 98);
            else if(direction == "West" || direction == "East") windDirection.Location = new System.Drawing.Point(51, 98);
            else if(direction == "Southwest" || direction == "Northwest" || direction == "Northeast" || direction == "Southeast") windDirection.Location = new System.Drawing.Point(37, 98);
            else if(direction == "West-northwest" || direction ==  "North-northwest" || direction == "South-southwest") windDirection.Location = new System.Drawing.Point(25, 98);
            else if(direction == "South-southeast" || direction == "North-northeast" || direction == "West-southwest") windDirection.Location = new System.Drawing.Point(25, 98);

            windDirection.Text = direction;

            dateLabel.Text = DateTime.Now.DayOfWeek.ToString();
            hourLabel.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
        }
    }
}

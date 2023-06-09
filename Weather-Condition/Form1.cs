using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Weather_Condition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setBackground();
        }

        void getInfos()
        {
            TextInfo textInfo = new CultureInfo("tr-TR", false).TextInfo;
            string city = txt_city.Text;
            try
            {
                string api_key = "YOUR API KEY";
                string connection = "https://api.openweathermap.org/data/2.5/weather?q=" + city + "&mode=xml&lang=tr&units=metric&appid=" + api_key;
                XDocument weather = XDocument.Load(connection);
                var temperature = weather.Descendants("temperature").ElementAt(0).Attribute("value").Value;
                var humidity = weather.Descendants("humidity").ElementAt(0).Attribute("value").Value;
                var pressure = weather.Descendants("pressure").ElementAt(0).Attribute("value").Value;
                var status = weather.Descendants("weather").ElementAt(0).Attribute("value").Value;
                var wind = weather.Descendants("speed").ElementAt(0).Attribute("value").Value;
                var country = weather.Descendants("country").ElementAt(0).Value;
                var city_name = weather.Descendants("city").ElementAt(0).Attribute("name").Value;
                var feels_like = weather.Descendants("feels_like").ElementAt(0).Attribute("value").Value;

                status = textInfo.ToTitleCase(status);

                lbl_temperature.Text = temperature.ToString() + "°";
                lbl_wind.Text = wind.ToString();
                lbl_humidity.Text = "%" + humidity.ToString();
                lbl_pressure.Text = pressure.ToString();
                lbl_status.Text = status.ToString();
                lbl_country.Text = country.ToString();
                lbl_city_name.Text = city_name.ToString();
                lbl_feels_like.Text = feels_like.ToString() + "°";
            }
            catch (Exception ex)
            {
                MessageBox.Show("The city you are looking for could not be found.", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void setBackground()
        {
            string[] dizi = { "bg1", "bg2", "bg3" };
            Random random = new Random();
            int bg_index = random.Next(0, 3);
            this.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(dizi[bg_index]);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            getInfos();
        }
    }
}

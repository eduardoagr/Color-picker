using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ColorPicker {
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e) {

            double red = redSlider.Value;
            double green = GreenSlider.Value;
            double blue = BlueSlider.Value;

            Color color = new Color(red, green, blue);

            boxColor.BackgroundColor = color;

            ValueColor.Text = bgHexColor(color);
        }

        private string bgHexColor(Color color) {
            int red = (int)(color.R * 255);
            int green = (int)(color.G * 255);
            int blue = (int)(color.B * 255);
            int alpha = (int)(color.A * 255);
            string hex = $"#{alpha:X2}{red:X2}{green:X2}{blue:X2}";

            return hex;
        }
    }
}

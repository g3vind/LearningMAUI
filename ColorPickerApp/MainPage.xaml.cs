using CommunityToolkit.Maui.Alerts;

namespace ColorPickerApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        string hexValue = string.Empty;
        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var redValue = sldRed.Value;
            var greenValue = sldGreen.Value;
            var blueValue = sldBlue.Value;

            Color color = Color.FromRgb(redValue, greenValue, blueValue);
            hexValue = color.ToHex();
            setColor(color);
        }

        private void setColor(Color color)
        {
            Container.BackgroundColor = color;
            lbl.Text = color.ToHex();
            hexValue = color.ToHex();
            //generateColor.BackgroundColor = color;
        }

        

        private void generateColor_Clicked(object sender, EventArgs e)
        {
            Random random = new Random();
            var redValue = random.Next(0, 265);
            var greenValue = random.Next(0, 265);
            var blueValue = random.Next(0, 265);
            Color color = Color.FromRgb(redValue, greenValue, blueValue);
            setColor(color);
            sldRed.Value = redValue;
            sldGreen.Value = greenValue;
            sldBlue.Value = blueValue;
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Clipboard.SetTextAsync(hexValue);
            var toast = Toast.Make($"Hex value {hexValue} copied to clipboard", CommunityToolkit.Maui.Core.ToastDuration.Short);
            await toast.Show();
        }
    }

}

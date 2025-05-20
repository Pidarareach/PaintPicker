//using System.Diagnostics;
namespace PaintPicker
{
    public partial class MainPage : ContentPage
    {
        bool isRandom;
        public MainPage()
        {
            InitializeComponent();
        }

        private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (!isRandom)
            {
                var red = SliderRed.Value;
                var green = SliderGreen.Value;
                var blue = SliderBlue.Value;

                Color color = Color.FromRgb(red, green, blue);

                SetColor(color);
            }
            
        }

        private void SetColor(Color color)
        {
            //Debug.WriteLine(color.ToString());
            btnRandom.BackgroundColor = color;
            Container.BackgroundColor = color;
            lblHex.Text = color.ToHex();
        }

        private void btnRandom_Clicked(object sender, EventArgs e)
        {
            isRandom = true;

            var random = new Random();

            var color = Color.FromRgb(
                random.Next(0, 256),
                random.Next(0, 256),
                random.Next(0, 256));

            SetColor(color);

            SliderRed.Value = color.Red;
            SliderGreen.Value = color.Green;
            SliderBlue.Value = color.Blue;
            isRandom = false;
        }
    }

}

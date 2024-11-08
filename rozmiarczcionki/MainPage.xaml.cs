using System.Collections.Specialized;
using System.Runtime.InteropServices.Marshalling;

namespace rozmiarczcionki
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        readonly double sliderIncrement = 1;
        double sliderCorrectValue;

        public MainPage()
        {
            InitializeComponent();
        }

        private void SlidSizeChanged(object sender, ValueChangedEventArgs args)
        {
            sliderCorrectValue = (int)(args.NewValue / sliderIncrement) * sliderIncrement;
            Rozm.Text = "Rozmiar czcionki:" + sliderCorrectValue.ToString("0");
        
        Probny.FontSize = sliderCorrectValue;
        
        }
        private void OnColorClicked(object sender, EventArgs e)
        {
            count++;
            if (count == 4)
            {
                count = 0;
            }
            switch (count)
            {
                case 0:
                    Probny.TextColor = Colors.Black;
                    break;
                case 1:
                    Probny.TextColor = Colors.Blue;
                    break;
                case 2:
                    Probny.TextColor = Colors.Green;
                    break;
                case 3:
                    Probny.TextColor = Colors.Red;
                    break;
            }
        }
        private void OnTextAlignChanged(object sender, EventArgs e)
        {
            if (Left.IsChecked) {
                Probny.HorizontalTextAlignment = TextAlignment.Start; 
                    }
            else if (Center.IsChecked) { Probny.HorizontalTextAlignment = TextAlignment.Center; }
            else if (Right.IsChecked) { Probny.HorizontalTextAlignment = TextAlignment.End; }
        }

    }
}

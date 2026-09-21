namespace EventVsBindingMauiApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            /*if (rotationSlider is not null)
                rotationLabel.Rotation = rotationSlider.Value;*/

            /*
            Slider slider = sender as Slider;
            if (slider is not null
                && rotationLabel is not null)
                rotationLabel.Rotation = slider.Value;

            */

            if (sender is Slider slider
                && rotationLabel is not null)
                rotationLabel.Rotation = slider.Value;
        }

        public string Message { get; set; }

        private string returnMessage;
        public string ReturnMessage
        {
            get { return returnMessage; }
            set 
            { 
                returnMessage = value;
                //OnPropertyChanged("ReturnMessage");
                //OnPropertyChanged(nameof(ReturnMessage));
                OnPropertyChanged();
            }
        }


        private void Button_Clicked(object sender, EventArgs e)
        {
            //resultMessageLabel.Text = messageEntry.Text;
            ReturnMessage = Message;
            //OnPropertyChanged("ReturnMessage");
            //OnPropertyChanged(nameof(ReturnMessage));
        }
    }
}

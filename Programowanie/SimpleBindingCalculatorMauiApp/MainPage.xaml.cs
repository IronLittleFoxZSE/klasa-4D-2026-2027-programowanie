namespace SimpleBindingCalculatorMauiApp
{
    public partial class MainPage : ContentPage
    {
        public string FirstStrNumber { get; set; }

        public string SecondStrNumber { get; set; }

        private string result;
        public string Result
        {
            get { return result; }
            set { result = value; OnPropertyChanged(); }
        }

        private Color colorResult;
        public Color ColorResult
        {
            get { return colorResult; }
            set { colorResult = value; OnPropertyChanged(); }
        }

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (int.TryParse(FirstStrNumber, out int firstNumber)
                && int.TryParse(SecondStrNumber, out int secondNumber))
            {
                int result = firstNumber + secondNumber;
                Result = "Wynik to " + result;
                ColorResult = Colors.Green;
            }
            else
            {
                Result = "Podałeś nieprawidłowe dane";
                ColorResult = Colors.Red;
            }
        }
    }
}

using ControlsMauiApp.Data;
using System.Collections.ObjectModel;
using System.Runtime.ConstrainedExecution;

namespace ControlsMauiApp
{
    public partial class MainPage : ContentPage
    {
        public string Message { get; set; }

        private string returnMessage;
        public string ReturnMessage
        {
            get { return returnMessage; }
            set
            {
                returnMessage = value;
                OnPropertyChanged();
            }
        }

        //public Command ChangeMessage { get; set; }

        private Command changeMessage;
        public Command ChangeMessage
        {
            get
            {
                if (changeMessage == null)
                {
                    changeMessage = new Command(
                        () =>
                        {
                            ReturnMessage = Message;
                        }
                        );
                }
                return changeMessage;
            }
        }

        private DateTime minimumDate;
        public DateTime MinimumDate
        {
            get { return minimumDate; }
            set { minimumDate = value; OnPropertyChanged(); }
        }

        private DateTime maximumDate;
        public DateTime MaximumDate
        {
            get { return maximumDate; }
            set { maximumDate = value; OnPropertyChanged(); }
        }

        private DateTime selectDate;
        public DateTime SelectDate
        {
            get { return selectDate; }
            set { selectDate = value; OnPropertyChanged(); }
        }

        private TimeSpan selectTime;
        public TimeSpan SelectTime
        {
            get { return selectTime; }
            set { selectTime = value; OnPropertyChanged(); }
        }


        private bool isLegalAge;
        public bool IsLegalAge
        {
            get { return isLegalAge; }
            set { isLegalAge = value; OnPropertyChanged(); }
        }

        private string selectedImage;
        public string SelectedImage
        {
            get { return selectedImage; }
            set { selectedImage = value; OnPropertyChanged(); }
        }

        private Command changeImage;
        public Command ChangeImage
        {
            get
            {
                if (changeImage == null)
                    changeImage = new Command(
                        () =>
                        {
                            currentImageNumber = (currentImageNumber + 1) % images.Count;
                            SelectedImage = images[currentImageNumber];
                        }
                        );
                return changeImage;
            }
        }

        private double progresDataLevel;
        public double ProgresDataLevel
        {
            get { return progresDataLevel; }
            set { progresDataLevel = value; OnPropertyChanged(); }
        }

        private Command changeProgresDataLevel;
        public Command ChangeProgresDataLevel
        {
            get
            {
                if (changeProgresDataLevel == null)
                    changeProgresDataLevel = new Command(
                        () =>
                        {
                            if (ProgresDataLevel <= 0
                                || ProgresDataLevel >= 1)
                                changePrograsDataLevel *= -1;
                            ProgresDataLevel += changePrograsDataLevel;
                        }
                        );
                return changeProgresDataLevel;
            }
        }

        private string favoriteAnimal;
        public string FavoriteAnimal
        {
            get { return favoriteAnimal; }
            set { favoriteAnimal = value; OnPropertyChanged(); }
        }

        private string searchData;
        public string SearchData
        {
            get { return searchData; }
            set { searchData = value; OnPropertyChanged(); }
        }

        private Command changeSearchData;
        public Command ChangeSearchData
        {
            get
            {
                if (changeSearchData == null)
                    changeSearchData = new Command<string>(
                        (string data) =>
                        {

                        }
                        );
                return changeSearchData;
            }
        }

        private int stepperValue;
        public int StepperValue
        {
            get { return stepperValue; }
            set { stepperValue = value; OnPropertyChanged(); }
        }

        private bool isOn;

        public bool IsOn
        {
            get { return isOn; }
            set { isOn = value; OnPropertyChanged(); }
        }

        public ObservableCollection<string> AnimalCollection { get; set; }

        private string selectedAnimal;
        public string SelectedAnimal
        {
            get { return selectedAnimal; }
            set { selectedAnimal = value; OnPropertyChanged(); }
        }
        public ObservableCollection<Car> CarsCollection { get; set; }
        private Car selectedCar;

        public Car SelectedCar
        {
            get { return selectedCar; }
            set { selectedCar = value; OnPropertyChanged(); }
        }

        public ObservableCollection<Monkey> Monkeys { get; private set; }


        private int currentImageNumber;
        private List<string> images;
        private double changePrograsDataLevel;

        public MainPage()
        {
            //ChangeMessage = new Command(CopyMessage);
            //ChangeMessage = new Command(() => ReturnMessage = Message);

            MinimumDate = new DateTime(2025, 1, 1);
            MaximumDate = new DateTime(2025, 12, 31);
            SelectDate = DateTime.Now;

            SelectTime = TimeSpan.Zero;

            currentImageNumber = 0;
            images = new()
        { "dotnet_bot.png", "dotnet_bot_two.png" };
            SelectedImage = images[currentImageNumber];

            changePrograsDataLevel = 0.1;
            ProgresDataLevel = 0.1;

            FavoriteAnimal = "Pies";

            StepperValue = 0;

            IsOn = false;

            AnimalCollection = new ObservableCollection<string>()
        {
            "Pies",
            "Kot",
            "Krowa"
        };
            SelectedAnimal = AnimalCollection.First();

            CarsCollection = new ObservableCollection<Car>()
        {
            new Car(){ Name="Fiat", Description = "Kultowy mały fiat"},
            new Car(){ Name="Audi", Description = "A tutaj jego opis"},
        };
            SelectedCar = CarsCollection.First();

            CreateMonkeyCollection();

            InitializeComponent();
        }

        private void CopyMessage()
        {
            ReturnMessage = Message;
        }

        void CreateMonkeyCollection()
        {
            Monkeys =
            [
                new Monkey
            {
                Name = "Baboon",
                Location = "Africa & Asia",
                Details = "Baboons are African and Arabian Old World monkeys belonging to the genus Papio, part of the subfamily Cercopithecinae.",
                ImageUrl = "baboon.jpg"
            },
            new Monkey
            {
                Name = "Capuchin Monkey",
                Location = "Central & South America",
                Details = "The capuchin monkeys are New World monkeys of the subfamily Cebinae. Prior to 2011, the subfamily contained only a single genus, Cebus.",
                ImageUrl = "capuchin_monkey.jpg"
            },
            new Monkey
            {
                Name = "Blue Monkey",
                Location = "Central and East Africa",
                Details = "The blue monkey or diademed monkey is a species of Old World monkey native to Central and East Africa, ranging from the upper Congo River basin east to the East African Rift and south to northern Angola and Zambia",
                ImageUrl = "blue_monkey.jpg"
            },
        ];


        }
    }
}

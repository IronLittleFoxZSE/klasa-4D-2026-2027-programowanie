/*
Zadanie – Rezerwacja pokoju hotelowego
Napisz aplikację w .NET MAUI, która pozwala przygotować prostą rezerwację pokoju hotelowego.

Użytkownik powinien podać następujące informacje:
- Imię i nazwisko – Entry,
- Adres e-mail – Entry,
- Data przyjazdu – DatePicker,
- Liczba nocy – Stepper (od 1 do 14),
- Liczba osób – Stepper (od 1 do 4),
- Rodzaj pokoju – Picker:
  - Pokój jednoosobowy – 200 zł / noc,
  - Pokój dwuosobowy – 300 zł / noc,
  - Apartament – 500 zł / noc,
- Śniadanie – Switch – dodatkowo 40 zł za osobę za każdą noc,
- Miejsce parkingowe – CheckBox – dodatkowo 30 zł za każdą noc,
- przycisk Oblicz koszt – Button,
- Label wyświetlający podsumowanie rezerwacji.

Aktualna liczba nocy oraz liczba osób powinna być wyświetlana obok odpowiednich kontrolek Stepper. Wykorzystaj do tego binding, tak aby wartości zmieniały się automatycznie.
Po naciśnięciu przycisku Oblicz koszt aplikacja powinna obliczyć całkowity koszt pobytu.

Przykład:
Imię i nazwisko: Jan Kowalski
Data przyjazdu: 15.10.2026
Liczba nocy: 3
Liczba osób: 2
Pokój: Pokój dwuosobowy
Śniadanie: TAK
Parking: TAK
Koszt pokoju: 3 × 300 zł = 900 zł
Śniadanie: 3 × 2 × 40 zł = 240 zł
Parking: 3 × 30 zł = 90 zł
Łącznie: 1230 zł
W podsumowaniu wyświetl imię i nazwisko klienta, datę przyjazdu, wybrany rodzaj pokoju, liczbę nocy, liczbę osób oraz całkowity koszt rezerwacji.

Dodatkowe wymagania:
- użytkownik nie może wybrać daty przyjazdu wcześniejszej niż dzisiejsza,
- przed wykonaniem obliczeń sprawdź, czy użytkownik podał imię i nazwisko oraz wybrał rodzaj pokoju,
- jeśli dane są niepoprawne lub niekompletne, wyświetl odpowiedni komunikat.

Dla chętnych: dodaj Slider pozwalający ustawić rabat od 0% do 20%. Aktualna wartość rabatu powinna być wyświetlana za pomocą Label i bindingu. Rabat należy uwzględnić w końcowej cenie rezerwacji.

*/
namespace HotelBookingMauiApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}

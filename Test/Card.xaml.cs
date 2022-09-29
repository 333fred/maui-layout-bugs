using System.Collections.ObjectModel;

namespace Test;

public partial class Card : ContentView
{

    public Card()
    {
        InitializeComponent();
    }
}

public class CardViewModel
{
    public int Number { get; set; }

    public CardViewModel(int number)
    {
        Number = number;
    }
}
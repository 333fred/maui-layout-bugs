using System.Collections.ObjectModel;

namespace Test;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MainPageViewModel();
    }
}

public class MainPageViewModel
{
    public ObservableCollection<CardViewModelCollection> Matches { get; } = new ObservableCollection<CardViewModelCollection>(Enumerable.Range(0, 20).Select(_ => new CardViewModelCollection()));
}

public class CardViewModelCollection
{
    public List<CardViewModel> Cards { get; } = Enumerable.Range(1, 6).Select(i => new CardViewModel(i)).ToList();
}

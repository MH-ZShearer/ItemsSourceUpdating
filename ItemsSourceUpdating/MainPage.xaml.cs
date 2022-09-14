namespace ItemsSourceUpdating;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void NumbersButton_Clicked(object sender, EventArgs e)
	{
		var list = new List<int> { 1, 2, 3, 4, 5, 6 };

		ItemPicker.ItemsSource = list;
	}

	private void LettersButton_Clicked(object sender, EventArgs e)
	{
		var list = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F' };

		ItemPicker.ItemsSource = list;
	}
}


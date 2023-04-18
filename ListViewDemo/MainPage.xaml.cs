using ListViewDemo.Model;

namespace ListViewDemo;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
        List<User> users = new List<User>();
        users.Add(new User() { Name = "Juan" });
        users.Add(new User() { Name = "Paty" });
        lista.ItemsSubTipoAlerta = users;
    }
}


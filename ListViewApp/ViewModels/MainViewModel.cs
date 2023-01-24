using System.Collections.Generic;

namespace ListViewApp.ViewModels;

public class MainViewModel : ViewModelBase
{
    public string Greeting => "Welcome to Avalonia!";
    public List<string> Items { get; set; }
    public MainViewModel()
    {
        Items = new List<string>();
        for (int i = 1; i <= 50; i++)
        {
            Items.Add($"This is item {i}.");
        }
    }
}

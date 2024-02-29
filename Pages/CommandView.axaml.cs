using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace YaoAvaDemo;

public partial class CommandView : UserControl
{
    public CommandView()
    {
        InitializeComponent();
    }

    private void HandleButtonClick(object sender, RoutedEventArgs e)
    {
        int i = int.Parse(count.Text);
        i++;
        count.Text = i.ToString();
    }
}
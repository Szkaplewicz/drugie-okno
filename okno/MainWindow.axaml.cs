using Avalonia.Controls;
using Avalonia.Interactivity;

namespace okno;

public partial class MainWindow : Window
{
    private int klikniecia = 0;

    public MainWindow()
    {
        InitializeComponent();
    }

    private void Przycisk_Click(object? sender, RoutedEventArgs e)
    {
        klikniecia++;
        Przycisk.Content = $"Kliknięto: {klikniecia}";
    }
}
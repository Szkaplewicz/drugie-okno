using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace okno;

public partial class MainWindow : Window
{
    private int klikniecia = 0;

    public MainWindow()
    {
        InitializeComponent();
        Data.Text = $"Dziś jest {DateTime.Now:d MMMM yyyy}";
    }

    private void Przycisk_Click(object? sender, RoutedEventArgs e)
    {
        klikniecia++;
        Przycisk.Content = $"Kliknięto: {klikniecia}";
        if (!string.IsNullOrWhiteSpace(PoleImie.Text))
            Napis.Text = $"Cześć, {PoleImie.Text.Trim()}!";
    }
}
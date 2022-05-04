using System;
using System.Reflection;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Interactivity;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using VisualFinal.ViewModels;

namespace VisualFinal.Views
{
    public partial class SecondView : UserControl
    {
        public SecondView()
        {
            InitializeComponent();
            this.FindControl<Button>("Select").Click += ClickEventSample;
            this.FindControl<Button>("Union").Click += ClickEventSample;
            this.FindControl<Button>("Group").Click += ClickEventSample;
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
        private async void ClickEventSample(object? sender, RoutedEventArgs e)
        {
            var window = new SelectDBView((this.DataContext as SecondViewModel).MainContext);
            await window.ShowDialog((Window)this.VisualRoot);
        }
    }
}

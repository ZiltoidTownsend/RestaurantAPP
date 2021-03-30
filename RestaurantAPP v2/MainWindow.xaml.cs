using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace RestaurantAPP_v2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }


    }

    public class IsKeyboardFocusConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is ListBoxItem listBoxItem)
            {
                listBoxItem.IsKeyboardFocusWithinChanged -= ListBoxItem_IsKeyboardFocusWithinChanged;
                listBoxItem.IsKeyboardFocusWithinChanged += ListBoxItem_IsKeyboardFocusWithinChanged;
            }
            return Binding.DoNothing;
        }
        private void ListBoxItem_IsKeyboardFocusWithinChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (sender is ListBoxItem listBoxItem && e.NewValue is bool isFocus && isFocus)
                listBoxItem.IsSelected = true;
        }


        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

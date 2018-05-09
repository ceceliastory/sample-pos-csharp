using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SamplePos.Purchase;

namespace SamplePos
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ViewBaseModel();
        }

    }

    public class ViewBaseModel : INotifyPropertyChanged
    {
        public CommandHandler OnClick => new CommandHandler();
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class CommandHandler : ICommand
    {
        public bool CanExecute(object parameter)
        {
            Console.WriteLine("can execute");
            return true;
        }

        public void Execute(object parameter)
        {
            Console.WriteLine("is executing!");
        }

        
        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("no!!!!!!");
        }

        public event EventHandler CanExecuteChanged;
    }
}

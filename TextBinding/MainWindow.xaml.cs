using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TextBinding
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person p = new Person("Jan", "Dobeš", new DateTime(1999, 11, 11));
        public MainWindow()
        {
            InitializeComponent();
            DataContext = p;
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            BindingExpression expression = jmeno.GetBindingExpression(TextBox.TextProperty);
            expression?.UpdateSource();
        }
    }
    class Person
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public DateTime Narozeni { get; set; }
        public Person(string Jmeno, string Prijmeni, DateTime Narozeni)
        {
            this.Jmeno = Jmeno;
            this.Prijmeni = Prijmeni;
            this.Narozeni = Narozeni;
        }
    }
}

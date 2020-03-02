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
        Person d = new Person("Jan", "Dobeš", new DateTime(2001,1,1));
        public MainWindow()
        {
            InitializeComponent();
            DataContext = d;
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            Person p = new Person(jmeno.Text, prijmeni.Text, narozeni.DisplayDate);
            BindingExpression expression = Shrnuti.GetBindingExpression(TextBox.TextProperty);
            expression?.UpdateSource();
            DataContext = p;
        }
    }
    class Person
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public DateTime Narozeni { get; set; }
        public string Vse { get; set; }
        public Person(string Jmeno, string Prijmeni, DateTime Narozeni)
        {
            this.Jmeno = Jmeno;
            this.Prijmeni = Prijmeni;
            this.Narozeni = Narozeni;
            this.Vse = Jmeno + " " + Prijmeni + " " + Convert.ToString(Narozeni.Day) + "." + Convert.ToString(Narozeni.Month) + ". " + Convert.ToString(Narozeni.Year);
        }
    }
}
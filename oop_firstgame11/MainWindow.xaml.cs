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

namespace oop_firstgame11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Character character1;
        Character character2;
        public MainWindow()
        {
            InitializeComponent();
            character1 = new Character("Petr");
            character2 = new Character("Pavel");
            txt1.Text = character1.ToString();
            txt2.Text = character2.ToString();
        }

        private void attack_Click(object sender, RoutedEventArgs e)
        {
            character2.GetHit(character1.Damage);
            txt2.Text = character2.ToString();
        }
    }
}
